Public Class Form1

    Private Util As ACP.Util

    Private gMyLongitude As Double
    Private gMyLatitude As Double
    Private gGMSTDelta As Double
    Private gNowUTCDate As Date

    Private Sub btnSavePlan_Click(sender As Object, e As EventArgs) Handles btnSavePlan.Click
        SaveFileDialog1.InitialDirectory = My.Settings.SaveDir
        If (SaveFileDialog1.ShowDialog() = DialogResult.OK) Then
            My.Settings.SaveDir = SaveFileDialog1.InitialDirectory
            SaveMyPlan(SaveFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnSelectPlan_Click(sender As Object, e As EventArgs) Handles btnSelectPlan.Click
        OpenFileDialog1.FileName = My.Settings.FilePath
        If (OpenFileDialog1.ShowDialog() = DialogResult.OK) Then
            lblPlanPath.Text = OpenFileDialog1.FileName
            My.Settings.FilePath = lblPlanPath.Text

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPlanPath.Text = My.Settings.FilePath
        txtLat.Text = My.Settings.Latitude
        txtLong.Text = My.Settings.Longitude
        Util = CreateObject("ACP.Util")
    End Sub

    Private Sub SetUpConstants()
        ' Set constants like myLongitude, Latitude, Time values
        gMyLongitude = Util.DMS_Degrees(txtLong.Text)
        gMyLatitude = Util.DMS_Degrees(txtLat.Text)

        My.Settings.Latitude = txtLat.Text          ' Might have changed
        My.Settings.Longitude = txtLong.Text
        Dim nowLAST As Double = Util.NowLST(gMyLongitude)
        Dim nowDate As Date = Now()
        Dim nowGMTsiderealTime As Double = Util.Date_GMST(nowDate)
        gGMSTDelta = nowGMTsiderealTime - nowLAST

        gNowUTCDate = Date.UtcNow()

    End Sub

    Private Sub LoadMyPlan(fileName As String)
        Dim s As String
        Dim ra As String = ""       ' 34 23 67 type of thing
        Dim dec As String = ""
        Dim targName As String = ""
        Dim waitString As String = ""    ' #waituntil 0, 13:40 UTC time

        SetUpConstants()

        Dim objReader As New System.IO.StreamReader(fileName)

        Do While objReader.Peek() <> -1
            s = objReader.ReadLine()
            txtOrigPlan.AppendText(s & vbCrLf)

            If (UCase(s.Substring(0, Math.Min(s.Length, 7))) = ";=ALTAZ") Then
                txtNewPlan.AppendText(s & vbCrLf)
                If (waitString <> "") Then
                    ' need to determine Ra/Dec for this one
                    ConvertToRaDec(s, waitString, ra, dec)
                End If
            ElseIf (IsTargetLine(s)) Then
                ' get target name
                Dim targetS = s.Replace(vbTab, " ")    ' replace tabs
                targetS = Trim(RemoveComment(targetS))
                Dim pieces() As String = targetS.Split(" ")
                If ((pieces.Count > 0) And (ra <> "") And (dec <> "")) Then
                    If (pieces(0) <> "") Then
                        targName = pieces(0) & vbTab & ra & vbTab & dec
                        txtNewPlan.AppendText(targName & vbCrLf)
                        ra = ""
                        dec = ""
                        waitString = ""
                    End If
                Else
                    txtNewPlan.AppendText(s & vbCrLf)
                End If

            ElseIf (UCase(s.Substring(0, Math.Min(s.Length, 10))) = "#WAITUNTIL") Then
                    waitString = s
                    txtNewPlan.AppendText(s & vbCrLf)
                Else
                    txtNewPlan.AppendText(s & vbCrLf)
            End If
        Loop
        objReader.Close()
        objReader = Nothing
    End Sub

    Private Sub SaveMyPlan(fileName As String)
        'MsgBox("Saving " & fileName,, "Save File")
        Dim objWriter As New System.IO.StreamWriter(fileName)
        objWriter.Write(txtNewPlan.Text)
        objWriter.Close()
    End Sub

    Private Function RemoveComment(s As String) As String
        ' remove any comment from the string
        Dim newS As String = ""
        Dim pos As Integer
        pos = s.IndexOf(";")
        If (pos > -1) Then
            newS = s.Substring(0, pos)
        Else
            ' no comment
            newS = s
        End If
        Return newS
    End Function

    Private Sub ConvertToRaDec(s As String, waitString As String, ByRef ra As String, ByRef dec As String)
        ' s is something like ;=ALTAZ  3 56 23   5 46 78
        Dim azD As Double
        Dim altD As Double
        Dim pm As Integer = 0     ' assume am. If PM, then this is 12

        Dim thisUTCTime As Date
        Dim hr, min As Integer
        ' Find hr and minute of #waituntil 9,hh:mm   ;czxCZXc
        Dim half() As String = waitString.Split(":")
        If (half.Count < 2) Then
            MsgBox("Waituntil string does not have 2 pieces: " & vbCrLf & waitString)
            hr = 10
            min = 30
        Else
            half(0) = half(0).Replace(",", "0")    ' can be ,2:30 or ,12:30
            hr = CInt(half(0).Substring(half(0).Length - 2))
            min = CInt(half(1).Substring(0, 2))
            If ((waitString.IndexOf(" PM ") > 0) And (hr < 12)) Then
                pm = 12         ' add 12 hours for PM
            End If
        End If
        Dim dayAdjust = 1       ' if the localtime is after 5:00 PM (midnight local) then we need to add a day to UTC. Assume all times refer
        ' to the next day UTC
        'If (hr < 7) Then
        '    dayAdjust = 1
        'End If
        thisUTCTime = New Date(gNowUTCDate.Year, gNowUTCDate.Month, gNowUTCDate.Day + dayAdjust, hr + pm, min, 0, DateTimeKind.Utc)

        Dim localTime As Date = thisUTCTime.ToLocalTime
        Dim siderealTime As Double = Util.Date_GMST(localTime) - gGMSTDelta
        If (siderealTime < 0) Then
            siderealTime = siderealTime + 24
        End If
        Dim ct = Util.NewCT(gMyLatitude, siderealTime)

        ' get the two degree strings from ;=ALTAZ  3 56 23   5 46 78
        s = s.Substring(7)   ' remove ;=AltAz
        s = Trim(s)
        s = s.Replace(vbTab, " ")
        Dim news As String = s.Replace("  ", " ")
        While (s <> news)
            s = news
            news = news.Replace("  ", " ")
        End While
        Dim pieces() As String = news.Split(" ")
        If (pieces.Count <> 6) Then
            ra = "unknown"
            dec = "unknown"
            Exit Sub
        End If

        azD = Util.DMS_Degrees(pieces(3) & " " & pieces(4) & " " & pieces(5))
        altD = Util.DMS_Degrees(pieces(0) & " " & pieces(1) & " " & pieces(2))
        ct.Azimuth = azD
        ct.Elevation = altD

        ra = Util.Degrees_DMS(ct.RightAscension)
        dec = Util.Degrees_DMS(ct.Declination)
    End Sub

    Private Function IsTargetLine(s As String) As Boolean
        ' if first char of line is ; or # then not a target. 
        ' If Empty Then Not a target
        s = Trim(s)
        If ((s(0) = ";") Or (s(0) = "#")) Then
            Return False
        End If
        If (s = "") Then
            Return False
        End If
        Return True
    End Function

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        txtNewPlan.Text = ""
        txtOrigPlan.Text = ""
        If (System.IO.File.Exists(lblPlanPath.Text)) Then
            LoadMyPlan(lblPlanPath.Text)
            btnSavePlan.Enabled = True
        Else
            MsgBox("Plan not found: " & vbCrLf & lblPlanPath.Text)
        End If
    End Sub
End Class
