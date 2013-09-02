Public Class RemotePC

    Private Sub RemotePC_Cloaaaaaaaaaaased(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosed
        Form1.ListBox1.Items.Add("---------------------------")
        Form1.ListBox1.Items.Add("Remote-PC Has Stopped!")
    End Sub
    Private Sub RemotePC_Closed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosing
        Form1.PictureBox2.Hide()
        Form1.Label9.Visible = "False"
        Form1.Button2.Enabled = "True"
        Form1.Button4.Enabled = "False"
        Form1.ComboBox1.Enabled = "True"
        Form1.ListBox1.Items.Add("---------------------------")
        Form1.ListBox1.Items.Add("Stoping Remote-PC...")
        Form1.TextBox1.Enabled = "True"
        Form1.TextBox2.Enabled = "True"
        Form1.TextBox3.Enabled = "True"
    End Sub


    Private Sub RemotePC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.Havok_Interface_UseDoubleBuffers = "true" Then
            Me.DoubleBuffered = True
        End If
        If My.Settings.Havok_Interface_UseDoubleBuffers = "false" Then
            Me.DoubleBuffered = False
        End If
        Form1.ListBox1.Items.Add("---------------------------")
        Form1.ListBox1.Items.Add("Remote-PC Has Started!")
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.Close()
    End Sub






    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1.ListBox1.Items.Add("---------------------------")
        Form1.ListBox1.Items.Add("Shutting Down " & TextBox1.Text & "...")
        Shell("/s /m \\" & TextBox1.Text)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button3.Visible = "False"
        GroupBox1.Enabled = "False"
        Button1.Visible = "False"
        Button9.Visible = "True"
        Button11.Visible = "False"
        Button12.Visible = "False"
        Button3.Visible = "False"
        Button10.Visible = "False"

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        GroupBox1.Enabled = "True"
        Button1.Visible = "True"
        Button9.Visible = "False"
        Button3.Visible = "True"
        Button11.Visible = "True"
        Button12.Visible = "True"
        Button3.Visible = "True"
        Button10.Visible = "True"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form1.ListBox1.Items.Add("---------------------------")
        Form1.ListBox1.Items.Add("Starting Advanced CMD Options...")
        Shell("shutdown /i")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Form1.ListBox1.Items.Add("---------------------------")
        Form1.ListBox1.Items.Add("Shutting Down & Restarting " & TextBox1.Text & "...")
        Shell("shutdown /r /m \\" & TextBox1.Text)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form1.ListBox1.Items.Add("---------------------------")
        Form1.ListBox1.Items.Add("Shutting Down " & TextBox1.Text & " With Time Countdown" & "...")
        Shell("shutdown /t " & TextBox2.Text & " /m \\" & TextBox2.Text)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Form1.ListBox1.Items.Add("---------------------------")
        Form1.ListBox1.Items.Add("Shutting Down " & TextBox2.Text & " With Comment" & "...")
        Shell("shutdown /s /c " & TextBox3.Text & " /m \\" & TextBox2.Text)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Form1.ListBox1.Items.Add("---------------------------")
        Form1.ListBox1.Items.Add("Shutting Down & Restarting " & TextBox2.Text & " With Comment" & "...")
        Shell("shutdown /r /c " & TextBox3.Text & " /m \\" & TextBox2.Text)
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Form1.ListBox1.Items.Add("---------------------------")
        Form1.ListBox1.Items.Add("Shutting Down & Restarting " & TextBox1.Text & " With Time Countdown" & "...")
        Shell("shutdown /r " & TextBox2.Text & " /m \\" & TextBox2.Text)
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Form1.ListBox1.Items.Add("---------------------------")
        Form1.ListBox1.Items.Add("Shutting Down & Restarting " & TextBox1.Text & " With Time Countdown & Comment" & "...")
        Shell("shutdown /r /t " & TextBox2.Text & " /c " & TextBox3.Text & " /m \\" & TextBox2.Text)
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Form1.ListBox1.Items.Add("---------------------------")
        Form1.ListBox1.Items.Add("Shutting Down " & TextBox1.Text & " With Time Countdown & Comment" & "...")
        Shell("shutdown /s /t " & TextBox2.Text & " /c " & TextBox3.Text & " /m \\" & TextBox2.Text)
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Me.Hide()
    End Sub
End Class