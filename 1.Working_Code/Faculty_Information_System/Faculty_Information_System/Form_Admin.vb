Public Class Form_Admin

    Public Sub Btn_Approval_Click() Handles Btn_Approval.Click
        Scroll_Panel.Visible = True
        Scroll_Panel.Height = Btn_Approval.Height
        Scroll_Panel.Top = Btn_Approval.Top
        Output_Panel.Controls.Clear()
        Output_Panel.Controls.Add(New Admin_Approval_User_Control)
    End Sub

    Public Sub Btn_Delete_Click() Handles Btn_Delete.Click
        Scroll_Panel.Visible = True
        Scroll_Panel.Height = Btn_Delete.Height
        Scroll_Panel.Top = Btn_Delete.Top
        Output_Panel.Controls.Clear()
        Output_Panel.Controls.Add(New Admin_Delete_User_Control)

    End Sub

    Public Sub Btn_Edit_Click() Handles Btn_Edit.Click
        Scroll_Panel.Visible = True
        Scroll_Panel.Height = Btn_Edit.Height
        Scroll_Panel.Top = Btn_Edit.Top
        
        Output_Panel.Controls.Clear()
        Output_Panel.Controls.Add(New Admin_Edit_User_Control)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to Logout ?", "caption", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
        ElseIf result = DialogResult.Yes Then
            Me.Close()
            Form_Main.Show()
        End If

    End Sub

    Private Sub Form_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Btn_Approval_Click()

    End Sub
End Class