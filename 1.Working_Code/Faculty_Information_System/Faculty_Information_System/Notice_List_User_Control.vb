Imports System.Data.OleDb

Public Class Notice_List_User_Control

    Protected Sub updateFunc2(ByVal sender As Object, ByVal e As System.EventArgs)
        'Add delete Query
        Dim btn2 As Button = DirectCast(sender, Button)
        Dim name2 As String = btn2.Name
        Dim desc2 As String = btn2.Tag

        Dim cn As OleDbConnection = New OleDbConnection(Form_Main.connectString)
        cn.Open()
        Dim deleteString As String = " DELETE FROM Notification_Table WHERE Notice_Description = '" & desc2 & "'  "
        Dim cmd As OleDbCommand = New OleDbCommand(deleteString, cn)
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As Exception

        End Try

        cn.Close()

        MessageBox.Show("Notice Removed")
        Teacher_Homepage.Btn_List_Click()

    End Sub

    'Function to dynamically allocate new richtextboxes'
    Private Sub outTextAdder(i As Integer, tmp As String, tmp2 As String, out_date As String, out_time As String)
        Dim txtName As String
        txtName = "txtOutput" & CStr(i)
        'Incrementing location of textbox
        'Dim yt As Integer = txtOutput1.Location.Y + 25 * (i - 1)
        Dim disapprove_name = "Disapprove" & CStr(i)
        Dim x As Integer = 20
        Dim yt As Integer = 30 + 112 * (i - 1)
        Dim txt1 As New TextBox
        Dim disapp As New Button
        txt1.Multiline = True
        'txt1.AutoScroll = True
        txt1.Name = txtName
        txt1.Width = 430
        txt1.Height = 105
        txt1.ReadOnly = True
        txt1.ScrollBars = ScrollBars.Vertical
        disapp.Name = tmp2
        disapp.Tag = tmp
        disapp.Width = 105
        disapp.Height = 35
        disapp.Text = "Delete"
        disapp.Font = New Font("Century Gothic", 11)
        disapp.BackColor = Color.OrangeRed
        disapp.ForeColor = Color.White
        disapp.FlatStyle = FlatStyle.Popup
        Me.Controls.Add(txt1)
        'Me.Controls.Add(app)
        Me.Controls.Add(disapp)
        'AddHandler app.Click, AddressOf updateFunc
        AddHandler disapp.Click, AddressOf updateFunc2
        txt1.Location = New Point(x, yt + 20)
        txt1.ReadOnly = True
        disapp.Location = New Point(460, yt + 50)
        txt1.Text = tmp
        txt1.Font = New Font("Century Gothic", 11)
        txt1.BackColor = Color.Beige
        txt1.SelectionStart = txt1.Text.Length
        txt1.ScrollToCaret()
        txt1.Refresh()

    End Sub

    Dim index As Integer
    Private Sub Notice_List_User_Control_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Visible = False
        Dim cn As OleDbConnection = New OleDbConnection(Form_Main.connectString)
        cn.Open()
        Dim selectString As String = " SELECT * FROM Notification_Table WHERE Username = '" & Form_Main.input_user & "'  ORDER BY Issue_Date DESC, Issue_Time DESC"
        Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        Dim i As Integer = 1
        While reader.Read()
            Dim output_str As String = reader("Notice_Description")
            Dim output_name As String = reader("Full_Name")
            Dim output_date As String = reader("Issue_Date")
            Dim output_time As String = reader("Issue_Time")
            outTextAdder(i, output_str, output_name, output_date, output_time)
            i = i + 1
        End While
        If i = 1 Then
            Label1.Visible = True
        Else
            Label1.Visible = False
        End If
        cn.Close()
        index = i

    End Sub




    'Private Sub Btn_submit_Click(sender As Object, e As EventArgs) Handles Btn_Submit.Click
    '    For Each cntrl As Control In Me.Controls
    '        If TypeOf cntrl Is CheckBox Then
    '            If DirectCast(cntrl, CheckBox).Checked = True Then
    '                Dim str As String = "txtOutput" & cntrl.Name
    '                Dim temp As String = Me.Controls.Find(str, True)(0).Text
    '                Dim cn As OleDbConnection = New OleDbConnection(Form_Main.connectString)
    '                cn.Open()
    '                Dim deleteString As String = " DELETE FROM Notification_Table WHERE Notice_Description = '" & temp & "' "
    '                Dim cmd As OleDbCommand = New OleDbCommand(deleteString, cn)

    '                Try
    '                    cmd.ExecuteNonQuery()
    '                    cmd.Dispose()
    '                Catch ex As Exception

    '                End Try

    '                cn.Close()
    '            End If
    '        End If
    '    Next

    '    MessageBox.Show("Successfully Deleted")
    '    Teacher_Homepage.Btn_List_Click()

    'End Sub
End Class