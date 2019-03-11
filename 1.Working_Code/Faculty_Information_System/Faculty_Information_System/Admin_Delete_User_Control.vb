Imports System.Data.OleDb
Imports System.Net.Mail
Public Class Admin_Delete_User_Control

    'function to disapprove record
    Protected Sub updateFunc2(ByVal sender As Object, ByVal e As System.EventArgs)

        Dim btn2 As Button = DirectCast(sender, Button)
        Dim name2 As String = btn2.Name
        Dim email2 As String = btn2.Tag

        'sql query to delete the current record from the databse
        Dim cn As OleDbConnection = New OleDbConnection(Form_Main.connectString)
        cn.Open()
        Dim deleteString As String = " DELETE FROM Teacher_Info_Table WHERE Username = '" & name2 & "' "
        Dim cmd As OleDbCommand = New OleDbCommand(deleteString, cn)
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As Exception

        End Try

        'code to email the letter of disapproval to the user
        Dim e_mail As New MailMessage()
        Try
            e_mail = New MailMessage()
            e_mail.From = New MailAddress("faculty.information.system2019@gmail.com")
            e_mail.To.Add(email2)
            e_mail.Subject = "Approval for Internship"
            e_mail.IsBodyHtml = False
            e_mail.Body = "Respected Sir/Ma'am " & Environment.NewLine & "This email is to inform you that your account has been deleted. Contact admin for further details." & Environment.NewLine & "Regards" & Environment.NewLine & "Team IITG"

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

        MessageBox.Show("Record Deleted")
        Form_Admin.Btn_Delete_Click()

        cn.Close()

    End Sub


    'Function to dynamically allocate new textboxes''
    Private Sub outTextAdder(i As Integer, output_name As String, output_email As String, output_college As String, output_degree As String, output_branch As String, teacher As String)

        Dim txtName As String
        'define dynamic textbox and button disapprove
        txtName = "txtOutput" & CStr(i)
        Dim disapprove_name = "Disapprove" & CStr(i)
        'set x and y coordinates for text box and button location
        Dim x As Integer = 30
        Dim yt As Integer = 30 + 112 * (i - 1)
        Dim txt1 As New TextBox
        Dim disapp As New Button
        txt1.Multiline = True
        txt1.Name = txtName
        txt1.Width = 370
        txt1.Height = 110
        txt1.ReadOnly = True

        'set button name as username and button tag a user email
        disapp.Name = teacher
        disapp.Tag = output_email
        disapp.Width = 105
        disapp.Height = 35
        disapp.Text = "Delete"
        disapp.Font = New Font("Century Gothic", 11)
        disapp.BackColor = Color.OrangeRed
        disapp.ForeColor = Color.White
        disapp.FlatStyle = FlatStyle.Popup

        'add the dynmaic tools to the controls
        Me.Controls.Add(txt1)
        Me.Controls.Add(disapp)
        AddHandler disapp.Click, AddressOf updateFunc2
        txt1.Location = New Point(x, yt + 20)
        disapp.Location = New Point(420, yt + 55)
        'output the details of the record
        txt1.Text = "Name: " & output_name & Environment.NewLine & "Email: " & output_email & Environment.NewLine & "Department: " & output_college & Environment.NewLine & "Room Number: " & output_degree & Environment.NewLine & "Contact Number: " & output_branch

        txt1.Font = New Font("Century Gothic", 10)
        txt1.BackColor = Color.Beige
        txt1.SelectionStart = txt1.Text.Length
        txt1.ScrollToCaret()
        txt1.Refresh()

    End Sub


    Private Sub Admin_Delete_User_Control_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label2.Visible = False

        Dim i As Integer = 1
        Dim cn As OleDbConnection = New OleDbConnection(Form_Main.connectString)
        cn.Open()
        Dim selectString As String = "SELECT * FROM Teacher_Info_Table where Approved= 'YES' ORDER BY Full_Name"
        Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()

        'read records with pending approval one by one and form dynamic textboxes to print their record
        While reader.Read()

            Dim output_name As String = reader("Full_Name")
            Dim output_email As String = reader("Email")
            Dim output_college As String = reader("Department")
            Dim output_degree As String = reader("Room_Number")
            Dim output_branch As String = reader("Contact_Number")
            Dim teacher As String = reader("Username")
            'call function to dynamically allocate textboxes and button
            outTextAdder(i, output_name, output_email, output_college, output_degree, output_branch, teacher)
            i = i + 1


        End While

        If i = 1 Then
            Label2.Visible = True ' if no record present
        End If

        cn.Close()
    End Sub
End Class




