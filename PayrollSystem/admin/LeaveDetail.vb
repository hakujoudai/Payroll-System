Imports System.Data
Imports System.Data.SqlClient
Imports System.Net.Mail
Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class LeaveDetail

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
        sqlCmd.CommandText = "Select * from payroll.leaves"

        sqlRd = sqlCmd.ExecuteReader
        sqlDt.Load(sqlRd)
        sqlRd.Close()
        sqlConn.Close()
        DataGridView1.DataSource = sqlDt
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick, DataGridView1.CellClick
        Dim dt As DateTime
        Try
            In1.Text = DataGridView1.SelectedRows(0).Cells(0).Value.ToString
            In2.Text = DataGridView1.SelectedRows(0).Cells(1).Value.ToString
            dt = DataGridView1.SelectedRows(0).Cells(2).Value.ToString
            Convert.ToDateTime(dt)
            Dim format As String = "yyyy-MM-dd"
            Dim str As String = dt.ToString(format)
            In3.Text = str

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub LeaveDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadTable()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sqlConn.ConnectionString = Server

        Try
            sqlConn.Open()
            query = "INSERT INTO payroll.leaves (LEAVE_ID, EMP_ID, DATE_OF_LEAVE) VALUE (" & "'" & In1.Text & "', '" & In2.Text & "', '" & In3.Text & "' );"
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
            .CommandText = "UPDATE payroll.leaves SET DATE_OF_LEAVE=@DATE_OF_LEAVE WHERE LEAVE_ID=@LEAVE_ID"
            .CommandType = CommandType.Text
            .Parameters.AddWithValue("@LEAVE_ID", In1.Text)
            .Parameters.AddWithValue("@DATE_OF_LEAVE", In3.Text)

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
            .CommandText = "DELETE FROM payroll.leaves WHERE LEAVE_ID=@LEAVE_ID"

            .CommandType = CommandType.Text
            .Parameters.AddWithValue("@LEAVE_ID", In1.Text)

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