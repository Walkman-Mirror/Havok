﻿Public Class XULAppInstaller

    Private Sub Checkname_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Checkname.Tick
        Button1.Text = "&Install " & TextBox3.Text
    End Sub

    Private Sub XULAppInstaller_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Preferences.Enabled = False
        Checkname.Start()
    End Sub


    Private Sub XULAppInstaller_Clsoign(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosing
        Preferences.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Enabled = False
        Me.LabelX4.Visible = True
        Form1.NotifyIcon1.BalloonTipText = "Installing XUL Application..."
        Form1.NotifyIcon1.ShowBalloonTip(50)
        LabelX4.Text = "Installing..."
        Shell("xulrunner --install-app " & TextBox3.Text & "[" & TextBoxX2.Text & "[" & TextBoxX1.Text & "]]")
        Me.LabelX4.Text = "Installed!"
        Form1.NotifyIcon1.BalloonTipText = "XUL Application Successfully Installed!"
        Form1.NotifyIcon1.ShowBalloonTip(50)
        MsgBox(TextBox3.Text & " Has Been Installed!")
        Me.LabelX4.Visible = False
        Me.Enabled = True
    End Sub
End Class