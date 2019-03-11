Imports System.Data.OleDb

Public Class Form_Main
    Public Function isAlpha(ByVal letterChar As String) As Boolean
        Return System.Text.RegularExpressions.Regex.IsMatch(letterChar, "^[A-Z|a-z|\s|.|']*$") 'flag
    End Function
    Public input_user As String
    Public str_notification As String
    Public forget_user As String
    Public flag_admin As Integer = 0
    Public flag_Panel_Login As String = "0"
    'Global variables to be used accross the project
    Public connectString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Teacher_Database.accdb"
    'Connection string with relative address
    Public Save_Address As String = System.IO.Path.GetFullPath(Application.StartupPath & "\..\..\Images_Profile")
    'Adress to store profile pic
    Public flag_view As Integer = 0
    Private Sub Form_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Scroll_Panel.Visible = False
        Btn_HomePge_Click()

    End Sub

    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click
        'flag_admin = 0
        Scroll_Panel.Visible = True
        Scroll_Panel.Height = Btn_Search.Height
        Scroll_Panel.Top = Btn_Search.Top
        Output_Panel.Controls.Clear()
        Output_Panel.Controls.Add(New Search_User_Control)
        'Loads search user control for search for searching through database

    End Sub

    Private Sub Btn_Teacher_Login_Click(sender As Object, e As EventArgs) Handles Btn_Teacher_Login.Click
        'flag_admin = 0
        Scroll_Panel.Visible = True
        Scroll_Panel.Height = Btn_Teacher_Login.Height
        Scroll_Panel.Top = Btn_Teacher_Login.Top
        Output_Panel.Controls.Clear()
        Output_Panel.Controls.Add(New Login_USer_Control)
        'Loads login user control for personal homepage of teacher, editing and other features
    End Sub

    Private Sub Btn_Signup_Click(sender As Object, e As EventArgs) Handles Btn_Signup.Click
        'flag_admin = 0
        Scroll_Panel.Visible = True
        Scroll_Panel.Height = Btn_Signup.Height
        Scroll_Panel.Top = Btn_Signup.Top
        Output_Panel.Controls.Clear()
        Output_Panel.Controls.Add(New Register_User_Control)
        'Loads signup user control
    End Sub

    Private Sub Btn_Notification_Click(sender As Object, e As EventArgs) Handles Btn_Notification.Click
        'flag_admin = 0
        Scroll_Panel.Visible = True
        Scroll_Panel.Height = Btn_Notification.Height
        Scroll_Panel.Top = Btn_Notification.Top
        Output_Panel.Controls.Clear()
        Output_Panel.Controls.Add(New Notification_User_Control)
        'Loads Notification user control
    End Sub

    Public Sub Btn_Admin_Click() Handles Btn_Admin.Click
        Scroll_Panel.Visible = True
        Scroll_Panel.Height = Btn_Admin.Height
        Scroll_Panel.Top = Btn_Admin.Top
        Output_Panel.Controls.Clear()
        Output_Panel.Controls.Add(New Admin_User_Control)
        'Loads Admin user control for approval of new registrations
    End Sub


    Public Sub Btn_HomePge_Click() Handles Btn_HomePge.Click
        'flag_admin = 0
        Scroll_Panel.Visible = True
        Scroll_Panel.Height = Btn_HomePge.Height
        Scroll_Panel.Top = Btn_HomePge.Top
        Output_Panel.Controls.Clear()
        Output_Panel.Controls.Add(New HomePage_User_Control)
        'Redirects to homepage
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'For exiting the program
        Dim result As Integer = MessageBox.Show("Are you sure you want to Exit ?", "caption", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
        ElseIf result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class
