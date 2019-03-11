Imports System.Data.OleDb

Public Class Notice_User_Control

    Private Sub Btn_Notice_Click(sender As Object, e As EventArgs) Handles Btn_Notice.Click
        If Txt_Notice.Text.Trim() = "" Then
            MessageBox.Show("Write Notice First")
        Else
            Dim cn As OleDbConnection = New OleDbConnection(Form_Main.connectString)
            cn.Open()
            Dim str1 As String = Form_Main.input_user
            Dim issue_date As String = DateTime.Now.ToString("dd-MM-yyyy")
            Dim issue_time As String = DateTime.Now.ToString("HH:mm")


            Dim full_name As String = ""
            Dim department As String = ""
            Dim selectString As String = "SELECT * FROM Teacher_Info_Table WHERE Username='" & str1 & "'"
            Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                full_name = reader("Full_Name")
                department = reader("Department")
            End If
            cn.Close()

            Dim Notice_Text As String = "Issued by: " & full_name & "-------------Date/Time: " & issue_date & "  " & issue_time & ":00" & Environment.NewLine & Environment.NewLine & Txt_Notice.Text.Trim()
            Dim cn2 As OleDbConnection = New OleDbConnection(Form_Main.connectString)
            cn2.Open()
            Dim insertString As String = "INSERT INTO Notification_Table([Username],[Full_Name],[Department],[Notice_Description],[Issue_Date],[Issue_Time]) VALUES('" & str1 & "','" & full_name & "','" & department & "','" & Notice_Text & "','" & issue_date & "','" & issue_time & "')"
            Dim cmd2 As OleDbCommand = New OleDbCommand(insertString, cn2)
            cmd2.Parameters.Add(New OleDbParameter("Username", CType(str1, String)))
            cmd2.Parameters.Add(New OleDbParameter("Full_Name", CType(full_name, String)))
            cmd2.Parameters.Add(New OleDbParameter("Department", CType(department, String)))
            cmd2.Parameters.Add(New OleDbParameter("Notice_Description", CType(Notice_Text, String)))
            cmd2.Parameters.Add(New OleDbParameter("Issue_Date", CType(issue_date, String)))
            cmd2.Parameters.Add(New OleDbParameter("Issue_Time", CType(issue_time, String)))

            cmd2.ExecuteNonQuery()

            cn2.Close()
            MessageBox.Show("New Notice Entered")
            Txt_Notice.Clear()
        End If


    End Sub

    Private Sub Notice_User_Control_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Txt_Notice_TextChanged(sender As Object, e As EventArgs) Handles Txt_Notice.TextChanged

    End Sub
End Class