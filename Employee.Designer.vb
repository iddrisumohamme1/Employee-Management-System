<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        ResetBtn = New Button()
        DataGridView1 = New DataGridView()
        EditBtn = New Button()
        DeleteBtn = New Button()
        HomeBtn = New Button()
        AddBtn = New Button()
        PickerDOB = New DateTimePicker()
        Label8 = New Label()
        Label7 = New Label()
        ComboBoxEducation = New ComboBox()
        ComboBoxPosition = New ComboBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        ComboBoxGender = New ComboBox()
        TextBoxPhone = New TextBox()
        TextBoxAddress = New TextBox()
        TextBoxName = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveBorder
        Panel1.Controls.Add(ResetBtn)
        Panel1.Controls.Add(DataGridView1)
        Panel1.Controls.Add(EditBtn)
        Panel1.Controls.Add(DeleteBtn)
        Panel1.Controls.Add(HomeBtn)
        Panel1.Controls.Add(AddBtn)
        Panel1.Controls.Add(PickerDOB)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(ComboBoxEducation)
        Panel1.Controls.Add(ComboBoxPosition)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(ComboBoxGender)
        Panel1.Controls.Add(TextBoxPhone)
        Panel1.Controls.Add(TextBoxAddress)
        Panel1.Controls.Add(TextBoxName)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(1, 63)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1239, 389)
        Panel1.TabIndex = 0
        ' 
        ' ResetBtn
        ' 
        ResetBtn.AllowDrop = True
        ResetBtn.AutoEllipsis = True
        ResetBtn.Location = New Point(242, 312)
        ResetBtn.Name = "ResetBtn"
        ResetBtn.Size = New Size(75, 42)
        ResetBtn.TabIndex = 23
        ResetBtn.Text = "Reset"
        ResetBtn.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowDrop = True
        DataGridView1.BackgroundColor = SystemColors.Menu
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.GridColor = SystemColors.InactiveBorder
        DataGridView1.Location = New Point(418, 9)
        DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlDarkDark
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlLightLight
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.Size = New Size(818, 362)
        DataGridView1.TabIndex = 22
        ' 
        ' EditBtn
        ' 
        EditBtn.Location = New Point(75, 312)
        EditBtn.Name = "EditBtn"
        EditBtn.Size = New Size(50, 42)
        EditBtn.TabIndex = 21
        EditBtn.Text = "Edit"
        EditBtn.UseVisualStyleBackColor = True
        ' 
        ' DeleteBtn
        ' 
        DeleteBtn.AllowDrop = True
        DeleteBtn.AutoEllipsis = True
        DeleteBtn.Location = New Point(137, 312)
        DeleteBtn.Name = "DeleteBtn"
        DeleteBtn.Size = New Size(79, 42)
        DeleteBtn.TabIndex = 20
        DeleteBtn.Text = "Delete"
        DeleteBtn.UseVisualStyleBackColor = True
        ' 
        ' HomeBtn
        ' 
        HomeBtn.Location = New Point(337, 312)
        HomeBtn.Name = "HomeBtn"
        HomeBtn.Size = New Size(75, 42)
        HomeBtn.TabIndex = 19
        HomeBtn.Text = "Home"
        HomeBtn.UseVisualStyleBackColor = True
        ' 
        ' AddBtn
        ' 
        AddBtn.Location = New Point(11, 312)
        AddBtn.Name = "AddBtn"
        AddBtn.Size = New Size(49, 42)
        AddBtn.TabIndex = 18
        AddBtn.Text = "Add"
        AddBtn.UseVisualStyleBackColor = True
        ' 
        ' PickerDOB
        ' 
        PickerDOB.CalendarMonthBackground = SystemColors.Menu
        PickerDOB.CustomFormat = "2001-01-01"
        PickerDOB.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PickerDOB.ImeMode = ImeMode.NoControl
        PickerDOB.Location = New Point(105, 259)
        PickerDOB.Name = "PickerDOB"
        PickerDOB.Size = New Size(221, 25)
        PickerDOB.TabIndex = 17
        PickerDOB.Value = New Date(2025, 1, 1, 0, 0, 0, 0)
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(137, 235)
        Label8.Name = "Label8"
        Label8.Size = New Size(124, 21)
        Label8.TabIndex = 16
        Label8.Text = "Employee DOB"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(242, 167)
        Label7.Name = "Label7"
        Label7.Size = New Size(167, 21)
        Label7.TabIndex = 15
        Label7.Text = "Employee Education"
        ' 
        ' ComboBoxEducation
        ' 
        ComboBoxEducation.BackColor = SystemColors.Menu
        ComboBoxEducation.FlatStyle = FlatStyle.Flat
        ComboBoxEducation.FormattingEnabled = True
        ComboBoxEducation.Items.AddRange(New Object() {"Diploma", "UG", "Master"})
        ComboBoxEducation.Location = New Point(242, 191)
        ComboBoxEducation.Name = "ComboBoxEducation"
        ComboBoxEducation.Size = New Size(170, 29)
        ComboBoxEducation.TabIndex = 14
        ' 
        ' ComboBoxPosition
        ' 
        ComboBoxPosition.BackColor = SystemColors.Menu
        ComboBoxPosition.FlatStyle = FlatStyle.Flat
        ComboBoxPosition.FormattingEnabled = True
        ComboBoxPosition.Items.AddRange(New Object() {"Manager", "Security", "Cleaner", "Accountant", "IT"})
        ComboBoxPosition.Location = New Point(242, 106)
        ComboBoxPosition.Name = "ComboBoxPosition"
        ComboBoxPosition.Size = New Size(170, 29)
        ComboBoxPosition.TabIndex = 13
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(11, 167)
        Label6.Name = "Label6"
        Label6.Size = New Size(139, 21)
        Label6.TabIndex = 12
        Label6.Text = "Employee Phone"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(11, 82)
        Label5.Name = "Label5"
        Label5.Size = New Size(145, 21)
        Label5.TabIndex = 11
        Label5.Text = "Employee Gender"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(242, 82)
        Label4.Name = "Label4"
        Label4.Size = New Size(153, 21)
        Label4.TabIndex = 10
        Label4.Text = "Employee Position"
        ' 
        ' ComboBoxGender
        ' 
        ComboBoxGender.BackColor = SystemColors.Menu
        ComboBoxGender.FlatStyle = FlatStyle.Flat
        ComboBoxGender.FormattingEnabled = True
        ComboBoxGender.Items.AddRange(New Object() {"Male", "Female"})
        ComboBoxGender.Location = New Point(11, 106)
        ComboBoxGender.Name = "ComboBoxGender"
        ComboBoxGender.Size = New Size(163, 29)
        ComboBoxGender.TabIndex = 9
        ' 
        ' TextBoxPhone
        ' 
        TextBoxPhone.BackColor = SystemColors.Menu
        TextBoxPhone.BorderStyle = BorderStyle.None
        TextBoxPhone.Location = New Point(11, 194)
        TextBoxPhone.Name = "TextBoxPhone"
        TextBoxPhone.Size = New Size(163, 22)
        TextBoxPhone.TabIndex = 8
        ' 
        ' TextBoxAddress
        ' 
        TextBoxAddress.BackColor = SystemColors.Menu
        TextBoxAddress.BorderStyle = BorderStyle.None
        TextBoxAddress.Location = New Point(242, 42)
        TextBoxAddress.Name = "TextBoxAddress"
        TextBoxAddress.Size = New Size(170, 22)
        TextBoxAddress.TabIndex = 7
        ' 
        ' TextBoxName
        ' 
        TextBoxName.BackColor = SystemColors.Menu
        TextBoxName.BorderStyle = BorderStyle.None
        TextBoxName.Location = New Point(11, 42)
        TextBoxName.Name = "TextBoxName"
        TextBoxName.Size = New Size(163, 22)
        TextBoxName.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(11, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(136, 21)
        Label3.TabIndex = 4
        Label3.Text = "Employee Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(242, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(150, 21)
        Label2.TabIndex = 3
        Label2.Text = "Employee Address"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.man
        PictureBox1.Location = New Point(1, 7)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(46, 50)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(53, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(152, 21)
        Label1.TabIndex = 2
        Label1.Text = "Manage Employee"
        ' 
        ' Employee
        ' 
        AutoScaleDimensions = New SizeF(10F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1252, 473)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Employee"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Employee"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxPhone As TextBox
    Friend WithEvents TextBoxAddress As TextBox
    Friend WithEvents ComboBoxGender As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBoxEducation As ComboBox
    Friend WithEvents ComboBoxPosition As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PickerDOB As DateTimePicker
    Friend WithEvents EditBtn As Button
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents HomeBtn As Button
    Friend WithEvents AddBtn As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ResetBtn As Button
End Class
