Imports System.Data.OleDb

Public Class Register_User_Control

    Private Sub Register_User_Control_Load() Handles MyBase.Load

        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim r As New Random
        Dim sb As String = ""
        For i As Integer = 1 To 5
            Dim idx As Integer = r.Next(0, 35)
            sb = String.Concat(sb, s.Substring(idx, 1))
        Next
        Register_ECaptcha.Text = sb
        Register_ECaptcha.Font = New Font(Register_ECaptcha.Font, FontStyle.Strikeout)
    End Sub

    Private Sub Btn_Create_Click(sender As Object, e As EventArgs) Handles Btn_Create.Click
        If Not Form_Main.isAlpha(Register_Name.Text) Or System.Text.RegularExpressions.Regex.IsMatch(Register_Name.Text, "^[\s]*$") Then
            MsgBox("Enter Name in alphabets")
            Register_User_Control_Load()
            GoTo ErrExit
        End If
        If Register_Name.TextLength > 254 Then
            MsgBox("Max allowed Name Length: 254")
            Register_User_Control_Load()
            Register_Name.Text = Register_Name.Text.Substring(0, 254)
            GoTo ErrExit
        End If
        If System.Text.RegularExpressions.Regex.IsMatch(Register_username.Text, "^[\s]*$") Then
            MsgBox("Enter username")
            Register_User_Control_Load()
            GoTo ErrExit
        End If
        If Register_username.TextLength > 254 Then
            MsgBox("Max allowed username Length: 254")
            Register_User_Control_Load()
            Register_username.Text = Register_username.Text.Substring(0, 254)
            GoTo ErrExit
        End If
        If String.Compare(Register_username.Text, "xxx") = 0 Then
            MsgBox("Username Not Allowed")
            Register_User_Control_Load()
            GoTo ErrExit
        End If
        If Len(Register_Password.Text.Trim()) < 3 Then
            MsgBox("Password needs to be a minimum of three characters")
            Register_User_Control_Load()
            GoTo ErrExit
        End If

        If Register_Password.TextLength > 254 Then
            MsgBox("Max allowed password Length: 254")
            Register_User_Control_Load()
            Register_Password.Text = ""
            'Register_Password.Text = Register_Password.Text.Substring(0, 254)
            GoTo ErrExit
        End If

        If String.Compare(Register_Password.Text, Register_rePassword.Text) <> 0 Then
            MsgBox("Passowrds Do Not Match")
            Register_User_Control_Load()
            GoTo ErrExit
        End If

        If Register_Department.SelectedIndex = -1 Then
            MsgBox("Enter Department")
            Register_User_Control_Load()
            GoTo ErrExit
        End If
        If Not System.Text.RegularExpressions.Regex.IsMatch(Register_Room.Text, "^[\s]*[a-z|A-Z][0-9]{0,1}-[0-9]{3}[\s]*$") Then
            MsgBox("Enter Room Number in format: A-123 or A1-123")
            Register_User_Control_Load()
            GoTo ErrExit
        End If
        If Register_Room.TextLength > 254 Then
            MsgBox("Max allowed Room Length: 254")
            Register_Room.Text = Register_Room.Text.Substring(0, 254)
            Register_User_Control_Load()
            GoTo ErrExit
        End If
        If Not System.Text.RegularExpressions.Regex.IsMatch(Register_Contact.Text, "^[\s]*[0-9]{7}[\s]*$") Then
            MsgBox("Enter 7 digits Contact Number [use digits from 0-9]")
            Register_User_Control_Load()
            GoTo ErrExit
        End If

        If Register_Contact.TextLength > 254 Then
            MsgBox("Max allowed Contact Number Length: 254")
            Register_Contact.Text = Register_Contact.Text.Substring(0, 254)
            Register_User_Control_Load()
            GoTo ErrExit
        End If
        If Not System.Text.RegularExpressions.Regex.IsMatch(Register_Email.Text, "^[\s]*[^@|\s]+@iitg.ac.in[\s]*$") Then
            MsgBox("Enter IITG email address(ending in @iitg.ac.in)")
            Register_User_Control_Load()
            GoTo ErrExit
        End If
        If Register_Email.TextLength > 254 Then
            MsgBox("Max allowed email address Length: 254")
            Register_Email.Text = Register_Email.Text.Substring(0, 254)
            Register_User_Control_Load()
            GoTo ErrExit
        End If

        If Register_Question.Text.Length = 0 Then
            MessageBox.Show("Please Choose the Security Question")
            Register_User_Control_Load()
            GoTo ErrExit
        End If

        If Register_Answer.Text.Length = 0 Then
            MessageBox.Show("Security Answer can't be left Empty")
            Register_User_Control_Load()
            GoTo ErrExit
        End If

        If String.Compare(Register_ECaptcha.Text, Register_Enter.Text) <> 0 Then
            MessageBox.Show("Enter the Correct Captcha")
            Register_User_Control_Load()
            Register_Enter.Clear()
            GoTo ErrExit
        End If


        Dim cn2 As OleDbConnection = New OleDbConnection(Form_Main.connectString)
        cn2.Open()
        Dim str2 As String = Register_username.Text.Trim()
        Dim str3 As String = Register_Email.Text.Trim()

        Dim selectString2 As String = " SELECT * FROM Teacher_Info_Table WHERE Username='" & str2 & "' "
        Dim selectString3 As String = " SELECT * FROM Teacher_Info_Table WHERE Email='" & str3 & "' "

        Dim cmd2 As OleDbCommand = New OleDbCommand(selectString2, cn2)
        Dim cmd3 As OleDbCommand = New OleDbCommand(selectString3, cn2)
        Dim reader As OleDbDataReader = cmd2.ExecuteReader()
        Dim reader3 As OleDbDataReader = cmd3.ExecuteReader()

        If reader.Read() Then
            MessageBox.Show("Username Already Exists")
            'Register_Department.Text = String.Empty
            Register_User_Control_Load()

            Return
        End If

        If reader3.Read() Then
            MessageBox.Show("Email-Id Already Exists")
            Register_User_Control_Load()
            'Register_Department.Text = String.Empty
            'Dim a As Control
            'For Each a In Me.Controls
            '    If TypeOf a Is TextBox Then
            '        a.Text = ""
            '    End If
            '    If TypeOf a Is ComboBox Then
            '        a.Text = ""
            '    End If
            'Next
            Return
        End If

        cn2.Close()

       
        Dim cn As OleDbConnection = New OleDbConnection(Form_Main.connectString)
        cn.Open()
        Dim username As String = Register_username.Text.Trim()
        Dim temp_password As String = Register_Password.Text.Trim()
        'Dim temp_password As String = Register_Password.Text
        Dim password As String = EncryptPassword(temp_password, username)
        Dim full_name As String = Register_Name.Text.Trim()
        Dim department As String = Register_Department.Text.Trim()
        Dim contact As String = Register_Contact.Text.Trim()
        Dim room As String = Register_Room.Text.Trim()
        Dim email As String = Register_Email.Text.Trim()
        Dim question As String = Register_Question.Text.Trim()
        Dim answer As String = Register_Answer.Text.Trim()
        Dim tag As String = " "
        Dim interest As String = " "
        Dim code As String = " "
        Dim description As String = " "
        Dim approved As String = "NO"
        Dim dob As String = "29-12-1999"
        Dim cv As String = " "
        Dim path As String = "@"


        Dim insertString As String = "INSERT INTO Teacher_Info_Table([Username],[Password],[Full_Name],[Department],[Contact_Number],[Room_Number],[Research_Tag],[Research_Interest],[Current_Course_Code],[Current_Course_Description],[DOB],[Email],[Approved],[Link_To_Webpage],[Image_Address],[Security_Question],[Security_Answer]) VALUES('" & username & "','" & password & "','" & full_name & "','" & department & "','" & contact & "','" & room & "','" & tag & "','" & interest & "','" & code & "','" & description & "','" & dob & "', '" & email & "', '" & approved & "', '" & cv & "', '" & path & "', '" & question & "', '" & answer & "')"


        'Dim insertString As String = "INSERT INTO Teacher_Info_Table([Username],[Password],[Full_Name],[Department],[Contact_Number],[Room_Number],[Research_Tag],[Research_Interest],[Current_Course_Code],[Current_Course_Description],[DOB],[Email],[Approved],[Link_To_Webpage],[Image_Address]) VALUES('" & username & "','" & password & "','" & full_name & "','" & department & "','" & contact & "','" & room & "','" & tag & "','" & interest & "','" & code & "','" & description & "','" & dob & "', '" & email & "', '" & approved & "', '" & cv & "', '" & path & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(insertString, cn)
        cmd.Parameters.Add(New OleDbParameter("Username", CType(username, String)))
        cmd.Parameters.Add(New OleDbParameter("Password", CType(password, String)))
        cmd.Parameters.Add(New OleDbParameter("Full_Name", CType(full_name, String)))
        cmd.Parameters.Add(New OleDbParameter("Department", CType(department, String)))
        cmd.Parameters.Add(New OleDbParameter("Contact_Number", CType(contact, String)))
        cmd.Parameters.Add(New OleDbParameter("Research_Tag", CType(tag, String)))
        cmd.Parameters.Add(New OleDbParameter("Research_Interest", CType(interest, String)))
        cmd.Parameters.Add(New OleDbParameter("Current_Course_Code", CType(code, String)))
        cmd.Parameters.Add(New OleDbParameter("Current_Course_Description", CType(description, String)))
        cmd.Parameters.Add(New OleDbParameter("DOB", CType(dob, String)))
        cmd.Parameters.Add(New OleDbParameter("Email", CType(email, String)))
        cmd.Parameters.Add(New OleDbParameter("Approved", CType(approved, String)))
        cmd.Parameters.Add(New OleDbParameter("Link_To_Webpage", CType(cv, String)))
        cmd.Parameters.Add(New OleDbParameter("Security_Question", CType(question, String)))
        cmd.Parameters.Add(New OleDbParameter("Security_Answer", CType(answer, String)))

        cmd.ExecuteNonQuery()

        cn.Close()
        Dim ax As Control
        For Each ax In Me.Controls
            If TypeOf ax Is TextBox Then
                ax.Text = Nothing
            End If

            If TypeOf ax Is ComboBox Then
                ax.Text = Nothing
            End If
        Next


        Register_User_Control_Load()
        MessageBox.Show("Registration Successful")

ErrExit:
    End Sub

End Class


