Public Class ViewSource

    Private Sub ViewSource_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GeckoWebBrowser1.Navigate("view-source:" & Form1.WebBrowser1.Url.ToString)
        Form1.ListBox1.Items.Add("---------------------------")
        Form1.ListBox1.Items.Add("View-Source Has Started!")
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        GeckoWebBrowser1.Navigate("view-source:" & Form1.WebBrowser1.Url.ToString)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        GeckoWebBrowser1.SelectAll()
        GeckoWebBrowser1.CopySelection()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        My.Computer.FileSystem.WriteAllText("view-source" & TimeOfDay.Day.ToString & TimeOfDay.DayOfWeek.ToString & TimeOfDay.DayOfYear.ToString & ".txt", GeckoWebBrowser1.Text, False)
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.Close()
    End Sub

    Private Sub ViewSource_FormClosing(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosing
        Form1.ListBox1.Items.Add("---------------------------")
        Form1.ListBox1.Items.Add("Stoping View-Source...")
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
    End Sub

    Private Sub ViewSource_FormClosed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosed
        Form1.ListBox1.Items.Add("---------------------------")
        Form1.ListBox1.Items.Add("View-Source Has Stopped!")
    End Sub

    Private Sub GeckoWebBrowser1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeckoWebBrowser1.Navigating
        Form1.PictureBox2.Visible = True
        Form1.Label9.Visible = True
        Form1.Label9.Text = "Busy"
        Form1.ListBox1.Items.Add("(GeckoFX) Navigating...")
        LabelX1.Text = "Getting Source Code..."
        If My.Settings.Havok_Weapons_ViewSource_AutoRefresh = "true" Then

        End If
        If My.Settings.Havok_Weapons_ViewSource_AutoRefresh = "false" Then
            Button17.Enabled = False
        End If
    End Sub

    Private Sub GeckoWebBrowser1_Claaaaaaick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeckoWebBrowser1.Navigated
        If My.Settings.Havok_Interface_UseDoubleBuffers = "true" Then
            Me.DoubleBuffered = True
        End If
        If My.Settings.Havok_Interface_UseDoubleBuffers = "false" Then
            Me.DoubleBuffered = False
        End If
        Form1.PictureBox2.Visible = False
        Form1.Label9.Visible = False
        Form1.ListBox1.Items.Add("(GeckoFX) Navigation Completed")
        LabelX1.Text = "Viewing Source: " & GeckoWebBrowser1.Url.ToString
        If My.Settings.Havok_Weapons_ViewSource_AutoRefresh = "true" Then

        End If
        If My.Settings.Havok_Weapons_ViewSource_AutoRefresh = "false" Then
            Button17.Enabled = True
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        GeckoWebBrowser1.GoBack()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        GeckoWebBrowser1.GoForward()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide()
    End Sub

    Private Sub AutomaticRefresher_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutomaticRefresher.Tick
        GeckoWebBrowser1.Navigate("view-source:" & Form1.WebBrowser1.Url.ToString)
    End Sub
End Class