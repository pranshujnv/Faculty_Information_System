<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Admin
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
        Me.Btn_Approval = New System.Windows.Forms.Button()
        Me.Btn_Delete = New System.Windows.Forms.Button()
        Me.Scroll_Panel = New System.Windows.Forms.Panel()
        Me.Btn_Edit = New System.Windows.Forms.Button()
        Me.Output_Panel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.Panel1.Controls.Add(Me.Btn_Approval)
        Me.Panel1.Controls.Add(Me.Btn_Delete)
        Me.Panel1.Controls.Add(Me.Scroll_Panel)
        Me.Panel1.Controls.Add(Me.Btn_Edit)
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(324, 896)
        Me.Panel1.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(151, 597)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 49)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Logout"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Faculty_Information_System.My.Resources.Resources.IIT_Guwahati_Logo_svg
        Me.PictureBox1.Location = New System.Drawing.Point(21, 15)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(259, 165)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Btn_Approval
        '
        Me.Btn_Approval.BackColor = System.Drawing.Color.OrangeRed
        Me.Btn_Approval.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Approval.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Approval.ForeColor = System.Drawing.Color.White
        Me.Btn_Approval.Location = New System.Drawing.Point(55, 247)
        Me.Btn_Approval.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Approval.Name = "Btn_Approval"
        Me.Btn_Approval.Size = New System.Drawing.Size(209, 49)
        Me.Btn_Approval.TabIndex = 16
        Me.Btn_Approval.Text = "Approval"
        Me.Btn_Approval.UseVisualStyleBackColor = False
        '
        'Btn_Delete
        '
        Me.Btn_Delete.BackColor = System.Drawing.Color.OrangeRed
        Me.Btn_Delete.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Delete.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Delete.ForeColor = System.Drawing.Color.White
        Me.Btn_Delete.Location = New System.Drawing.Point(55, 329)
        Me.Btn_Delete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Delete.Name = "Btn_Delete"
        Me.Btn_Delete.Size = New System.Drawing.Size(209, 49)
        Me.Btn_Delete.TabIndex = 13
        Me.Btn_Delete.Text = "Delete"
        Me.Btn_Delete.UseVisualStyleBackColor = False
        '
        'Scroll_Panel
        '
        Me.Scroll_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Scroll_Panel.Location = New System.Drawing.Point(43, 247)
        Me.Scroll_Panel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Scroll_Panel.Name = "Scroll_Panel"
        Me.Scroll_Panel.Size = New System.Drawing.Size(13, 49)
        Me.Scroll_Panel.TabIndex = 12
        '
        'Btn_Edit
        '
        Me.Btn_Edit.BackColor = System.Drawing.Color.OrangeRed
        Me.Btn_Edit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Edit.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Edit.ForeColor = System.Drawing.Color.White
        Me.Btn_Edit.Location = New System.Drawing.Point(55, 409)
        Me.Btn_Edit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Edit.Name = "Btn_Edit"
        Me.Btn_Edit.Size = New System.Drawing.Size(209, 49)
        Me.Btn_Edit.TabIndex = 11
        Me.Btn_Edit.Text = "Edit"
        Me.Btn_Edit.UseVisualStyleBackColor = False
        '
        'Output_Panel
        '
        Me.Output_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Output_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Output_Panel.Location = New System.Drawing.Point(385, 160)
        Me.Output_Panel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Output_Panel.Name = "Output_Panel"
        Me.Output_Panel.Size = New System.Drawing.Size(909, 681)
        Me.Output_Panel.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(745, 52)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 55)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Admin"
        '
        'Form_Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1344, 897)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Output_Panel)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "Form_Admin"
        Me.Text = "Form_Admin"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Output_Panel As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Btn_Edit As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Btn_Approval As System.Windows.Forms.Button
    Friend WithEvents Btn_Delete As System.Windows.Forms.Button
    Public WithEvents Scroll_Panel As System.Windows.Forms.Panel
End Class
