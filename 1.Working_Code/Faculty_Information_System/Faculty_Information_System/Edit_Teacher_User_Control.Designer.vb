<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Teacher_User_Control
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Edit_Name = New System.Windows.Forms.TextBox()
        Me.Edit_Department = New System.Windows.Forms.ComboBox()
        Me.Edit_Research_Tags = New System.Windows.Forms.ComboBox()
        Me.Edit_Research_Interests = New System.Windows.Forms.TextBox()
        Me.Edit_Course_Code = New System.Windows.Forms.TextBox()
        Me.Edit_Course = New System.Windows.Forms.TextBox()
        Me.Edit_DOB = New System.Windows.Forms.TextBox()
        Me.Edit_Room_Number = New System.Windows.Forms.TextBox()
        Me.Edit_Contact_number = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Btn_Edit_Submit = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Edit_Email = New System.Windows.Forms.TextBox()
        Me.Edit_CV = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ImagePictureBox = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Browse = New System.Windows.Forms.Button()
        CType(Me.ImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label1.Location = New System.Drawing.Point(184, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label2.Location = New System.Drawing.Point(125, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Department"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label4.Location = New System.Drawing.Point(64, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Research Interests"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label5.Location = New System.Drawing.Point(25, 282)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(213, 22)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Current Courses Code"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label6.Location = New System.Drawing.Point(95, 319)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(157, 22)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Add Experience"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label7.Location = New System.Drawing.Point(199, 373)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 22)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "DOB"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label8.Location = New System.Drawing.Point(104, 409)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(142, 22)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Room Number"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label9.Location = New System.Drawing.Point(83, 443)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(258, 22)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Contact Number    +91 361"
        '
        'Edit_Name
        '
        Me.Edit_Name.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Edit_Name.Location = New System.Drawing.Point(349, 75)
        Me.Edit_Name.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Edit_Name.Name = "Edit_Name"
        Me.Edit_Name.Size = New System.Drawing.Size(279, 27)
        Me.Edit_Name.TabIndex = 0
        '
        'Edit_Department
        '
        Me.Edit_Department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Edit_Department.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Edit_Department.FormattingEnabled = True
        Me.Edit_Department.Items.AddRange(New Object() {"Biotechnology", "Chemical", "Chemistry", "Civil", "CSE", "Design", "ECE and EEE", "HSS", "Mathematics", "Mechancial", "Physics"})
        Me.Edit_Department.Location = New System.Drawing.Point(349, 113)
        Me.Edit_Department.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Edit_Department.Name = "Edit_Department"
        Me.Edit_Department.Size = New System.Drawing.Size(279, 29)
        Me.Edit_Department.TabIndex = 1
        '
        'Edit_Research_Tags
        '
        Me.Edit_Research_Tags.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Edit_Research_Tags.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Edit_Research_Tags.FormattingEnabled = True
        Me.Edit_Research_Tags.Items.AddRange(New Object() {"Biodiversity", "Genetics", "Chemical Equilbrium", "Thermodynamics", "Cementious Materil", "Structural Mechanics", "Artificial Intelligence", "DS and Algorithms", "Networking", "Operating Systems", "Systems and Databases", "Architecture", "Ergonomics Research", "Communication Networks", "Speech and Image Processing", "Literature And Culture", "Economics", "Psychology", "Algebra and Geometry", "Cryptography and Finance", "Number Theory and Probabilty", "Machine Design", "Materials", "High Energy Physics", "Matter Physics", "Photonics", "Other(s)", ""})
        Me.Edit_Research_Tags.Location = New System.Drawing.Point(349, 148)
        Me.Edit_Research_Tags.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Edit_Research_Tags.Name = "Edit_Research_Tags"
        Me.Edit_Research_Tags.Size = New System.Drawing.Size(279, 29)
        Me.Edit_Research_Tags.TabIndex = 2
        '
        'Edit_Research_Interests
        '
        Me.Edit_Research_Interests.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Edit_Research_Interests.Location = New System.Drawing.Point(349, 183)
        Me.Edit_Research_Interests.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Edit_Research_Interests.Multiline = True
        Me.Edit_Research_Interests.Name = "Edit_Research_Interests"
        Me.Edit_Research_Interests.Size = New System.Drawing.Size(279, 90)
        Me.Edit_Research_Interests.TabIndex = 3
        '
        'Edit_Course_Code
        '
        Me.Edit_Course_Code.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Edit_Course_Code.Location = New System.Drawing.Point(349, 279)
        Me.Edit_Course_Code.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Edit_Course_Code.Name = "Edit_Course_Code"
        Me.Edit_Course_Code.Size = New System.Drawing.Size(279, 27)
        Me.Edit_Course_Code.TabIndex = 4
        '
        'Edit_Course
        '
        Me.Edit_Course.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Edit_Course.Location = New System.Drawing.Point(349, 316)
        Me.Edit_Course.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Edit_Course.Multiline = True
        Me.Edit_Course.Name = "Edit_Course"
        Me.Edit_Course.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Edit_Course.Size = New System.Drawing.Size(279, 47)
        Me.Edit_Course.TabIndex = 5
        '
        'Edit_DOB
        '
        Me.Edit_DOB.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Edit_DOB.Location = New System.Drawing.Point(349, 373)
        Me.Edit_DOB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Edit_DOB.Name = "Edit_DOB"
        Me.Edit_DOB.Size = New System.Drawing.Size(279, 27)
        Me.Edit_DOB.TabIndex = 6
        '
        'Edit_Room_Number
        '
        Me.Edit_Room_Number.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Edit_Room_Number.Location = New System.Drawing.Point(349, 409)
        Me.Edit_Room_Number.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Edit_Room_Number.Name = "Edit_Room_Number"
        Me.Edit_Room_Number.Size = New System.Drawing.Size(279, 27)
        Me.Edit_Room_Number.TabIndex = 7
        '
        'Edit_Contact_number
        '
        Me.Edit_Contact_number.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Edit_Contact_number.Location = New System.Drawing.Point(349, 443)
        Me.Edit_Contact_number.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Edit_Contact_number.Name = "Edit_Contact_number"
        Me.Edit_Contact_number.Size = New System.Drawing.Size(279, 27)
        Me.Edit_Contact_number.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label3.Location = New System.Drawing.Point(104, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Research Tags"
        '
        'Btn_Edit_Submit
        '
        Me.Btn_Edit_Submit.BackColor = System.Drawing.Color.OrangeRed
        Me.Btn_Edit_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Edit_Submit.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Btn_Edit_Submit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_Edit_Submit.Location = New System.Drawing.Point(368, 581)
        Me.Btn_Edit_Submit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Edit_Submit.Name = "Btn_Edit_Submit"
        Me.Btn_Edit_Submit.Size = New System.Drawing.Size(172, 44)
        Me.Btn_Edit_Submit.TabIndex = 11
        Me.Btn_Edit_Submit.Text = "Make Edits"
        Me.Btn_Edit_Submit.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label10.Location = New System.Drawing.Point(111, 473)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(134, 22)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Email Address"
        '
        'Edit_Email
        '
        Me.Edit_Email.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Edit_Email.Location = New System.Drawing.Point(349, 476)
        Me.Edit_Email.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Edit_Email.Name = "Edit_Email"
        Me.Edit_Email.Size = New System.Drawing.Size(279, 27)
        Me.Edit_Email.TabIndex = 9
        '
        'Edit_CV
        '
        Me.Edit_CV.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Edit_CV.Location = New System.Drawing.Point(349, 510)
        Me.Edit_CV.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Edit_CV.Multiline = True
        Me.Edit_CV.Name = "Edit_CV"
        Me.Edit_CV.Size = New System.Drawing.Size(279, 53)
        Me.Edit_CV.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label11.Location = New System.Drawing.Point(20, 510)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(220, 22)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Add Webpage/CV link"
        '
        'ImagePictureBox
        '
        Me.ImagePictureBox.BackColor = System.Drawing.Color.DarkGray
        Me.ImagePictureBox.Location = New System.Drawing.Point(689, 84)
        Me.ImagePictureBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ImagePictureBox.Name = "ImagePictureBox"
        Me.ImagePictureBox.Size = New System.Drawing.Size(121, 139)
        Me.ImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.ImagePictureBox.TabIndex = 23
        Me.ImagePictureBox.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Browse
        '
        Me.Browse.BackColor = System.Drawing.Color.OrangeRed
        Me.Browse.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Browse.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Browse.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Browse.Location = New System.Drawing.Point(689, 279)
        Me.Browse.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Browse.Name = "Browse"
        Me.Browse.Size = New System.Drawing.Size(161, 38)
        Me.Browse.TabIndex = 24
        Me.Browse.Text = "Upload Image"
        Me.Browse.UseVisualStyleBackColor = False
        '
        'Edit_Teacher_User_Control
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Browse)
        Me.Controls.Add(Me.ImagePictureBox)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Edit_CV)
        Me.Controls.Add(Me.Edit_Email)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Btn_Edit_Submit)
        Me.Controls.Add(Me.Edit_Contact_number)
        Me.Controls.Add(Me.Edit_Room_Number)
        Me.Controls.Add(Me.Edit_DOB)
        Me.Controls.Add(Me.Edit_Course)
        Me.Controls.Add(Me.Edit_Course_Code)
        Me.Controls.Add(Me.Edit_Research_Interests)
        Me.Controls.Add(Me.Edit_Research_Tags)
        Me.Controls.Add(Me.Edit_Department)
        Me.Controls.Add(Me.Edit_Name)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Edit_Teacher_User_Control"
        Me.Size = New System.Drawing.Size(1009, 724)
        CType(Me.ImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Edit_Name As System.Windows.Forms.TextBox
    Friend WithEvents Edit_Department As System.Windows.Forms.ComboBox
    Friend WithEvents Edit_Research_Tags As System.Windows.Forms.ComboBox
    Friend WithEvents Edit_Research_Interests As System.Windows.Forms.TextBox
    Friend WithEvents Edit_Course_Code As System.Windows.Forms.TextBox
    Friend WithEvents Edit_Course As System.Windows.Forms.TextBox
    Friend WithEvents Edit_DOB As System.Windows.Forms.TextBox
    Friend WithEvents Edit_Room_Number As System.Windows.Forms.TextBox
    Friend WithEvents Edit_Contact_number As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Btn_Edit_Submit As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Edit_Email As System.Windows.Forms.TextBox
    Friend WithEvents Edit_CV As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ImagePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Browse As System.Windows.Forms.Button

End Class
