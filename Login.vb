Imports MySqlConnector


Public Class Login
    Private connection As MySqlConnection
    Private Const DefaultUserId As String = "Admin"
    Private Const DefaultPassword As String = "1234"
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Define the connection string
        Dim connectionString As String = "server=localhost;user=root;password=0000;database=employeemangementsystembd"
        connection = New MySqlConnection(connectionString)
    End Sub


    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Try
            ' Check for default credentials
            If TextBoxUserId.Text = DefaultUserId AndAlso TextBoxPassword.Text = DefaultPassword Then
                MessageBox.Show("Login Successful, Welcome ")
                Main.Show()
                Me.Hide()
                Return
            End If

            ' Open the connection
            connection.Open()

            ' Create a new MySqlCommand with the correct SQL syntax
            Dim cn As New MySqlCommand("SELECT `user_id`, `password` FROM `users` WHERE `user_id` = @User_id AND `password` = @Password", connection)

            ' Add parameters to the command
            cn.Parameters.Add("@User_id", MySqlDbType.VarChar).Value = TextBoxUserId.Text
            cn.Parameters.Add("@Password", MySqlDbType.VarChar).Value = TextBoxPassword.Text

            ' Execute the command and fill the DataTable
            Dim datareader As New MySqlDataAdapter(cn)
            Dim table As New DataTable()
            datareader.Fill(table)

            ' Check if any rows are returned 
            If Not verify() Then
                ' Verification failed
            ElseIf table.Rows.Count = 0 Then
                MessageBox.Show("Invalid Username or Password")
            Else
                MessageBox.Show("Login Successful, Welcome")
                Main.Show()
                Me.Hide()
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            ' Ensure the connection is closed
            If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        TextBoxUserId.Text = ""
        TextBoxPassword.Text = ""
    End Sub

    Private Sub CheckBoxPassword_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxPassword.CheckedChanged
        TextBoxPassword.UseSystemPasswordChar = Not CheckBoxPassword.Checked
    End Sub





    Private Function verify() As Boolean
        If String.IsNullOrEmpty(TextBoxUserId.Text) Then
            MessageBox.Show("Please enter your username")
            Return False
        ElseIf String.IsNullOrEmpty(TextBoxPassword.Text) Then
            MessageBox.Show("Please enter your password")
            Return False
        End If
        Return True
    End Function
End Class
