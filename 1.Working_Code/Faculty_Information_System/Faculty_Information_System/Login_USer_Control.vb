Imports System.Data.OleDb

Public Class Login_USer_Control

    Private Sub Login_USer_Control_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Forget_Panel.Visible = False
    End Sub
    Private Sub Btn_submit_Click(sender As Object, e As EventArgs) Handles Btn_submit.Click
        Dim cn As OleDbConnection = New OleDbConnection(Form_Main.connectString)
        cn.Open()
        Form_Main.input_user = Txt_username.Text.Trim()
        Dim temp_password As String = Txt_password.Text.Trim()
        Dim input_password As String = EncryptPassword(temp_password, Form_Main.input_user)

        Dim selectString As String = "SELECT * FROM Teacher_Info_Table WHERE Username='" & Form_Main.input_user & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()


        If reader.Read() Then
            If String.Compare(reader("Password"), input_password) = 0 Then
                If String.Compare(reader("Approved"), "YES") = 0 Then
                    Form_Main.flag_view = 1
                    Form_Main.Hide()
                    Teacher_Homepage.Show()
                Else
                    MessageBox.Show("Approval Pending by Admin")
                End If
            Else
                MessageBox.Show("Incorrect Password")
            End If
        Else
            MessageBox.Show("Invalid Username")
        End If
        Txt_password.Text = ""
        cn.Close()

    End Sub

    Private Sub Btn_Forget_Click(sender As Object, e As EventArgs) Handles Btn_Forget.Click

        Form_Main.flag_Panel_Login = "0"
        Forget_Panel.Controls.Clear()
        Forget_Panel.Controls.Add(New Forget_User_Control)
        Forget_Panel.Visible = True

        If String.Compare(Form_Main.flag_Panel_Login, "1") = 0 Then
            Forget_Panel.Visible = False
        End If

    End Sub



    Public Sub Forget_Panel_Paint(sender As Object, e As PaintEventArgs) Handles Forget_Panel.Paint

    End Sub
End Class
