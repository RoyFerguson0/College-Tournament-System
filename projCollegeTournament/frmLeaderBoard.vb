'*************************************************************
' Class : frmLeaderBoard
' Project : projCollegeTournament
' Version : 1.1
' Date (Created) : 24/04/2021
' Date (Modified) : 11/05/2021
' Description : Form used to display the individual/teams scores
'************************************************************* 
Public Class frmLeaderBoard
    '*************************************************************
    ' Private Sub : btnScoresScreen_Click
    ' Parameters : Object, EventArgs
    ' Return Type : None
    ' Description : Used to show frmScores
    '*************************************************************
    Private Sub btnScoresScreen_Click(sender As Object, e As EventArgs) Handles btnScoresScreen.Click

        frmScores.Show() 'Showing the Scores Screen
        Me.Hide() 'Hiding frmLeaderBoard

    End Sub
    '*************************************************************
    ' Private Sub : btnClose_Click
    ' Parameters : Object, EventArgs
    ' Return Type : None
    ' Description : Used to close the entire application/program
    '*************************************************************
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        frmSplash.Close() 'Used to close program

    End Sub
    '*************************************************************
    ' Private Sub : btnDisplay_Click
    ' Parameters : Object, EventArgs
    ' Return Type : None
    ' Description : Used to display the scores for each individual and team
    '*************************************************************
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        'Declaring strGrades 
        Dim strGrades As String

        'loop through each element in first column of array and add to string (names)
        For i As Integer = 0 To MyGlobals.intPlayerCount - 1
            For x As Integer = 0 To 6
                strGrades += MyGlobals.arrGrades(i, x) & "                        "
                If x = 6 Then
                    strGrades += vbNewLine
                End If
            Next
        Next
        'Output strings to labels
        lblDisplayGrades.Text = strGrades
    End Sub
End Class