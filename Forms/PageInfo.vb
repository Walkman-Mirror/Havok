Public Class PageInfo

    Private Sub PageInfo_Loaaad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.Havok_Interface_UseDoubleBuffers = "true" Then
            Me.DoubleBuffered = True
        End If
        If My.Settings.Havok_Interface_UseDoubleBuffers = "false" Then
            Me.DoubleBuffered = False
        End If
        Form1.ListBox1.Items.Add("---------------------------")
        Form1.ListBox1.Items.Add("Page-Info Has Started!")
        Label1.Text = Form1.WebBrowser1.DocumentTitle
        Label2.Text = Form1.WebBrowser1.Url.ToString
        Label3.Text = "URL: " & Form1.WebBrowser1.Url.ToString
        Label4.Text = "Document Type: " & Form1.WebBrowser1.Document.GetType.ToString
        Label5.Text = "Encoding: " & Form1.WebBrowser1.Document.InputEncoding.ToString
        Label6.Text = "Forms Count: " & Form1.WebBrowser1.Document.Forms.Count.ToString
        Label7.Text = "Referrer: " & Form1.WebBrowser1.ReferrerUrl.ToString
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label1.Text = Form1.WebBrowser1.DocumentTitle
        Label2.Text = Form1.WebBrowser1.Url.ToString
        Label3.Text = "URL: " & Form1.WebBrowser1.Url.ToString
        Label4.Text = "Document Type: " & Form1.WebBrowser1.Document.GetType.ToString
        Label5.Text = "Encoding: " & Form1.WebBrowser1.Document.InputEncoding.ToString
        Label6.Text = "Forms Count: " & Form1.WebBrowser1.Document.Forms.Count.ToString
        Label7.Text = "Referrer: " & Form1.WebBrowser1.ReferrerUrl.ToString
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1.WebBrowser1.ShowPageProperties()
    End Sub



    Private Sub PageInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosing

        Form1.ComboBox1.Enabled = "True"
        Form1.PictureBox2.Show()
        Form1.Label9.Visible = "False"
        Form1.Label9.Text = "Page-Info"
        Form1.Button2.Enabled = "True"
        Form1.Button4.Enabled = "False"
        Form1.PictureBox2.Hide()
        Form1.Label9.Visible = "False"
        Form1.TextBox1.Enabled = "True"
        Form1.TextBox2.Enabled = "True"
        Form1.TextBox3.Enabled = "True"
        Form1.ListBox1.Items.Add("---------------------------")
        Form1.ListBox1.Items.Add("Stoping Page-Info...")


    End Sub
    Private Sub PageInfo_Loaaaaaaaaaaaaaaaaaaaad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosed
        Form1.ListBox1.Items.Add("---------------------------")
        Form1.ListBox1.Items.Add("Page-Info Has Stopped!")


    End Sub



End Class