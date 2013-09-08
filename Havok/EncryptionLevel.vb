Imports Gecko
Public Class EncryptionLevel


    Private Sub EncryptionLevel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form1.ListBox1.Items.Add("---------------------------")
        Form1.ListBox1.Items.Add("Encryption-Level Has Started!")


        'Checks The Encryption Level Of Web Browser 1 a.k.a "WebBrowser1" On Form1
        If Form1.WebBrowser1.SecurityState = GeckoSecurityState.Secure = True Then
            Label1.Text = "Encryption Level: Secure"
            Label1.ForeColor = Color.Green
        End If
        If Form1.WebBrowser1.SecurityState = GeckoSecurityState.Insecure = True Then
            Label1.Text = "Encryption Level: Insecure"
            Label1.ForeColor = Color.Red
        End If
        If Form1.WebBrowser1.SecurityState = GeckoSecurityState.Broken = True Then
            Label1.Text = "Encryption Level: Broken"
            Label1.ForeColor = Color.Blue
        End If
    End Sub

    Private Sub EncryptionLevel_Closed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosing
        If Form1.ComboBox1.Text = "Encryption-Level" Then
            Form1.ComboBox1.Enabled = "True"
            Form1.PictureBox2.Show()
            Form1.Label9.Visible = "False"
            Form1.Label9.Text = "Encryption-Level"
            Form1.Button2.Enabled = "True"
            Form1.Button4.Enabled = "False"
            Form1.PictureBox2.Hide()
            Form1.Label9.Visible = "False"
            Form1.TextBox1.Enabled = "True"
            Form1.TextBox2.Enabled = "True"
            Form1.TextBox3.Enabled = "True"
            Form1.ListBox1.Items.Add("---------------------------")
            Form1.ListBox1.Items.Add("Stoping Encryption-Level...")
        End If
    End Sub

    Private Sub EncryptionLevel_Cloaaaaaaaaaaaased(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosed
        Form1.ListBox1.Items.Add("---------------------------")
        Form1.ListBox1.Items.Add("Encryption-Level Has Stoped!")
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Checks The Encryption Level Of Web Browser 1 a.k.a "WebBrowser1" On Form1
        If Form1.WebBrowser1.SecurityState = GeckoSecurityState.Secure = True Then
            Label1.Text = "Encryption Level: Secure"
            Label1.ForeColor = Color.Green
        End If
        If Form1.WebBrowser1.SecurityState = GeckoSecurityState.Insecure = True Then
            Label1.Text = "Encryption Level: Insecure"
            Label1.ForeColor = Color.Red
        End If
        If Form1.WebBrowser1.SecurityState = GeckoSecurityState.Broken = True Then
            Label1.Text = "Encryption Level: Broken"
            Label1.ForeColor = Color.Blue
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub
End Class
