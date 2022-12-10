Imports MySql.Data.MySqlClient

Public Class WelcomeStaff
    Dim sqlConn As New MySqlConnection
    Dim sqlCmd, sqlCmd3, sqlCmd4, sqlCmd5, sqlCmd6, sqlCmd7 As New MySqlCommand
    Dim sqlRd, sqlRd3, sqlRd4, sqlRd5, sqlRd6, sqlRd7 As MySqlDataReader
    Dim sqlDt, sqlDt3, sqlDt4, sqlDt5, sqlDt6, sqlDt7 As New DataTable

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PayrollCalculator.show()
    End Sub

    Dim Server As String = "server=localhost;user=root;password=password;port=3306;database=payroll"

    Private Sub loadTable()
        sqlConn.ConnectionString = Server

        sqlConn.Open()
        sqlCmd.Connection = sqlConn
        sqlCmd.CommandText = "Select * from payroll.employee"
        sqlRd = sqlCmd.ExecuteReader
        sqlDt.Load(sqlRd)
        sqlRd.Close()
        sqlConn.Close()

        sqlConn.Open()
        sqlCmd3.Connection = sqlConn
        sqlCmd3.CommandText = "Select * from payroll.salary"
        sqlRd3 = sqlCmd3.ExecuteReader
        sqlDt3.Load(sqlRd3)
        sqlRd3.Close()
        sqlConn.Close()

        sqlConn.Open()
        sqlCmd4.Connection = sqlConn
        sqlCmd4.CommandText = "Select * from payroll.bonuses"
        sqlRd4 = sqlCmd4.ExecuteReader
        sqlDt4.Load(sqlRd4)
        sqlRd4.Close()
        sqlConn.Close()

        sqlConn.Open()
        sqlCmd5.Connection = sqlConn
        sqlCmd5.CommandText = "Select * from payroll.deductions"
        sqlRd5 = sqlCmd5.ExecuteReader
        sqlDt5.Load(sqlRd5)
        sqlRd5.Close()
        sqlConn.Close()

        sqlConn.Open()
        sqlCmd6.Connection = sqlConn
        sqlCmd6.CommandText = "Select * from payroll.leaves"
        sqlRd6 = sqlCmd6.ExecuteReader
        sqlDt6.Load(sqlRd6)
        sqlRd6.Close()
        sqlConn.Close()

        sqlConn.Open()
        sqlCmd7.Connection = sqlConn
        sqlCmd7.CommandText = "Select * from payroll.payroll"
        sqlRd7 = sqlCmd7.ExecuteReader
        sqlDt7.Load(sqlRd7)
        sqlRd7.Close()
        sqlConn.Close()


        DataGridView1.DataSource = sqlDt
        DataGridView3.DataSource = sqlDt3
        DataGridView4.DataSource = sqlDt4
        DataGridView5.DataSource = sqlDt5
        DataGridView6.DataSource = sqlDt6
        DataGridView7.DataSource = sqlDt7

    End Sub
    Private Sub WelcomeStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadTable()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SalDetails.Show()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        BonDetails.Show()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        DedDetails.Show()
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        PayrollDetail.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        MessageBox.Show("Successfully logged out")
        Me.Hide()
        SalDetails.Hide()
        BonDetails.Hide()
        DedDetails.Hide()
        PayrollDetail.Hide()
        Login.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        loadTable()
    End Sub
End Class