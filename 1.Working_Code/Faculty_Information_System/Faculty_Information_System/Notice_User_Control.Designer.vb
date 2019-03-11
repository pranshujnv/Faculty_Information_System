<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Notice_User_Control
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
        Me.Btn_Notice = New System.Windows.Forms.Button()
        Me.Txt_Notice = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Btn_Notice
        '
        Me.Btn_Notice.BackColor = System.Drawing.Color.OrangeRed
        Me.Btn_Notice.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Notice.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Btn_Notice.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_Notice.Location = New System.Drawing.Point(259, 326)
        Me.Btn_Notice.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Notice.Name = "Btn_Notice"
        Me.Btn_Notice.Size = New System.Drawing.Size(135, 47)
        Me.Btn_Notice.TabIndex = 23
        Me.Btn_Notice.Text = "Add Notice"
        Me.Btn_Notice.UseVisualStyleBackColor = False
        '
        'Txt_Notice
        '
        Me.Txt_Notice.BackColor = System.Drawing.Color.Beige
        Me.Txt_Notice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_Notice.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Txt_Notice.ForeColor = System.Drawing.Color.Black
        Me.Txt_Notice.Location = New System.Drawing.Point(86, 73)
        Me.Txt_Notice.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_Notice.Multiline = True
        Me.Txt_Notice.Name = "Txt_Notice"
        Me.Txt_Notice.Size = New System.Drawing.Size(470, 199)
        Me.Txt_Notice.TabIndex = 24
        '
        'Notice_User_Control
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Txt_Notice)
        Me.Controls.Add(Me.Btn_Notice)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Notice_User_Control"
        Me.Padding = New System.Windows.Forms.Padding(8)
        Me.Size = New System.Drawing.Size(757, 588)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_Notice As System.Windows.Forms.Button
    Friend WithEvents Txt_Notice As System.Windows.Forms.TextBox

End Class
