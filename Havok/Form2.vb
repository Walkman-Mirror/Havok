Imports System.IO
Public Class Updates

    Private Sub GeckoWebBrowser1_Navigated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeckoWebBrowser1.Navigated
        Form1.PictureBox2.Visible = False
        Form1.Label9.Visible = False
        Form1.ListBox1.Items.Add("Loading Web Page 2... [Done]")
        Label1.Text = "Checking for updates has completed."
    End Sub

    Private Sub GeckoWebBrowser1_Navigating(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeckoWebBrowser1.Navigating
        Form1.PictureBox2.Visible = True
        Form1.Label9.Visible = True
        Form1.Label9.Text = "Loading Web Page 2..."
        Form1.ListBox1.Items.Add("Loading Web Page 2...")
        Label1.Text = "Checking for updates..."
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        GeckoWebBrowser1.Visible = True
        GeckoWebBrowser1.Navigate("http://deavmi.github.io/Havok")
    End Sub


End Class
