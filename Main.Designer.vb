<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Panel1 = New Panel()
        Label6 = New Label()
        DetailLabel = New Label()
        SalaryLabel = New Label()
        EmployeeLabel = New Label()
        PictureBoxDetails = New PictureBox()
        PictureBoxEmployee = New PictureBox()
        PictureBoxSalary = New PictureBox()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        PictureBoxlogout = New PictureBox()
        logoutLabel = New Label()
        Panel1.SuspendLayout()
        CType(PictureBoxDetails, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxEmployee, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxSalary, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxlogout, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveBorder
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(DetailLabel)
        Panel1.Controls.Add(SalaryLabel)
        Panel1.Controls.Add(EmployeeLabel)
        Panel1.Controls.Add(PictureBoxDetails)
        Panel1.Controls.Add(PictureBoxEmployee)
        Panel1.Controls.Add(PictureBoxSalary)
        Panel1.Location = New Point(3, 58)
        Panel1.Margin = New Padding(4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(665, 228)
        Panel1.TabIndex = 0
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(182, 18)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(192, 21)
        Label6.TabIndex = 5
        Label6.Text = "Employee Management"
        ' 
        ' DetailLabel
        ' 
        DetailLabel.AutoSize = True
        DetailLabel.Location = New Point(249, 158)
        DetailLabel.Margin = New Padding(4, 0, 4, 0)
        DetailLabel.Name = "DetailLabel"
        DetailLabel.Size = New Size(63, 21)
        DetailLabel.TabIndex = 5
        DetailLabel.Text = "Details"
        ' 
        ' SalaryLabel
        ' 
        SalaryLabel.AutoSize = True
        SalaryLabel.Location = New Point(500, 158)
        SalaryLabel.Margin = New Padding(4, 0, 4, 0)
        SalaryLabel.Name = "SalaryLabel"
        SalaryLabel.Size = New Size(58, 21)
        SalaryLabel.TabIndex = 6
        SalaryLabel.Text = "Salary"
        ' 
        ' EmployeeLabel
        ' 
        EmployeeLabel.AutoSize = True
        EmployeeLabel.Location = New Point(19, 158)
        EmployeeLabel.Margin = New Padding(4, 0, 4, 0)
        EmployeeLabel.Name = "EmployeeLabel"
        EmployeeLabel.Size = New Size(86, 21)
        EmployeeLabel.TabIndex = 7
        EmployeeLabel.Text = "Employee"
        ' 
        ' PictureBoxDetails
        ' 
        PictureBoxDetails.Image = CType(resources.GetObject("PictureBoxDetails.Image"), Image)
        PictureBoxDetails.Location = New Point(236, 74)
        PictureBoxDetails.Name = "PictureBoxDetails"
        PictureBoxDetails.Size = New Size(91, 73)
        PictureBoxDetails.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBoxDetails.TabIndex = 2
        PictureBoxDetails.TabStop = False
        ' 
        ' PictureBoxEmployee
        ' 
        PictureBoxEmployee.Image = CType(resources.GetObject("PictureBoxEmployee.Image"), Image)
        PictureBoxEmployee.Location = New Point(19, 74)
        PictureBoxEmployee.Name = "PictureBoxEmployee"
        PictureBoxEmployee.Size = New Size(86, 73)
        PictureBoxEmployee.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBoxEmployee.TabIndex = 1
        PictureBoxEmployee.TabStop = False
        ' 
        ' PictureBoxSalary
        ' 
        PictureBoxSalary.Image = My.Resources.Resources.paycheck
        PictureBoxSalary.Location = New Point(482, 74)
        PictureBoxSalary.Name = "PictureBoxSalary"
        PictureBoxSalary.Size = New Size(90, 73)
        PictureBoxSalary.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBoxSalary.TabIndex = 0
        PictureBoxSalary.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.home
        PictureBox1.Location = New Point(3, 1)
        PictureBox1.Margin = New Padding(4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(84, 53)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(95, 33)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 21)
        Label1.TabIndex = 2
        Label1.Text = "Home"
        ' 
        ' PictureBoxlogout
        ' 
        PictureBoxlogout.Image = My.Resources.Resources.logout
        PictureBoxlogout.Location = New Point(558, 30)
        PictureBoxlogout.Name = "PictureBoxlogout"
        PictureBoxlogout.Size = New Size(42, 24)
        PictureBoxlogout.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBoxlogout.TabIndex = 3
        PictureBoxlogout.TabStop = False
        ' 
        ' logoutLabel
        ' 
        logoutLabel.AutoSize = True
        logoutLabel.Location = New Point(607, 33)
        logoutLabel.Margin = New Padding(4, 0, 4, 0)
        logoutLabel.Name = "logoutLabel"
        logoutLabel.Size = New Size(61, 21)
        logoutLabel.TabIndex = 4
        logoutLabel.Text = "logout"
        ' 
        ' Main
        ' 
        AutoScaleDimensions = New SizeF(10F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(681, 345)
        Controls.Add(logoutLabel)
        Controls.Add(PictureBoxlogout)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Main"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Main"
        WindowState = FormWindowState.Minimized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBoxDetails, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxEmployee, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxSalary, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxlogout, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBoxlogout As PictureBox
    Friend WithEvents logoutLabel As Label
    Friend WithEvents PictureBoxSalary As PictureBox
    Friend WithEvents PictureBoxDetails As PictureBox
    Friend WithEvents PictureBoxEmployee As PictureBox
    Friend WithEvents SalaryLabel As Label
    Friend WithEvents EmployeeLabel As Label
    Friend WithEvents DetailLabel As Label
    Friend WithEvents Label6 As Label
End Class
