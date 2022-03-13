<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreen))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.prog = New System.Windows.Forms.ProgressBar()
        Me.date_time = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.classLabel = New System.Windows.Forms.Label()
        Me.version = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblSplash = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 30
        '
        'prog
        '
        Me.prog.Location = New System.Drawing.Point(-3, 403)
        Me.prog.Name = "prog"
        Me.prog.Size = New System.Drawing.Size(543, 23)
        Me.prog.TabIndex = 25
        '
        'date_time
        '
        Me.date_time.AutoSize = True
        Me.date_time.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_time.Location = New System.Drawing.Point(4, 379)
        Me.date_time.Name = "date_time"
        Me.date_time.Size = New System.Drawing.Size(121, 17)
        Me.date_time.TabIndex = 24
        Me.date_time.Text = "PLACEHOLDER"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(224, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 23)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Spartanburg Community College"
        '
        'classLabel
        '
        Me.classLabel.AutoSize = True
        Me.classLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.classLabel.Location = New System.Drawing.Point(276, 43)
        Me.classLabel.Name = "classLabel"
        Me.classLabel.Size = New System.Drawing.Size(157, 30)
        Me.classLabel.TabIndex = 29
        Me.classLabel.Text = "CPT-206-A80S"
        '
        'version
        '
        Me.version.AutoSize = True
        Me.version.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.version.Location = New System.Drawing.Point(261, 78)
        Me.version.Name = "version"
        Me.version.Size = New System.Drawing.Size(186, 30)
        Me.version.TabIndex = 28
        Me.version.Text = "Visual Basic Lab 9"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(7, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(130, 120)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'lblSplash
        '
        Me.lblSplash.AutoSize = True
        Me.lblSplash.Font = New System.Drawing.Font("Segoe UI Semibold", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSplash.Location = New System.Drawing.Point(5, 5)
        Me.lblSplash.Name = "lblSplash"
        Me.lblSplash.Size = New System.Drawing.Size(161, 25)
        Me.lblSplash.TabIndex = 31
        Me.lblSplash.Text = "Charlotte Childers"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(7, 179)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(516, 155)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 33
        Me.PictureBox2.TabStop = False
        '
        'SplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumTurquoise
        Me.ClientSize = New System.Drawing.Size(537, 426)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblSplash)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.classLabel)
        Me.Controls.Add(Me.version)
        Me.Controls.Add(Me.prog)
        Me.Controls.Add(Me.date_time)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SplashScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SplashScreen"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents prog As ProgressBar
    Friend WithEvents date_time As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents classLabel As Label
    Friend WithEvents version As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblSplash As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
