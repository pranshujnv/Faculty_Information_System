<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_User_Control
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
        Me.Admin_Password = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Submit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Admin_Password
        '
        Me.Admin_Password.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Admin_Password.Location = New System.Drawing.Point(331, 115)
        Me.Admin_Password.Margin = New System.Windows.Forms.Padding(2)
        Me.Admin_Password.Name = "Admin_Password"
        Me.Admin_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Admin_Password.Size = New System.Drawing.Size(166, 26)
        Me.Admin_Password.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(126, 115)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Admin Password"
        '
        'Btn_Submit
        '
        Me.Btn_Submit.BackColor = System.Drawing.Color.OrangeRed
        Me.Btn_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Submit.Font = New System.Drawing.Font("Century Gothic", 14.25!)
        Me.Btn_Submit.ForeColor = System.Drawing.Color.Azure
        Me.Btn_Submit.Location = New System.Drawing.Point(359, 194)
        Me.Btn_Submit.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Submit.Name = "Btn_Submit"
        Me.Btn_Submit.Size = New System.Drawing.Size(105, 34)
        Me.Btn_Submit.TabIndex = 3
        Me.Btn_Submit.Text = "Submit"
        Me.Btn_Submit.UseVisualStyleBackColor = False
        '
        'Admin_User_Control
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Btn_Submit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Admin_Password)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Admin_User_Control"
        Me.Size = New System.Drawing.Size(757, 588)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Admin_Password As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Btn_Submit As System.Windows.Forms.Button

End Class
