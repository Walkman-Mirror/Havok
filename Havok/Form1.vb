Imports System.Net.Sockets
Imports System.Diagnostics
Imports System.Net
Imports System.Text
Imports System.IO
'mabye gonna make a mail sender on a timer, will see what i can code up :P (P.S reason for importing Mail functions)
Imports System.Net.Mail
Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Updates.Show()
    End Sub

    Private Sub WeaponStarter()
        If ComboBox1.Text = "UDP-Flooder" Then
            ComboBox1.Enabled = "False"
            ListBox1.Items.Add("---------------------------")
            ListBox1.Items.Add("Starting UDP-Flooder...")
            'UDPFlooder.Show()
            Button2.Enabled = False
            Button4.Enabled = True
        End If

        If ComboBox1.Text = "Remote-PC" Then
            ComboBox1.Enabled = "False"
            PictureBox2.Show()
            Label9.Visible = "True"
            Label9.Text = "Remote-PC"
            ListBox1.Items.Add("---------------------------")
            ListBox1.Items.Add("Starting Remote-PC...")
            RemotePC.Show()

            PictureBox2.Show()
            Label9.Visible = "True"
            Button2.Enabled = False
            Button4.Enabled = True


        End If

        If ComboBox1.Text = "JS-Console" Then
            ComboBox1.Enabled = "False"
            PictureBox2.Show()
            Label9.Visible = "True"
            Label9.Text = "JS-Console"
            ListBox1.Items.Add("---------------------------")
            ListBox1.Items.Add("Starting JS-Console...")
            Button2.Enabled = "False"
            Button4.Enabled = "True"
            PictureBox2.Show()
            Label9.Visible = "True"

            Shell("js.exe")
            ListBox1.Items.Add("---------------------------")
            ListBox1.Items.Add("JS-Console Has Started!")
            PictureBox2.Hide()
            Label9.Visible = "False"
            TextBox1.Enabled = "True"
            TextBox2.Enabled = "True"
            TextBox3.Enabled = "True"
            Button2.Enabled = "True"
            Button4.Enabled = "False"
            ComboBox1.Enabled = "True"
            Button2.Enabled = False
            Button4.Enabled = True

        End If

        If ComboBox1.Text = "Page-Info" Then
            ComboBox1.Enabled = "False"
            PictureBox2.Show()
            Label9.Visible = "True"
            Label9.Text = "Page-Info"
            ListBox1.Items.Add("---------------------------")
            ListBox1.Items.Add("Starting Page-Info...")
            PageInfo.Show()
            Button2.Enabled = "False"
            Button4.Enabled = "True"
            PictureBox2.Show()
            Label9.Visible = "True"
            Button2.Enabled = False
            Button4.Enabled = True


        End If


        'MULTISTAKING IS CURRENTLY IN PROGRESS STARTING FROM HERE
        '!!!!!!!!!!!!!!!!!!!!!!!!
        '!!!!!!!!!!!!!!!!!!!!!!!!
        '!!!!!!!!!!!!!!!!!!!!!!!!
        '!!!!!!!!!!!!!!!!!!!!!!!!
        '!!!!!!!!!!!!!!!!!!!!!!!!
        '!!!!!!!!!!!!!!!!!!!!!!!!

        If ComboBox1.Text = "HGetter" Then
            ListBox1.Items.Add("---------------------------")
            ListBox1.Items.Add("Starting HGetter...")
            'HGetter.Show()
            Button2.Enabled = False
            Button4.Enabled = True


        End If



        If ComboBox1.Text = "HPusher" Then

            ListBox1.Items.Add("---------------------------")
            ListBox1.Items.Add("Starting HPusher...")
            HPusher.Show()
            Button2.Enabled = False
            Button4.Enabled = True


        End If


        If ComboBox1.Text = "RouterAdmin" Then

            ListBox1.Items.Add("---------------------------")
            ListBox1.Items.Add("Starting RouterAdmin...")
            'RouterAdmin.Show()
            Button2.Enabled = False
            Button4.Enabled = True


        End If





        'ENDING HERE
        '!!!!!!!!!!!!!!!!!!!!!!!!
        '!!!!!!!!!!!!!!!!!!!!!!!!
        '!!!!!!!!!!!!!!!!!!!!!!!!
        '!!!!!!!!!!!!!!!!!!!!!!!!
        '!!!!!!!!!!!!!!!!!!!!!!!!
        '!!!!!!!!!!!!!!!!!!!!!!!!


        If ComboBox1.Text = "Encryption-Level" Then
            ComboBox1.Enabled = "False"
            PictureBox2.Show()
            Label9.Visible = "True"
            Label9.Text = "Encryption-Level"
            ListBox1.Items.Add("---------------------------")
            ListBox1.Items.Add("Starting Encryption-Level...")
            EncryptionLevel.Show()
            Button2.Enabled = False
            Button4.Enabled = True
            PictureBox2.Show()
            Label9.Visible = "True"

        End If

        If ComboBox1.Text = "View-Source" Then
            ComboBox1.Enabled = "False"
            PictureBox2.Show()
            Label9.Visible = "True"
            Label9.Text = "View-Source"
            ListBox1.Items.Add("---------------------------")
            ListBox1.Items.Add("Starting View-Source...")
            ViewSource.Show()
            Button2.Enabled = False
            Button4.Enabled = True
            PictureBox2.Show()
            Label9.Visible = "True"

        End If


        'LOL MetriliX
        If ComboBox1.Text = "ashlin" Then
            ComboBox1.Enabled = "False"
            PictureBox2.Show()
            Label9.Visible = "True"
            Label9.Text = "Where Is Ashlin?"
            Button2.Enabled = "False"
            Button4.Enabled = "True"
            PictureBox2.Show()
            Label9.Visible = "True"
            TextBox1.Enabled = "False"
            TextBox2.Enabled = "False"
            TextBox3.Enabled = "False"
            Label1.Text = "James"
            MsgBox("When Ashlin Sees Dis' Shit, Well He Is Gonna' Be Cray-Cray!!!!!!!!!!!!!!!!!!")
            ComboBox1.Enabled = "True"
            PictureBox2.Show()
            Label9.Visible = "False"
            Label9.Text = "HGetter"
            Button2.Enabled = "True"
            Button4.Enabled = "False"
            PictureBox2.Hide()
            Label9.Visible = "False"
            TextBox1.Enabled = "True"
            TextBox2.Enabled = "True"
            TextBox3.Enabled = "True"
            Label1.Text = My.Application.Info.ProductName
        End If
        'If The Combo Box Contains Nothing or "-----" We Make A Msgbox Popup Prompting The User To Select A Weapon
        If ComboBox1.Text = "-----" Then
            MsgBox("Please Select A Weapon/Tool")
        End If
        If ComboBox1.Text = "" Then
            MsgBox("Please Select A Weapon/Tool")
        End If
    End Sub

    Private Sub WeaponStopper()
        If ComboBox1.Text = "UDP-Flooder" Then
            'UDPFlooder.Close()
        End If

        If ComboBox1.Text = "Remote-PC" Then
            RemotePC.Close()
        End If

        If ComboBox1.Text = "Page-Info" Then
            PageInfo.Close()
        End If

        If ComboBox1.Text = "HGetter" Then
            'HGetter.Close()
        End If

        If ComboBox1.Text = "HPusher" Then
            HPusher.Close()
        End If



        If ComboBox1.Text = "Encryption-Level" Then
            EncryptionLevel.Close()
        End If



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        WeaponStarter()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        WeaponStopper()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        WebBrowser1.GoBack()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        WebBrowser1.GoForward()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        WebBrowser1.Refresh()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Form3.ShowDialog()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        WebBrowser1.Stop()
    End Sub

    Private Sub Button12_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Preferences.Show()
    End Sub
    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Me.Show()
    End Sub

    Private Sub Button9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        ListBox1.Items.Add("---------------------------")
        ListBox1.Items.Add("Pinging " & (TextBox1.Text))
        ListBox1.Items.Add("---------------------------")
        Shell("ping " & TextBox1.Text)

    End Sub

    Private Sub GetLastTyped()
        TextBox1.Text = My.Settings.Havok_Environment_LastTyped_LastTypedIPAddress
        TextBox2.Text = My.Settings.Havok_Environment_LastTyped_LastTypedMiscBox
        TextBox3.Text = My.Settings.Havok_Environment_LastTyped_LastTypedPort
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ListBox1.Items.Add("Starting Up...")



        'Reads The User Settings For Havok
        If My.Settings.Havok_Interface_WindowHeaderBarEnabled = "true" Then
            Panel1.Visible = True
        End If
        If My.Settings.Havok_Interface_WindowHeaderBarEnabled = "false" Then
            Panel1.Visible = False
        End If
        If My.Settings.Havok_Interface_MenuStripEnabled = "true" Then
            MenuStrip1.Visible = True
        End If
        If My.Settings.Havok_Interface_MenuStripEnabled = "false" Then
            MenuStrip1.Visible = False
        End If
        If My.Settings.Havok_Environment_HideOnStartup = "true" Then
            'Hide The Main Havok Window
            Me.Hide()
        End If
        If My.Settings.Havok_Interface_ChestaGUI = "1" Then
            'Activate The Chesta Mod/Mode
            ListBox1.BackColor = Color.Black
            ListBox1.ForeColor = Color.LimeGreen
            Label4.ForeColor = Color.LimeGreen
            Label2.ForeColor = Color.LimeGreen
            Label8.ForeColor = Color.LimeGreen
            Label1.ForeColor = Color.Lime
            Label6.ForeColor = Color.Lime
        End If
        If My.Settings.Havok_Interface_ChestaGUI = "0" Then
            'Deactivate The Chesta Mod/Mode
            ListBox1.BackColor = Color.White
            ListBox1.ForeColor = Color.Black
            Label4.ForeColor = Color.Black
            Label2.ForeColor = Color.Black
            Label8.ForeColor = Color.Black
            Label1.ForeColor = Color.Black
            Label6.ForeColor = Color.Black
        End If
        If My.Settings.Havok_Interface_VisualStyling = "false" Then
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Button15.Visible = False
            Button16.Visible = True
        End If

        If My.Settings.Havok_Interface_VisualStyling = "true" Then
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Button15.Visible = True
            Button16.Visible = False
        End If
        If My.Settings.Havok_Interface_SystemStats = "1" Then
            Label7.Visible = True
            Label10.Visible = True
            SystemStats.Start()
        End If
        If My.Settings.Havok_Interface_SystemStats = "0" Then
            Label7.Visible = False
            Label10.Visible = False
        End If
        If My.Settings.Havok_Interface_Extensions_NetMon_InStatusBar = "true" Then
            ToolStripStatusLabel1.Visible = True
        End If
        If My.Settings.Havok_Interface_Extensions_NetMon_InStatusBar = "false" Then
            ToolStripStatusLabel1.Visible = False
        End If
        If My.Settings.Havok_Interface_StatusBarVisible = "true" Then
            StatusStrip1.Visible = True
        End If
        If My.Settings.Havok_Interface_StatusBarVisible = "false" Then
            StatusStrip1.Visible = False
        End If
        If My.Settings.Havok_Interface_OptionsButtonVisible = "true" Then
            ToolStripDropDownButton1.Visible = True
        End If
        If My.Settings.Havok_Interface_OptionsButtonVisible = "false" Then
            ToolStripDropDownButton1.Visible = False
        End If
        If My.Settings.Havok_Interface_Browser_StatusTextVisible = "true" Then
            ToolStripStatusLabel2.Visible = True
            WebBrowser1StatusText.Start()
        End If
        If My.Settings.Havok_Interface_Browser_StatusTextVisible = "false" Then
            ToolStripStatusLabel2.Visible = False
        End If
        'Just Gets Sum More Settings
        If My.Settings.Havok_Environment_Lockdown = "0" Then
            'Deactivates Lockdown Mode
            EnableToolStripMenuItem1.Visible = True
            EnableToolStripMenuItem.Visible = True
            Me.Enabled = True
            DisableToolStripMenuItem.Visible = False
            DisableToolStripMenuItem1.Visible = False
            Label9.Visible = False
            ListBox1.Items.Add("---------------------------")
            ListBox1.Items.Add("Lockdown Mode Disabled!")
        End If
        If My.Settings.Havok_Environment_Lockdown = "1" Then
            'Activates Lockdown Mode
            EnableToolStripMenuItem1.Visible = False
            EnableToolStripMenuItem.Visible = False
            Me.Enabled = False
            DisableToolStripMenuItem.Visible = True
            DisableToolStripMenuItem1.Visible = True
            PictureBox2.Visible = True
            Label9.Visible = True
            Label9.Text = "Lockdown"
            ListBox1.Items.Add("---------------------------")
            ListBox1.Items.Add("Lockdown Mode Enabled!")
        End If
        'Check If LastTyped Is Activated
        If My.Settings.Havok_Environment_RememberLastTyped = "true" Then
            GetLastTyped()
        End If
        If My.Settings.Havok_Environment_RememberLastTyped = "false" Then
            'This Is Useless Putting Here, But I Always Do
        End If
        'Checks More Settings
        If My.Settings.Havok_Interface_CurrentTimeClockEnabled = "true" Then
            Label11.Visible = True
            Padawan.Start()
        End If
        If My.Settings.Havok_Interface_CurrentTimeClockEnabled = "false" Then
            Label11.Visible = False
        End If
        If My.Settings.Havok_Interface_UseDoubleBuffers = "true" Then
            Me.DoubleBuffered = True
        End If
        If My.Settings.Havok_Interface_UseDoubleBuffers = "false" Then
            Me.DoubleBuffered = False
        End If
        NetMonTimer.Interval = My.Settings.Havok_Extensions_NetMon_TimerInterval.ToString
        '----------

        ' UI related stuff
        ToolStripMenuItem6.Text = My.User.Name.ToString
        OSToolStripMenuItem.Text = My.Computer.Info.OSFullName
        AaaaToolStripMenuItem.Text = My.Computer.Info.OSVersion
        ComboBox1.Text = My.Settings.Havok_Environment_LastTyped_LastSelectedWeapon


        'Lord Deavmied This
        If My.Settings.Havok_Environment_FirstRun = "true" Then
            LicenseAgreement.ShowDialog()
            NotifyIconContextMenuStrip1.Enabled = False
        End If
        'Show the Notify icon's ballontip message
        NotifyIcon1.ShowBalloonTip(50)
        ListBox1.Items.Add("Welcome To " & My.Application.Info.ProductName)
        ListBox1.Items.Add("Version " & My.Application.Info.Version.ToString)
        ListBox1.Items.Add(My.Application.Info.Copyright)
        ListBox1.Items.Add("")
        ListBox1.Items.Add("Visit the project: http://deavmi.github.io/Havok")
        ListBox1.Items.Add("---------------------------")
        'Navigate The Main WebBrowser (WebBrowser1 On Form1) 
        WebBrowser1.Navigate(My.Settings.Havok_Browser_HomepageURL.ToString)
        'Navigate ABout Form's Two WebBrowsers (WebBrowser1 and WebBrwoser2 On About)
        Preferences.WebBrowser1.Navigate("http://www.gnu.org/licenses/gpl.txt")
        Preferences.WebBrowser2.Navigate("http://deavmi.3owl.com/index.php/User_talk:Deavmi")
        WebBrowser1StatusText.Start()
        NetMonTimer.Start()
        Label6.Text = "v" & My.Application.Info.Version.ToString
        If My.Settings.Havok_Environment_DevMessage = "true" Then
            MsgBox("Havok 3 Is Beta, HGetter's and HPusher's Background Workers a.k.a The Downloader and Uploader (Respectively) Their Processes, Cannot Be Canceled, To End Them You Need To Exit Havok or Restart Havok, This Can Be Done From The Settings Tab In The About Window. Thanks. ~Deavmi")
        End If
    End Sub

    Private Sub Button10_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Preferences.WebBrowser2.Refresh()
        ListBox1.Items.Clear()
        WebBrowser1.Navigate(My.Settings.Havok_Browser_HomepageURL.ToString)
        If ComboBox1.Text = "UDP-Flooder" Then
            'UDPFlooder.Close()
            WebBrowser1.Navigate(My.Settings.Havok_Browser_HomepageURL.ToString)
        End If
        If ComboBox1.Text = "HGetter" Then
            'HGetter.Close()
            WebBrowser1.Navigate(My.Settings.Havok_Browser_HomepageURL.ToString)
        End If
        If ComboBox1.Text = "Remote-PC" Then
            RemotePC.Close()
            WebBrowser1.Navigate(My.Settings.Havok_Browser_HomepageURL.ToString)
        End If
        If ComboBox1.Text = "Encryption-Level" Then
            EncryptionLevel.Close()
            WebBrowser1.Navigate(My.Settings.Havok_Browser_HomepageURL.ToString)
        End If
        If ComboBox1.Text = "HPusher" Then
            HPusher.Close()
            WebBrowser1.Navigate(My.Settings.Havok_Browser_HomepageURL.ToString)
        End If
        If ComboBox1.Text = "Page-Info" Then
            PageInfo.Close()
            WebBrowser1.Navigate(My.Settings.Havok_Browser_HomepageURL.ToString)
        End If
        If ComboBox1.Text = "View-Source" Then
            ViewSource.Close()
            WebBrowser1.Navigate(My.Settings.Havok_Browser_HomepageURL.ToString)
        End If
        If ComboBox1.Text = "RouterAdmin" Then
            'RouterAdmin.Close()
            WebBrowser1.Navigate(My.Settings.Havok_Browser_HomepageURL.ToString)
        End If

    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Me.Hide()
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        'Lil' Inspirational Quotes 
        If TextBox1.Text = "" Then
            MsgBox("Listen Here " & My.User.Name.ToString & ", Live Life, Don't Be A Turkey")
        Else
            MsgBox("Listen Here " & My.User.Name.ToString & ", Live Life, Don't Be A Turkey" & TextBox1.Text)
        End If
    End Sub

    Private Sub PageInfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        WebBrowser1.ShowPageProperties()
    End Sub

    Private Sub AToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Preferences.ShowDialog()
    End Sub

    Private Sub Yebo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SystemStats.Tick
        Label7.Text = "Available Physical Mem: " & My.Computer.Info.AvailablePhysicalMemory
        Label10.Text = "Available Virtuel Mem: " & My.Computer.Info.AvailablePhysicalMemory
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Show()
        Form3.ShowDialog()
    End Sub

    Private Sub Padawan_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Padawan.Tick
        Label11.Text = TimeOfDay
    End Sub

    Private Sub WebBrowser1StatusText_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WebBrowser1StatusText.Tick
        ToolStripStatusLabel2.Text = WebBrowser1.StatusText
    End Sub

    Private Sub AToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Checks The Encryption Level Of Web Browser 1 a.k.a "WebBrowser1" On Form1
        If WebBrowser1.SecurityState = Gecko.GeckoSecurityState.Secure Then
            MsgBox("Encryption Level: Secure")
        End If
        If WebBrowser1.SecurityState = Gecko.GeckoSecurityState.Insecure Then
            MsgBox("Encryption Level: Insecure")
        End If
        If WebBrowser1.SecurityState = Gecko.GeckoSecurityState.Broken Then
            MsgBox("Encryption Level: Broken")
        End If
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        My.Settings.Havok_Interface_VisualStyling = "false"
        My.Settings.Save()
        If My.Settings.Havok_Interface_VisualStyling = "false" Then
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Button15.Visible = False
            Button16.Visible = True
        End If
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        My.Settings.Havok_Interface_VisualStyling = "true"
        My.Settings.Save()
        If My.Settings.Havok_Interface_VisualStyling.ToString = "true" Then
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Button15.Visible = True
            Button16.Visible = False
        End If
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        WebBrowser1.Navigate("http://google.com/search?btnI=1&q=" & TextBoxX1.Text)
    End Sub

    Private Sub AboutHavokToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutHavokToolStripMenuItem.Click
        If Preferences.Visible = True Then

        Else
            Preferences.ShowDialog()
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub CheckForUpdatesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckForUpdatesToolStripMenuItem.Click
        'Updates.Show()
    End Sub

    Private Sub EnableToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnableToolStripMenuItem1.Click
        My.Settings.Havok_Environment_Lockdown = "1"
        My.Settings.Save()
        If My.Settings.Havok_Environment_Lockdown = "1" Then
            EnableToolStripMenuItem1.Visible = False
            EnableToolStripMenuItem.Visible = False
            Me.Enabled = False
            DisableToolStripMenuItem.Visible = True
            DisableToolStripMenuItem1.Visible = True
            PictureBox2.Visible = True
            ListBox1.Items.Add("---------------------------")
            ListBox1.Items.Add("Lockdown Mode Enabled!")
            Label6.Text = "Lockdown Mode"
        End If
    End Sub

    Private Sub DisableToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisableToolStripMenuItem.Click
        My.Settings.Havok_Environment_Lockdown = "0"
        My.Settings.Save()
        If My.Settings.Havok_Environment_Lockdown = "0" Then
            EnableToolStripMenuItem1.Visible = True
            EnableToolStripMenuItem.Visible = True
            Me.Enabled = True
            DisableToolStripMenuItem.Visible = False
            DisableToolStripMenuItem1.Visible = False
            PictureBox2.Visible = True
            ListBox1.Items.Add("---------------------------")
            ListBox1.Items.Add("Lockdown Mode Disabled!")
            Label6.Text = "v" & My.Application.Info.Version.ToString
        End If
    End Sub

    Private Sub AppInfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AppInfoToolStripMenuItem.Click
        ListBox1.Items.Add("App Info: ")
        ListBox1.Items.Add("---------------------------")
        ListBox1.Items.Add(My.Application.Info.ProductName)
        ListBox1.Items.Add("Build: " & My.Application.Info.Version.Build.ToString)
        ListBox1.Items.Add("Version: " & My.Application.Info.Version.ToString)
        ListBox1.Items.Add("Loaded Assemblies Count: " & My.Application.Info.LoadedAssemblies.Count.ToString)
        ListBox1.Items.Add("Culture: " & My.Application.Culture.ToString)
        ListBox1.Items.Add("User Interface Culture: " & My.Application.UICulture.ToString)
    End Sub

    Private Sub AaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AaToolStripMenuItem.Click
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub

    Private Sub BlackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BlackToolStripMenuItem.Click
        ListBox1.ForeColor = Color.Black
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        ListBox1.BackColor = Color.Gray
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        ListBox1.BackColor = Color.White
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        ListBox1.BackColor = Color.Black
    End Sub

    Private Sub GrayToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrayToolStripMenuItem.Click
        ListBox1.ForeColor = Color.Gray
    End Sub

    Private Sub WhiteToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WhiteToolStripMenuItem.Click
        ListBox1.ForeColor = Color.White
    End Sub

    Private Sub ResetToDefaultsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetToDefaultsToolStripMenuItem.Click
        ListBox1.Items.Add("Restoring Colors To Defaults...")
        ListBox1.ForeColor = Color.Black
        ListBox1.BackColor = Color.White
    End Sub

    Private Sub ResetToDefaultsToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetToDefaultsToolStripMenuItem2.Click
        ListBox1.Items.Add("Restoring Fore Color To Default...")
        ListBox1.ForeColor = Color.Black
    End Sub

    Private Sub ResetToDefaultsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetToDefaultsToolStripMenuItem1.Click
        ListBox1.Items.Add("Restoring Back Color To Default...")
        ListBox1.BackColor = Color.White
    End Sub

    Private Sub WebBrowser1_Navigating(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WebBrowser1.Navigating
        PictureBox2.Visible = True
        Label9.Visible = True
        Label9.Text = "Busy"
        ListBox1.Items.Add("[GeckoFX] (Main-Browser) Navigating...")
        GroupBox1.Text = "Web Browser - [Navigating]"
        ToolStripLabel1.Text = "Navigating"
        WebBrowser1.Cursor = Cursors.AppStarting
        ToolStripProgressBar1.Visible = True
        OpenPageInDeafultBrowserToolStripMenuItem.Enabled = False
        ToolStripLabel1.Text = "Waiting..."
        ToolStripLabel1.Enabled = False
    End Sub

    Private Sub WebBrowser1_Navigated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WebBrowser1.Navigated
        ToolStripLabel1.Text = WebBrowser1.DocumentTitle
        PictureBox2.Visible = False
        Label9.Visible = False
        ListBox1.Items.Add("[GeckoFX] (Main-Browser) Navigation Completed")
        GroupBox1.Text = "Web Browser - [" & WebBrowser1.DocumentTitle.ToString & "]"
        TextBoxX1.Text = WebBrowser1.Document.Url.ToString
        WebBrowser1.Cursor = Cursors.Default
        ToolStripProgressBar1.Visible = False
        OpenPageInDeafultBrowserToolStripMenuItem.Enabled = True
        ToolStripLabel1.Text = WebBrowser1.DocumentTitle.ToString
    End Sub

    Private Sub Button17_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        WebBrowser1.Navigate(My.Settings.Havok_Browser_HomepageURL.ToString)
    End Sub

    Private Sub WebBrowser1_JavascriptError(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WebBrowser1.JavascriptError
        If My.Settings.Havok_Interface_Browser_NotifyOnJavascriptError = "true" Then
            ListBox1.Items.Add("There Has Been A Javascript Error On This Page: " & WebBrowser1.Url.ToString)
        End If
        If My.Settings.Havok_Interface_Browser_NotifyOnJavascriptError = "false" Then
            'DO NOTHIN, This Really doesn't need to be here
        End If
    End Sub

    Private Sub WebBrowser1_Redirecting(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WebBrowser1.Redirecting
        If My.Settings.Havok_Interface_Browser_NotifyOnRedirect = "true" Then
            ListBox1.Items.Add("The Page : " & WebBrowser1.Url.ToString & " Is Redirecting...")
        End If
        If My.Settings.Havok_Interface_Browser_NotifyOnRedirect = "false" Then
            'DO NOTHIN, This Really doesn't need to be here
        End If
    End Sub

    Private Sub WebBrowser1_SecurityStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If My.Settings.Havok_Browser_NotifyOnSecurityStateChanged = "true" Then
            ListBox1.Items.Add("The Security State Has Been Changed!")
        End If
        If My.Settings.Havok_Browser_NotifyOnSecurityStateChanged = "false" Then
            'DO NOTHIN, This Really doesn't need to be here
        End If
    End Sub

    Private Sub Network_Avalibility_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub ToolStripStatusLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabel1.TextChanged
        If ToolStripStatusLabel1.Text = "Network Available: Yes" Then
            NotifyIcon1.BalloonTipText = "You Are Connected To A Network!"
            NotifyIcon1.ShowBalloonTip(50)
        End If
        If ToolStripStatusLabel1.Text = "Network Available: No" Then
            NotifyIcon1.BalloonTipText = "You Are Not Connected To A Network!"
            NotifyIcon1.ShowBalloonTip(50)
        End If
    End Sub

    Private Sub OpenPageInDeafultBrowserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenPageInDeafultBrowserToolStripMenuItem.Click
        Process.Start(WebBrowser1.Document.Url.ToString)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        'START MULTITASKING CODE HERE
        'START MULTITASKING CODE HERE
        'START MULTITASKING CODE HERE
        'START MULTITASKING CODE HERE
        'START MULTITASKING CODE HERE
        'START MULTITASKING CODE HERE
        'START MULTITASKING CODE HERE
        'START MULTITASKING CODE HERE

        If ComboBox1.Text = "HGetter" Then
            'If HGetter.Visible = True Then
            '    Button2.Enabled = False
            '    Button4.Enabled = True
            'Else
            '    Button2.Enabled = True
            '    Button4.Enabled = False
            'End If
        End If

        If ComboBox1.Text = "HPusher" Then
            If HPusher.Visible = True Then
                Button2.Enabled = False
                Button4.Enabled = True
            Else
                Button2.Enabled = True
                Button4.Enabled = False
            End If
        End If

        If ComboBox1.Text = "RouterAdmin" Then
            'If RouterAdmin.Visible = True Then
            '    Button2.Enabled = False
            '    Button4.Enabled = True
            'Else
            '    Button2.Enabled = True
            '    Button4.Enabled = False
            'End If
        End If

        If ComboBox1.Text = "UDP-Flooder" Then
            'If UDPFlooder.Visible = True Then
            '    Button2.Enabled = False
            '    Button4.Enabled = True
            'Else
            '    Button2.Enabled = True
            '    Button4.Enabled = False
            'End If
        End If




        'STOP MULTITASKING CODE HERE
        'STOP MULTITASKING CODE HERE
        'STOP MULTITASKING CODE HERE
        'STOP MULTITASKING CODE HERE
        'STOP MULTITASKING CODE HERE
        'STOP MULTITASKING CODE HERE
        'STOP MULTITASKING CODE HERE
        If My.Settings.Havok_Environment_RememberLastTyped = "true" Then
            My.Settings.Havok_Environment_LastTyped_LastSelectedWeapon = ComboBox1.Text.ToString
            My.Settings.Save()
        End If
    End Sub

    Private Sub NetStatusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NetStatusToolStripMenuItem.Click
        NetStatus.Show()
    End Sub

    Private Sub NetStatusToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        NetStatus.Show()
    End Sub

    Private Sub Network_Connected()
        NetStatus.PictureBox1.Visible = False
        NetStatus.PictureBox2.Visible = True
        ToolStripStatusLabel1.Text = "You Are Connected To A Network!"
        ToolStripStatusLabel1.ForeColor = Color.Green
        NetStatus.LabelX2.Text = "Connected!"
        NetStatus.LabelX2.ForeColor = Color.Green
    End Sub

    Private Sub Network_Disconnected()
        NetStatus.PictureBox1.Visible = True
        NetStatus.PictureBox2.Visible = False
        ToolStripStatusLabel1.Text = "You Are Not Connected To A Network!"
        ToolStripStatusLabel1.ForeColor = Color.Red
        NetStatus.LabelX2.Text = "Disconnected."
        NetStatus.LabelX2.ForeColor = Color.Red
    End Sub


    Private Sub NetMonTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NetMonTimer.Tick
        If My.Computer.Network.IsAvailable = True Then
            Network_Connected()
        Else
            Network_Disconnected()
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        If My.Settings.Havok_Environment_RememberLastTyped = "true" Then
            My.Settings.Havok_Environment_LastTyped_LastTypedMiscBox = TextBox2.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If My.Settings.Havok_Environment_RememberLastTyped = "true" Then
            My.Settings.Havok_Environment_LastTyped_LastTypedIPAddress = TextBox1.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        If My.Settings.Havok_Environment_RememberLastTyped = "true" Then
            My.Settings.Havok_Environment_LastTyped_LastTypedPort = TextBox3.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        WebBrowser1.Navigate(TextBoxX1.Text)
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub LabelX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel1.DoubleClick
        'New feature coming here soon.
    End Sub

    Private Sub MinimizeToTrayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MinimizeToTrayToolStripMenuItem.Click
        Me.Hide()
    End Sub

    Private Sub CheckForUpdatesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckForUpdatesToolStripMenuItem1.Click
        'Updates.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Preferences.ShowDialog()
    End Sub

    Private Sub PreferencesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreferencesToolStripMenuItem.Click
        Preferences.ShowDialog()
    End Sub

    Private Sub RestartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestartToolStripMenuItem.Click
        Application.Restart()
    End Sub

    Private Sub BreakDebuggerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BreakDebuggerToolStripMenuItem.Click
        Debugger.Break()
    End Sub

    Private Sub VisitDeavmisSIteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VisitDeavmisSIteToolStripMenuItem.Click
        Process.Start("http://deavmi.github.io/Deavmi")
    End Sub

    Private Sub MinimizeToTrayToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MinimizeToTrayToolStripMenuItem1.Click
        Me.Hide()
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WebBrowser1.DocumentCompleted
        ToolStripLabel1.Enabled = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'UDPFlooder.Show()
    End Sub

    Private Sub ExternelInstanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExternelInstanceToolStripMenuItem.Click
        Shell("Havok.exe")
    End Sub

    Private Sub OnSameInstanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OnSameInstanceToolStripMenuItem.Click
        Dim newsession As Form1 = New Form1
        newsession.Show()
    End Sub

    Private Sub NewSessionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewSessionToolStripMenuItem.Click
        If My.Settings.Havok_Environment_StartNewSessionsOnSameInstance = "true" Then
            Dim newsession As Form1 = New Form1
            newsession.Show()
        End If
        If My.Settings.Havok_Environment_StartNewSessionsOnSameInstance = "false" Then
            Shell("Havok.exe")
        End If
    End Sub
End Class





