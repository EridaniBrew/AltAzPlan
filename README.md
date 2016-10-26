# AltAzPlan
Program to generate ACP plan with Alt/Az targets.

Uses the special command ;#AltAz   Alt  Az  to set up targets. This command looks like a comment to ACP.
It requires a prior #waituntil command to properly generate the target Ra/Dec target values.

Example usage:


;Plan to test Alt/Az generation
; Needs 3 commands in a row WaitUntil, ;=AltAz x xx xx   yy yy yy
;Target line gives targetName. The subsequent RA/Dec will be filled in
; 
  #WaitUntil 0,3:30 AM      ; local datetime is 08:30 PM
;=AltAz    24 0 0     77 0 0
Targ830           ; my comment here
;
  #WaitUntil 0,6:30 AM      ; local datetime is 11:30 PM
;=AltAz     51 0 0   190 0 0
MyTarg1130
;

This plan gets converted to the following by AltAzPlan:

;Plan to test Alt/Az generation
; Needs 3 commands in a row WaitUntil, ;=AltAz x xx xx   yy yy yy
;Target line gives targetName. The subsequent RA/Dec will be filled in
; 
  #WaitUntil 0,3:30 AM      ; local datetime is 08:30 PM
;=AltAz    24 0 0     77 0 0
Targ830	03° 29' 08"	23° 10' 54"
;
  #WaitUntil 0,6:30 AM      ; local datetime is 11:30 PM
;=AltAz     51 0 0   190 0 0
MyTarg1130	01° 02' 16"	-05° 35' 41"

The converted plan specifies Targets in the usual Ra/Dec format, where the Ra/Dec
are calculated based on the #waituntil time and the AltAz coordinates for that day.

If the same input plan is used at a future date the Ra/Dec target values change based on the new date.
