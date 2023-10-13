<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmScores
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbSelectPlayer = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAddPlayersScreen = New System.Windows.Forms.Button()
        Me.btnSaveScores = New System.Windows.Forms.Button()
        Me.btnLoginScreen = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbEvent1 = New System.Windows.Forms.ComboBox()
        Me.cmbEvent2 = New System.Windows.Forms.ComboBox()
        Me.cmbEvent4 = New System.Windows.Forms.ComboBox()
        Me.cmbEvent5 = New System.Windows.Forms.ComboBox()
        Me.cmbEvent3 = New System.Windows.Forms.ComboBox()
        Me.btnLeaderBoardScreen = New System.Windows.Forms.Button()
        Me.btnHelpScores = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.PeachPuff
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(260, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Player:"
        '
        'cmbSelectPlayer
        '
        Me.cmbSelectPlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSelectPlayer.ForeColor = System.Drawing.Color.Black
        Me.cmbSelectPlayer.FormattingEnabled = True
        Me.cmbSelectPlayer.Location = New System.Drawing.Point(342, 139)
        Me.cmbSelectPlayer.Name = "cmbSelectPlayer"
        Me.cmbSelectPlayer.Size = New System.Drawing.Size(151, 28)
        Me.cmbSelectPlayer.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.PeachPuff
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(107, 212)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Event 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.PeachPuff
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(243, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Event 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.PeachPuff
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(367, 212)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 23)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Event 3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.PeachPuff
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(503, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 23)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Event 4"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.PeachPuff
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(632, 212)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 23)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Event 5"
        '
        'btnAddPlayersScreen
        '
        Me.btnAddPlayersScreen.BackColor = System.Drawing.Color.LightCyan
        Me.btnAddPlayersScreen.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAddPlayersScreen.ForeColor = System.Drawing.Color.Black
        Me.btnAddPlayersScreen.Location = New System.Drawing.Point(260, 387)
        Me.btnAddPlayersScreen.Name = "btnAddPlayersScreen"
        Me.btnAddPlayersScreen.Size = New System.Drawing.Size(250, 34)
        Me.btnAddPlayersScreen.TabIndex = 12
        Me.btnAddPlayersScreen.Text = "Back to Add Players Screen"
        Me.btnAddPlayersScreen.UseVisualStyleBackColor = False
        '
        'btnSaveScores
        '
        Me.btnSaveScores.BackColor = System.Drawing.Color.LightCyan
        Me.btnSaveScores.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSaveScores.ForeColor = System.Drawing.Color.Black
        Me.btnSaveScores.Location = New System.Drawing.Point(311, 316)
        Me.btnSaveScores.Name = "btnSaveScores"
        Me.btnSaveScores.Size = New System.Drawing.Size(122, 31)
        Me.btnSaveScores.TabIndex = 13
        Me.btnSaveScores.Text = "Save Scores"
        Me.btnSaveScores.UseVisualStyleBackColor = False
        '
        'btnLoginScreen
        '
        Me.btnLoginScreen.BackColor = System.Drawing.Color.LightCyan
        Me.btnLoginScreen.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnLoginScreen.ForeColor = System.Drawing.Color.Black
        Me.btnLoginScreen.Location = New System.Drawing.Point(24, 389)
        Me.btnLoginScreen.Name = "btnLoginScreen"
        Me.btnLoginScreen.Size = New System.Drawing.Size(203, 31)
        Me.btnLoginScreen.TabIndex = 14
        Me.btnLoginScreen.Text = "Back to Login Screen"
        Me.btnLoginScreen.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.PeachPuff
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 22.2!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(204, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(340, 50)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Calculating Scores"
        '
        'cmbEvent1
        '
        Me.cmbEvent1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEvent1.ForeColor = System.Drawing.Color.Black
        Me.cmbEvent1.FormattingEnabled = True
        Me.cmbEvent1.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbEvent1.Location = New System.Drawing.Point(83, 244)
        Me.cmbEvent1.Name = "cmbEvent1"
        Me.cmbEvent1.Size = New System.Drawing.Size(102, 28)
        Me.cmbEvent1.TabIndex = 16
        '
        'cmbEvent2
        '
        Me.cmbEvent2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEvent2.ForeColor = System.Drawing.Color.Black
        Me.cmbEvent2.FormattingEnabled = True
        Me.cmbEvent2.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbEvent2.Location = New System.Drawing.Point(218, 244)
        Me.cmbEvent2.Name = "cmbEvent2"
        Me.cmbEvent2.Size = New System.Drawing.Size(102, 28)
        Me.cmbEvent2.TabIndex = 17
        '
        'cmbEvent4
        '
        Me.cmbEvent4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEvent4.ForeColor = System.Drawing.Color.Black
        Me.cmbEvent4.FormattingEnabled = True
        Me.cmbEvent4.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbEvent4.Location = New System.Drawing.Point(484, 244)
        Me.cmbEvent4.Name = "cmbEvent4"
        Me.cmbEvent4.Size = New System.Drawing.Size(102, 28)
        Me.cmbEvent4.TabIndex = 18
        '
        'cmbEvent5
        '
        Me.cmbEvent5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEvent5.ForeColor = System.Drawing.Color.Black
        Me.cmbEvent5.FormattingEnabled = True
        Me.cmbEvent5.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbEvent5.Location = New System.Drawing.Point(612, 244)
        Me.cmbEvent5.Name = "cmbEvent5"
        Me.cmbEvent5.Size = New System.Drawing.Size(102, 28)
        Me.cmbEvent5.TabIndex = 19
        '
        'cmbEvent3
        '
        Me.cmbEvent3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEvent3.ForeColor = System.Drawing.Color.Black
        Me.cmbEvent3.FormattingEnabled = True
        Me.cmbEvent3.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbEvent3.Location = New System.Drawing.Point(349, 244)
        Me.cmbEvent3.Name = "cmbEvent3"
        Me.cmbEvent3.Size = New System.Drawing.Size(102, 28)
        Me.cmbEvent3.TabIndex = 20
        '
        'btnLeaderBoardScreen
        '
        Me.btnLeaderBoardScreen.BackColor = System.Drawing.Color.LightCyan
        Me.btnLeaderBoardScreen.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnLeaderBoardScreen.ForeColor = System.Drawing.Color.Black
        Me.btnLeaderBoardScreen.Location = New System.Drawing.Point(541, 389)
        Me.btnLeaderBoardScreen.Name = "btnLeaderBoardScreen"
        Me.btnLeaderBoardScreen.Size = New System.Drawing.Size(198, 31)
        Me.btnLeaderBoardScreen.TabIndex = 21
        Me.btnLeaderBoardScreen.Text = "Go to Leader Board"
        Me.btnLeaderBoardScreen.UseVisualStyleBackColor = False
        '
        'btnHelpScores
        '
        Me.btnHelpScores.BackColor = System.Drawing.Color.LightCyan
        Me.btnHelpScores.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnHelpScores.ForeColor = System.Drawing.Color.Black
        Me.btnHelpScores.Location = New System.Drawing.Point(40, 139)
        Me.btnHelpScores.Name = "btnHelpScores"
        Me.btnHelpScores.Size = New System.Drawing.Size(114, 31)
        Me.btnHelpScores.TabIndex = 22
        Me.btnHelpScores.Text = "Help Screen"
        Me.btnHelpScores.UseVisualStyleBackColor = False
        '
        'frmScores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(788, 450)
        Me.Controls.Add(Me.btnHelpScores)
        Me.Controls.Add(Me.btnLeaderBoardScreen)
        Me.Controls.Add(Me.cmbEvent3)
        Me.Controls.Add(Me.cmbEvent5)
        Me.Controls.Add(Me.cmbEvent4)
        Me.Controls.Add(Me.cmbEvent2)
        Me.Controls.Add(Me.cmbEvent1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnLoginScreen)
        Me.Controls.Add(Me.btnSaveScores)
        Me.Controls.Add(Me.btnAddPlayersScreen)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbSelectPlayer)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmScores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmScores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmbSelectPlayer As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnAddPlayersScreen As Button
    Friend WithEvents btnSaveScores As Button
    Friend WithEvents btnLoginScreen As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbEvent1 As ComboBox
    Friend WithEvents cmbEvent2 As ComboBox
    Friend WithEvents cmbEvent4 As ComboBox
    Friend WithEvents cmbEvent5 As ComboBox
    Friend WithEvents cmbEvent3 As ComboBox
    Friend WithEvents btnLeaderBoardScreen As Button
    Friend WithEvents btnHelpScores As Button
End Class
