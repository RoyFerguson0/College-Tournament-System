'*************************************************************
' Class : frmSplash
' Project : projCollegeTournament
' Version : 1.1
' Date (Created) : 16/04/2021
' Date (Modified) : 11/05/2021
' Description : Used as a pop up screen before the login screen loads.
'************************************************************* 
Public Class frmSplash
    '*************************************************************
    ' Private Sub : tmrSplash_Tick
    ' Parameters : Object, EventArgs
    ' Return Type : None
    ' Description : Used to show frmLogin when the timer ends
    '*************************************************************
    Private Sub tmrSplash_Tick(sender As Object, e As EventArgs) Handles tmrSplash.Tick

        Me.Hide() 'Hiding frmSplash
        frmLogin.Show() 'Showing Login Screen
        tmrSplash.Enabled = False 'Turning times off so page doesn't continue to load



    End Sub
    '*************************************************************
    ' Private Sub : tmrProgress_Tick
    ' Parameters : Object, EventArgs
    ' Return Type : None
    ' Description : Used to show bar filling up so the user knows when the frmLogin screen is displayed.
    '*************************************************************
    Private Sub tmrProgress_Tick(sender As Object, e As EventArgs) Handles tmrProgress.Tick

        pbrSplash.PerformStep() 'Getting progress bar to run when splash screen is displayed



    End Sub
End Class