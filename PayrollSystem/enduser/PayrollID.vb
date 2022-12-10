
Imports System.Data
Imports System.Data.SqlClient
Imports System.Net.Mail
Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class PayrollID

    Dim sqlConn As New MySqlConnection
    Dim sqlCmd As New MySqlCommand
    Dim sqlRd As MySqlDataReader
    Dim dtA As New MySqlDataAdapter
    Dim Server As String = "server=localhost;user=root;password=password;port=3306;database=payroll"
    Dim query As String

    Private Sub View_Click(sender As Object, e As EventArgs) Handles View.Click
        sqlConn.ConnectionString = Server
        Dim total As Double
        Try
            sqlConn.Open()
            query = "SELECT TOTAL_AMOUNT FROM payroll.payroll WHERE PAYROLL_ID=" & TextBox1.Text
            sqlCmd = New MySqlCommand(query, sqlConn)
            sqlRd = sqlCmd.ExecuteReader
            sqlRd.Read()
            total = sqlRd("TOTAL_AMOUNT")
            sqlRd.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message, "MySQL Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            sqlConn.Dispose()
        End Try

        Label3.Text = "PHP " & total
    End Sub

    Private Sub PayrollID_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class