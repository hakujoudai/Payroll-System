Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Login
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles userTxt.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

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
            MessageBox.Show("welcome admin")
            Me.Hide()
            WelcomeAdmin.Show()
        Else
            MessageBox.Show("incorrect username or password")
        End If

    End Sub
End Class