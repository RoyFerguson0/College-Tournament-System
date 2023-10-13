<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplash
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblDeveloper = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tmrSplash = New System.Windows.Forms.Timer(Me.components)
        Me.pbrSplash = New System.Windows.Forms.ProgressBar()
        Me.tmrProgress = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.PeachPuff
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 20.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(47, 42)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(701, 46)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "This is a College Tournament Score System"
        '
        'lblDeveloper
        '
        Me.lblDeveloper.AutoSize = True
        Me.lblDeveloper.BackColor = System.Drawing.Color.PeachPuff
        Me.lblDeveloper.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblDeveloper.ForeColor = System.Drawing.Color.Black
        Me.lblDeveloper.Location = New System.Drawing.Point(286, 351)
        Me.lblDeveloper.Name = "lblDeveloper"
        Me.lblDeveloper.Size = New System.Drawing.Size(220, 18)
        Me.lblDeveloper.TabIndex = 1
        Me.lblDeveloper.Text = "Developed by Roy Ferguson"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.PeachPuff
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(342, 374)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Copyright 2021"
        '
        'tmrSplash
        '
        Me.tmrSplash.Enabled = True
        Me.tmrSplash.Interval = 5000
        '
        'pbrSplash
        '
        Me.pbrSplash.Location = New System.Drawing.Point(197, 409)
        Me.pbrSplash.Name = "pbrSplash"
        Me.pbrSplash.Size = New System.Drawing.Size(400, 29)
        Me.pbrSplash.Step = 12
        Me.pbrSplash.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbrSplash.TabIndex = 4
        '
        'tmrProgress
        '
        Me.tmrProgress.Enabled = True
        Me.tmrProgress.Interval = 500
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.projCollegeTournament.My.Resources.Resources.BelfastmetLogo
        Me.PictureBox1.Location = New System.Drawing.Point(197, 115)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(400, 196)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'frmSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pbrSplash)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDeveloper)
        Me.Controls.Add(Me.lblTitle)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSplash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSplash"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblDeveloper As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tmrSplash As Timer
    Friend WithEvents pbrSplash As ProgressBar
    Friend WithEvents tmrProgress As Timer
    Friend WithEvents PictureBox1 As PictureBox
End Class
