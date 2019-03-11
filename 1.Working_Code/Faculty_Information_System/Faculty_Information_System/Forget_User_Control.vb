Imports System.Data.OleDb

Public Class Forget_User_Control

    Private Sub Forget_User_Control_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Lbl_username.Visible = True
        Forget_Username.Visible = True
        Btn_Submit1.Visible = True

        Lbl_Question.Visible = False
        Lbl_Answer.Visible = False
        Forget_Question.Visible = False
        Forget_Answer.Visible = False
        Btn_Submit2.Visible = False

        Lbl_New_Password.Visible = False
        Forget_Password.Visible = False
        Btn_Submit3.Visible = False
        TextBox1.Visible = False
        Label4.Visible = False


    End Sub

    Private Sub Btn_Submit1_Click(sender As Object, e As EventArgs) Handles Btn_Submit1.Click

        If Forget_Username.TextLength > 254 Then
            MsgBox("Max allowed username Length: 254")
            Forget_Username.Text = Forget_Username.Text.Substring(0, 254)
            GoTo ErrExit
        End If

        Dim cn2 As OleDbConnection = New OleDbConnection(Form_Main.connectString)
        cn2.Open()
        Dim str2 As String = Forget_Username.Text.Trim()
        Dim selectString2 As String = " SELECT * FROM Teacher_Info_Table WHERE Username='" & str2 & "' "
        Dim cmd2 As OleDbCommand = New OleDbCommand(selectString2, cn2)
        Dim reader As OleDbDataReader = cmd2.ExecuteReader()
        If reader.Read() Then
            Form_Main.forget_user = str2
            Lbl_username.Visible = False
            Forget_Username.Visible = False
            Btn_Submit1.Visible = False

            Lbl_Question.Visible = True
            Lbl_Answer.Visible = True
            Forget_Question.Visible = True
            Forget_Answer.Visible = True
            Btn_Submit2.Visible = True

            Lbl_New_Password.Visible = False
            Forget_Password.Visible = False
            TextBox1.Visible = False
            Label4.Visible = False
            Btn_Submit3.Visible = False

            Forget_Question.Text = " "
            Forget_Question.Text = reader("Security_Question")
        Else
            MessageBox.Show("Enter Correct Username")
        End If
ErrExit:  'flag
    End Sub

    Private Sub Btn_Submit2_Click(sender As Object, e As EventArgs) Handles Btn_Submit2.Click

        Dim cn As OleDbConnection = New OleDbConnection(Form_Main.connectString)
        cn.Open()
        Dim str1 As String = Form_Main.forget_user

        Dim selectString As String = "SELECT * FROM Teacher_Info_Table WHERE Username='" & str1 & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        If reader.Read() Then
            Dim correct_answer As String = reader("Security_Answer")
            Dim input_answer As String = Forget_Answer.Text.Trim()

            If String.Compare(correct_answer, input_answer) = 0 Then

                Btn_Submit2.Visible = False
                Lbl_New_Password.Visible = True
                Forget_Password.Visible = True
                TextBox1.Visible = True
                Label4.Visible = True
                Btn_Submit3.Visible = True
                Forget_Answer.ReadOnly = True
            Else
                MessageBox.Show("Wrong Answer")
            End If
        End If
        cn.Close()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Lbl_Question.Click

    End Sub

    Private Sub Btn_Submit3_Click(sender As Object, e As EventArgs) Handles Btn_Submit3.Click


        If Forget_Password.TextLength > 254 Then
            MsgBox("Max allowed Password Length: 254")
            Forget_Password.Text = ""
            GoTo ErrExit2
        End If

        If Len(Forget_Password.Text.Trim()) < 3 Then
            MsgBox("Password needs to be a minimum of three characters")
            GoTo ErrExit2
        End If

        If String.Compare(Forget_Password.Text.Trim(), TextBox1.Text.Trim()) <> 0 Then
            MsgBox("Passowrds Do Not Match")
            Forget_Password.Text = ""
            TextBox1.Text = ""
            GoTo ErrExit2
        End If


        Dim cn As OleDbConnection = New OleDbConnection(Form_Main.connectString)
        cn.Open()

        Dim str1 As String = Form_Main.forget_user
        Dim temp_password As String = Forget_Password.Text.Trim()
        Dim temp As String = EncryptPassword(temp_password, str1) 'Made change here

        Dim updateString As String = "UPDATE Teacher_Info_Table SET [Password] ='" & temp & "' WHERE [Username] = '" & str1 & "';"
        Dim cmd As OleDbCommand = New OleDbCommand(updateString, cn)
        cmd.Parameters.Add(New OleDbParameter("Password", CType(temp, String)))
        MessageBox.Show("Password Changed")
        Form_Main.flag_Panel_Login = "1"

        Lbl_username.Visible = False
        Forget_Username.Visible = False
        Btn_Submit1.Visible = False

        Lbl_Question.Visible = False
        Lbl_Answer.Visible = False
        Forget_Question.Visible = False
        Forget_Answer.Visible = False
        Btn_Submit2.Visible = False

        Lbl_New_Password.Visible = False
        Forget_Password.Visible = False
        Btn_Submit3.Visible = False
        TextBox1.Visible = False
        Label4.Visible = False

        cmd.ExecuteNonQuery()
        cn.Close()
ErrExit2:  'flag
    End Sub



End Class
