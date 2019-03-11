<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Main
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Btn_HomePge = New System.Windows.Forms.Button()
        Me.Btn_Admin = New System.Windows.Forms.Button()
        Me.Btn_Notification = New System.Windows.Forms.Button()
        Me.Btn_Signup = New System.Windows.Forms.Button()
        Me.Scroll_Panel = New System.Windows.Forms.Panel()
        Me.Btn_Teacher_Login = New System.Windows.Forms.Button()
        Me.Btn_Search = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Output_Panel = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Btn_HomePge)
        Me.Panel1.Controls.Add(Me.Btn_Admin)
        Me.Panel1.Controls.Add(Me.Btn_Notification)
        Me.Panel1.Controls.Add(Me.Btn_Signup)
        Me.Panel1.Controls.Add(Me.Scroll_Panel)
        Me.Panel1.Controls.Add(Me.Btn_Teacher_Login)
        Me.Panel1.Controls.Add(Me.Btn_Search)
        Me.Panel1.Location = New System.Drawing.Point(3, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(324, 896)
        Me.Panel1.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(151, 780)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 49)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Faculty_Information_System.My.Resources.Resources.IIT_Guwahati_Logo_svg
        Me.PictureBox1.Location = New System.Drawing.Point(21, 15)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(259, 165)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Btn_HomePge
        '
        Me.Btn_HomePge.BackColor = System.Drawing.Color.OrangeRed
        Me.Btn_HomePge.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_HomePge.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_HomePge.ForeColor = System.Drawing.Color.White
        Me.Btn_HomePge.Location = New System.Drawing.Point(55, 247)
        Me.Btn_HomePge.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_HomePge.Name = "Btn_HomePge"
        Me.Btn_HomePge.Size = New System.Drawing.Size(209, 49)
        Me.Btn_HomePge.TabIndex = 16
        Me.Btn_HomePge.Text = "HomePage"
        Me.Btn_HomePge.UseVisualStyleBackColor = False
        '
        'Btn_Admin
        '
        Me.Btn_Admin.BackColor = System.Drawing.Color.OrangeRed
        Me.Btn_Admin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Admin.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Admin.ForeColor = System.Drawing.Color.White
        Me.Btn_Admin.Location = New System.Drawing.Point(55, 658)
        Me.Btn_Admin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Admin.Name = "Btn_Admin"
        Me.Btn_Admin.Size = New System.Drawing.Size(209, 49)
        Me.Btn_Admin.TabIndex = 15
        Me.Btn_Admin.Text = "Admin Login"
        Me.Btn_Admin.UseVisualStyleBackColor = False
        '
        'Btn_Notification
        '
        Me.Btn_Notification.BackColor = System.Drawing.Color.OrangeRed
        Me.Btn_Notification.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Notification.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Notification.ForeColor = System.Drawing.Color.White
        Me.Btn_Notification.Location = New System.Drawing.Point(55, 574)
        Me.Btn_Notification.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Notification.Name = "Btn_Notification"
        Me.Btn_Notification.Size = New System.Drawing.Size(209, 49)
        Me.Btn_Notification.TabIndex = 14
        Me.Btn_Notification.Text = "Notifications"
        Me.Btn_Notification.UseVisualStyleBackColor = False
        '
        'Btn_Signup
        '
        Me.Btn_Signup.BackColor = System.Drawing.Color.OrangeRed
        Me.Btn_Signup.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Btn_Signup.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Signup.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Signup.ForeColor = System.Drawing.Color.White
        Me.Btn_Signup.Location = New System.Drawing.Point(55, 329)
        Me.Btn_Signup.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Signup.Name = "Btn_Signup"
        Me.Btn_Signup.Size = New System.Drawing.Size(209, 49)
        Me.Btn_Signup.TabIndex = 13
        Me.Btn_Signup.Text = "Teacher Signup"
        Me.Btn_Signup.UseVisualStyleBackColor = False
        '
        'Scroll_Panel
        '
        Me.Scroll_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Scroll_Panel.Location = New System.Drawing.Point(43, 247)
        Me.Scroll_Panel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Scroll_Panel.Name = "Scroll_Panel"
        Me.Scroll_Panel.Size = New System.Drawing.Size(15, 49)
        Me.Scroll_Panel.TabIndex = 12
        '
        'Btn_Teacher_Login
        '
        Me.Btn_Teacher_Login.BackColor = System.Drawing.Color.OrangeRed
        Me.Btn_Teacher_Login.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Btn_Teacher_Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Teacher_Login.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Teacher_Login.ForeColor = System.Drawing.Color.White
        Me.Btn_Teacher_Login.Location = New System.Drawing.Point(55, 409)
        Me.Btn_Teacher_Login.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Teacher_Login.Name = "Btn_Teacher_Login"
        Me.Btn_Teacher_Login.Size = New System.Drawing.Size(209, 49)
        Me.Btn_Teacher_Login.TabIndex = 11
        Me.Btn_Teacher_Login.Text = "Teacher Login"
        Me.Btn_Teacher_Login.UseVisualStyleBackColor = False
        '
        'Btn_Search
        '
        Me.Btn_Search.BackColor = System.Drawing.Color.OrangeRed
        Me.Btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Search.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Search.ForeColor = System.Drawing.Color.White
        Me.Btn_Search.Location = New System.Drawing.Point(55, 490)
        Me.Btn_Search.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Search.Name = "Btn_Search"
        Me.Btn_Search.Size = New System.Drawing.Size(209, 49)
        Me.Btn_Search.TabIndex = 14
        Me.Btn_Search.Text = "Search"
        Me.Btn_Search.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(505, 65)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(620, 55)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = " Faculty Information System "
        '
        'Output_Panel
        '
        Me.Output_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Output_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Output_Panel.Location = New System.Drawing.Point(385, 160)
        Me.Output_Panel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Output_Panel.Name = "Output_Panel"
        Me.Output_Panel.Size = New System.Drawing.Size(909, 681)
        Me.Output_Panel.TabIndex = 14
        '
        'Form_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1344, 897)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Output_Panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "Form_Main"
        Me.Text = "Faculty_Information_System"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents Btn_HomePge As System.Windows.Forms.Button
    Public WithEvents Btn_Admin As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Output_Panel As System.Windows.Forms.Panel
    Public WithEvents Btn_Notification As System.Windows.Forms.Button
    Public WithEvents Btn_Signup As System.Windows.Forms.Button
    Public WithEvents Btn_Teacher_Login As System.Windows.Forms.Button
    Public WithEvents Btn_Search As System.Windows.Forms.Button
    Public WithEvents Scroll_Panel As System.Windows.Forms.Panel

End Class
