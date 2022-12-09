Imports System.Data
Imports System.Data.SqlClient
Imports System.Net.Mail
Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32

Public Class WelcomeUser

    Dim sqlConn As New MySqlConnection
    Dim sqlCmd, sqlCmd2 As New MySqlCommand
    Dim sqlRd, sqlRd2 As MySqlDataReader
    Dim sqlDt, sqlDt2 As New DataTable
    Dim Server As String = "server=localhost;user=root;password=Jeffreythe1st;port=3306;database=payroll"

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        EmpID.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        LeaveDetail.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        PayrollID.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        loadTable()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        MessageBox.Show("Successfully logged out")
        Me.Hide()
        EmpID.Hide()
        EmpRecord.Hide()
        LeaveDetail.Hide()
        PayrollID.Hide()
        Login.Show()
    End Sub

    Dim query As String

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
        sqlCmd2.Connection = sqlConn
        sqlCmd2.CommandText = "Select * from payroll.leaves"
        sqlRd2 = sqlCmd2.ExecuteReader
        sqlDt2.Load(sqlRd2)
        sqlRd2.Close()
        sqlConn.Close()

        DataGridView1.DataSource = sqlDt
        DataGridView2.DataSource = sqlDt2

    End Sub
    Private Sub WelcomeUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadTable()
    End Sub
End Class