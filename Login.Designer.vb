<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        PictureBox1 = New PictureBox()
        GroupBox1 = New GroupBox()
        CheckBoxPassword = New CheckBox()
        TextBoxPassword = New TextBox()
        Label3 = New Label()
        TextBoxUserId = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        LoginBtn = New Button()
        ResetBtn = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(241, 66)
        PictureBox1.Margin = New Padding(4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(54, 54)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(CheckBoxPassword)
        GroupBox1.Controls.Add(TextBoxPassword)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(TextBoxUserId)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(104, 118)
        GroupBox1.Margin = New Padding(4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4)
        GroupBox1.Size = New Size(334, 150)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        ' 
        ' CheckBoxPassword
        ' 
        CheckBoxPassword.AutoSize = True
        CheckBoxPassword.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CheckBoxPassword.Location = New Point(36, 119)
        CheckBoxPassword.Margin = New Padding(2)
        CheckBoxPassword.Name = "CheckBoxPassword"
        CheckBoxPassword.Size = New Size(147, 25)
        CheckBoxPassword.TabIndex = 4
        CheckBoxPassword.Text = "Show Password"
        CheckBoxPassword.UseVisualStyleBackColor = True
        ' 
        ' TextBoxPassword
        ' 
        TextBoxPassword.BackColor = SystemColors.Menu
        TextBoxPassword.BorderStyle = BorderStyle.None
        TextBoxPassword.Location = New Point(122, 77)
        TextBoxPassword.Margin = New Padding(2)
        TextBoxPassword.Name = "TextBoxPassword"
        TextBoxPassword.Size = New Size(182, 22)
        TextBoxPassword.TabIndex = 3
        TextBoxPassword.UseSystemPasswordChar = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(36, 77)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 21)
        Label3.TabIndex = 2
        Label3.Text = "Password"
        ' 
        ' TextBoxUserId
        ' 
        TextBoxUserId.BackColor = SystemColors.Menu
        TextBoxUserId.BorderStyle = BorderStyle.None
        TextBoxUserId.Location = New Point(122, 40)
        TextBoxUserId.Margin = New Padding(2)
        TextBoxUserId.Name = "TextBoxUserId"
        TextBoxUserId.Size = New Size(182, 22)
        TextBoxUserId.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(36, 40)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(65, 21)
        Label2.TabIndex = 0
        Label2.Text = "User ID"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(127, 17)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(370, 32)
        Label1.TabIndex = 2
        Label1.Text = "Employee Management System"
        ' 
        ' LoginBtn
        ' 
        LoginBtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LoginBtn.Location = New Point(159, 290)
        LoginBtn.Margin = New Padding(2)
        LoginBtn.Name = "LoginBtn"
        LoginBtn.Size = New Size(63, 28)
        LoginBtn.TabIndex = 3
        LoginBtn.Text = "Login"
        LoginBtn.UseVisualStyleBackColor = True
        ' 
        ' ResetBtn
        ' 
        ResetBtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ResetBtn.Location = New Point(297, 290)
        ResetBtn.Margin = New Padding(2)
        ResetBtn.Name = "ResetBtn"
        ResetBtn.Size = New Size(61, 28)
        ResetBtn.TabIndex = 4
        ResetBtn.Text = "Reset"
        ResetBtn.UseVisualStyleBackColor = True
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(10F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        ClientSize = New Size(611, 329)
        Controls.Add(ResetBtn)
        Controls.Add(LoginBtn)
        Controls.Add(Label1)
        Controls.Add(GroupBox1)
        Controls.Add(PictureBox1)
        Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        WindowState = FormWindowState.Minimized
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxUserId As TextBox
    Friend WithEvents CheckBoxPassword As CheckBox
    Friend WithEvents LoginBtn As Button
    Friend WithEvents ResetBtn As Button
End Class
