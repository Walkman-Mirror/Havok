Imports System.IO
Public Class LicenseAgreement

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox("You Have To Agree To The License, Havok Will Now Quit!")
        Application.Exit()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        My.Settings.Havok_Environment_FirstRun = "false"
        My.Settings.Save()
        If My.Settings.Havok_Environment_FirstRun = "false" Then
            Form1.NotifyIconContextMenuStrip1.Enabled = False
            Form1.Show()
            WhatsNew.ShowDialog()
            Me.Close()
        End If
    End Sub

    Private Sub LicenseAgreement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WhatsNew.GeckoWebBrowser1.Navigate("http://deavmi.github.io/Havok/#changelog")
    End Sub
End Class
