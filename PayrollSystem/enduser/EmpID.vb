Public Class EmpID
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        EmpRecord.id = TextBox1.Text
        EmpRecord.Show()
    End Sub

    Private Sub EmpID_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class