Imports System.Data
Imports System.Data.SqlClient
Imports System.Net.Mail
Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class PayrollCalculator

    Dim sqlConn As New MySqlConnection
    Dim sqlCmd As New MySqlCommand
    Dim sqlRd As MySqlDataReader
    Dim dtA As New MySqlDataAdapter
    Dim Server As String = "server=localhost;user=root;password=password;port=3306;database=payroll"
    Dim query As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sqlConn.ConnectionString = Server
        Dim sal, ded, bon As Double
        Try
            sqlConn.Open()
            query = "SELECT SALARY_AMOUNT FROM payroll.salary WHERE SALARY_ID=" & TextBox1.Text
            sqlCmd = New MySqlCommand(query, sqlConn)
            sqlRd = sqlCmd.ExecuteReader
            sqlRd.Read()
            sal = sqlRd("SALARY_AMOUNT")
            sqlRd.Close()

            query = "SELECT DEDUCTION_AMOUNT FROM payroll.deductions WHERE DEDUCTION_ID=" & TextBox2.Text
            sqlCmd = New MySqlCommand(query, sqlConn)
            sqlRd = sqlCmd.ExecuteReader
            sqlRd.Read()
            ded = sqlRd("DEDUCTION_AMOUNT")
            sqlRd.Close()

            query = "SELECT BONUS_AMOUNT FROM payroll.bonuses WHERE BONUS_ID=" & TextBox3.Text
            sqlCmd = New MySqlCommand(query, sqlConn)
            sqlRd = sqlCmd.ExecuteReader
            sqlRd.Read()
            bon = sqlRd("BONUS_AMOUNT")
            sqlRd.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "MySQL Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            sqlConn.Dispose()
        End Try

        TextBox4.Text = sal - ded + bon
    End Sub

    Private Sub PayrollCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class