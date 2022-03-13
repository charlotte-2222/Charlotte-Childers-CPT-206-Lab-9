<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Me.LstGrade = New System.Windows.Forms.ListBox()
        Me.LstStudents = New System.Windows.Forms.ListBox()
        Me.BtnDisplay = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.TxtNum = New System.Windows.Forms.TextBox()
        Me.lblGrade = New System.Windows.Forms.Label()
        Me.lblStudents = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DECOY = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LstGrade
        '
        Me.LstGrade.FormattingEnabled = True
        Me.LstGrade.Items.AddRange(New Object() {"A", "B", "C", "D", "F"})
        Me.LstGrade.Location = New System.Drawing.Point(34, 62)
        Me.LstGrade.Name = "LstGrade"
        Me.LstGrade.Size = New System.Drawing.Size(21, 69)
        Me.LstGrade.TabIndex = 0
        '
        'LstStudents
        '
        Me.LstStudents.FormattingEnabled = True
        Me.LstStudents.Location = New System.Drawing.Point(108, 62)
        Me.LstStudents.Name = "LstStudents"
        Me.LstStudents.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.LstStudents.Size = New System.Drawing.Size(88, 95)
        Me.LstStudents.Sorted = True
        Me.LstStudents.TabIndex = 1
        '
        'BtnDisplay
        '
        Me.BtnDisplay.Location = New System.Drawing.Point(236, 134)
        Me.BtnDisplay.Name = "BtnDisplay"
        Me.BtnDisplay.Size = New System.Drawing.Size(75, 23)
        Me.BtnDisplay.TabIndex = 2
        Me.BtnDisplay.Text = "&Display"
        Me.BtnDisplay.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(317, 134)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.TabIndex = 3
        Me.BtnExit.Text = "E&xit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'TxtNum
        '
        Me.TxtNum.Location = New System.Drawing.Point(258, 60)
        Me.TxtNum.Name = "TxtNum"
        Me.TxtNum.ReadOnly = True
        Me.TxtNum.Size = New System.Drawing.Size(75, 20)
        Me.TxtNum.TabIndex = 4
        '
        'lblGrade
        '
        Me.lblGrade.AutoSize = True
        Me.lblGrade.Location = New System.Drawing.Point(31, 46)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(36, 13)
        Me.lblGrade.TabIndex = 5
        Me.lblGrade.Text = "&Grade"
        '
        'lblStudents
        '
        Me.lblStudents.AutoSize = True
        Me.lblStudents.Location = New System.Drawing.Point(105, 46)
        Me.lblStudents.Name = "lblStudents"
        Me.lblStudents.Size = New System.Drawing.Size(52, 13)
        Me.lblStudents.TabIndex = 6
        Me.lblStudents.Text = "&Students:"
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(255, 44)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(104, 13)
        Me.lblResult.TabIndex = 7
        Me.lblResult.Text = "Number of Students:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 30
        '
        'DECOY
        '
        Me.DECOY.AutoSize = True
        Me.DECOY.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DECOY.Location = New System.Drawing.Point(9, 191)
        Me.DECOY.Name = "DECOY"
        Me.DECOY.Size = New System.Drawing.Size(58, 20)
        Me.DECOY.TabIndex = 8
        Me.DECOY.Text = "DECOY"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 220)
        Me.Controls.Add(Me.DECOY)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblStudents)
        Me.Controls.Add(Me.lblGrade)
        Me.Controls.Add(Me.TxtNum)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnDisplay)
        Me.Controls.Add(Me.LstStudents)
        Me.Controls.Add(Me.LstGrade)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Charlotte Childers | Ch. 9, Exercise #4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LstGrade As ListBox
    Friend WithEvents LstStudents As ListBox
    Friend WithEvents BtnDisplay As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents TxtNum As TextBox
    Friend WithEvents lblGrade As Label
    Friend WithEvents lblStudents As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DECOY As Label
End Class
