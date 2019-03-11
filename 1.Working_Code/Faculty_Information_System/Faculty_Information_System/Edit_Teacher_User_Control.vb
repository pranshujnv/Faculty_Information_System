Imports System.Data.OleDb
Imports System.IO

Public Class Edit_Teacher_User_Control
    Dim globalimage As String = "@"
    

    Private Sub Edit_Teacher_User_Control_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ImagePictureBox.AllowDrop = True
        '68, 170, 170
        ImagePictureBox.BackColor = Color.FromArgb(68, 170, 170)
        Dim cn As OleDbConnection = New OleDbConnection(Form_Main.connectString)
        cn.Open()
        Dim str1 As String = Form_Main.input_user

        Dim selectString As String = "SELECT * FROM Teacher_Info_Table WHERE Username='" & str1 & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        'Load the information of prof from database in reader
        If reader.Read() Then
            Edit_Name.Text = reader("Full_Name")
            Edit_Department.Text = reader("Department")
            Edit_Research_Tags.Text = reader("Research_Tag")
            Edit_Research_Interests.Text = reader("Research_Interest")
            Edit_Course_Code.Text = reader("Current_Course_Code")
            Edit_Course.Text = reader("Current_Course_Description")
            Edit_DOB.Text = reader("DOB")
            Edit_Room_Number.Text = reader("Room_Number")
            Edit_Contact_number.Text = reader("Contact_Number")
            Edit_Email.Text = reader("Email")
            Edit_CV.Text = reader("Link_To_Webpage")
            Dim temp As String = Form_Main.Save_Address & "\" & "xxx.jpg"
            If (String.Compare(reader("Image_Address"), "@") = 0) Then

                ImagePictureBox.Image = Image.FromFile(temp)

                ImagePictureBox.SizeMode = PictureBoxSizeMode.Zoom
                cn.Close()
                Return
            End If
            temp = Form_Main.Save_Address & "\" & reader("Image_Address")
            ImagePictureBox.Image = Image.FromFile(temp)
            ImagePictureBox.BackColor = Color.FromArgb(68, 170, 170)
            'Form_Main.Save_Address & "\" & Path.GetFileName(imagepath)
            ImagePictureBox.SizeMode = PictureBoxSizeMode.Zoom
        End If
        cn.Close()
    End Sub

    Private Sub Btn_Edit_Submit_Click(sender As Object, e As EventArgs) Handles Btn_Edit_Submit.Click
        'exception handling
        If Not Form_Main.isAlpha(Edit_Name.Text) Then
            MsgBox("Enter Name in alphabets only")
            GoTo ErrExit
        End If
        If Edit_Name.TextLength > 254 Then
            MsgBox("Max allowed Name Length: 254")
            Edit_Name.Text = Edit_Name.Text.Substring(0, 254)
            GoTo ErrExit
        End If
        If Not System.Text.RegularExpressions.Regex.IsMatch(Edit_Course_Code.Text, "^[\s]*([a-z|A-Z]{2}[0-9]{3}[\s]*){0,1}$") Then
            MsgBox("Enter Course Code in format: AB123")
            GoTo ErrExit
        End If
        If Edit_Course_Code.TextLength > 254 Then
            MsgBox("Max allowed Course Code Length: 254")
            Edit_Course_Code.Text = Edit_Course_Code.Text.Substring(0, 254)
            GoTo ErrExit
        End If
        If Not System.Text.RegularExpressions.Regex.IsMatch(Edit_DOB.Text, "^[\s]*[0-9]{2}-[0-9]{2}-[0-9]{4}$") Then
            MsgBox("Enter Date in format: dd-mm-yyyy")
            GoTo ErrExit
        End If
        If Edit_DOB.TextLength > 254 Then
            MsgBox("Max allowed Date Length: 254")
            Edit_DOB.Text = Edit_DOB.Text.Substring(0, 254)
            GoTo ErrExit
        End If
        If Not System.Text.RegularExpressions.Regex.IsMatch(Edit_Room_Number.Text, "^[\s]*([a-z|A-Z]-[0-9]{3}[\s]*){0,1}$") Then
            MsgBox("Enter Room Number in format: A-123")
            GoTo ErrExit
        End If
        If Edit_Room_Number.TextLength > 254 Then
            MsgBox("Max allowed Room Number Length: 254")
            Edit_Room_Number.Text = Edit_Room_Number.Text.Substring(0, 254)
            GoTo ErrExit
        End If
        If Not System.Text.RegularExpressions.Regex.IsMatch(Edit_Contact_number.Text, "^[\s]*[+]{0,1}[0-9][0-9|\-]*[0-9][\s]*$") Then
            MsgBox("Enter Contact Number in standard format [use digits from 0-9]")
            GoTo ErrExit
        End If
        If Edit_Contact_number.TextLength > 254 Then
            MsgBox("Max allowed Contact Number Length: 254")
            Edit_Contact_number.Text = Edit_Contact_number.Text.Substring(0, 254)
            GoTo ErrExit
        End If
        If Not System.Text.RegularExpressions.Regex.IsMatch(Edit_Email.Text, "^[\s]*[^@|\s]+@iitg.ac.in[\s]*$") Then
            MsgBox("Enter IITG email address(ending in @iitg.ac.in)")
            GoTo ErrExit
        End If
        If Edit_Email.TextLength > 254 Then
            MsgBox("Max allowed email address Length: 254")
            Edit_Email.Text = Edit_Email.Text.Substring(0, 254)
            GoTo ErrExit
        End If

        Dim cn As OleDbConnection = New OleDbConnection(Form_Main.connectString)
        cn.Open()
        Dim full_name As String = Edit_Name.Text.Trim()
        Dim str1 As String = Form_Main.input_user
        Dim updateString As String = "UPDATE Teacher_Info_Table SET Full_Name='" & full_name & "', Department='" & Edit_Department.Text.Trim() & "', Email='" & Edit_Email.Text.Trim() & "', Room_Number='" & Edit_Room_Number.Text.Trim() & "', Contact_Number='" & Edit_Contact_number.Text.Trim() & "', Research_Tag='" & Edit_Research_Tags.Text.Trim() & "', Research_Interest='" & Edit_Research_Interests.Text.Trim() & "', Current_Course_Code='" & Edit_Course_Code.Text.Trim() & "', Current_Course_Description='" & Edit_Course.Text.Trim() & "', DOB='" & Edit_DOB.Text.Trim() & "', Link_To_Webpage='" & Edit_CV.Text.Trim() & "' WHERE Username = '" & str1 & "';"
        Dim cmd As OleDbCommand = New OleDbCommand(updateString, cn)
        cmd.ExecuteNonQuery()
        cn.Close()

        Dim cn2 As OleDbConnection = New OleDbConnection(Form_Main.connectString)
        cn2.Open()
        Dim updateString2 As String = "UPDATE Notification_Table SET Full_Name='" & full_name & "', Department='" & Edit_Department.Text & "' WHERE Username = '" & str1 & "';"
        Dim cmd2 As OleDbCommand = New OleDbCommand(updateString2, cn2)
        cmd2.ExecuteNonQuery()
        cn2.Close()
ErrExit:
    End Sub


    Private Sub ImagePictureBox_DragDrop(sender As Object, e As DragEventArgs) Handles ImagePictureBox.DragDrop


        Dim imagesDragDrop As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())
        Dim extension As String
        For Each imagepath As String In imagesDragDrop
            extension = Path.GetExtension(imagepath)
            If (extension = ".jpg" Or extension = ".jpeg" Or extension = ".png" Or extension = ".gif" Or extension = ".ico") Then

                If ImagePictureBox.Image Is Nothing Then
                Else
                    ImagePictureBox.Image.Dispose()

                End If
                Try
                    ImagePictureBox.Image = Image.FromFile(imagepath)
                    ImagePictureBox.Image.Save(Form_Main.Save_Address & "\" & Form_Main.input_user & ".jpg")
                    ImagePictureBox.SizeMode = PictureBoxSizeMode.Zoom
                    Dim str1 As String = Form_Main.input_user
                    Dim cn As OleDbConnection = New OleDbConnection(Form_Main.connectString)
                    globalimage = Form_Main.input_user & ".jpg"
                    cn.Open()
                    Dim updateString As String = "UPDATE Teacher_Info_Table SET [Image_Address]='" & globalimage & "' WHERE [Username] = '" & str1 & "';"
                    ImagePictureBox.BackColor = Color.FromArgb(68, 170, 170)
                    Dim cmd As OleDbCommand = New OleDbCommand(updateString, cn)
                    cmd.ExecuteNonQuery()
                    cn.Close()
                Catch ex As Exception
                    MessageBox.Show("Memory Needs some time to Dispose")
                End Try
            Else
                MessageBox.Show("Please Drag and Drop an image")
            End If
        Next

    End Sub
    Private Sub ImagePictureBox_DragEnter(sender As Object, e As DragEventArgs) Handles ImagePictureBox.DragEnter

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If


    End Sub
    Private Sub Browse_Click(sender As Object, e As EventArgs) Handles Browse.Click
        If (OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Dim selected_image As String = OpenFileDialog1.FileName

            'MessageBox.Show(selected_image)
            'Dim str1 As String = Form_Main.input_user
            'Dim updateString As String = "UPDATE Teacher_Info_Table SET Image_Address='" & globalimage & "' WHERE Username = '" & str1 & "';"
            'Dim updateString As String = "UPDATE Teacher_Info_Table SET Full_Name='" & full_name & "', Department='" & Edit_Department.Text & "', Email='" & Edit_Email.Text & "', Room_Number='" & Edit_Room_Number.Text & "', Contact_Number='" & Edit_Contact_number.Text & "', Research_Tag='" & Edit_Research_Tags.Text & "', Research_Interest='" & Edit_Research_Interests.Text & "', Current_Course_Code='" & Edit_Course_Code.Text & "', Current_Course_Description='" & Edit_Course.Text & "', DOB='" & Edit_DOB.Text & "', Link_To_Webpage='" & Edit_CV.Text & "' WHERE Username = '" & str1 & "';"
            Dim extension As String = Path.GetExtension(selected_image)
            If (extension = ".jpg" Or extension = ".jpeg" Or extension = ".png" Or extension = ".gif" Or extension = ".ico") Then

                If ImagePictureBox.Image Is Nothing Then
                Else
                    ImagePictureBox.Image.Dispose()

                End If

                'If File.Exists(Form_Main.Save_Address & "\" & Form_Main.input_user & ".jpg") Then
                'My.Computer.FileSystem.DeleteFile(Form_Main.Save_Address & "\" & Form_Main.input_user & ".jpg", Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, Microsoft.VisualBasic.FileIO.RecycleOption.SendToRecycleBin)
                'End If
                Try
                    ImagePictureBox.Image = Image.FromFile(selected_image)
                    ImagePictureBox.Image.Save(Form_Main.Save_Address & "\" & Form_Main.input_user & ".jpg")
                    ImagePictureBox.SizeMode = PictureBoxSizeMode.Zoom
                    Dim str1 As String = Form_Main.input_user
                    Dim cn As OleDbConnection = New OleDbConnection(Form_Main.connectString)
                    globalimage = Form_Main.input_user & ".jpg"
                    cn.Open()
                    Dim updateString As String = "UPDATE Teacher_Info_Table SET [Image_Address]='" & globalimage & "' WHERE [Username] = '" & str1 & "';"
                    ImagePictureBox.BackColor = Color.FromArgb(68, 170, 170)
                    Dim cmd As OleDbCommand = New OleDbCommand(updateString, cn)
                    cmd.ExecuteNonQuery()
                    cn.Close()


                Catch ex As Exception

                    MessageBox.Show("Memory Needs some time to Dispose")
                End Try
            Else
                MessageBox.Show("Please Choose an Image")
            End If
        End If
    End Sub

    Private Sub ImagePictureBox_Click(sender As Object, e As EventArgs) Handles ImagePictureBox.Click

    End Sub
End Class
