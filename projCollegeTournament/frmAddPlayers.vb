'*************************************************************
' Class : frmAddPlayers
' Project : projCollegeTournament
' Version : 1.1
' Date (Created) : 23/04/2021
' Date (Modified) : 14/05/2021
' Description : This form is used to add individuals to the tournament.
'************************************************************* 
Public Class frmAddPlayers

    'It is used to keep track of players added to a team
    Dim intClass1Count As Integer = 1 'Team 1
    Dim intClass2Count As Integer = 1 'Team 2
    Dim intClass3Count As Integer = 1 'Team 3
    Dim intClass4Count As Integer = 1 'Team 4

    '*************************************************************
    ' Private Sub : btnScoresScreen_Click
    ' Parameters : Object, EventArgs
    ' Return Type : None
    ' Description : Used to show frmScores
    '************************************************************* 
    Private Sub btnScoresScreen_Click(sender As Object, e As EventArgs) Handles btnScoresScreen.Click

        frmScores.Show() 'Showing scores screen
        Me.Hide() 'Hiding frmAddPlayers

    End Sub
    '*************************************************************
    ' Private Sub : btnLoginScreen_Click
    ' Parameters : Object, EventArgs
    ' Return Type : None
    ' Description : Used to show frmLogin
    '************************************************************* 
    Private Sub btnLoginScreen_Click(sender As Object, e As EventArgs) Handles btnLoginScreen.Click

        frmLogin.Show() 'Showing Login Screen
        Me.Hide() 'Hiding frmAddPlayers

    End Sub
    '*************************************************************
    ' Private Sub : frmAddPlayers_Load
    ' Parameters : Object, EventArgs
    ' Return Type : None
    ' Description : Used to pre-populate the first four teams
    '*************************************************************
    Private Sub frmAddPlayers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Pre-Populate Teams into the array
        MyGlobals.arrGrades(0, 0) = "Teams 1"
        MyGlobals.arrGrades(1, 0) = "Teams 2"
        MyGlobals.arrGrades(2, 0) = "Teams 3"
        MyGlobals.arrGrades(3, 0) = "Teams 4"

    End Sub
    '*************************************************************
    ' Private Sub : btnAddPlayers_Click
    ' Parameters : Object, EventArgs
    ' Return Type : None
    ' Description : Used to add players to the tournament
    '*************************************************************
    Private Sub btnAddPlayer_Click(sender As Object, e As EventArgs) Handles btnAddPlayer.Click

        Dim strName As String 'Declaring strName

        'Validating if button is pressed and nothing is in textbox
        If txtPlayerName.Text = Nothing Then
            MessageBox.Show("No player entered, please try again") 'Message is displayed
            'Clear and focus cursor in player name textbox
            txtPlayerName.Clear()
            txtPlayerName.Focus()
            Exit Sub
        End If

        'If number of players is less than 24 then
        If MyGlobals.intPlayerCount < 24 Then '24 due to the four pre-populated teams
            strName = txtPlayerName.Text 'Setting strName equal to txtPlayerName
            MyGlobals.arrGrades(MyGlobals.intPlayerCount, 0) = strName 'Storing player name in array
            MyGlobals.intPlayerCount += 1 'Adding one to the number of players added
            MessageBox.Show(strName & " has been added.") 'Displaying a message that player is added
            'Clear and focus cursor in player name textbox
            txtPlayerName.Clear()
            txtPlayerName.Focus()
        Else
            'If number of players is more or equal to 24 then
            If MyGlobals.intPlayerCount >= 24 Then
                MessageBox.Show("Maximum number of players added") 'Displaying a message that max number of players is added
                'Clear and focus cursor in player name textbox
                txtPlayerName.Clear()
                txtPlayerName.Focus()
            End If
        End If

    End Sub
    '*************************************************************
    ' Private Sub : frmAddPlayers_Activated
    ' Parameters : Object, EventArgs
    ' Return Type : None
    ' Description : Used to focus cursor in the player name textbox when form loads
    '*************************************************************
    Private Sub frmAddPlayers_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'Focus cursor in player name textbox
        txtPlayerName.Focus()

    End Sub
End Class