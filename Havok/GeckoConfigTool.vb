Public Class BrowserLiciousWindow

    Private Sub GeckoConfigTool_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GeckoWebBrowser1_Navigating(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeckoWebBrowser1.Navigating
        Form1.PictureBox2.Visible = True
        Form1.Label9.Visible = True
        Form1.Label9.Text = "Loading Web Page 10..."
        Form1.ListBox1.Items.Add("Loading Web Page 10...")
    End Sub

    Private Sub GeckoWebBrowser1_Navigated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeckoWebBrowser1.Navigated
        Form1.PictureBox2.Visible = False
        Form1.Label9.Visible = False
        Form1.ListBox1.Items.Add("Loading Web Page 10... [Done]")
    End Sub


    Private Sub GeckoWebBrowser1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeckoWebBrowser1.Click

    End Sub
End Class