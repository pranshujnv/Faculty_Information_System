<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class View_Teacher_User_Control
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
        Me.View_Contact_number = New System.Windows.Forms.TextBox()
        Me.View_Room_Number = New System.Windows.Forms.TextBox()
        Me.View_DOB = New System.Windows.Forms.TextBox()
        Me.View_Course = New System.Windows.Forms.TextBox()
        Me.View_Course_Code = New System.Windows.Forms.TextBox()
        Me.View_Research_Interests = New System.Windows.Forms.TextBox()
        Me.View_Name = New System.Windows.Forms.TextBox()
        Me.View_Department = New System.Windows.Forms.TextBox()
        Me.View_Research_Tags = New System.Windows.Forms.TextBox()
        Me.View_Email = New System.Windows.Forms.TextBox()
        Me.VIew_CV = New System.Windows.Forms.Button()
        Me.ImagePictureBox2 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Apply = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        CType(Me.ImagePictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'View_Contact_number
        '
        Me.View_Contact_number.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.View_Contact_number.Location = New System.Drawing.Point(262, 366)
        Me.View_Contact_number.Margin = New System.Windows.Forms.Padding(2)
        Me.View_Contact_number.Name = "View_Contact_number"
        Me.View_Contact_number.ReadOnly = True
        Me.View_Contact_number.Size = New System.Drawing.Size(210, 27)
        Me.View_Contact_number.TabIndex = 26
        '
        'View_Room_Number
        '
        Me.View_Room_Number.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.View_Room_Number.Location = New System.Drawing.Point(262, 337)
        Me.View_Room_Number.Margin = New System.Windows.Forms.Padding(2)
        Me.View_Room_Number.Name = "View_Room_Number"
        Me.View_Room_Number.ReadOnly = True
        Me.View_Room_Number.Size = New System.Drawing.Size(210, 27)
        Me.View_Room_Number.TabIndex = 25
        '
        'View_DOB
        '
        Me.View_DOB.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.View_DOB.Location = New System.Drawing.Point(262, 309)
        Me.View_DOB.Margin = New System.Windows.Forms.Padding(2)
        Me.View_DOB.Name = "View_DOB"
        Me.View_DOB.ReadOnly = True
        Me.View_DOB.Size = New System.Drawing.Size(210, 27)
        Me.View_DOB.TabIndex = 24
        '
        'View_Course
        '
        Me.View_Course.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.View_Course.Location = New System.Drawing.Point(262, 259)
        Me.View_Course.Margin = New System.Windows.Forms.Padding(2)
        Me.View_Course.Multiline = True
        Me.View_Course.Name = "View_Course"
        Me.View_Course.ReadOnly = True
        Me.View_Course.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.View_Course.Size = New System.Drawing.Size(210, 46)
        Me.View_Course.TabIndex = 23
        '
        'View_Course_Code
        '
        Me.View_Course_Code.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.View_Course_Code.Location = New System.Drawing.Point(262, 231)
        Me.View_Course_Code.Margin = New System.Windows.Forms.Padding(2)
        Me.View_Course_Code.Name = "View_Course_Code"
        Me.View_Course_Code.ReadOnly = True
        Me.View_Course_Code.Size = New System.Drawing.Size(210, 27)
        Me.View_Course_Code.TabIndex = 22
        '
        'View_Research_Interests
        '
        Me.View_Research_Interests.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.View_Research_Interests.Location = New System.Drawing.Point(262, 149)
        Me.View_Research_Interests.Margin = New System.Windows.Forms.Padding(2)
        Me.View_Research_Interests.Multiline = True
        Me.View_Research_Interests.Name = "View_Research_Interests"
        Me.View_Research_Interests.ReadOnly = True
        Me.View_Research_Interests.Size = New System.Drawing.Size(210, 73)
        Me.View_Research_Interests.TabIndex = 21
        '
        'View_Name
        '
        Me.View_Name.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.View_Name.Location = New System.Drawing.Point(262, 61)
        Me.View_Name.Margin = New System.Windows.Forms.Padding(2)
        Me.View_Name.Name = "View_Name"
        Me.View_Name.ReadOnly = True
        Me.View_Name.Size = New System.Drawing.Size(210, 27)
        Me.View_Name.TabIndex = 18
        '
        'View_Department
        '
        Me.View_Department.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.View_Department.Location = New System.Drawing.Point(262, 94)
        Me.View_Department.Margin = New System.Windows.Forms.Padding(2)
        Me.View_Department.Name = "View_Department"
        Me.View_Department.ReadOnly = True
        Me.View_Department.Size = New System.Drawing.Size(210, 27)
        Me.View_Department.TabIndex = 27
        '
        'View_Research_Tags
        '
        Me.View_Research_Tags.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.View_Research_Tags.Location = New System.Drawing.Point(262, 118)
        Me.View_Research_Tags.Margin = New System.Windows.Forms.Padding(2)
        Me.View_Research_Tags.Name = "View_Research_Tags"
        Me.View_Research_Tags.ReadOnly = True
        Me.View_Research_Tags.Size = New System.Drawing.Size(210, 27)
        Me.View_Research_Tags.TabIndex = 28
        '
        'View_Email
        '
        Me.View_Email.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.View_Email.Location = New System.Drawing.Point(262, 398)
        Me.View_Email.Margin = New System.Windows.Forms.Padding(2)
        Me.View_Email.Name = "View_Email"
        Me.View_Email.ReadOnly = True
        Me.View_Email.Size = New System.Drawing.Size(210, 27)
        Me.View_Email.TabIndex = 30
        '
        'VIew_CV
        '
        Me.VIew_CV.BackColor = System.Drawing.Color.OrangeRed
        Me.VIew_CV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.VIew_CV.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.VIew_CV.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VIew_CV.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.VIew_CV.Location = New System.Drawing.Point(65, 444)
        Me.VIew_CV.Margin = New System.Windows.Forms.Padding(2)
        Me.VIew_CV.Name = "VIew_CV"
        Me.VIew_CV.Size = New System.Drawing.Size(260, 32)
        Me.VIew_CV.TabIndex = 31
        Me.VIew_CV.Text = "Click To View Webpage/CV"
        Me.VIew_CV.UseVisualStyleBackColor = False
        '
        'ImagePictureBox2
        '
        Me.ImagePictureBox2.BackColor = System.Drawing.Color.DarkGray
        Me.ImagePictureBox2.Location = New System.Drawing.Point(517, 68)
        Me.ImagePictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.ImagePictureBox2.Name = "ImagePictureBox2"
        Me.ImagePictureBox2.Size = New System.Drawing.Size(121, 139)
        Me.ImagePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImagePictureBox2.TabIndex = 32
        Me.ImagePictureBox2.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Apply
        '
        Me.Apply.BackColor = System.Drawing.Color.OrangeRed
        Me.Apply.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Apply.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Apply.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Apply.Location = New System.Drawing.Point(430, 444)
        Me.Apply.Margin = New System.Windows.Forms.Padding(2)
        Me.Apply.Name = "Apply"
        Me.Apply.Size = New System.Drawing.Size(169, 32)
        Me.Apply.TabIndex = 34
        Me.Apply.Text = "Apply For Internship"
        Me.Apply.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label12.Location = New System.Drawing.Point(83, 399)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(134, 22)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "Email Address"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label13.Location = New System.Drawing.Point(61, 366)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(258, 22)
        Me.Label13.TabIndex = 43
        Me.Label13.Text = "Contact Number    +91 361"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label14.Location = New System.Drawing.Point(78, 336)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(142, 22)
        Me.Label14.TabIndex = 42
        Me.Label14.Text = "Room Number"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label15.Location = New System.Drawing.Point(149, 307)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 22)
        Me.Label15.TabIndex = 41
        Me.Label15.Text = "DOB"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label16.Location = New System.Drawing.Point(106, 261)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(111, 22)
        Me.Label16.TabIndex = 40
        Me.Label16.Text = "Experience"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label17.Location = New System.Drawing.Point(19, 229)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(213, 22)
        Me.Label17.TabIndex = 39
        Me.Label17.Text = "Current Courses Code"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label18.Location = New System.Drawing.Point(48, 149)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(176, 22)
        Me.Label18.TabIndex = 38
        Me.Label18.Text = "Research Interests"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label19.Location = New System.Drawing.Point(78, 118)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(142, 22)
        Me.Label19.TabIndex = 37
        Me.Label19.Text = "Research Tags"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label20.Location = New System.Drawing.Point(94, 94)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(123, 22)
        Me.Label20.TabIndex = 36
        Me.Label20.Text = "Department"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label21.Location = New System.Drawing.Point(138, 66)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(66, 22)
        Me.Label21.TabIndex = 35
        Me.Label21.Text = "Name"
        '
        'View_Teacher_User_Control
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Apply)
        Me.Controls.Add(Me.ImagePictureBox2)
        Me.Controls.Add(Me.VIew_CV)
        Me.Controls.Add(Me.View_Email)
        Me.Controls.Add(Me.View_Research_Tags)
        Me.Controls.Add(Me.View_Department)
        Me.Controls.Add(Me.View_Contact_number)
        Me.Controls.Add(Me.View_Room_Number)
        Me.Controls.Add(Me.View_DOB)
        Me.Controls.Add(Me.View_Course)
        Me.Controls.Add(Me.View_Course_Code)
        Me.Controls.Add(Me.View_Research_Interests)
        Me.Controls.Add(Me.View_Name)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "View_Teacher_User_Control"
        Me.Size = New System.Drawing.Size(757, 588)
        CType(Me.ImagePictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents View_Contact_number As System.Windows.Forms.TextBox
    Friend WithEvents View_Room_Number As System.Windows.Forms.TextBox
    Friend WithEvents View_DOB As System.Windows.Forms.TextBox
    Friend WithEvents View_Course As System.Windows.Forms.TextBox
    Friend WithEvents View_Course_Code As System.Windows.Forms.TextBox
    Friend WithEvents View_Research_Interests As System.Windows.Forms.TextBox
    Friend WithEvents View_Name As System.Windows.Forms.TextBox
    Friend WithEvents View_Department As System.Windows.Forms.TextBox
    Friend WithEvents View_Research_Tags As System.Windows.Forms.TextBox
    Friend WithEvents View_Email As System.Windows.Forms.TextBox
    Friend WithEvents VIew_CV As System.Windows.Forms.Button
    Friend WithEvents ImagePictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Apply As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label

End Class
