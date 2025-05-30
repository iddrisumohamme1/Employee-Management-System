Imports MySqlConnector

Public Class Employee
    Private connection As MySqlConnection

    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Define the connection string
        Dim connectionString As String = "server=localhost;user=root;password=0000;database=employeemangementsystembd"
        connection = New MySqlConnection(connectionString)
        LoadData()
    End Sub

    Private Sub LoadData()
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            Dim query As String = "SELECT * FROM employeetable"
            Dim cmd As New MySqlCommand(query, connection)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
            ' Ensure columns are generated automatically
            DataGridView1.AutoGenerateColumns = True
        Catch ex As MySqlException
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            Dim query As String = "INSERT INTO employeetable (EmpName, EmpAdd,EmpPos,EmpDob,EmpPhone,EmpEdu,EmpGend) VALUES (@EmpName, @EmpAdd,@EmpPos, @EmpDOB, @EmpPhone, @EmpEdu,@EmpGend)"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@EmpName", TextBoxName.Text)
            cmd.Parameters.AddWithValue("@EmpAdd", TextBoxAddress.Text)
            cmd.Parameters.AddWithValue("@EmpPos", ComboBoxPosition.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@EmpDob", PickerDOB.Value)
            cmd.Parameters.AddWithValue("@EmpPhone", TextBoxPhone.Text)
            cmd.Parameters.AddWithValue("@EmpEdu", ComboBoxEducation.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@EmpGend", ComboBoxGender.SelectedItem.ToString())
            cmd.ExecuteNonQuery()
            MessageBox.Show("Employee Added successfully")
            LoadData()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Dim Key = 0

    Private Sub Clear()
        TextBoxName.Clear()
        ComboBoxPosition.Text = ""
        ComboBoxGender.Text = ""
        TextBoxAddress.Text = ""
        Key = 0
        ComboBoxEducation.Text = ""
        TextBoxPhone.Text = ""
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If Key = 0 Then
            MessageBox.Show("Select The Employee To Delete")
        Else
            Try
                If connection.State = ConnectionState.Closed Then
                    connection.Open()
                End If
                Dim query = "DELETE FROM employeetable WHERE EmpId = @EmpId"
                Dim cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@EmpId", Key)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Employee Deleted successfully")
                LoadData()
            Catch ex As MySqlException
                MessageBox.Show("An error occurred: " & ex.Message)
            Finally
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        Dim cellValue As String = row.Cells(0).Value?.ToString()

        If Not String.IsNullOrEmpty(cellValue) AndAlso IsNumeric(cellValue) Then
            Key = Convert.ToUInt32(cellValue)
            TextBoxName.Text = row.Cells(1).Value.ToString()
            TextBoxAddress.Text = row.Cells(2).Value.ToString()
            ComboBoxPosition.Text = row.Cells(3).Value.ToString()
            PickerDOB.Value = Convert.ToDateTime(row.Cells(4).Value)
            TextBoxPhone.Text = row.Cells(5).Value.ToString()
            ComboBoxEducation.Text = row.Cells(6).Value.ToString()
            ComboBoxGender.Text = row.Cells(7).Value.ToString()
        Else
            MessageBox.Show("Invalid cell value. Please ensure the cell contains a valid number.")
        End If
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        If TextBoxName.Text = "" Or TextBoxPhone.Text = "" Or TextBoxAddress.Text = "" Then
            MessageBox.Show("Missing Information")
        Else
            Try
                If connection.State = ConnectionState.Closed Then
                    connection.Open()
                End If
                Dim query As String = "UPDATE employeetable SET EmpName =@EmpName, EmpAdd =@EmpAdd,EmpPos = @EmpPos,EmpDob =@EmpDob, EmpPhone =@EmpPhone, EmpEdu = @EmpEdu,EmpGend = @EmpGend WHERE EmpId = @EmpId"
                Dim cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@EmpId", Key)
                cmd.Parameters.AddWithValue("@EmpName", TextBoxName.Text)
                cmd.Parameters.AddWithValue("@EmpAdd", TextBoxAddress.Text)
                cmd.Parameters.AddWithValue("@EmpPos", ComboBoxPosition.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@EmpDob", PickerDOB.Value)
                cmd.Parameters.AddWithValue("@EmpPhone", TextBoxPhone.Text)
                cmd.Parameters.AddWithValue("@EmpEdu", ComboBoxEducation.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@EmpGend", ComboBoxGender.SelectedItem.ToString())
                cmd.ExecuteNonQuery()
                MessageBox.Show("Employee Updated")
                LoadData()
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            Finally
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        Me.Hide()
        Dim Main = New Main
        Main.Show()
    End Sub

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        ' Clear all input fields
        TextBoxName.Clear()
        TextBoxAddress.Clear()
        ComboBoxPosition.SelectedIndex = -1
        PickerDOB.Value = DateTime.Now
        TextBoxPhone.Clear()
        ComboBoxEducation.SelectedIndex = -1
        ComboBoxGender.SelectedIndex = -1

        ' Reset the Key variable
        Key = 0
    End Sub
End Class
