Imports MySqlConnector
Imports System.Data.MySqlClient

Public Class Details
    Private connection As MySqlConnection

    Private Sub Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Define the connection string
        Dim connectionString As String = "server=localhost;user=root;password=0000;database=employeemangementsystembd"
        connection = New MySqlConnection(connectionString)
    End Sub

    Private Sub FetchEmployeeData(empId As Integer)
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim query As String = "SELECT * FROM employeetable WHERE EmpId = @EmpId"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@EmpId", empId)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            For Each row As DataRow In table.Rows
                EmpNameLabel.Text = row(1).ToString()
                EmpAddLabel.Text = row(2).ToString()
                EmpPosLabel.Text = row(3).ToString()
                EmpDobLabel.Text = row(4).ToString()
                EmpPhoneLabel.Text = row(5).ToString()
                EmpEduLabel.Text = row(6).ToString()
                EmpGenderLabel.Text = row(7).ToString()
                EmpNameLabel.Visible = True
                EmpPhoneLabel.Visible = True
                EmpAddLabel.Visible = True
                EmpPosLabel.Visible = True
                EmpDobLabel.Visible = True
                EmpEduLabel.Visible = True
                EmpGenderLabel.Visible = True
            Next
        Catch ex As MySqlException
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub RefreshBtn_Click(sender As Object, e As EventArgs) Handles RefreshBtn.Click
        ' Assuming you have a way to get the EmpId, for example from a TextBox or other control
        Dim empId As Integer
        If Integer.TryParse(EmpIdTextBox.Text, empId) Then
            FetchEmployeeData(empId)
        Else
            MessageBox.Show("Please enter a valid Employee ID.")
        End If
    End Sub

    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        Me.Hide()
        Dim Main = New Main
        Main.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
