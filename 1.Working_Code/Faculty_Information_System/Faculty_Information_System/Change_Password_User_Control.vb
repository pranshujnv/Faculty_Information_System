Imports System.Data.OleDb
Public Class Change_Password_User_Control

    Private Sub Change_Password_User_Control_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Current_Password.Visible = True
        Label1.Visible = True
        Btn_Curr_Password.Visible = True
        Label2.Visible = False
        Label3.Visible = False
        Btn_change_password.Visible = False
        New_Password.Visible = False
        Renew_Password.Visible = False
    End Sub

    Private Sub Btn_Curr_Password_Click(sender As Object, e As EventArgs) Handles Btn_Curr_Password.Click

        If Current_Password.TextLength > 254 Then
            MsgBox("Max allowed Password Length: 254")
            Current_Password.Text = Current_Password.Text.Substring(0, 254)
            GoTo ErrExit
        End If


        Dim cn As OleDbConnection = New OleDbConnection(Form_Main.connectString)
        cn.Open()
        Dim str1 As String = Form_Main.input_user

        Dim selectString As String = "SELECT * FROM Teacher_Info_Table WHERE Username='" & str1 & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        If reader.Read() Then
            Dim temp_password As String = Current_Password.Text.Trim()
            Dim password As String = EncryptPassword(temp_password, Form_Main.input_user)
            If (String.Compare(reader("Password"), password) = 0) Then
                Current_Password.Visible = False
                Label1.Visible = False
                Btn_Curr_Password.Visible = False
                Label2.Visible = True
                Label3.Visible = True
                Btn_change_password.Visible = True
                New_Password.Visible = True
                Renew_Password.Visible = True
            Else
                MessageBox.Show("Incorrect Password")
            End If
        End If
ErrExit:


    End Sub

    Private Sub Btn_change_password_Click(sender As Object, e As EventArgs) Handles Btn_change_password.Click

        If New_Password.TextLength > 254 Or Renew_Password.TextLength > 254 Then
            MsgBox("Max allowed Password Length: 254")
            New_Password.Text = ""
            Renew_Password.Text = ""
            GoTo ErrExit2
        End If

        If String.Compare(New_Password.Text.Trim(), Renew_Password.Text.Trim()) = 0 Then

            If Len(New_Password.Text.Trim()) < 3 Then
                MsgBox("Password needs to be a minimum of three characters")
                GoTo ErrExit2
            End If

            Dim cn As OleDbConnection = New OleDbConnection(Form_Main.connectString)
            cn.Open()
            Dim str1 As String = Form_Main.input_user
            Dim temp_password As String = Current_Password.Text.Trim()
            Dim password As String = EncryptPassword(temp_password, Form_Main.input_user)
            Dim updateString As String = "UPDATE Teacher_Info_Table SET [Password]='" & password & "' WHERE Username = '" & str1 & "';"
            Dim cmd As OleDbCommand = New OleDbCommand(updateString, cn)
            cmd.ExecuteNonQuery()
            cn.Close()
            MessageBox.Show("Password Updated Successfully")

        Else
            MessageBox.Show("Passwords Do Not Match")
        End If
        Dim a As Control
        For Each a In Me.Controls
            If TypeOf a Is TextBox Then
                a.Text = ""
            End If
        Next
        Return
ErrExit2:

    End Sub
End Class
