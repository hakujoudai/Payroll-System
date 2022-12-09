Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Login


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If userTxt.Text = "" Then
            MessageBox.Show("Please enter username")
            userTxt.Focus()
            Exit Sub
        ElseIf passTxt.Text = "" Then
            MessageBox.Show("Please enter password")
            passTxt.Focus()
            Exit Sub
        End If

        If userTxt.Text = "admin" And passTxt.Text = "admin" Then
            MessageBox.Show("Successfully logged in as Admin")
            Me.Hide()
            WelcomeAdmin.Show()
        ElseIf userTxt.Text = "staff" And passTxt.Text = "staff" Then
            MessageBox.Show("Successfully logged in as Staff")
            Me.Hide()
            WelcomeStaff.Show()
        ElseIf userTxt.Text = "user" And passTxt.Text = "user" Then
            MessageBox.Show("Successfully logged in as User")
            Me.Hide()
            WelcomeUser.Show()
        Else
            MessageBox.Show("Incorrect Username or Password")
        End If

        userTxt.Text = ""
        passTxt.Text = ""
    End Sub
End Class