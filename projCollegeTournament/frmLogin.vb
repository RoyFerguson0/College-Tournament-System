'*************************************************************
' Class : frmLogin
' Project : projCollegeTournament
' Version : 1.1
' Date (Created) : 16/04/2021
' Date (Modified) : 14/05/2021
' Description : This form is used to log a authorised person into the tournament.
'************************************************************* 
Public Class frmLogin
    Dim intTries As Integer = 0 'Declaring intTries and equaling it to zero
    '*************************************************************
    ' Private Sub : btnLogon_Click
    ' Parameters : Object, EventArgs
    ' Return Type : None
    ' Description : If password and username match then Add Players page will show.
    '*************************************************************
    Private Sub btnLogon_Click(sender As Object, e As EventArgs) Handles btnLogon.Click

        'If username or password is blank display message box then clear and focus textboxes.
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Username or password has not been entered")
            'Clear and focus cursor in username textbox
            txtUsername.Clear()
            txtPassword.Clear()
            txtUsername.Focus()
            Exit Sub
        End If
        'Declaring strUsername and StrPassword and assigning them to equal a textbox.
        Dim strUsername, strPassword As String
        strUsername = txtUsername.Text
        strPassword = txtPassword.Text

        'No more than three login attempts allowed
        If intTries < 3 Then
            'What username and password needs to be entered for frmAddPlayers to be displayed.
            If strUsername.ToLower = "bmc" And strPassword.ToLower = "admin" Then
                'Clear and focus cursor in username textbox
                txtUsername.Clear()
                txtPassword.Clear()
                txtUsername.Focus()
                frmAddPlayers.Show() 'Showing Add Players Screen
                Me.Hide() 'Hiding frmLogin
            Else
                'If username or password is invalid it displays a message box
                MessageBox.Show("Invalid Username or Password")
                intTries += 1 'Adding one to intTries(Number of Attemps) 
                'Clear and focus cursor in username textbox
                txtUsername.Clear()
                txtPassword.Clear()
                txtUsername.Focus()
                'If login attempts are equal to or greater than three a message box will be displayed and program will close.
                If intTries >= 3 Then
                    MessageBox.Show("Maximum number of attempts reached the application willl now close")
                    frmSplash.Close()
                End If
            End If
        End If
    End Sub
    '*************************************************************
    ' Private Sub : btnClear_Click
    ' Parameters : Object, EventArgs
    ' Return Type : None
    ' Description : Used to clear and focus textboxes.
    '*************************************************************
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'Clear and focus cursor in username textbox
        txtUsername.Clear()
        txtPassword.Clear()
        txtUsername.Focus()


    End Sub
    '*************************************************************
    ' Private Sub : btnClose_Click
    ' Parameters : Object, EventArgs
    ' Return Type : None
    ' Description : Used to close entire application/program.
    '*************************************************************
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        frmSplash.Close() 'Used to close program

    End Sub
    '*************************************************************
    ' Private Sub : frmLogin_Activated
    ' Parameters : Object, EventArgs
    ' Return Type : None
    ' Description : Used to focus cursor in the username textbox when form loads
    '*************************************************************
    Private Sub frmLogin_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        txtUsername.Focus() 'focus textbox

    End Sub
End Class