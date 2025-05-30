Public Class Main
    Private Sub PictureBoxEmployee_Click(sender As Object, e As EventArgs) Handles PictureBoxEmployee.Click, EmployeeLabel.Click
        Me.Hide()
        Dim Emp = New Employee
        Emp.Show()
    End Sub

    Private Sub PictureBoxDetails_Click(sender As Object, e As EventArgs) Handles PictureBoxDetails.Click, DetailLabel.Click
        Me.Hide()
        Dim Det = New Details
        Det.Show()
    End Sub

    Private Sub PictureBoxSalary_Click(sender As Object, e As EventArgs) Handles PictureBoxSalary.Click, SalaryLabel.Click
        Me.Hide()
        Dim Sal = New Salary
        Sal.Show()
    End Sub

    Private Sub logoutLabel_Click(sender As Object, e As EventArgs) Handles logoutLabel.Click, PictureBoxlogout.Click
        Dim log = New Login
        log.Show()
        Me.Hide()
    End Sub


End Class



