Imports System.Data.OleDb
Public Class View_Teacher_User_Control
    Dim CV As String

    Private Sub View_Teacher_User_Control_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        If Form_Main.flag_view = 1 Then
            Apply.Visible = False
        End If
        Dim cn As OleDbConnection = New OleDbConnection(Form_Main.connectString)
        cn.Open()
        Dim str1 As String = Form_Main.input_user

        Dim selectString As String = "SELECT * FROM Teacher_Info_Table WHERE Username='" & str1 & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        'Load the information of prof from database in reader
        If reader.Read() Then
            View_Name.Text = reader("Full_Name")
            View_Department.Text = reader("Department")
            View_Research_Tags.Text = reader("Research_Tag")
            View_Research_Interests.Text = reader("Research_Interest")
            View_Course_Code.Text = reader("Current_Course_Code")
            View_Course.Text = reader("Current_Course_Description")
            View_DOB.Text = reader("DOB")
            View_Room_Number.Text = reader("Room_Number")
            View_Contact_number.Text = reader("Contact_Number")
            View_Email.Text = reader("Email")
            CV = reader("Link_To_Webpage")
            Dim temp As String = Form_Main.Save_Address & "\" & "xxx.jpg"
            If (String.Compare(reader("Image_Address"), "@") = 0) Then

                ImagePictureBox2.BackColor = Color.FromArgb(68, 170, 170)
                ImagePictureBox2.Image = Image.FromFile(temp)

                ImagePictureBox2.SizeMode = PictureBoxSizeMode.Zoom
                cn.Close()
                Return
            End If
            temp = Form_Main.Save_Address & "\" & reader("Image_Address")
            ImagePictureBox2.Image = Image.FromFile(temp)
            ImagePictureBox2.BackColor = Color.FromArgb(68, 170, 170)
            'Form_Main.Save_Address & "\" & Path.GetFileName(imagepath)
            ImagePictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        End If
        cn.Close()
    End Sub

    Private Sub VIew_CV_Click(sender As Object, e As EventArgs) Handles VIew_CV.Click
        If String.Compare(CV, "") = 0 Then
            MessageBox.Show("CV not added by the Faculty")
        Else
            Try
                System.Diagnostics.Process.Start(CV)
            Catch ex As Exception
                MsgBox("Link provided not valid")
            End Try
            'Opens the link to CV in web browser
        End If


    End Sub

    Private Sub Apply_Click(sender As Object, e As EventArgs) Handles Apply.Click
        Form_Main.Hide()
        Form_Internship.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub View_Name_TextChanged(sender As Object, e As EventArgs) Handles View_Name.TextChanged

    End Sub
End Class
