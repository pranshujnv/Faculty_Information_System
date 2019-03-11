Imports System.Data.OleDb

Public Class Form_Notification
    'deleting dynamically allocated controls
        
    'Function to dynamically allocate new richtextboxes'
    Private Sub outTextAdder(i As Integer, tmp As String, tmp2 As String, out_date As String, out_time As String)
        Dim txtName As String
        txtName = "txtOutput" & CStr(i)
        'Incrementing location of textbox
        'Dim yt As Integer = txtOutput1.Location.Y + 25 * (i - 1)
        Dim x As Integer = 30
        Dim yt As Integer = 30 + 108 * (i - 1)
        Dim txt1 As New TextBox
        txt1.Multiline = True
        txt1.Name = txtName
        txt1.Width = 900
        txt1.Height = 90
        txt1.ScrollBars = ScrollBars.Vertical
        txt1.Font = New Font("Century Gothic", 11)
        txt1.ReadOnly = True
        Me.Controls.Add(txt1)
        txt1.Location = New Point(x, yt)
        txt1.Text = tmp
        txt1.Font = New Font("Century Gothic", 11)
        txt1.BackColor = Color.White
        txt1.SelectionStart = txt1.Text.Length
        txt1.ScrollToCaret()
        txt1.Refresh()

    End Sub

    Private Sub Form_Notification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cn As OleDbConnection = New OleDbConnection(Form_Main.connectString)
        cn.Open()
        Dim selectString As String = "SELECT * FROM Notification_Table WHERE Department='" & Form_Main.str_notification & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(selectString, cn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        Dim i As Integer = 1
        While reader.Read()
            'TextBox1.Text = TextBox1.Text & reader("Full_Name") & Environment.NewLine
            Dim output_str As String = reader("Notice_Description")
            Dim output_name As String = reader("Full_Name")
            Dim output_date As String = reader("Issue_Date")
            Dim output_time As String = reader("Issue_Time")
            outTextAdder(i, output_str, output_name, output_date, output_time)
            i = i + 1

        End While

        cn.Close()
        Btn_Go_Back.Location = New Point(451, 30 + 108 * (i - 1))
    End Sub

    Private Sub Btn_Go_Back_Click(sender As Object, e As EventArgs) Handles Btn_Go_Back.Click
        Form_Main.Show()
        Me.Close()
    End Sub

End Class