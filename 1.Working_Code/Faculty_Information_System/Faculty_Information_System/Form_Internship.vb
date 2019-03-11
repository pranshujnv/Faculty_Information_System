Imports System.Data.OleDb
Public Class Form_Internship

    Private Sub Btn_Submit_Click(sender As Object, e As EventArgs) Handles Btn_Submit.Click

        'flag
        'name
        If Not Form_Main.isAlpha(Intern_Name.Text) Or System.Text.RegularExpressions.Regex.IsMatch(Intern_Name.Text, "^[\s]*$") Then
            MsgBox("Enter Name in alphabets")
            GoTo ErrExit
        End If
        If Intern_Name.TextLength > 254 Then
            MsgBox("Max allowed Name Length: 254")
            Intern_Name.Text = Intern_Name.Text.Substring(0, 254)
            GoTo ErrExit
        End If

        'email
        If Not System.Text.RegularExpressions.Regex.IsMatch(Intern_Email.Text, "^[\s]*[^@|\s]+@[^@|\s]+[\s]*$") Then
            MsgBox("Enter email address. Format:[Id]@[Domain]")
            GoTo ErrExit
        End If
        If Intern_Email.TextLength > 254 Then
            MsgBox("Max allowed email address Length: 254")
            Intern_Email.Text = Intern_Email.Text.Substring(0, 254)
            GoTo ErrExit
        End If

        'college
        If Not Form_Main.isAlpha(Intern_College.Text) Or System.Text.RegularExpressions.Regex.IsMatch(Intern_College.Text, "^[\s]*$") Then
            MsgBox("Enter College Name in alphabets")
            GoTo ErrExit
        End If
        If Intern_College.TextLength > 254 Then
            MsgBox("Max allowed College Name Length: 254")
            Intern_College.Text = Intern_College.Text.Substring(0, 254)
            GoTo ErrExit
        End If

        'degree
        If Not Form_Main.isAlpha(Intern_Degree.Text) Or System.Text.RegularExpressions.Regex.IsMatch(Intern_Degree.Text, "^[\s]*$") Then
            MsgBox("Enter degree in alphabets")
            GoTo ErrExit
        End If
        If Intern_Degree.TextLength > 254 Then
            MsgBox("Max allowed degree Length: 254")
            Intern_Degree.Text = Intern_Degree.Text.Substring(0, 254)
            GoTo ErrExit
        End If

        'branch
        If Not Form_Main.isAlpha(Intern_Branch.Text) Or System.Text.RegularExpressions.Regex.IsMatch(Intern_Branch.Text, "^[\s]*$") Then
            MsgBox("Enter branch in alphabets")
            GoTo ErrExit
        End If
        If Intern_Branch.TextLength > 254 Then
            MsgBox("Max allowed Branch Length: 254")
            Intern_Branch.Text = Intern_Branch.Text.Substring(0, 254)
            GoTo ErrExit
        End If

        'current year
        If Not System.Text.RegularExpressions.Regex.IsMatch(Intern_Year.Text, "^[A-z|a-z|.|'|0-9|\s]*$") Or System.Text.RegularExpressions.Regex.IsMatch(Intern_Year.Text, "^[\s]*$") Then
            MsgBox("Enter Year in alphanumeric characters")
            GoTo ErrExit
        End If
        If Intern_Year.TextLength > 254 Then
            MsgBox("Max allowed Year Length: 254")
            Intern_Year.Text = Intern_Year.Text.Substring(0, 254)
            GoTo ErrExit
        End If

        'additional info
        If Intern_Description.TextLength > 32766 Then
            MsgBox("Max allowed username Length: 32766")
            Intern_Year.Text = Intern_Year.Text.Substring(0, 32766)
            GoTo ErrExit
        End If
        'end of flag

        Dim cn2 As OleDbConnection = New OleDbConnection(Form_Main.connectString)
        cn2.Open()
        Dim str5 As String = Intern_Email.Text.Trim()
        Dim str2 As String = Form_Main.input_user

        Dim selectString As String = " SELECT * FROM Student_App_Table WHERE Teacher_Username='" & str2 & "'"
        Dim cmd4 As OleDbCommand = New OleDbCommand(selectString, cn2)
        Dim reader As OleDbDataReader = cmd4.ExecuteReader()

        Dim flag As Integer = 0
        While reader.Read()
            Dim temp_email As String = reader("Student_Email")
            If String.Compare(temp_email, str5) = 0 Then
                flag = 1
            End If
        End While

        If flag = 1 Then
            MsgBox("You have already applied to this Professor")
            Form_Main.Show()
            Me.Close()
            For Each a In Me.Controls
                If TypeOf a Is TextBox Then
                    a.Text = ""
                End If
            Next
            GoTo ErrExit
        End If
      
        cn2.Close()


        Dim cn As OleDbConnection = New OleDbConnection(Form_Main.connectString)
        cn.Open()
        Dim str As String = Form_Main.input_user
        Dim name As String = Intern_Name.Text.Trim()
        Dim email As String = Intern_Email.Text.Trim()
        Dim college As String = Intern_College.Text.Trim()
        Dim degree As String = Intern_Degree.Text.Trim()
        Dim branch As String = Intern_Branch.Text.Trim()
        Dim year As String = Intern_Year.Text.Trim()
        Dim resumee As String = Intern_Resume.Text.Trim()
        Dim description As String = Intern_Description.Text.Trim()
        Dim approved As String = "NO"


        Dim insertString As String = "INSERT INTO Student_App_Table([Teacher_Username],[Student_Name],[Student_Email],[Student_College],[Student_Degree],[Student_Branch],[Student_Current_Year],[Student_Resume],[Student_Description],[Student_Approved]) VALUES('" & str & "','" & name & "','" & email & "','" & college & "','" & degree & "','" & branch & "','" & year & "','" & resumee & "','" & description & "','" & approved & "')"


        'Dim insertString As String = "INSERT INTO Teacher_Info_Table([Username],[Password],[Full_Name],[Department],[Contact_Number],[Room_Number],[Research_Tag],[Research_Interest],[Current_Course_Code],[Current_Course_Description],[DOB],[Email],[Approved],[Link_To_Webpage],[Image_Address]) VALUES('" & username & "','" & password & "','" & full_name & "','" & department & "','" & contact & "','" & room & "','" & tag & "','" & interest & "','" & code & "','" & description & "','" & dob & "', '" & email & "', '" & approved & "', '" & cv & "', '" & path & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(insertString, cn)
        cmd.Parameters.Add(New OleDbParameter("Teacher_Username", CType(str, String)))
        cmd.Parameters.Add(New OleDbParameter("Student_Name", CType(name, String)))
        cmd.Parameters.Add(New OleDbParameter("Student_Email", CType(email, String)))
        cmd.Parameters.Add(New OleDbParameter("Student_College", CType(college, String)))
        cmd.Parameters.Add(New OleDbParameter("Student_Degree", CType(degree, String)))
        cmd.Parameters.Add(New OleDbParameter("Student_Branch", CType(branch, String)))
        cmd.Parameters.Add(New OleDbParameter("Student_Current_Year", CType(year, String)))
        cmd.Parameters.Add(New OleDbParameter("Student_Resume", CType(resumee, String)))
        cmd.Parameters.Add(New OleDbParameter("Student_Description", CType(description, String)))
        cmd.Parameters.Add(New OleDbParameter("Student_Approved", CType(approved, String)))
        cmd.ExecuteNonQuery()

        cn.Close()

        MessageBox.Show("Registration Successful")
        Form_Main.Show()
        Me.Close()
ErrExit:  'flag
    End Sub

    Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
        Me.Close()
        Form_Main.Show()

    End Sub

    Private Sub Intern_Name_TextChanged(sender As Object, e As EventArgs) Handles Intern_Name.TextChanged

    End Sub

    Private Sub Form_Internship_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class