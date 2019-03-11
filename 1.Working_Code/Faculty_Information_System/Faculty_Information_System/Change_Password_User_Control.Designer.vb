<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Change_Password_User_Control
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Btn_Curr_Password = New System.Windows.Forms.Button()
        Me.Btn_change_password = New System.Windows.Forms.Button()
        Me.Current_Password = New System.Windows.Forms.TextBox()
        Me.New_Password = New System.Windows.Forms.TextBox()
        Me.Renew_Password = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Current Password"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 254)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(239, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter New Password"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(59, 292)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(245, 27)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Re-Enter New Password"
        '
        'Btn_Curr_Password
        '
        Me.Btn_Curr_Password.BackColor = System.Drawing.Color.OrangeRed
        Me.Btn_Curr_Password.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Curr_Password.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Curr_Password.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_Curr_Password.Location = New System.Drawing.Point(325, 174)
        Me.Btn_Curr_Password.Name = "Btn_Curr_Password"
        Me.Btn_Curr_Password.Size = New System.Drawing.Size(109, 44)
        Me.Btn_Curr_Password.TabIndex = 1
        Me.Btn_Curr_Password.Text = "Submit"
        Me.Btn_Curr_Password.UseVisualStyleBackColor = False
        '
        'Btn_change_password
        '
        Me.Btn_change_password.BackColor = System.Drawing.Color.OrangeRed
        Me.Btn_change_password.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_change_password.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_change_password.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_change_password.Location = New System.Drawing.Point(325, 349)
        Me.Btn_change_password.Name = "Btn_change_password"
        Me.Btn_change_password.Size = New System.Drawing.Size(110, 42)
        Me.Btn_change_password.TabIndex = 4
        Me.Btn_change_password.Text = "Update"
        Me.Btn_change_password.UseVisualStyleBackColor = False
        '
        'Current_Password
        '
        Me.Current_Password.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Current_Password.Location = New System.Drawing.Point(325, 128)
        Me.Current_Password.Name = "Current_Password"
        Me.Current_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Current_Password.Size = New System.Drawing.Size(195, 27)
        Me.Current_Password.TabIndex = 0
        '
        'New_Password
        '
        Me.New_Password.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.New_Password.Location = New System.Drawing.Point(325, 254)
        Me.New_Password.Name = "New_Password"
        Me.New_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.New_Password.Size = New System.Drawing.Size(195, 27)
        Me.New_Password.TabIndex = 2
        '
        'Renew_Password
        '
        Me.Renew_Password.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Renew_Password.Location = New System.Drawing.Point(325, 292)
        Me.Renew_Password.Name = "Renew_Password"
        Me.Renew_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Renew_Password.Size = New System.Drawing.Size(195, 27)
        Me.Renew_Password.TabIndex = 3
        '
        'Change_Password_User_Control
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Renew_Password)
        Me.Controls.Add(Me.New_Password)
        Me.Controls.Add(Me.Current_Password)
        Me.Controls.Add(Me.Btn_change_password)
        Me.Controls.Add(Me.Btn_Curr_Password)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Change_Password_User_Control"
        Me.Size = New System.Drawing.Size(1009, 769)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Btn_Curr_Password As System.Windows.Forms.Button
    Friend WithEvents Btn_change_password As System.Windows.Forms.Button
    Friend WithEvents Current_Password As System.Windows.Forms.TextBox
    Friend WithEvents New_Password As System.Windows.Forms.TextBox
    Friend WithEvents Renew_Password As System.Windows.Forms.TextBox

End Class
