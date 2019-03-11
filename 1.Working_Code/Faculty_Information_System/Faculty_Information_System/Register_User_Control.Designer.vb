<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register_User_Control
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
        Me.Btn_Create = New System.Windows.Forms.Button()
        Me.Register_Department = New System.Windows.Forms.ComboBox()
        Me.Register_Contact = New System.Windows.Forms.TextBox()
        Me.Register_Room = New System.Windows.Forms.TextBox()
        Me.Register_Password = New System.Windows.Forms.TextBox()
        Me.Register_username = New System.Windows.Forms.TextBox()
        Me.Register_Name = New System.Windows.Forms.TextBox()
        Me.Lbl_Register_Contact = New System.Windows.Forms.Label()
        Me.Lbl_Register_Room = New System.Windows.Forms.Label()
        Me.Lbl_Register_Department = New System.Windows.Forms.Label()
        Me.Lbl_Register_Password = New System.Windows.Forms.Label()
        Me.Lbl_Register_username = New System.Windows.Forms.Label()
        Me.Lbl_Register_Name = New System.Windows.Forms.Label()
        Me.Register_Email = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Register_Question = New System.Windows.Forms.ComboBox()
        Me.Register_Answer = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Register_ECaptcha = New System.Windows.Forms.RichTextBox()
        Me.Register_Enter = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Register_rePassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btn_Create
        '
        Me.Btn_Create.BackColor = System.Drawing.Color.OrangeRed
        Me.Btn_Create.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Create.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Create.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_Create.Location = New System.Drawing.Point(355, 372)
        Me.Btn_Create.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Create.Name = "Btn_Create"
        Me.Btn_Create.Size = New System.Drawing.Size(142, 48)
        Me.Btn_Create.TabIndex = 11
        Me.Btn_Create.Text = "Create Account"
        Me.Btn_Create.UseVisualStyleBackColor = False
        '
        'Register_Department
        '
        Me.Register_Department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Register_Department.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Register_Department.FormattingEnabled = True
        Me.Register_Department.Items.AddRange(New Object() {"Biotechnology", "Chemical", "Chemistry", "Civil", "CSE", "Design", "ECE and EEE", "HSS", "Mathematics", "Mechancial", "Physics"})
        Me.Register_Department.Location = New System.Drawing.Point(344, 162)
        Me.Register_Department.Margin = New System.Windows.Forms.Padding(2)
        Me.Register_Department.Name = "Register_Department"
        Me.Register_Department.Size = New System.Drawing.Size(267, 25)
        Me.Register_Department.TabIndex = 4
        '
        'Register_Contact
        '
        Me.Register_Contact.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Register_Contact.Location = New System.Drawing.Point(344, 224)
        Me.Register_Contact.Margin = New System.Windows.Forms.Padding(2)
        Me.Register_Contact.Name = "Register_Contact"
        Me.Register_Contact.Size = New System.Drawing.Size(267, 26)
        Me.Register_Contact.TabIndex = 6
        '
        'Register_Room
        '
        Me.Register_Room.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Register_Room.Location = New System.Drawing.Point(344, 193)
        Me.Register_Room.Margin = New System.Windows.Forms.Padding(2)
        Me.Register_Room.Name = "Register_Room"
        Me.Register_Room.Size = New System.Drawing.Size(267, 26)
        Me.Register_Room.TabIndex = 5
        '
        'Register_Password
        '
        Me.Register_Password.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Register_Password.Location = New System.Drawing.Point(344, 100)
        Me.Register_Password.Margin = New System.Windows.Forms.Padding(2)
        Me.Register_Password.Name = "Register_Password"
        Me.Register_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Register_Password.Size = New System.Drawing.Size(267, 26)
        Me.Register_Password.TabIndex = 2
        '
        'Register_username
        '
        Me.Register_username.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Register_username.Location = New System.Drawing.Point(344, 70)
        Me.Register_username.Margin = New System.Windows.Forms.Padding(2)
        Me.Register_username.Name = "Register_username"
        Me.Register_username.Size = New System.Drawing.Size(267, 26)
        Me.Register_username.TabIndex = 1
        '
        'Register_Name
        '
        Me.Register_Name.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Register_Name.Location = New System.Drawing.Point(344, 39)
        Me.Register_Name.Margin = New System.Windows.Forms.Padding(2)
        Me.Register_Name.Name = "Register_Name"
        Me.Register_Name.Size = New System.Drawing.Size(267, 26)
        Me.Register_Name.TabIndex = 0
        '
        'Lbl_Register_Contact
        '
        Me.Lbl_Register_Contact.AutoSize = True
        Me.Lbl_Register_Contact.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Register_Contact.Location = New System.Drawing.Point(129, 224)
        Me.Lbl_Register_Contact.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_Register_Contact.Name = "Lbl_Register_Contact"
        Me.Lbl_Register_Contact.Size = New System.Drawing.Size(215, 21)
        Me.Lbl_Register_Contact.TabIndex = 47
        Me.Lbl_Register_Contact.Text = "Contact Number   +91 361"
        '
        'Lbl_Register_Room
        '
        Me.Lbl_Register_Room.AutoSize = True
        Me.Lbl_Register_Room.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Register_Room.Location = New System.Drawing.Point(151, 193)
        Me.Lbl_Register_Room.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_Register_Room.Name = "Lbl_Register_Room"
        Me.Lbl_Register_Room.Size = New System.Drawing.Size(122, 21)
        Me.Lbl_Register_Room.TabIndex = 46
        Me.Lbl_Register_Room.Text = "Room Number"
        '
        'Lbl_Register_Department
        '
        Me.Lbl_Register_Department.AutoSize = True
        Me.Lbl_Register_Department.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Register_Department.Location = New System.Drawing.Point(165, 162)
        Me.Lbl_Register_Department.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_Register_Department.Name = "Lbl_Register_Department"
        Me.Lbl_Register_Department.Size = New System.Drawing.Size(108, 21)
        Me.Lbl_Register_Department.TabIndex = 45
        Me.Lbl_Register_Department.Text = "Department"
        '
        'Lbl_Register_Password
        '
        Me.Lbl_Register_Password.AutoSize = True
        Me.Lbl_Register_Password.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Register_Password.Location = New System.Drawing.Point(191, 100)
        Me.Lbl_Register_Password.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_Register_Password.Name = "Lbl_Register_Password"
        Me.Lbl_Register_Password.Size = New System.Drawing.Size(82, 21)
        Me.Lbl_Register_Password.TabIndex = 44
        Me.Lbl_Register_Password.Text = "Password"
        '
        'Lbl_Register_username
        '
        Me.Lbl_Register_username.AutoSize = True
        Me.Lbl_Register_username.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Register_username.Location = New System.Drawing.Point(126, 70)
        Me.Lbl_Register_username.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_Register_username.Name = "Lbl_Register_username"
        Me.Lbl_Register_username.Size = New System.Drawing.Size(148, 21)
        Me.Lbl_Register_username.TabIndex = 43
        Me.Lbl_Register_username.Text = "Create Username"
        '
        'Lbl_Register_Name
        '
        Me.Lbl_Register_Name.AutoSize = True
        Me.Lbl_Register_Name.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Register_Name.Location = New System.Drawing.Point(215, 39)
        Me.Lbl_Register_Name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_Register_Name.Name = "Lbl_Register_Name"
        Me.Lbl_Register_Name.Size = New System.Drawing.Size(58, 21)
        Me.Lbl_Register_Name.TabIndex = 42
        Me.Lbl_Register_Name.Text = "Name"
        '
        'Register_Email
        '
        Me.Register_Email.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Register_Email.Location = New System.Drawing.Point(344, 259)
        Me.Register_Email.Margin = New System.Windows.Forms.Padding(2)
        Me.Register_Email.Name = "Register_Email"
        Me.Register_Email.Size = New System.Drawing.Size(267, 26)
        Me.Register_Email.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(157, 259)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 21)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "Email Address"
        '
        'Register_Question
        '
        Me.Register_Question.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Register_Question.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Register_Question.FormattingEnabled = True
        Me.Register_Question.Items.AddRange(New Object() {"What was your favorite place to visit as a child?", "In what city were you born?", "What is the name of your first grade teacher?", "What is the name of your pet?"})
        Me.Register_Question.Location = New System.Drawing.Point(344, 288)
        Me.Register_Question.Margin = New System.Windows.Forms.Padding(2)
        Me.Register_Question.Name = "Register_Question"
        Me.Register_Question.Size = New System.Drawing.Size(267, 24)
        Me.Register_Question.TabIndex = 8
        '
        'Register_Answer
        '
        Me.Register_Answer.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Register_Answer.Location = New System.Drawing.Point(344, 320)
        Me.Register_Answer.Margin = New System.Windows.Forms.Padding(2)
        Me.Register_Answer.Name = "Register_Answer"
        Me.Register_Answer.Size = New System.Drawing.Size(267, 26)
        Me.Register_Answer.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(128, 290)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 21)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Security Question"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(205, 320)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 21)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Answer"
        '
        'Register_ECaptcha
        '
        Me.Register_ECaptcha.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Register_ECaptcha.BackColor = System.Drawing.Color.PowderBlue
        Me.Register_ECaptcha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Register_ECaptcha.Font = New System.Drawing.Font("SketchFlow Print", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Register_ECaptcha.Location = New System.Drawing.Point(165, 346)
        Me.Register_ECaptcha.Name = "Register_ECaptcha"
        Me.Register_ECaptcha.ReadOnly = True
        Me.Register_ECaptcha.Size = New System.Drawing.Size(131, 37)
        Me.Register_ECaptcha.TabIndex = 65
        Me.Register_ECaptcha.Text = ""
        '
        'Register_Enter
        '
        Me.Register_Enter.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Register_Enter.Location = New System.Drawing.Point(165, 422)
        Me.Register_Enter.Margin = New System.Windows.Forms.Padding(2)
        Me.Register_Enter.Name = "Register_Enter"
        Me.Register_Enter.Size = New System.Drawing.Size(131, 26)
        Me.Register_Enter.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Script", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(173, 401)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 19)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Enter the Captcha"
        '
        'Register_rePassword
        '
        Me.Register_rePassword.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Register_rePassword.Location = New System.Drawing.Point(344, 130)
        Me.Register_rePassword.Margin = New System.Windows.Forms.Padding(2)
        Me.Register_rePassword.Name = "Register_rePassword"
        Me.Register_rePassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Register_rePassword.Size = New System.Drawing.Size(267, 26)
        Me.Register_rePassword.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(120, 130)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 21)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Re-enter Password"
        '
        'Register_User_Control
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Register_rePassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Register_Enter)
        Me.Controls.Add(Me.Register_ECaptcha)
        Me.Controls.Add(Me.Register_Question)
        Me.Controls.Add(Me.Register_Answer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Register_Email)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Btn_Create)
        Me.Controls.Add(Me.Register_Department)
        Me.Controls.Add(Me.Register_Contact)
        Me.Controls.Add(Me.Register_Room)
        Me.Controls.Add(Me.Register_Password)
        Me.Controls.Add(Me.Register_username)
        Me.Controls.Add(Me.Register_Name)
        Me.Controls.Add(Me.Lbl_Register_Contact)
        Me.Controls.Add(Me.Lbl_Register_Room)
        Me.Controls.Add(Me.Lbl_Register_Department)
        Me.Controls.Add(Me.Lbl_Register_Password)
        Me.Controls.Add(Me.Lbl_Register_username)
        Me.Controls.Add(Me.Lbl_Register_Name)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Register_User_Control"
        Me.Size = New System.Drawing.Size(757, 588)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_Create As System.Windows.Forms.Button
    Friend WithEvents Register_Department As System.Windows.Forms.ComboBox
    Friend WithEvents Register_Contact As System.Windows.Forms.TextBox
    Friend WithEvents Register_Room As System.Windows.Forms.TextBox
    Friend WithEvents Register_Password As System.Windows.Forms.TextBox
    Friend WithEvents Register_username As System.Windows.Forms.TextBox
    Friend WithEvents Register_Name As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Register_Contact As System.Windows.Forms.Label
    Friend WithEvents Lbl_Register_Room As System.Windows.Forms.Label
    Friend WithEvents Lbl_Register_Department As System.Windows.Forms.Label
    Friend WithEvents Lbl_Register_Password As System.Windows.Forms.Label
    Friend WithEvents Lbl_Register_username As System.Windows.Forms.Label
    Friend WithEvents Lbl_Register_Name As System.Windows.Forms.Label
    Friend WithEvents Register_Email As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Register_Question As System.Windows.Forms.ComboBox
    Friend WithEvents Register_Answer As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Register_ECaptcha As System.Windows.Forms.RichTextBox
    Friend WithEvents Register_Enter As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Register_rePassword As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
