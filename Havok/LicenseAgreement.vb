Imports System.IO
Public Class LicenseAgreement

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox("You Have To Agree To The License, Havok Will Now Quit!")
        Application.Exit()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        My.Settings.FirstRun = "false"
        My.Settings.Save()
        If My.Settings.FirstRun = "false" Then
            Form1.NotifyIconContextMenuStrip1.Enabled = False
            Form1.Show()
            WhatsNew.ShowDialog()
            Me.Close()
        End If
    End Sub

    Private Sub LicenseAgreement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WhatsNew.GeckoWebBrowser1.Navigate("http://deavmi.3owl.com/wp-content/projects/havok/changelog.html")
    End Sub
End Class
