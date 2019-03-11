Imports System.Data.OleDb
Imports System.Net.Mail
Public Class Interested_Students_User_Control

    Protected Sub updateFunc2(ByVal sender As Object, ByVal e As System.EventArgs)
        'Add delete Query
        Dim btn2 As Button = DirectCast(sender, Button)
        Dim name2 As String = btn2.Name
        Dim email2 As String = btn2.Tag

        Dim cn As OleDbConnection = New OleDbConnection(Form_Main.connectString)
        cn.Open()
        Dim deleteString As String = " DELETE FROM Student_App_Table WHERE Teacher_Username = '" & name2 & "' AND Student_Email = '" & email2 & "' "
        Dim selectString As String = "SELECT * FROM Teacher_Info_Table where Username='" & name2 & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(deleteString, cn)
        Dim cmd2 As OleDbCommand = New OleDbCommand(selectString, cn)
        Dim reader As OleDbDataReader = cmd2.ExecuteReader()
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As Exception

        End Try

        Dim full_name_teacher As String = " "
        If reader.Read() Then
            full_name_teacher = reader("Full_Name")
        End If

        Dim e_mail As New MailMessage()
        Try
            e_mail = New MailMessage()
            e_mail.From = New MailAddress("faculty.information.system2019@gmail.com")
            e_mail.To.Add(email2)
            e_mail.Subject = "Approval for Internship"
            e_mail.IsBodyHtml = False
            e_mail.Body = "Respected Sir/Ma'am " & Environment.NewLine & "This email is to inform you that your request for Internship under " & full_name_teacher & " has been declined." & Environment.NewLine & "Regards" & Environment.NewLine & "Team IITG"

            Dim Smtp_Server As New SmtpClient("smtp.gmail.com")
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New System.Net.NetworkCredential("faculty.information.system2019@gmail.com", "Admin@123")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Send(e_mail)
            'MsgBox("Mail Sent")

        Catch error_t As Exception
            MessageBox.Show("Unable to send Email as Proxy settings are not disabled")
        End Try

        MessageBox.Show("Student Removed")
        Teacher_Homepage.Button2_Click()

        cn.Close()

    End Sub



    Protected Sub updateFunc(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim btn2 As Button = DirectCast(sender, Button)
        Dim name2 As String = btn2.Name
        Dim email2 As String = btn2.Tag

        Dim cn As OleDbConnection = New OleDbConnection(Form_Main.connectString)
        cn.Open()
        Dim selectString As String = "SELECT * FROM Teacher_Info_Table where Username='" & name2 & "'"
        Dim updateString As String = "UPDATE Student_App_Table SET Student_Approved='YES' WHERE Teacher_Username = '" & name2 & "' AND Student_Email = '" & email2 & "';"
        Dim cmd As OleDbCommand = New OleDbCommand(updateString, cn)
        Dim cmd2 As OleDbCommand = New OleDbCommand(selectString, cn)
        cmd.ExecuteNonQuery()
        Dim reader As OleDbDataReader = cmd2.ExecuteReader()

        Dim full_name_teacher As String = " "
        If reader.Read() Then
            full_name_teacher = reader("Full_Name")
        End If

        Dim e_mail As New MailMessage()
        Try
            e_mail = New MailMessage()
            e_mail.From = New MailAddress("faculty.information.system2019@gmail.com")
            e_mail.To.Add(email2)
            e_mail.Subject = "Approval for Internship"
            e_mail.IsBodyHtml = False
            e_mail.Body = "Respected Sir/Ma'am " & Environment.NewLine & "This email is to inform you that your request for Internship under " & full_name_teacher & " has been approved." & Environment.NewLine & "You can now contact the Professor." & Environment.NewLine & "Regards" & Environment.NewLine & "Team IITG"

            Dim Smtp_Server As New SmtpClient("smtp.gmail.com")
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New System.Net.NetworkCredential("faculty.information.system2019@gmail.com", "Admin@123")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Send(e_mail)
            'MsgBox("Mail Sent")

        Catch error_t As Exception
            MessageBox.Show("Unable to send Email as Proxy settings are not disabled")
        End Try



        MessageBox.Show("Student Approved")
        Teacher_Homepage.Button2_Click()

        cn.Close()
    End Sub


    'Function to dynamically allocate new richtextboxes'
    Private Sub outTextAdder(i As Integer, output_name As String, output_email As String, output_college As String, output_degree As String, output_branch As String, output_year As String, output_resume As String, output_description As String, teacher As String)
        Dim txtName As String
        txtName = "txtOutput" & CStr(i)
        Dim approve_name = "Approve" & CStr(i)
        Dim disapprove_name = "Disapprove" & CStr(i)
        Dim x As Integer = 30
        Dim yt As Integer = 30 + 162 * (i - 1)
        Dim txt1 As New TextBox
        Dim app As New Button
        Dim disapp As New Button
        txt1.Multiline = True
        txt1.Name = txtName
        txt1.Width = 370
        txt1.Height = 150
        txt1.ReadOnly = True

        app.Name = teacher
        app.Tag = output_email
        app.Width = 105
        app.Height = 35
        app.Text = "Approve"
        app.Font = New Font("Century Gothic", 11)
        app.BackColor = Color.OrangeRed
        app.ForeColor = Color.White
        app.FlatStyle = FlatStyle.Popup

        disapp.Name = teacher
        disapp.Tag = output_email
        disapp.Width = 105
        disapp.Height = 35
        disapp.Text = "Decline"
        disapp.Font = New Font("Century Gothic", 11)
        disapp.BackColor = Color.OrangeRed
        disapp.ForeColor = Color.White
        disapp.FlatStyle = FlatStyle.Popup
        Me.Controls.Add(txt1)
        Me.Controls.Add(app)
        Me.Controls.Add(disapp)
        AddHandler app.Click, AddressOf updateFunc
        AddHandler disapp.Click, AddressOf updateFunc2
        txt1.Location = New Point(x, yt + 20)
        app.Location = New Point(420, yt + 40)
        disapp.Location = New Point(420, yt + 115)
        txt1.Text = "Name: " & output_name & Environment.NewLine & "Email: " & output_email & Environment.NewLine & "College: " & output_college & Environment.NewLine & "Degree: " & output_degree & Environment.NewLine & "Branch : " & output_branch & Environment.NewLine & "Current Year : " & output_year & Environment.NewLine & "Resume : " & output_resume & Environment.NewLine & "Description : " & output_description
        txt1.Font = New Font("Century Gothic", 10)
        txt1.BackColor = Color.Beige
        txt1.SelectionStart = txt1.Text.Length
        txt1.ScrollToCaret()
        txt1.Refresh()

    End Sub

    Private Sub Interested_Students_User_Control_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Visible = False
        Dim i As Integer = 1
        Dim cn As OleDbConnection = New OleDbConnection(Form_Main.connectString)
        cn.Open()
        Dim selectString As String = "SELECT * FROM Student_App_Table where Teacher_Username='" & Form_Main.input_user & "' AND Student_Approved= 'NO' ORDER BY Student_Name"
        Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()

        While reader.Read()
            'TextBox1.Text = TextBox1.Text & reader("Full_Name") & Environment.NewLine
            Dim output_name As String = reader("Student_Name")
            Dim output_email As String = reader("Student_Email")
            Dim output_college As String = reader("Student_College")
            Dim output_degree As String = reader("Student_Degree")
            Dim output_branch As String = reader("Student_Branch")
            Dim output_year As String = reader("Student_Current_Year")
            Dim output_resume As String = reader("Student_Resume")
            Dim output_description As String = reader("Student_Description")
            Dim teacher As String = reader("Teacher_Username")
            outTextAdder(i, output_name, output_email, output_college, output_degree, output_branch, output_year, output_resume, output_description, teacher)
            i = i + 1

        End While

        If i = 1 Then
            Label2.Visible = True
        End If

        cn.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
