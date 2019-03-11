
Imports System.Data.OleDb
Imports System.Net.Mail

'shows records with pending approval
Public Class Admin_Approval_User_Control


    'Approve button function
    Protected Sub updateFunc(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        Dim name As String = btn.Name
        Dim email_to As String = btn.Tag
        Dim cn As OleDbConnection = New OleDbConnection(Form_Main.connectString)
        cn.Open()
        'sets approved filed as yes
        Dim updateString As String = "UPDATE Teacher_Info_Table SET Approved='YES' WHERE Username = '" & name & "';"
        Dim cmd As OleDbCommand = New OleDbCommand(updateString, cn)
        cmd.ExecuteNonQuery()
        cn.Close()
        'code to send approval email to the user
        Dim e_mail As New MailMessage()
        Try
            e_mail = New MailMessage()
            e_mail.From = New MailAddress("faculty.information.system2019@gmail.com")
            e_mail.To.Add(email_to)
            e_mail.Subject = "Approval for Faculty Login"
            e_mail.IsBodyHtml = False
            e_mail.Body = "Respected Sir/Ma'am " & Environment.NewLine & "This email is to inform you that your request for IITG Faculty Login has been approved" & Environment.NewLine & "May you have a Wonderful experience." & Environment.NewLine & "Regards" & Environment.NewLine & "Team IITG"

            Dim Smtp_Server As New SmtpClient("smtp.gmail.com")
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New System.Net.NetworkCredential("faculty.information.system2019@gmail.com", "Admin@123")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Send(e_mail)
            'Shows message box in case email is not sent
        Catch error_t As Exception
            MessageBox.Show("Unable to send Email as Proxy settings are not disabled")
        End Try

        MessageBox.Show("Approved")
        'Form_Main.flag_admin = 1
        Form_Admin.Btn_Approval_Click()
    End Sub
    'function to disapprove record
    Protected Sub updateFunc2(ByVal sender As Object, ByVal e As System.EventArgs)

        Dim btn2 As Button = DirectCast(sender, Button)
        Dim name2 As String = btn2.Name
        Dim email_to2 As String = btn2.Tag
        'sql query to delete the current record from the databse
        Dim cn As OleDbConnection = New OleDbConnection(Form_Main.connectString)
        cn.Open()
        Dim deleteString As String = " DELETE FROM Teacher_Info_Table WHERE Username = '" & name2 & "'  "
        Dim cmd As OleDbCommand = New OleDbCommand(deleteString, cn)
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As Exception

        End Try
        '

        cn.Close()
        'code to email the letter of disapproval to the user
        Dim e_mail As New MailMessage()
        Try

            e_mail = New MailMessage()
            e_mail.From = New MailAddress("faculty.information.system2019@gmail.com")
            e_mail.To.Add(email_to2)
            e_mail.Subject = "Approval for Faculty Lcogin"
            e_mail.IsBodyHtml = False
            e_mail.Body = "Respected Sir/Ma'am " & Environment.NewLine & "This email is to inform you that your request for IITG Faculty Login has been disapproved" & Environment.NewLine & "Regards" & Environment.NewLine & "Team IITG"

            Dim Smtp_Server As New SmtpClient("smtp.gmail.com")
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New System.Net.NetworkCredential("faculty.information.system2019@gmail.com", "Admin@123")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Send(e_mail)

            'Shows message box in case email is not sent
        Catch error_t As Exception
            MessageBox.Show("Unable to send Email as Proxy settings are not disabled")
        End Try

        MessageBox.Show("Disapproved")
        Form_Admin.Btn_Approval_Click()
    End Sub

    'Function to dynamically allocate new textboxes'
    Private Sub outTextAdder(i As Integer, output_name As String, output_dept As String, output_email As String, output_room As String, output_contact As String, output_user As String)
        Dim txtName As String
        'define dynamic textbox and two buttons for approve and disapprove
        txtName = "txtOutput" & CStr(i)
        Dim approve_name = "Approve" & CStr(i)
        Dim disapprove_name = "Disapprove" & CStr(i)
        'set x and y coordinates for text box and button location
        Dim x As Integer = 10
        Dim yt As Integer = 10 + 122 * (i - 1)
        Dim txt1 As New TextBox
        Dim app As New Button
        Dim disapp As New Button
        txt1.Multiline = True
        txt1.Name = txtName
        txt1.Width = 350
        txt1.Height = 120
        txt1.ReadOnly = True
        txt1.ScrollBars = ScrollBars.Vertical
        app.Name = output_user
        app.Tag = output_email
        app.Width = 120
        app.Height = 40
        app.Text = "Approve"
        app.Font = New Font("Century Gothic", 11)
        app.BackColor = Color.OrangeRed
        app.ForeColor = Color.White
        app.FlatStyle = FlatStyle.Popup
        'set button name as username and button tag a user email
        disapp.Name = output_user
        disapp.Width = 120
        disapp.Height = 40
        disapp.Tag = output_email
        disapp.Text = "Disapprove"
        disapp.Font = New Font("Century Gothic", 11)
        disapp.BackColor = Color.OrangeRed
        disapp.ForeColor = Color.White
        disapp.FlatStyle = FlatStyle.Popup
        'add the dynmaic tools to the controls
        Me.Controls.Add(txt1)
        Me.Controls.Add(app)
        Me.Controls.Add(disapp)
        AddHandler app.Click, AddressOf updateFunc
        AddHandler disapp.Click, AddressOf updateFunc2
        txt1.Location = New Point(x, yt)
        app.Location = New Point(370, yt + 15)
        disapp.Location = New Point(370, yt + 70)
        'output the details of the record
        txt1.Text = "Name: " & output_name & Environment.NewLine & "Department: " & output_dept & Environment.NewLine & "Room Number: " & output_room & Environment.NewLine & "Email: " & output_email & Environment.NewLine & "Contact NUmber : " & output_contact
        txt1.Font = New Font("Century Gothic", 11)
        txt1.BackColor = Color.Beige
        txt1.SelectionStart = txt1.Text.Length
        txt1.ScrollToCaret()
        txt1.Refresh()

    End Sub

    Private Sub Admin_Approval_User_Control_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Visible = False
        Dim i As Integer = 1

   
        Dim cn As OleDbConnection = New OleDbConnection(Form_Main.connectString)
        cn.Open()
        Dim selectString As String = "SELECT * FROM Teacher_Info_Table WHERE Approved='NO' ORDER BY Full_Name"
        Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        'read records with pending approval one by one and form dynamic textboxes to print their record
        While reader.Read()

            Dim output_user As String = reader("Username")
            Dim output_name As String = reader("Full_Name")
            Dim output_dept As String = reader("Department")
            Dim output_email As String = reader("Email")
            Dim output_room As String = reader("Room_Number")
            Dim output_contact As String = reader("Contact_Number")

            outTextAdder(i, output_name, output_dept, output_email, output_room, output_contact, output_user)
            i = i + 1

        End While
            If i = 1 Then
            Label2.Visible = True 'in case no record present for approval 
            Else
                Label2.Visible = False
        End If
        cn.Close()


    End Sub

End Class