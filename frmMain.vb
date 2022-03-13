' Charlotte Childers
' CPT-206-Lab-9
' 3/13/2022



Option Strict On
Option Explicit On
Option Infer Off
Public Class frmMain
    Private Declare Function HideTheCaret Lib "user32.dll" (ByVal hWnd As IntPtr) As Boolean
    ' ^Hides I-Beam caret on disabled caret.
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
        'These Form Closing events both work the same way, regardless if it is the 'BtnExit' button or the 'X' on the form. 
        'This is an *intended function.*
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Are you sure you wish to exit?",
                           "Exit the Application...",
                           MessageBoxButtons.YesNo) = DialogResult.Yes Then
            SplashScreen.Close()
            Application.Exit()
        Else
            e.Cancel = True
        End If
        'These Form Closing events both work the same way, regardless if it is the 'BtnExit' button or the 'X' on the form. 
        'This is an *intended function.*
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DECOY.Text = DateTime.Now.ToString("F")
        'Time/Date
    End Sub
End Class
