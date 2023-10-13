'*************************************************************
' Class : frmHelpScores
' Project : projCollegeTournament
' Version : 1.1
' Date (Created) : 27/04/2021
' Date (Modified) : 10/05/2021
' Description : Form used to show user how to operate frmScores.
'************************************************************* 
Public Class frmHelpScores
    '*************************************************************
    ' Private Sub : btnScoresScreen_Click
    ' Parameters : Object, EventArgs
    ' Return Type : None
    ' Description : Used to show frmScores 
    '*************************************************************
    Private Sub btnScoresScreen_Click(sender As Object, e As EventArgs) Handles btnScoresScreen.Click

        frmScores.Show() 'Showing Scores screen
        Me.Hide() 'Hiding frmHelpScores 

    End Sub
End Class