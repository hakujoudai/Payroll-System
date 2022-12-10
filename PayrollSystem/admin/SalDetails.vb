﻿Imports System.Data
Imports System.Data.SqlClient
Imports System.Net.Mail
Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class SalDetails

    Dim sqlConn As New MySqlConnection
    Dim sqlCmd As New MySqlCommand
    Dim sqlRd As MySqlDataReader
    Dim sqlDt As New DataTable
    Dim Server As String = "server=localhost;user=root;password=password;port=3306;database=payroll"
    Dim query As String

    Private Sub loadTable()
        sqlConn.ConnectionString = Server

        sqlConn.Open()
        sqlCmd.Connection = sqlConn
        sqlCmd.CommandText = "Select * from payroll.salary"

        sqlRd = sqlCmd.ExecuteReader
        sqlDt.Load(sqlRd)
        sqlRd.Close()
        sqlConn.Close()
        DataGridView1.DataSource = sqlDt
    End Sub

    Private Sub SalDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadTable()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick, DataGridView1.CellClick
        Try
            In1.Text = DataGridView1.SelectedRows(0).Cells(0).Value.ToString
            In2.Text = DataGridView1.SelectedRows(0).Cells(1).Value.ToString
            In3.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sqlConn.ConnectionString = Server

        Try
            sqlConn.Open()
            query = "INSERT INTO payroll.salary (SALARY_ID, JOB_CODE, SALARY_AMOUNT) VALUE (" & "'" & In1.Text & "', '" & In2.Text & "', " & In3.Text & " );"
            sqlCmd = New MySqlCommand(query, sqlConn)
            sqlRd = sqlCmd.ExecuteReader
            sqlRd.Close()
            MessageBox.Show("Successfully added Record")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MySQL Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            sqlConn.Dispose()
        End Try


        loadTable()
        In1.Text = ""
        In2.Text = ""
        In3.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sqlConn.ConnectionString = Server

        sqlConn.Open()
        sqlCmd.Connection = sqlConn

        With sqlCmd
            .CommandText = "UPDATE payroll.salary SET JOB_CODE=@JOB_CODE, SALARY_AMOUNT=@SALARY_AMOUNT WHERE SALARY_ID=@SALARY_ID"
            .CommandType = CommandType.Text
            .Parameters.AddWithValue("@SALARY_ID", In1.Text)
            .Parameters.AddWithValue("@JOB_CODE", In2.Text)
            .Parameters.AddWithValue("@SALARY_AMOUNT", In3.Text)

        End With

        sqlCmd.ExecuteNonQuery()
        sqlCmd.Parameters.Clear()
        sqlConn.Close()
        MessageBox.Show("Successfully updated Record")
        loadTable()

        In1.Text = ""
        In2.Text = ""
        In3.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For Each row As DataGridViewRow In DataGridView1.SelectedRows
            DataGridView1.Rows.Remove(row)
        Next

        sqlConn.ConnectionString = Server

        sqlConn.Open()
        sqlCmd.Connection = sqlConn

        With sqlCmd
            .CommandText = "DELETE FROM payroll.salary WHERE SALARY_ID=@SALARY_ID"

            .CommandType = CommandType.Text
            .Parameters.AddWithValue("@SALARY_ID", In1.Text)

        End With

        sqlCmd.ExecuteNonQuery()
        sqlCmd.Parameters.Clear()
        sqlConn.Close()

        MessageBox.Show("Successfully deleted Record")
        loadTable()
        In1.Text = ""
        In2.Text = ""
        In3.Text = ""

        loadTable()
    End Sub
End Class