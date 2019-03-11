<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login_USer_Control
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
        Me.Btn_submit = New System.Windows.Forms.Button()
        Me.Lbl_password = New System.Windows.Forms.Label()
        Me.Txt_password = New System.Windows.Forms.TextBox()
        Me.Txt_username = New System.Windows.Forms.TextBox()
        Me.Lbl_username = New System.Windows.Forms.Label()
        Me.Btn_Forget = New System.Windows.Forms.Button()
        Me.Forget_Panel = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Btn_submit
        '
        Me.Btn_submit.BackColor = System.Drawing.Color.OrangeRed
        Me.Btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_submit.Font = New System.Drawing.Font("Century Gothic", 14.25!)
        Me.Btn_submit.ForeColor = System.Drawing.Color.AliceBlue
        Me.Btn_submit.Location = New System.Drawing.Point(225, 314)
        Me.Btn_submit.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_submit.Name = "Btn_submit"
        Me.Btn_submit.Size = New System.Drawing.Size(148, 48)
        Me.Btn_submit.TabIndex = 31
        Me.Btn_submit.Text = "Submit"
        Me.Btn_submit.UseVisualStyleBackColor = False
        '
        'Lbl_password
        '
        Me.Lbl_password.AutoSize = True
        Me.Lbl_password.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_password.Location = New System.Drawing.Point(143, 178)
        Me.Lbl_password.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_password.Name = "Lbl_password"
        Me.Lbl_password.Size = New System.Drawing.Size(104, 24)
        Me.Lbl_password.TabIndex = 30
        Me.Lbl_password.Text = "Password"
        '
        'Txt_password
        '
        Me.Txt_password.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_password.Location = New System.Drawing.Point(292, 178)
        Me.Txt_password.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_password.Name = "Txt_password"
        Me.Txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_password.Size = New System.Drawing.Size(170, 27)
        Me.Txt_password.TabIndex = 29
        '
        'Txt_username
        '
        Me.Txt_username.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_username.Location = New System.Drawing.Point(292, 139)
        Me.Txt_username.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_username.Name = "Txt_username"
        Me.Txt_username.Size = New System.Drawing.Size(170, 27)
        Me.Txt_username.TabIndex = 28
        '
        'Lbl_username
        '
        Me.Lbl_username.AutoSize = True
        Me.Lbl_username.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_username.Location = New System.Drawing.Point(134, 139)
        Me.Lbl_username.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_username.Name = "Lbl_username"
        Me.Lbl_username.Size = New System.Drawing.Size(113, 24)
        Me.Lbl_username.TabIndex = 27
        Me.Lbl_username.Text = "Username"
        '
        'Btn_Forget
        '
        Me.Btn_Forget.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Forget.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Forget.Font = New System.Drawing.Font("Segoe Script", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Forget.ForeColor = System.Drawing.Color.White
        Me.Btn_Forget.Location = New System.Drawing.Point(326, 224)
        Me.Btn_Forget.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Forget.Name = "Btn_Forget"
        Me.Btn_Forget.Size = New System.Drawing.Size(136, 29)
        Me.Btn_Forget.TabIndex = 35
        Me.Btn_Forget.Text = "Forget Password?"
        Me.Btn_Forget.UseVisualStyleBackColor = False
        '
        'Forget_Panel
        '
        Me.Forget_Panel.Location = New System.Drawing.Point(3, 3)
        Me.Forget_Panel.Name = "Forget_Panel"
        Me.Forget_Panel.Size = New System.Drawing.Size(503, 464)
        Me.Forget_Panel.TabIndex = 36
        '
        'Login_USer_Control
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Forget_Panel)
        Me.Controls.Add(Me.Btn_Forget)
        Me.Controls.Add(Me.Btn_submit)
        Me.Controls.Add(Me.Lbl_password)
        Me.Controls.Add(Me.Txt_password)
        Me.Controls.Add(Me.Txt_username)
        Me.Controls.Add(Me.Lbl_username)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Login_USer_Control"
        Me.Size = New System.Drawing.Size(757, 588)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_submit As System.Windows.Forms.Button
    Friend WithEvents Lbl_password As System.Windows.Forms.Label
    Friend WithEvents Txt_password As System.Windows.Forms.TextBox
    Friend WithEvents Txt_username As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_username As System.Windows.Forms.Label
    Friend WithEvents Btn_Forget As System.Windows.Forms.Button
    Friend WithEvents Forget_Panel As System.Windows.Forms.Panel

End Class
