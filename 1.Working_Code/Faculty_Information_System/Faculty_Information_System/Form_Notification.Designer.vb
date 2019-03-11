<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Notification
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
        Me.Btn_Go_Back = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_Go_Back
        '
        Me.Btn_Go_Back.BackColor = System.Drawing.Color.OrangeRed
        Me.Btn_Go_Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Go_Back.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Go_Back.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_Go_Back.Location = New System.Drawing.Point(316, 542)
        Me.Btn_Go_Back.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Go_Back.Name = "Btn_Go_Back"
        Me.Btn_Go_Back.Size = New System.Drawing.Size(164, 37)
        Me.Btn_Go_Back.TabIndex = 0
        Me.Btn_Go_Back.Text = "Go Back"
        Me.Btn_Go_Back.UseVisualStyleBackColor = False
        '
        'Form_Notification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.Btn_Go_Back)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "Form_Notification"
        Me.Text = "Form_Notification"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btn_Go_Back As System.Windows.Forms.Button
End Class
