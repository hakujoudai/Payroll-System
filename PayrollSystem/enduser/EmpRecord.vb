Imports System.Data
Imports System.Data.SqlClient
Imports System.Net.Mail
Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class EmpRecord

    Dim sqlConn As New MySqlConnection
    Dim sqlCmd As New MySqlCommand
    Dim sqlRd As MySqlDataReader
    Dim sqlDt As New DataTable
    Dim Server As String = "server=localhost;user=root;password=Jeffreythe1st;port=3306;database=payroll"
    Dim query As String

    Public Shared id As String

    Private Sub loadTable()
        sqlConn.ConnectionString = Server

        sqlConn.Open()
        sqlCmd.Connection = sqlConn
        sqlCmd.CommandText = "Select * from payroll.employee WHERE EMP_ID=" & id

        sqlRd = sqlCmd.ExecuteReader
        sqlDt.Load(sqlRd)
        sqlRd.Close()
        sqlConn.Close()
        DataGridView1.DataSource = sqlDt
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick, DataGridView1.CellClick
        Try
            In1.Text = DataGridView1.SelectedRows(0).Cells(1).Value.ToString
            In2.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString
            In3.Text = DataGridView1.SelectedRows(0).Cells(3).Value.ToString
            In4.Text = DataGridView1.SelectedRows(0).Cells(4).Value.ToString
            In5.Text = DataGridView1.SelectedRows(0).Cells(6).Value.ToString
            In6.Text = DataGridView1.SelectedRows(0).Cells(7).Value.ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub EmpRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadTable()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sqlConn.ConnectionString = Server

        sqlConn.Open()
        sqlCmd.Connection = sqlConn

        With sqlCmd
            .CommandText = "UPDATE payroll.employee SET EMP_LNAME=@EMP_LNAME, EMP_FNAME=@EMP_FNAME, EMP_GENDER=@EMP_GENDER, EMP_ADD=@EMP_ADD, EMP_CONTACT_NUMBER=@EMP_CONTACT_NUMBER, EMP_HOURS_WORKED=@EMP_HOURS_WORKED WHERE EMP_ID =@EMP_ID"
            .CommandType = CommandType.Text
            .Parameters.AddWithValue("@EMP_ID", id)
            .Parameters.AddWithValue("@EMP_LNAME", In1.Text)
            .Parameters.AddWithValue("@EMP_FNAME", In2.Text)
            .Parameters.AddWithValue("@EMP_GENDER", In3.Text)
            .Parameters.AddWithValue("@EMP_ADD", In4.Text)
            .Parameters.AddWithValue("@EMP_CONTACT_NUMBER", In5.Text)
            .Parameters.AddWithValue("@EMP_HOURS_WORKED", In6.Text)



        End With

        sqlCmd.ExecuteNonQuery()
        sqlCmd.Parameters.Clear()
        sqlConn.Close()
        MessageBox.Show("Successfully updated Record")
        loadTable()

        In1.Text = ""
        In2.Text = ""
        In3.Text = ""
        In4.Text = ""
        In5.Text = ""
        In6.Text = ""

    End Sub
End Class