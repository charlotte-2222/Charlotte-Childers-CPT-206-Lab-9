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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.LstGrade = New System.Windows.Forms.ListBox()
        Me.LstStudents = New System.Windows.Forms.ListBox()
        Me.BtnDisplay = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.lblGrade = New System.Windows.Forms.Label()
        Me.lblStudents = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DECOY = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblForResultStudents = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LstGrade
        '
        Me.LstGrade.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstGrade.FormattingEnabled = True
        Me.LstGrade.ItemHeight = 15
        Me.LstGrade.Items.AddRange(New Object() {"A", "B", "C", "D", "F"})
        Me.LstGrade.Location = New System.Drawing.Point(15, 46)
        Me.LstGrade.Name = "LstGrade"
        Me.LstGrade.Size = New System.Drawing.Size(29, 79)
        Me.LstGrade.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.LstGrade, "View Students by Grade")
        '
        'LstStudents
        '
        Me.LstStudents.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstStudents.FormattingEnabled = True
        Me.LstStudents.ItemHeight = 17
        Me.LstStudents.Location = New System.Drawing.Point(89, 46)
        Me.LstStudents.Name = "LstStudents"
        Me.LstStudents.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.LstStudents.Size = New System.Drawing.Size(82, 89)
        Me.LstStudents.Sorted = True
        Me.LstStudents.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.LstStudents, "List of Students who obtained selected grade")
        '
        'BtnDisplay
        '
        Me.BtnDisplay.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDisplay.Location = New System.Drawing.Point(191, 104)
        Me.BtnDisplay.Name = "BtnDisplay"
        Me.BtnDisplay.Size = New System.Drawing.Size(80, 31)
        Me.BtnDisplay.TabIndex = 1
        Me.BtnDisplay.Text = "&Display"
        Me.ToolTip1.SetToolTip(Me.BtnDisplay, "Display Results")
        Me.BtnDisplay.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnExit.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.Location = New System.Drawing.Point(291, 104)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(80, 31)
        Me.BtnExit.TabIndex = 2
        Me.BtnExit.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.BtnExit, "Exit this application")
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'lblGrade
        '
        Me.lblGrade.AutoSize = True
        Me.lblGrade.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrade.Location = New System.Drawing.Point(12, 30)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(44, 17)
        Me.lblGrade.TabIndex = 5
        Me.lblGrade.Text = "&Grade"
        '
        'lblStudents
        '
        Me.lblStudents.AutoSize = True
        Me.lblStudents.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudents.Location = New System.Drawing.Point(86, 30)
        Me.lblStudents.Name = "lblStudents"
        Me.lblStudents.Size = New System.Drawing.Size(65, 17)
        Me.lblStudents.TabIndex = 6
        Me.lblStudents.Text = "&Students:"
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(209, 40)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(132, 17)
        Me.lblResult.TabIndex = 7
        Me.lblResult.Text = "Number of Students"
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
        Me.ToolTip1.SetToolTip(Me.DECOY, "Current Time/Date")
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(376, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'lblForResultStudents
        '
        Me.lblForResultStudents.AutoSize = True
        Me.lblForResultStudents.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForResultStudents.Location = New System.Drawing.Point(266, 64)
        Me.lblForResultStudents.Name = "lblForResultStudents"
        Me.lblForResultStudents.Size = New System.Drawing.Size(21, 20)
        Me.lblForResultStudents.TabIndex = 10
        Me.lblForResultStudents.Text = "N"
        Me.ToolTip1.SetToolTip(Me.lblForResultStudents, "Numerical amount of students who obtained selected grade")
        Me.lblForResultStudents.Visible = False
        '
        'frmMain
        '
        Me.AcceptButton = Me.BtnDisplay
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Plum
        Me.CancelButton = Me.BtnExit
        Me.ClientSize = New System.Drawing.Size(429, 220)
        Me.Controls.Add(Me.lblForResultStudents)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DECOY)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblStudents)
        Me.Controls.Add(Me.lblGrade)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnDisplay)
        Me.Controls.Add(Me.LstStudents)
        Me.Controls.Add(Me.LstGrade)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Charlotte Childers | Ch. 9, Exercise #4"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LstGrade As ListBox
    Friend WithEvents LstStudents As ListBox
    Friend WithEvents BtnDisplay As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents lblGrade As Label
    Friend WithEvents lblStudents As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DECOY As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblForResultStudents As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
