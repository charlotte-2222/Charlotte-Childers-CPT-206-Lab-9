' Charlotte Childers
' CPT-206-Lab-9
' 3/13/2022



Option Strict On
Option Explicit On
Option Infer Off
Public Class frmMain
    Private Declare Function HideCaret Lib "user32.dll" (ByVal hWnd As IntPtr) As Boolean
    ' ^Hides I-Beam caret on disabled caret.
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
        'These Form Closing events both work the same way, regardless if it is the 'BtnExit' button or the [X] on the form. 
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



    '-Begin Main Operations-'
    Dim FileInfo(14, 1) As String
    Dim intStudentIndex As Integer

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.LstGrade.SelectedIndex = 0
        Dim LoadFile As IO.StreamReader 'Stream reader to open coded file
        Dim FailFile As OpenFileDialog = New OpenFileDialog 'catch/backup for failure in stream reader, will allow user to open from Dir

        If IO.File.Exists("NamesAndGraddes.txt") Then
            'If it exists in the debug file / is readable, it will open
            LoadFile = IO.File.OpenText("NamesAndGraddes.txt")
            Do Until LoadFile.Peek = -1
                FileInfo(intStudentIndex, 0) = LoadFile.ReadLine
                FileInfo(intStudentIndex, 1) = LoadFile.ReadLine
                intStudentIndex += 1

            Loop
            LoadFile.Close()
        Else
            'If the specified file, in our case "NamesAndGrades.txt", is not present/readable -
            'the user will be tasked with looking for it themselves
            MessageBox.Show("Unable to open the intended file - it was either missing from the directory or is not readable. Please select a file from the directory.",
            "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            If FailFile.ShowDialog() = DialogResult.OK Then
                LoadFile = IO.File.OpenText(FailFile.FileName)
                Do Until LoadFile.Peek = -1
                    FileInfo(intStudentIndex, 0) = LoadFile.ReadLine
                    FileInfo(intStudentIndex, 1) = LoadFile.ReadLine
                    intStudentIndex += 1

                Loop
                LoadFile.Close()
                If FailFile.ShowDialog() = DialogResult.Cancel Then
                    'Ok/Cancel options to close the application
                    ' !! Does not work as intended - has unintentional effects. Will revisit. !!



                Else
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub BtnDisplay_Click(sender As Object, e As EventArgs) Handles BtnDisplay.Click
        LstStudents.Items.Clear()
        Dim Student As Integer = 0
        For Y As Integer = 0 To intStudentIndex - 1
            If FileInfo(Y, 1) = LstGrade.SelectedItem.ToString Then
                LstStudents.Items.Add(FileInfo(Y, 0))
                Student += 1
            End If
        Next
        TxtNum.Text = Student.ToString
        HideCaret(TxtNum.Handle)
    End Sub

    Private Sub LstGrade_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstGrade.SelectedIndexChanged
        TxtNum.Clear()
        LstStudents.Items.Clear()
    End Sub


End Class
