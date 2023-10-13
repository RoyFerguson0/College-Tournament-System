<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddPlayers
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
        Me.btnAddPlayer = New System.Windows.Forms.Button()
        Me.lblPlayerName = New System.Windows.Forms.Label()
        Me.txtPlayerName = New System.Windows.Forms.TextBox()
        Me.btnLoginScreen = New System.Windows.Forms.Button()
        Me.btnScoresScreen = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAddPlayer
        '
        Me.btnAddPlayer.BackColor = System.Drawing.Color.LightCyan
        Me.btnAddPlayer.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAddPlayer.ForeColor = System.Drawing.Color.Black
        Me.btnAddPlayer.Location = New System.Drawing.Point(384, 157)
        Me.btnAddPlayer.Name = "btnAddPlayer"
        Me.btnAddPlayer.Size = New System.Drawing.Size(112, 39)
        Me.btnAddPlayer.TabIndex = 0
        Me.btnAddPlayer.Text = "Add Player"
        Me.btnAddPlayer.UseVisualStyleBackColor = False
        '
        'lblPlayerName
        '
        Me.lblPlayerName.AutoSize = True
        Me.lblPlayerName.BackColor = System.Drawing.Color.PeachPuff
        Me.lblPlayerName.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPlayerName.ForeColor = System.Drawing.Color.Black
        Me.lblPlayerName.Location = New System.Drawing.Point(67, 162)
        Me.lblPlayerName.Name = "lblPlayerName"
        Me.lblPlayerName.Size = New System.Drawing.Size(125, 25)
        Me.lblPlayerName.TabIndex = 1
        Me.lblPlayerName.Text = "Player Name:"
        '
        'txtPlayerName
        '
        Me.txtPlayerName.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtPlayerName.ForeColor = System.Drawing.Color.Black
        Me.txtPlayerName.Location = New System.Drawing.Point(216, 163)
        Me.txtPlayerName.Name = "txtPlayerName"
        Me.txtPlayerName.Size = New System.Drawing.Size(125, 31)
        Me.txtPlayerName.TabIndex = 2
        '
        'btnLoginScreen
        '
        Me.btnLoginScreen.BackColor = System.Drawing.Color.LightCyan
        Me.btnLoginScreen.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnLoginScreen.ForeColor = System.Drawing.Color.Black
        Me.btnLoginScreen.Location = New System.Drawing.Point(402, 315)
        Me.btnLoginScreen.Name = "btnLoginScreen"
        Me.btnLoginScreen.Size = New System.Drawing.Size(94, 29)
        Me.btnLoginScreen.TabIndex = 4
        Me.btnLoginScreen.Text = "Log off"
        Me.btnLoginScreen.UseVisualStyleBackColor = False
        '
        'btnScoresScreen
        '
        Me.btnScoresScreen.BackColor = System.Drawing.Color.LightCyan
        Me.btnScoresScreen.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnScoresScreen.ForeColor = System.Drawing.Color.Black
        Me.btnScoresScreen.Location = New System.Drawing.Point(202, 243)
        Me.btnScoresScreen.Name = "btnScoresScreen"
        Me.btnScoresScreen.Size = New System.Drawing.Size(153, 29)
        Me.btnScoresScreen.TabIndex = 5
        Me.btnScoresScreen.Text = "Go to Scores Page"
        Me.btnScoresScreen.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.PeachPuff
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 22.2!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(148, 61)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(285, 50)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Adding Players"
        '
        'frmAddPlayers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(573, 394)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnScoresScreen)
        Me.Controls.Add(Me.btnLoginScreen)
        Me.Controls.Add(Me.txtPlayerName)
        Me.Controls.Add(Me.lblPlayerName)
        Me.Controls.Add(Me.btnAddPlayer)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAddPlayers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAddPlayers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAddPlayer As Button
    Friend WithEvents lblPlayerName As Label
    Friend WithEvents txtPlayerName As TextBox
    Friend WithEvents btnLoginScreen As Button
    Friend WithEvents btnScoresScreen As Button
    Friend WithEvents lblTitle As Label
End Class
