Public Class Admin_User_Control


    Private Sub Admin_User_Control_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btn_Submit_Click() Handles Btn_Submit.Click
        Dim i As Integer = 1

        If String.Compare(Admin_Password.Text, "admin") <> 0 And Form_Main.flag_admin = 0 Then
            MessageBox.Show("Incorrect Password")
            Admin_Password.Text = ""
        Else
            Admin_Password.Text = ""
            Form_Main.Hide()
            Form_Admin.Show()
        End If

    End Sub

End Class
