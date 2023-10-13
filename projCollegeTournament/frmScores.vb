'*************************************************************
' Class : frmScores
' Project : projCollegeTournament
' Version : 1.1
' Date (Created) : 23/04/2021
' Date (Modified) : 14/05/2021
' Description :This form allows scores to be entered for five events
'************************************************************* 
Public Class frmScores
    '*************************************************************
    ' Private Sub : btnHelpScores_Click
    ' Parameters : Object, EventArgs
    ' Return Type : None
    ' Description : Used to show frmHelpScores
    '*************************************************************
    Private Sub btnHelpScores_Click(sender As Object, e As EventArgs) Handles btnHelpScores.Click

        frmHelpScores.Show() 'Showing the Help screen for the Scores
        Me.Hide() 'Hiding frmScores

    End Sub
    '*************************************************************
    ' Private Sub : btnLoginScreen_Click
    ' Parameters : Object, EventArgs
    ' Return Type : None
    ' Description : Used to show frmLogin
    '*************************************************************
    Private Sub btnLoginScreen_Click(sender As Object, e As EventArgs) Handles btnLoginScreen.Click

        frmLogin.Show() 'Showing the login screen
        Me.Hide() 'Hiding frmScores

    End Sub
    '*************************************************************
    ' Private Sub : btnAddPlayersScreen_Click
    ' Parameters : Object, EventArgs
    ' Return Type : None
    ' Description : Used to show frmAddPlayers
    '*************************************************************
    Private Sub btnAddPlayersScreen_Click(sender As Object, e As EventArgs) Handles btnAddPlayersScreen.Click

        frmAddPlayers.Show() 'Showing the Add Players screen
        Me.Hide() 'Hiding frmScores

    End Sub
    '*************************************************************
    ' Private Sub : btnLeaderBoardScreen_Click
    ' Parameters : Object, EventArgs
    ' Return Type : None
    ' Description : Used to show frmLeaderBoard
    '*************************************************************
    Private Sub btnLeaderBoardScreen_Click(sender As Object, e As EventArgs) Handles btnLeaderBoardScreen.Click

        frmLeaderBoard.Show() 'Showing the Leader Board screen
        Me.Hide() 'Hiding frmScores

    End Sub
    '*************************************************************
    ' Private Sub : btnSaveScores_Click
    ' Parameters : Object, EventArgs
    ' Return Type : None
    ' Description : Used to save the scores for each team/individual selected
    '*************************************************************
    Private Sub btnSaveScores_Click(sender As Object, e As EventArgs) Handles btnSaveScores.Click
        'Declaring i as integer and equaling it to a combo box
        Dim i As Integer = cmbSelectPlayer.SelectedIndex
        'Declaring intTotal
        Dim intTotal As Integer
        'Declaring strPlayer
        Dim strPlayer As String = cmbSelectPlayer.Text

        'Validating selected player combo box so if nothing is entered
        If cmbSelectPlayer.Text = Nothing Then
            MessageBox.Show("Please select a player") 'Displays a message 
        Else
            'Validation the scores for each event so if nothing is entered a message box is displayed
            If cmbEvent1.Text = Nothing Or cmbEvent2.Text = Nothing Or cmbEvent3.Text = Nothing Or cmbEvent4.Text = Nothing Or cmbEvent5.Text = Nothing Then
                MessageBox.Show("Please enter a number for an event")
            Else
                'get entered grades for selected class and add to array
                MyGlobals.arrGrades(i, 1) = cmbEvent1.Text
                MyGlobals.arrGrades(i, 2) = cmbEvent2.Text
                MyGlobals.arrGrades(i, 3) = cmbEvent3.Text
                MyGlobals.arrGrades(i, 4) = cmbEvent4.Text
                MyGlobals.arrGrades(i, 5) = cmbEvent5.Text

                'Adding all five events to get a total and putting it into the array 
                For x As Integer = 1 To 5
                    intTotal += CType(MyGlobals.arrGrades(i, x), Integer)
                Next
                MyGlobals.arrGrades(i, 6) = CStr(intTotal)
                'Display message that grades have been added and clear combo boxes
                MessageBox.Show("Scores have been added for " & strPlayer)
                cmbSelectPlayer.SelectedIndex = -1
                cmbEvent1.SelectedIndex = -1
                cmbEvent2.SelectedIndex = -1
                cmbEvent3.SelectedIndex = -1
                cmbEvent4.SelectedIndex = -1
                cmbEvent5.SelectedIndex = -1

            End If
        End If
    End Sub
    '*************************************************************
    ' Private Sub : cmbSelectPlayer_Click
    ' Parameters : Object, EventArgs
    ' Return Type : None
    ' Description : Used so you get the players added in the frmAddPlayers screen to show in combo box
    '*************************************************************
    Private Sub cmbSelectPlayer_click(sender As Object, e As EventArgs) Handles cmbSelectPlayer.Click

        'it is clearing the players combo box and refreshing it encase there was more people added to the tournament
        cmbSelectPlayer.Items.Clear()
        For i = 0 To MyGlobals.intPlayerCount - 1
            cmbSelectPlayer.Items.Add(MyGlobals.arrGrades(i, 0)) 'Adding the grades to the selected player in array
        Next
        cmbEvent1.SelectedIndex = -1
        cmbEvent2.SelectedIndex = -1
        cmbEvent3.SelectedIndex = -1
        cmbEvent4.SelectedIndex = -1
        cmbEvent5.SelectedIndex = -1
    End Sub
End Class