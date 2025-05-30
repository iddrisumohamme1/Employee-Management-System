<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Salary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Salary))
        Panel1 = New Panel()
        RichTextBoxSalary = New RichTextBox()
        ViewBtn = New Button()
        TextBoxWorkedDays = New TextBox()
        Label17 = New Label()
        Label15 = New Label()
        EmpNameLabel = New Label()
        RefreshBtn = New Button()
        EmpIdTextBox = New TextBox()
        Label9 = New Label()
        HomeBtn = New Button()
        EmpPosLabel = New Label()
        Label3 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveBorder
        Panel1.Controls.Add(RichTextBoxSalary)
        Panel1.Controls.Add(ViewBtn)
        Panel1.Controls.Add(TextBoxWorkedDays)
        Panel1.Controls.Add(Label17)
        Panel1.Controls.Add(Label15)
        Panel1.Controls.Add(EmpNameLabel)
        Panel1.Controls.Add(RefreshBtn)
        Panel1.Controls.Add(EmpIdTextBox)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(HomeBtn)
        Panel1.Controls.Add(EmpPosLabel)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(4, 69)
        Panel1.Margin = New Padding(7, 6, 7, 6)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(783, 375)
        Panel1.TabIndex = 2
        ' 
        ' RichTextBoxSalary
        ' 
        RichTextBoxSalary.BackColor = SystemColors.Menu
        RichTextBoxSalary.BorderStyle = BorderStyle.None
        RichTextBoxSalary.Location = New Point(292, 24)
        RichTextBoxSalary.Name = "RichTextBoxSalary"
        RichTextBoxSalary.Size = New Size(447, 317)
        RichTextBoxSalary.TabIndex = 33
        RichTextBoxSalary.Text = ""
        ' 
        ' ViewBtn
        ' 
        ViewBtn.Location = New Point(86, 304)
        ViewBtn.Margin = New Padding(7, 6, 7, 6)
        ViewBtn.Name = "ViewBtn"
        ViewBtn.Size = New Size(74, 37)
        ViewBtn.TabIndex = 32
        ViewBtn.Text = "View"
        ViewBtn.UseVisualStyleBackColor = True
        ' 
        ' TextBoxWorkedDays
        ' 
        TextBoxWorkedDays.BackColor = SystemColors.Menu
        TextBoxWorkedDays.BorderStyle = BorderStyle.None
        TextBoxWorkedDays.Location = New Point(7, 263)
        TextBoxWorkedDays.Margin = New Padding(7, 6, 7, 6)
        TextBoxWorkedDays.Name = "TextBoxWorkedDays"
        TextBoxWorkedDays.Size = New Size(119, 22)
        TextBoxWorkedDays.TabIndex = 31
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(15, 236)
        Label17.Margin = New Padding(7, 0, 7, 0)
        Label17.Name = "Label17"
        Label17.Size = New Size(111, 21)
        Label17.TabIndex = 30
        Label17.Text = "Worked Days"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(12, 156)
        Label15.Margin = New Padding(7, 0, 7, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(153, 21)
        Label15.TabIndex = 28
        Label15.Text = "Employee Position"
        ' 
        ' EmpNameLabel
        ' 
        EmpNameLabel.AutoSize = True
        EmpNameLabel.ForeColor = SystemColors.ActiveCaptionText
        EmpNameLabel.Location = New Point(12, 117)
        EmpNameLabel.Margin = New Padding(7, 0, 7, 0)
        EmpNameLabel.Name = "EmpNameLabel"
        EmpNameLabel.Size = New Size(0, 21)
        EmpNameLabel.TabIndex = 23
        ' 
        ' RefreshBtn
        ' 
        RefreshBtn.Location = New Point(152, 41)
        RefreshBtn.Margin = New Padding(7, 6, 7, 6)
        RefreshBtn.Name = "RefreshBtn"
        RefreshBtn.Size = New Size(103, 29)
        RefreshBtn.TabIndex = 22
        RefreshBtn.Text = "Fetch Data"
        RefreshBtn.UseVisualStyleBackColor = True
        ' 
        ' EmpIdTextBox
        ' 
        EmpIdTextBox.BackColor = SystemColors.Menu
        EmpIdTextBox.BorderStyle = BorderStyle.None
        EmpIdTextBox.Location = New Point(7, 41)
        EmpIdTextBox.Margin = New Padding(7, 6, 7, 6)
        EmpIdTextBox.Name = "EmpIdTextBox"
        EmpIdTextBox.Size = New Size(119, 22)
        EmpIdTextBox.TabIndex = 21
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(7, 14)
        Label9.Margin = New Padding(7, 0, 7, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(105, 21)
        Label9.TabIndex = 20
        Label9.Text = "Employee Id"
        ' 
        ' HomeBtn
        ' 
        HomeBtn.Location = New Point(7, 304)
        HomeBtn.Margin = New Padding(7, 6, 7, 6)
        HomeBtn.Name = "HomeBtn"
        HomeBtn.Size = New Size(65, 37)
        HomeBtn.TabIndex = 18
        HomeBtn.Text = "Home"
        HomeBtn.UseVisualStyleBackColor = True
        ' 
        ' EmpPosLabel
        ' 
        EmpPosLabel.AutoSize = True
        EmpPosLabel.ForeColor = SystemColors.ActiveCaptionText
        EmpPosLabel.Location = New Point(15, 189)
        EmpPosLabel.Margin = New Padding(7, 0, 7, 0)
        EmpPosLabel.Name = "EmpPosLabel"
        EmpPosLabel.Size = New Size(0, 21)
        EmpPosLabel.TabIndex = 10
        EmpPosLabel.Visible = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(7, 87)
        Label3.Margin = New Padding(7, 0, 7, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(136, 21)
        Label3.TabIndex = 4
        Label3.Text = "Employee Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(70, 42)
        Label1.Margin = New Padding(7, 0, 7, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 21)
        Label1.TabIndex = 6
        Label1.Text = " Salary"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(4, 3)
        PictureBox1.Margin = New Padding(7, 6, 7, 6)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(59, 60)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' Salary
        ' 
        AutoScaleDimensions = New SizeF(10F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(830, 468)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "Salary"
        Text = "Salary"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents EmpNameLabel As Label
    Friend WithEvents RefreshBtn As Button
    Friend WithEvents EmpIdTextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents HomeBtn As Button
    Friend WithEvents EmpPosLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBoxWorkedDays As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents RichTextBoxSalary As RichTextBox
    Friend WithEvents ViewBtn As Button
End Class
