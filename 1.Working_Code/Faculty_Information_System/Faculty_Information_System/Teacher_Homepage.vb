Imports System.Data.OleDb
Public Class Teacher_Homepage


    Dim vtuc As New View_Teacher_User_Control
    Dim etuc As New Edit_Teacher_User_Control
    'Global user control, mainly for disposing
    Private Sub Teacher_Homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim cn As OleDbConnection = New OleDbConnection(Form_Main.connectString)
        cn.Open()
        Dim str1 As String = Form_Main.input_user

        Dim selectString As String = "SELECT * FROM Teacher_Info_Table WHERE Username='" & str1 & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        If reader.Read() Then
            Dim name As String = reader("Full_Name")
            Label1.Text = "Hello, " & name
        End If
        'Load the homepage of user who logs in 
    End Sub

    Private Sub Btn_Edit_Click(sender As Object, e As EventArgs) Handles Btn_Edit.Click
        If vtuc.ImagePictureBox2.Image Is Nothing Then
        Else
            vtuc.ImagePictureBox2.Image.Dispose()

        End If
        If etuc.ImagePictureBox.Image Is Nothing Then
        Else
            etuc.ImagePictureBox.Image.Dispose()

        End If
        'DIspose previous images loaded to be able to overwrite them

        Scroll_Panel.Visible = True
        Scroll_Panel.Height = Btn_Edit.Height
        Scroll_Panel.Top = Btn_Edit.Top
        Panel1.Controls.Clear()
        etuc = New Edit_Teacher_User_Control
        Panel1.Controls.Add(etuc)
        'Loads Edit user control

    End Sub

    Private Sub Btn_View_Click(sender As Object, e As EventArgs) Handles Btn_View.Click
        If vtuc.ImagePictureBox2.Image Is Nothing Then
        Else
            vtuc.ImagePictureBox2.Image.Dispose()

        End If
        If etuc.ImagePictureBox.Image Is Nothing Then
        Else
            etuc.ImagePictureBox.Image.Dispose()

        End If

        Scroll_Panel.Visible = True
        Scroll_Panel.Height = Btn_View.Height
        Scroll_Panel.Top = Btn_View.Top
        Panel1.Controls.Clear()
        vtuc = New View_Teacher_User_Control
        Panel1.Controls.Add(vtuc)
        'Loads view user control
    End Sub

    Private Sub Btn_Notice_Click(sender As Object, e As EventArgs) Handles Btn_Notice.Click
        Scroll_Panel.Visible = True
        Scroll_Panel.Height = Btn_Notice.Height
        Scroll_Panel.Top = Btn_Notice.Top
        Panel1.Controls.Clear()
        Panel1.Controls.Add(New Notice_User_Control)
        'Loads the notice user control. Teacher can declare notice which can be seen by everyone
    End Sub

    Private Sub Btn_Logout_Click(sender As Object, e As EventArgs) Handles Btn_Logout.Click

        Dim result As Integer = MessageBox.Show("Do you want to Logout ?", "caption", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
        ElseIf result = DialogResult.Yes Then
            If vtuc.ImagePictureBox2.Image Is Nothing Then
            Else
                vtuc.ImagePictureBox2.Image.Dispose()

            End If
            If etuc.ImagePictureBox.Image Is Nothing Then
            Else
                etuc.ImagePictureBox.Image.Dispose()

            End If
            Scroll_Panel.Visible = True
            Scroll_Panel.Height = Btn_Logout.Height
            Scroll_Panel.Top = Btn_Logout.Top
            Panel1.Controls.Clear()
            Form_Main.flag_view = 0
            Form_Main.Show()
            Me.Close()
        End If
        'To go back to homepage
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        
        Scroll_Panel.Visible = True
        Scroll_Panel.Height = Button1.Height
        Scroll_Panel.Top = Button1.Top
        Panel1.Controls.Clear()

        Panel1.Controls.Add(New Search_User_Control)
        ' To search as a teacher. removes the feature to apply for internship
    End Sub

    Private Sub Change_Password_Click(sender As Object, e As EventArgs) Handles Change_Password.Click
        Scroll_Panel.Visible = True
        Scroll_Panel.Height = Change_Password.Height
        Scroll_Panel.Top = Change_Password.Top
        Panel1.Controls.Clear()
        Panel1.Controls.Add(New Change_Password_User_Control)
        'Loads change passwd user control
    End Sub

    Public Sub Btn_List_Click() Handles Btn_List.Click
        Scroll_Panel.Visible = True
        Scroll_Panel.Height = Btn_List.Height
        Scroll_Panel.Top = Btn_List.Top
        Panel1.Controls.Clear()
        Panel1.Controls.Add(New Notice_List_User_Control)
        'Loads Notice List user control
    End Sub


    Public Sub Button2_Click() Handles Button2.Click
        Scroll_Panel.Visible = True
        Scroll_Panel.Height = Button2.Height
        Scroll_Panel.Top = Button2.Top
        Panel1.Controls.Clear()
        Panel1.Controls.Add(New Interested_Students_User_Control)
        'Loads list of all the students who applied for internship unuder the prof
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Public Sub Btn_Approved_Click() Handles Btn_Approved.Click
        Scroll_Panel.Visible = True
        Scroll_Panel.Height = Btn_Approved.Height
        Scroll_Panel.Top = Btn_Approved.Top
        Panel1.Controls.Clear()
        Panel1.Controls.Add(New Approved_User_Control)
        'Loads the list of approved students
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class