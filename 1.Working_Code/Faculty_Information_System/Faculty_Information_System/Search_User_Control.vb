Imports System.Data.OleDb


Public Class Search_User_Control
    Public vtuc3 As New View_Teacher_User_Control
    Private Sub Search_User_Control_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Dept.Items.Count > 0 Then
            Dept.SelectedIndex = 0    ' The first item has index 0 '
        End If
        If Research_Interest.Items.Count > 0 Then
            Research_Interest.SelectedIndex = 0    ' The first item has index 0 '
        End If

        Search_Panel.Visible = False
        Back_Button.Visible = False
        ListBox2.Visible = False
    End Sub
    Private Sub Search_Click_Click(sender As Object, e As EventArgs) Handles Search_Click.Click
        Dim cn As OleDbConnection = New OleDbConnection(Form_Main.connectString)
        cn.Open()
        Dim str1 As String = Name2.Text.Trim()
        Dim str2 As String = Dept.Text.Trim()
        Dim str3 As String = Research_Interest.Text.Trim()
        Dim str4 As String = Course.Text.Trim()

        Dim selectString As String

        'Exception handling
        If Not Form_Main.isAlpha(Name2.Text) Then
            MsgBox("Enter Name in alphabets")
            GoTo ErrExit
        End If
        If Name2.TextLength > 254 Then
            MsgBox("Max allowed Name Length: 254")
            Name2.Text = Name2.Text.Substring(0, 254)
            GoTo ErrExit
        End If
        'If Not System.Text.RegularExpressions.Regex.IsMatch(Course.Text, "^[\s]*([a-z|A-Z]{2}[0-9]{3}[\s]*){0,1}$") Then
        '    MsgBox("Enter Course Code in format: AB123")
        '    GoTo ErrExit
        'End If

        If Not System.Text.RegularExpressions.Regex.IsMatch(Course.Text, "^[\s]*([a-z|A-Z]{2}[0-9]{3}[\s]*){0,1}$") Then
            MsgBox("Enter Course Code in format: AB123")
            GoTo ErrExit
        End If
        If Course.TextLength > 254 Then
            MsgBox("Max allowed Course Length: 254")
            Course.Text = Course.Text.Substring(0, 254)
            GoTo ErrExit
        End If

        If String.Compare(str1, "") = 0 And String.Compare(str2, "None") = 0 And String.Compare(str4, "") = 0 And String.Compare(str3, "None") = 0 Then
            selectString = "SELECT * FROM Teacher_Info_Table WHERE Approved='YES' ORDER BY Full_Name"

        ElseIf String.Compare(str1, "") = 0 And String.Compare(str2, "None") = 0 And String.Compare(str4, "") = 0 Then
            selectString = "SELECT * FROM Teacher_Info_Table WHERE Research_Tag='" & str3 & "' AND Approved='YES' ORDER BY Full_Name"

        ElseIf String.Compare(str1, "") = 0 And String.Compare(str3, "None") = 0 And String.Compare(str4, "") = 0 Then
            selectString = "SELECT * FROM Teacher_Info_Table WHERE Department='" & str2 & "' AND Approved='YES' ORDER BY Full_Name"

        ElseIf String.Compare(str2, "None") = 0 And String.Compare(str3, "None") = 0 And String.Compare(str4, "") = 0 Then
            selectString = "SELECT * FROM Teacher_Info_Table WHERE Full_Name like '%" & str1 & "%' AND Approved='YES' ORDER BY Full_Name"

        ElseIf String.Compare(str2, "None") = 0 And String.Compare(str3, "None") = 0 And String.Compare(str1, "") = 0 Then
            selectString = "SELECT * FROM Teacher_Info_Table WHERE Current_Course_Code ='" & str4 & "' AND Approved='YES' ORDER BY Full_Name"

        ElseIf String.Compare(str1, "") = 0 And String.Compare(str2, "None") = 0 Then
            selectString = "SELECT * FROM Teacher_Info_Table WHERE Research_Tag='" & str3 & "' AND Current_Course_Code ='" & str4 & "' AND Approved='YES' ORDER BY Full_Name"

        ElseIf String.Compare(str1, "") = 0 And String.Compare(str3, "None") = 0 Then
            selectString = "SELECT * FROM Teacher_Info_Table WHERE Department='" & str2 & "' AND Current_Course_Code ='" & str4 & "' AND Approved='YES' ORDER BY Full_Name"

        ElseIf String.Compare(str2, "None") = 0 And String.Compare(str3, "None") = 0 Then
            selectString = "SELECT * FROM Teacher_Info_Table WHERE Full_Name like '%" & str1 & "%' AND Current_Course_Code ='" & str4 & "' AND Approved='YES' ORDER BY Full_Name"

        ElseIf String.Compare(str1, "") = 0 And String.Compare(str4, "") = 0 Then
            selectString = "SELECT * FROM Teacher_Info_Table WHERE Department= '" & str2 & "' AND Research_Tag='" & str3 & "' AND Approved='YES' ORDER BY Full_Name"

        ElseIf String.Compare(str2, "None") = 0 And String.Compare(str4, "") = 0 Then
            selectString = "SELECT * FROM Teacher_Info_Table WHERE Full_Name like '%" & str1 & "%' AND Research_Tag='" & str3 & "' AND Approved='YES' ORDER BY Full_Name"

        ElseIf String.Compare(str3, "None") = 0 And String.Compare(str4, "") = 0 Then
            selectString = "SELECT * FROM Teacher_Info_Table WHERE Full_Name like '%" & str1 & "%' AND Department= '" & str2 & "' AND Approved='YES' ORDER BY Full_Name"

        ElseIf String.Compare(str1, "") = 0 Then
            selectString = "SELECT * FROM Teacher_Info_Table WHERE Department= '" & str2 & "' AND Research_Tag='" & str3 & "' AND Current_Course_Code ='" & str4 & "' AND Approved='YES' ORDER BY Full_Name"
        ElseIf String.Compare(str2, "None") = 0 Then
            selectString = "SELECT * FROM Teacher_Info_Table WHERE Full_Name like '%" & str1 & "%' AND Research_Tag='" & str3 & "' AND Current_Course_Code ='" & str4 & "' AND Approved='YES' ORDER BY Full_Name"
        ElseIf String.Compare(str3, "None") = 0 Then
            selectString = "SELECT * FROM Teacher_Info_Table WHERE Full_Name like '%" & str1 & "%' AND Department= '" & str2 & "' AND Current_Course_Code ='" & str4 & "' AND Approved='YES' ORDER BY Full_Name"
        ElseIf String.Compare(str4, "") = 0 Then
            selectString = "SELECT * FROM Teacher_Info_Table WHERE Full_Name like '%" & str1 & "%' AND Department= '" & str2 & "' AND Research_Tag='" & str3 & "' AND Approved='YES' ORDER BY Full_Name"
        Else
            selectString = "SELECT * FROM Teacher_Info_Table WHERE Full_Name like '%" & str1 & "%' AND Department= '" & str2 & "' AND Research_Tag='" & str3 & "' AND Current_Course_Code ='" & str4 & "' AND Approved='YES' ORDER BY Full_Name"
        End If
        Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()

        While reader.Read()
            ListBox1.Items.Add(reader("Full_Name") & " - " & reader("Email"))
            ListBox2.Items.Add(reader("Username"))


        End While
        cn.Close()
ErrExit:

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.MouseDoubleClick

        Me.ListBox2.Padding = New Padding(15)
        ListBox2.SelectedIndex = ListBox1.SelectedIndex
        Form_Main.input_user = ListBox2.GetItemText(ListBox2.SelectedItem)
        If String.Compare(Form_Main.input_user, "") = 0 Then
            Return
        End If
        Form_Main.Btn_HomePge.Visible = False
        Form_Main.Btn_Signup.Visible = False
        Form_Main.Btn_Teacher_Login.Visible = False
        Form_Main.Btn_Search.Visible = False
        Form_Main.Btn_Notification.Visible = False
        Form_Main.Btn_Admin.Visible = False
        Form_Main.Scroll_Panel.Visible = False
        Teacher_Homepage.Btn_View.Visible = False
        Teacher_Homepage.Btn_Edit.Visible = False
        Teacher_Homepage.Btn_Notice.Visible = False
        Teacher_Homepage.Button1.Visible = False
        Teacher_Homepage.Change_Password.Visible = False
        Teacher_Homepage.Btn_List.Visible = False
        Teacher_Homepage.Button2.Visible = False
        Teacher_Homepage.Btn_Approved.Visible = False
        Teacher_Homepage.Btn_Logout.Visible = False
        Teacher_Homepage.Scroll_Panel.Visible = False

        Back_Button.Visible = True
        Search_Panel.Controls.Clear()
        vtuc3 = New View_Teacher_User_Control
        Search_Panel.Controls.Add(vtuc3)
        Search_Panel.Visible = True
        Back_Button.Visible = True
    End Sub


    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        vtuc3.ImagePictureBox2.Image.Dispose()
        Form_Admin.Scroll_Panel.Visible = True
        Search_Panel.Visible = False
        Back_Button.Visible = False
        Form_Main.Btn_HomePge.Visible = True
        Form_Main.Btn_Signup.Visible = True
        Form_Main.Btn_Teacher_Login.Visible = True
        Form_Main.Btn_Search.Visible = True
        Form_Main.Btn_Notification.Visible = True
        Form_Main.Btn_Admin.Visible = True
        Form_Main.Scroll_Panel.Visible = True

        Teacher_Homepage.Btn_View.Visible = True
        Teacher_Homepage.Btn_Edit.Visible = True
        Teacher_Homepage.Btn_Notice.Visible = True
        Teacher_Homepage.Button1.Visible = True
        Teacher_Homepage.Change_Password.Visible = True
        Teacher_Homepage.Btn_List.Visible = True
        Teacher_Homepage.Button2.Visible = True
        Teacher_Homepage.Btn_Approved.Visible = True
        Teacher_Homepage.Btn_Logout.Visible = True
        Teacher_Homepage.Scroll_Panel.Visible = True
        ListBox1.ClearSelected()
    End Sub

    

End Class
