Imports System.Data.OleDb

Public Class Admin_Edit_User_Control
    Dim etuc1 As New Edit_Teacher_User_Control

    Private Sub Admin_Edit_User_Control_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Dept.Items.Count > 0 Then
            Dept.SelectedIndex = 0    ' The first item has index 0 '
        End If
        If Research_Interest.Items.Count > 0 Then
            Research_Interest.SelectedIndex = 0    ' The first item has index 0 '
        End If
        Label2.Visible = False
        Label1.Visible = False
        Search_Panel.Visible = False
        Back_Button.Visible = False
        ListBox2.Visible = False

        Dim cn As OleDbConnection = New OleDbConnection(Form_Main.connectString)
        cn.Open()

        Dim selectString As String
        selectString = "SELECT * FROM Teacher_Info_Table WHERE Approved='YES'"

        Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        Dim i As Integer = 1
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()

            While reader.Read()
                i = i + 1
            End While
        If i <> 1 Then
            Label1.Visible = True
        Else
            Label2.Visible = True
        End If
       
        cn.Close()
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
        Form_Admin.Btn_Delete.Visible = False
        Form_Admin.Btn_Approval.Visible = False
        Form_Admin.Button1.Visible = False
        Form_Admin.Btn_Edit.Visible = False
        Form_Admin.Scroll_Panel.Visible = False
        Back_Button.Visible = True
        Search_Panel.Controls.Clear()
        etuc1 = New Edit_Teacher_User_Control
        Search_Panel.Controls.Add(etuc1)
        Search_Panel.Visible = True
        Back_Button.Visible = True
    End Sub


    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Form_Admin.Btn_Approval.Visible = True
        Form_Admin.Btn_Delete.Visible = True
        Form_Admin.Button1.Visible = True
        Form_Admin.Btn_Edit.Visible = True
        Form_Admin.Scroll_Panel.Visible = True
        Search_Panel.Visible = False
        Back_Button.Visible = False
        ListBox1.ClearSelected()
        If etuc1.ImagePictureBox.Image Is Nothing Then
        Else
            etuc1.ImagePictureBox.Image.Dispose()
        End If
    End Sub


    Private Sub Search_Panel_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Search_Panel_Paint_1(sender As Object, e As PaintEventArgs) Handles Search_Panel.Paint

    End Sub
End Class
