' Charlotte Childers
' CPT-206-Lab-9
' 3/13/2022



Option Strict On
Option Explicit On
Option Infer Off
Public Class frmMain

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
    Dim Message As DialogResult 'Defining the message box as a variable type for later manipulation

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.LstGrade.SelectedIndex = 0
        Dim LoadFile As IO.StreamReader 'Stream reader to open coded file
        Dim FailFile As OpenFileDialog = New OpenFileDialog 'catch/backup for failure in stream reader, will allow user to open from Dir


        If IO.File.Exists("NamesAndGrades.txt") Then
            'If it exists in the debug file / is readable, it will open
            LoadFile = IO.File.OpenText("NamesAndGrades.txt")
            Do Until LoadFile.Peek = -1
                FileInfo(intStudentIndex, 0) = LoadFile.ReadLine
                FileInfo(intStudentIndex, 1) = LoadFile.ReadLine
                intStudentIndex += 1
            Loop
            LoadFile.Close()

        Else
            'Message box varAssigned
            Message = MessageBox.Show("Unable to open the intended file. It was either missing or unreadable. Please select a file from the directory, or cancel to exit.",
                            "Error",
                            MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Error)

            'If/else - If the user chooses to exit the program upon reaching an error, they will be able to do so.
            If Message = System.Windows.Forms.DialogResult.Cancel Then
                Me.Close()
            Else
                'If/else - If the user chooses to continue, let them proceed
                If Message = System.Windows.Forms.DialogResult.OK Then

                    'If/else - the continuation of the OpenFileDialog class.
                    'In the case that a user's file is not found, or the permission levels are unreachable, or there are
                    'simply unknown errors - the user may enter the directory to select a text document.
                    If FailFile.ShowDialog() = DialogResult.OK Then
                        LoadFile = IO.File.OpenText(FailFile.FileName)
                        Do Until LoadFile.Peek = -1
                            FileInfo(intStudentIndex, 0) = LoadFile.ReadLine
                            FileInfo(intStudentIndex, 1) = LoadFile.ReadLine
                            intStudentIndex += 1
                        Loop
                        LoadFile.Close()
                    End If
                End If

            End If

        End If

        '-End of main functions / File loading-

    End Sub

    Private Sub BtnDisplay_Click(sender As Object, e As EventArgs) Handles BtnDisplay.Click
        'On display, the student list will clear each time, to allow for a new set
        LstStudents.Items.Clear()
        Dim Student As Integer = 0
        For Y As Integer = 0 To intStudentIndex - 1
            If FileInfo(Y, 1) = LstGrade.SelectedItem.ToString Then
                LstStudents.Items.Add(FileInfo(Y, 0))
                Student += 1
            End If
        Next
        'The result label begins Visible=False as it is by default 0. Upon selection, it will change and become visible.
        lblForResultStudents.Visible = True
        lblForResultStudents.Text = Student.ToString

    End Sub

    Private Sub LstGrade_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstGrade.SelectedIndexChanged
        'TxtNum.Clear() -- Originally I was going to use a textbox, however a label is more UI/UX pleasing.
        lblForResultStudents.Visible = False
        'On index change, the student list will clear each time, to allow for a new set
        LstStudents.Items.Clear()
    End Sub

End Class
