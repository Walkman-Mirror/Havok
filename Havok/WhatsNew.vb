Public Class WhatsNew

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub WhatsNew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.Havok_Interface_UseDoubleBuffers = "true" Then
            Me.DoubleBuffered = True
        End If
        If My.Settings.Havok_Interface_UseDoubleBuffers = "false" Then
            Me.DoubleBuffered = False
        End If
        Me.Text = "Welcome To " & My.Application.Info.ProductName & "!"
        LabelX1.Text = "Welcome To " & My.Application.Info.ProductName & "!"
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserNavigatingEventArgs)
    
    End Sub

    Private Sub GeckoWebBrowser1_Navigating(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeckoWebBrowser1.Navigating
        Form1.PictureBox2.Visible = True
        Form1.Label9.Visible = True
        Form1.Label9.Text = "Busy"
        Form1.ListBox1.Items.Add("[GeckoFX] (Other) Navigating...")
        Me.Text = "What's New - [Fetching Changelog...]"
        Form1.ToolStripProgressBar1.Visible = True
    End Sub

    Private Sub GeckoWebBrowser1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeckoWebBrowser1.Navigated
        Form1.PictureBox2.Visible = False
        Form1.Label9.Visible = False
        Form1.ListBox1.Items.Add("[GeckoFX] (Other) Navigation Completed")
        Me.Text = "What's New"
        Form1.ToolStripProgressBar1.Visible = False
    End Sub

    Private Sub GeckoWebBrowser1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeckoWebBrowser1.Click

    End Sub
End Class