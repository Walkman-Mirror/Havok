﻿Imports System.IO
Imports Gecko.Xpcom
Imports Gecko.CookieManager
Imports Gecko
Imports System.Windows.Forms

Public Class Preferences

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Process.Start("http://3owl.com")
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Process.Start("http://iconfinder.com")
    End Sub

    Private Sub About_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.Havok_Interface_UseDoubleBuffers = "true" Then
            Me.DoubleBuffered = True
        End If
        If My.Settings.Havok_Interface_UseDoubleBuffers = "false" Then
            Me.DoubleBuffered = False
        End If
        Label6.Text = My.Application.Info.Version.Major.ToString & " Beta-Nightly"
        Label12.Text = "XUL Runner Version: " & Gecko.Xpcom.XulRunnerVersion.ToString
        If My.Settings.Havok_Interface_MenuStripEnabled = "true" Then
            CheckBox3.Checked = True
        End If
        If My.Settings.Havok_Interface_MenuStripEnabled = "false" Then
            CheckBox3.Checked = False
        End If
        If My.Settings.Havok_Interface_WindowHeaderBarEnabled = "true" Then
            CheckBox4.Checked = True
        End If
        If My.Settings.Havok_Interface_WindowHeaderBarEnabled = "false" Then
            CheckBox4.Checked = False
        End If
        If My.Settings.Havok_Interface_UseDoubleBuffers = "true" Then
            CheckBox5.Checked = True
        End If
        If My.Settings.Havok_Interface_UseDoubleBuffers = "false" Then
            CheckBox5.Checked = False
        End If
        If My.Settings.Havok_Interface_ChestaGUI = "0" Then
            Button3.Visible = True
            Button4.Visible = False
        End If
        If My.Settings.Havok_Interface_ChestaGUI = "1" Then
            Button3.Visible = False
            Button4.Visible = True
        End If
        If File.Exists("cheslyn") Then
            Button13.Enabled = True
        Else
            Button13.Enabled = False
        End If
        GeckoWebBrowser1.Navigate("about:license")
        TextBox3.Text = My.Settings.Havok_Weapons_UDPInterval.ToString
        If My.Settings.Havok_Interface_SystemStats = "1" Then
            CheckBox1.Checked = True
        End If
        If My.Settings.Havok_Interface_SystemStats = "0" Then
            CheckBox1.Checked = False
        End If
        If My.Settings.Havok_Interface_CurrentTimeClockEnabled = "true" Then
            CheckBox2.Checked = True
        End If
        If My.Settings.Havok_Interface_CurrentTimeClockEnabled = "false" Then
            CheckBox2.Checked = False
        End If
        TextBoxX1.Text = My.Settings.Havok_Browser_HomepageURL
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        My.Settings.Havok_Interface_ChestaGUI = "1"
        My.Settings.Save()
        If My.Settings.Havok_Interface_ChestaGUI = "1" Then
            'Activate The Chesta Mod/Mode
            Button3.Visible = False
            Button4.Visible = True
            Form1.ListBox1.BackColor = Color.Black
            Form1.ListBox1.ForeColor = Color.LimeGreen
            Form1.Label4.ForeColor = Color.LimeGreen
            Form1.Label2.ForeColor = Color.LimeGreen
            Form1.Label8.ForeColor = Color.LimeGreen
            Form1.Label1.ForeColor = Color.Lime
            Form1.Label6.ForeColor = Color.Lime
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        My.Settings.Havok_Interface_ChestaGUI = "0"
        My.Settings.Save()
        If My.Settings.Havok_Interface_ChestaGUI = "0" Then
            'Deactivate The Chesta Mod/Mode
            Button3.Visible = True
            Button4.Visible = False
            Form1.ListBox1.BackColor = Color.White
            Form1.ListBox1.ForeColor = Color.Black
            Form1.Label4.ForeColor = Color.Black
            Form1.Label2.ForeColor = Color.Black
            Form1.Label8.ForeColor = Color.Black
            Form1.Label1.ForeColor = Color.Black
            Form1.Label6.ForeColor = Color.Black
        End If
    End Sub

    Private Sub WebBrowser2_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserNavigatedEventArgs) Handles WebBrowser2.Navigated
        Form1.PictureBox2.Visible = False
        Form1.Label9.Visible = False
        Form1.ListBox1.Items.Add("Loading Web Page 5... [Done]")
    End Sub

    Private Sub WebBrowser2_Do2cumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserNavigatingEventArgs) Handles WebBrowser2.Navigating
        Form1.PictureBox2.Visible = True
        Form1.Label9.Visible = True
        Form1.Label9.Text = "Loading Web Page 5..."
        Form1.ListBox1.Items.Add("Loading Web Page 5...")
        Form1.Label6.Text = "Refreshing Feeds..."
        Form1.ToolStripProgressBar1.Visible = True
    End Sub

    Private Sub WebBrowser1_DocumentaaaaaaCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserNavigatedEventArgs) Handles WebBrowser1.Navigated
        Form1.PictureBox2.Visible = False
        Form1.Label9.Visible = False
        Form1.ListBox1.Items.Add("Loading Web Page 4... [Done]")
        Form1.ToolStripProgressBar1.Visible = True
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserNavigatingEventArgs) Handles WebBrowser1.Navigating
        Form1.PictureBox2.Visible = True
        Form1.Label9.Visible = True
        Form1.Label9.Text = "Loading Web Page 4..."
        Form1.ListBox1.Items.Add("Loading Web Page 4...")
        Form1.ToolStripProgressBar1.Visible = False
    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Process.Start("http://deavmi.3owl.com")
    End Sub

    Private Sub GeckoWebBrowser1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeckoWebBrowser1.Navigating
        Form1.PictureBox2.Visible = True
        Form1.Label9.Visible = True
        Form1.Label9.Text = "Loading Web Page 3..."
        Form1.ListBox1.Items.Add("Loading Web Page 3...")
        Form1.ToolStripProgressBar1.Visible = True
    End Sub
    Private Sub GeckoWebBrowsddder1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeckoWebBrowser1.Navigated
        Form1.PictureBox2.Visible = False
        Form1.Label9.Visible = False
        Form1.ListBox1.Items.Add("Loading Web Page 3... [Done]")
        Form1.ToolStripProgressBar1.Visible = False
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        My.Settings.Havok_Weapons_UDPInterval = TextBox3.Text
        My.Settings.Save()
        Form1.UDPFlooder.Interval = My.Settings.Havok_Weapons_UDPInterval.ToString
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        BrowserLiciousWindow.Show()
        BrowserLiciousWindow.Text = "Gecko Configuration"
        BrowserLiciousWindow.GeckoWebBrowser1.Navigate("about:config")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        BrowserLiciousWindow.Show()
        BrowserLiciousWindow.Text = "Gecko Plugins"
        BrowserLiciousWindow.GeckoWebBrowser1.Navigate("about:plugins")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        BrowserLiciousWindow.Show()
        BrowserLiciousWindow.Text = "Gecko Addons"
        BrowserLiciousWindow.GeckoWebBrowser1.Navigate("about:addons")
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        BrowserLiciousWindow.Show()
        BrowserLiciousWindow.Text = "Gecko Build Configuration"
        BrowserLiciousWindow.GeckoWebBrowser1.Navigate("about:buildconfig")
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        BrowserLiciousWindow.Show()
        BrowserLiciousWindow.Text = "Gecko Memory"
        BrowserLiciousWindow.GeckoWebBrowser1.Navigate("about:memory")
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        BrowserLiciousWindow.Show()
        BrowserLiciousWindow.Text = "Gecko Compartments"
        BrowserLiciousWindow.GeckoWebBrowser1.Navigate("about:compartments")
    End Sub

    Private Sub LinkLabel4_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        BrowserLiciousWindow.Show()
        BrowserLiciousWindow.Text = "Message From Mozilla"
        BrowserLiciousWindow.GeckoWebBrowser1.Navigate("about:mozilla")
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Shell("xulrunner.exe --help")
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        XULAppInstaller.ShowDialog()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        File.Delete("cheslyn")
        MsgBox("Havok Attempted To Fix The Random Cheslyn Message")
        If File.Exists("cheslyn") Then
            Button13.Enabled = True
        Else
            Button13.Enabled = False
        End If
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Application.Restart()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        MsgBox("Startup Path Is: " & Application.StartupPath.ToString)
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Debugger.Break()
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Form1.NotifyIcon1.BalloonTipText = "Restoring Settings To Defaults..."
        Form1.NotifyIcon1.ShowBalloonTip(50)
        Form1.ListBox1.Items.Add("Restoring Settings To Defaults...")
        My.Settings.Reset()
        Form1.NotifyIcon1.BalloonTipText = "Settings Have Been Restored!"
        Form1.NotifyIcon1.ShowBalloonTip(50)
        Form1.ListBox1.Items.Add("Settings Have Been Restored!")
        Form1.ListBox1.Items.Add("Havok Will Now Restart To Apply Your Settings!")
        MsgBox("Havok Will Now Restart To Apply Your Settings!")
        Application.Restart()
    End Sub

    Private Sub Button20_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        Gecko.Xpcom.Shutdown()
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form1.WebBrowser1.History.Clear()
        Form1.NotifyIcon1.BalloonTipText = "History Successfully Cleared!"
        Form1.NotifyIcon1.ShowBalloonTip(50)
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        Application.Exit()
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        My.Settings.Havok_Browser_HomepageURL = TextBoxX1.Text
        My.Settings.Save()
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        My.Settings.Havok_Browser_HomepageURL = "about:blank"
        My.Settings.Save()
        TextBoxX1.Text = My.Settings.Havok_Browser_HomepageURL
    End Sub

    Private Sub Button21_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        CookieManager.RemoveAll()
    End Sub

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        CookieManager.ImportCookies(TextBoxX2.Text)
    End Sub

    Private Sub CheckBox1_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            My.Settings.Havok_Interface_SystemStats = "1"
            My.Settings.Save()
            If My.Settings.Havok_Interface_SystemStats = "1" Then
                   CheckBox1.Checked = True
                Form1.Label7.Visible = True
                Form1.Label10.Visible = True
            End If
        Else
            My.Settings.Havok_Interface_SystemStats = "0"
            My.Settings.Save()
            If My.Settings.Havok_Interface_SystemStats = "0" Then
                CheckBox1.Checked = False
                Form1.Label7.Visible = False
                Form1.Label10.Visible = False
            End If
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            My.Settings.Havok_Interface_CurrentTimeClockEnabled = "true"
            My.Settings.Save()
            If My.Settings.Havok_Interface_CurrentTimeClockEnabled = "true" Then
                CheckBox2.Checked = True
                Form1.Label11.Visible = True
            End If
        Else
            My.Settings.Havok_Interface_CurrentTimeClockEnabled = "false"
            My.Settings.Save()
            If My.Settings.Havok_Interface_CurrentTimeClockEnabled = "false" Then
                CheckBox2.Checked = False
                Form1.Label11.Visible = False
            End If
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            My.Settings.Havok_Interface_WindowHeaderBarEnabled = "true"
            My.Settings.Save()
            If My.Settings.Havok_Interface_WindowHeaderBarEnabled = "true" Then
                CheckBox4.Checked = True
                Form1.Panel1.Visible = True
            End If
        Else
            My.Settings.Havok_Interface_WindowHeaderBarEnabled = "false"
            My.Settings.Save()
            If My.Settings.Havok_Interface_WindowHeaderBarEnabled = "false" Then
                CheckBox4.Checked = False
                Form1.Panel1.Visible = False
            End If
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            My.Settings.Havok_Interface_MenuStripEnabled = "true"
            My.Settings.Save()
            If My.Settings.Havok_Interface_MenuStripEnabled = "true" Then
                CheckBox3.Checked = True
                Form1.MenuStrip1.Visible = True
            End If
        Else
            My.Settings.Havok_Interface_MenuStripEnabled = "false"
            My.Settings.Save()
            If My.Settings.Havok_Interface_MenuStripEnabled = "false" Then
                CheckBox3.Checked = False
                Form1.MenuStrip1.Visible = False
            End If
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            My.Settings.Havok_Interface_UseDoubleBuffers = "true"
            My.Settings.Save()
            If My.Settings.Havok_Interface_UseDoubleBuffers = "true" Then
                CheckBox5.Checked = True
            End If
        Else
            My.Settings.Havok_Interface_UseDoubleBuffers = "false"
            My.Settings.Save()
            If My.Settings.Havok_Interface_UseDoubleBuffers = "false" Then
                CheckBox5.Checked = False
            End If
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = True Then
            My.Settings.Havok_Interface_VisualStyling = "1"
            My.Settings.Save()
            If My.Settings.Havok_Interface_VisualStyling = "1" Then
                CheckBox6.Checked = True
                Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
                Form1.Button15.Visible = True
                Form1.Button16.Visible = False
            End If
        Else
            My.Settings.Havok_Interface_VisualStyling = "0"
            My.Settings.Save()
            If My.Settings.Havok_Interface_VisualStyling = "0" Then
                CheckBox6.Checked = False
                Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
                Form1.Button15.Visible = False
                Form1.Button16.Visible = True
            End If
        End If
    End Sub
End Class
