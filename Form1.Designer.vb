<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblPlanPath = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnSelectPlan = New System.Windows.Forms.Button()
        Me.txtOrigPlan = New System.Windows.Forms.TextBox()
        Me.txtNewPlan = New System.Windows.Forms.TextBox()
        Me.btnSavePlan = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.lblLat = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLong = New System.Windows.Forms.TextBox()
        Me.txtLat = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPlanPath
        '
        Me.lblPlanPath.AutoSize = True
        Me.lblPlanPath.Location = New System.Drawing.Point(12, 33)
        Me.lblPlanPath.Name = "lblPlanPath"
        Me.lblPlanPath.Size = New System.Drawing.Size(31, 13)
        Me.lblPlanPath.TabIndex = 1
        Me.lblPlanPath.Text = "none"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnSelectPlan
        '
        Me.btnSelectPlan.Location = New System.Drawing.Point(12, 8)
        Me.btnSelectPlan.Name = "btnSelectPlan"
        Me.btnSelectPlan.Size = New System.Drawing.Size(78, 22)
        Me.btnSelectPlan.TabIndex = 2
        Me.btnSelectPlan.Text = "Select Plan"
        Me.btnSelectPlan.UseVisualStyleBackColor = True
        '
        'txtOrigPlan
        '
        Me.txtOrigPlan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtOrigPlan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrigPlan.Location = New System.Drawing.Point(3, 31)
        Me.txtOrigPlan.Multiline = True
        Me.txtOrigPlan.Name = "txtOrigPlan"
        Me.txtOrigPlan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOrigPlan.Size = New System.Drawing.Size(350, 253)
        Me.txtOrigPlan.TabIndex = 6
        '
        'txtNewPlan
        '
        Me.txtNewPlan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNewPlan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPlan.Location = New System.Drawing.Point(359, 31)
        Me.txtNewPlan.Multiline = True
        Me.txtNewPlan.Name = "txtNewPlan"
        Me.txtNewPlan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNewPlan.Size = New System.Drawing.Size(350, 253)
        Me.txtNewPlan.TabIndex = 7
        '
        'btnSavePlan
        '
        Me.btnSavePlan.Enabled = False
        Me.btnSavePlan.Location = New System.Drawing.Point(359, 3)
        Me.btnSavePlan.Name = "btnSavePlan"
        Me.btnSavePlan.Size = New System.Drawing.Size(78, 22)
        Me.btnSavePlan.TabIndex = 8
        Me.btnSavePlan.Text = "Save Plan..."
        Me.btnSavePlan.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "txt"
        Me.SaveFileDialog1.Filter = "Plans|*.txt|All Files|*.*"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 62)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(712, 287)
        Me.Panel1.TabIndex = 9
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnConvert, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSavePlan, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtNewPlan, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtOrigPlan, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(712, 287)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtLat)
        Me.Panel2.Controls.Add(Me.txtLong)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.lblLat)
        Me.Panel2.Controls.Add(Me.lblPlanPath)
        Me.Panel2.Controls.Add(Me.btnSelectPlan)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(712, 62)
        Me.Panel2.TabIndex = 10
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(712, 349)
        Me.Panel3.TabIndex = 11
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(3, 3)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(78, 22)
        Me.btnConvert.TabIndex = 9
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'lblLat
        '
        Me.lblLat.AutoSize = True
        Me.lblLat.Location = New System.Drawing.Point(150, 13)
        Me.lblLat.Name = "lblLat"
        Me.lblLat.Size = New System.Drawing.Size(48, 13)
        Me.lblLat.TabIndex = 3
        Me.lblLat.Text = "Lattitude"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(308, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Longitude"
        '
        'txtLong
        '
        Me.txtLong.Location = New System.Drawing.Point(368, 10)
        Me.txtLong.Name = "txtLong"
        Me.txtLong.Size = New System.Drawing.Size(75, 20)
        Me.txtLong.TabIndex = 5
        Me.txtLong.Text = "-111 40 46"
        '
        'txtLat
        '
        Me.txtLat.Location = New System.Drawing.Point(204, 10)
        Me.txtLat.Name = "txtLat"
        Me.txtLat.Size = New System.Drawing.Size(75, 20)
        Me.txtLat.TabIndex = 6
        Me.txtLat.Text = "32 56 35"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 349)
        Me.Controls.Add(Me.Panel3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "AltAzPlan"
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblPlanPath As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnSelectPlan As Button
    Friend WithEvents txtOrigPlan As TextBox
    Friend WithEvents txtNewPlan As TextBox
    Friend WithEvents btnSavePlan As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnConvert As Button
    Friend WithEvents txtLong As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblLat As Label
    Friend WithEvents txtLat As TextBox
End Class
