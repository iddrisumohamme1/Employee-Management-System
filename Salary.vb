Imports MySqlConnector

Public Class Salary
    Private connection As MySqlConnection

    Private Sub Salary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                EmpPosLabel.Text = row(3).ToString()
                EmpNameLabel.Visible = True
                EmpPosLabel.Visible = True
            Next
        Catch ex As MySqlException
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        Me.Hide()
        Dim Main = New Main
        Main.Show()
    End Sub

    Private Sub RefreshBtn_Click(sender As Object, e As EventArgs) Handles RefreshBtn.Click
        Dim empId As Integer
        If Integer.TryParse(EmpIdTextBox.Text, empId) Then
            FetchEmployeeData(empId)
        Else
            MessageBox.Show("Please enter a valid Employee ID.")
        End If
    End Sub

    Dim DailyPay As Integer

    Private Sub ViewBtn_Click(sender As Object, e As EventArgs) Handles ViewBtn.Click
        If EmpPosLabel.Text = "" Then
            MessageBox.Show("Select an Employee")
        ElseIf TextBoxWorkedDays.Text = "" OrElse Not Integer.TryParse(TextBoxWorkedDays.Text, Nothing) OrElse Convert.ToInt32(TextBoxWorkedDays.Text) > 28 Then
            MessageBox.Show("Enter a Valid Number of Days")
        Else
            Select Case EmpPosLabel.Text
                Case "Manager", "Accountant"
                    DailyPay = 1200
                Case "Security"
                    DailyPay = 600
                Case "IT"
                    DailyPay = 850
                Case Else
                    DailyPay = 500
            End Select

            Dim total As Integer = DailyPay * Convert.ToInt32(TextBoxWorkedDays.Text)
            RichTextBoxSalary.Text = $"Employee Id: {EmpIdTextBox.Text}" & Environment.NewLine &
                                     $"Employee Name: {EmpNameLabel.Text}" & Environment.NewLine &
                                     $"Employee Position: {EmpPosLabel.Text}" & Environment.NewLine &
                                     $"Days Worked: {TextBoxWorkedDays.Text}" & Environment.NewLine &
                                     $"Daily Salary $: {DailyPay}" & Environment.NewLine &
                                     $"Total Amount $: {total}"
        End If
    End Sub

End Class
