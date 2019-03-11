Public Class Notification_User_Control

    Private Sub CSE_Click(sender As Object, e As EventArgs) Handles CSE.Click
        Form_Main.Hide()
        Form_Main.str_notification = "CSE"
        Form_Notification.Show()
    End Sub

    Private Sub Mathematics_Click(sender As Object, e As EventArgs) Handles Mathematics.Click
        Form_Main.Hide()
        Form_Main.str_notification = "Mathematics"
        Form_Notification.Show()
    End Sub

    Private Sub ECE_Click(sender As Object, e As EventArgs) Handles ECE.Click
        Form_Main.Hide()
        Form_Main.str_notification = "ECE and EEE"
        Form_Notification.Show()
    End Sub

    Private Sub EEE_Click(sender As Object, e As EventArgs) Handles EEE.Click
        Form_Main.Hide()
        Form_Main.str_notification = "Chemistry"
        Form_Notification.Show()
    End Sub

    Private Sub Mechanical_Click(sender As Object, e As EventArgs) Handles Mechanical.Click
        Form_Main.Hide()
        Form_Main.str_notification = "Mechanical"
        Form_Notification.Show()
    End Sub

    Private Sub Chemical_Click(sender As Object, e As EventArgs) Handles Chemical.Click
        Form_Main.Hide()
        Form_Main.str_notification = "Chemical"
        Form_Notification.Show()
    End Sub

    Private Sub Biotechnology_Click(sender As Object, e As EventArgs) Handles Biotechnology.Click
        Form_Main.Hide()
        Form_Main.str_notification = "Biotechnology"
        Form_Notification.Show()
    End Sub

    Private Sub Design_Click(sender As Object, e As EventArgs) Handles Design.Click
        Form_Main.Hide()
        Form_Main.str_notification = "Design"
        Form_Notification.Show()
    End Sub

    Private Sub Physics_Click(sender As Object, e As EventArgs) Handles Physics.Click
        Form_Main.Hide()
        Form_Main.str_notification = "Physics"
        Form_Notification.Show()
    End Sub

    Private Sub Civil_Click(sender As Object, e As EventArgs) Handles Civil.Click
        Form_Main.Hide()
        Form_Main.str_notification = "Civil"
        Form_Notification.Show()
    End Sub

    Private Sub HSS_Click(sender As Object, e As EventArgs) Handles HSS.Click
        Form_Main.Hide()
        Form_Main.str_notification = "HSS"
        Form_Notification.Show()
    End Sub


    Private Sub Notification_User_Control_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
