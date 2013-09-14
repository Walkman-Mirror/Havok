Public Class HPusher

   

    Private Sub HPusher_Loaaaad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form1.ListBox1.Items.Add("---------------------------")
        Form1.ListBox1.Items.Add("HPusher Has Started!")
        'Set Status Texts In The Status Group Box
        Label12.Text = "File 1: Idle"
        Label13.Text = "File 2: Idle"
        Label14.Text = "File 3: Idle"
        Label15.Text = "File 4: Idle"
        Label16.Text = "File 5: Idle"
        'Set The ForeColor of The Labels
        Label1.ForeColor = Color.Red
        Label7.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label9.ForeColor = Color.Red
        Label8.ForeColor = Color.Red
        Label6.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label11.ForeColor = Color.Red
        Label10.ForeColor = Color.Red
        'Initialize HGetter's Background Woker To Support Cancelation Even Though This Will Only BE For Use In Havok 3.1 or When I get An Answer FRom A Developer On CodeProject
        HPusher_File_1_Uploader.WorkerSupportsCancellation = True
        HPusher_File_2_Uploader.WorkerSupportsCancellation = True
        HPusher_File_3_Uploader.WorkerSupportsCancellation = True
        HPusher_File_4_Uploader.WorkerSupportsCancellation = True
        HPusher_File_5_Uploader.WorkerSupportsCancellation = True
    End Sub




    Private Sub HPusher_Closed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Form1.ListBox1.Items.Add("---------------------------")
        Form1.ListBox1.Items.Add("HGetter Has Stopped!")

    End Sub
    Private Sub HPusher_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosing

        Form1.PictureBox2.Hide()
        Form1.Label9.Visible = "False"
        Form1.Button2.Enabled = "True"
        Form1.Button4.Enabled = "False"
        Form1.ComboBox1.Enabled = "True"
        Form1.ListBox1.Items.Add("---------------------------")
        Form1.ListBox1.Items.Add("Stoping HPusher...")
        Form1.TextBox1.Enabled = "True"
        Form1.TextBox2.Enabled = "True"
        Form1.TextBox3.Enabled = "True"
        If HPusher_File_1_Uploader.IsBusy = True Then
            HPusher_File_1_Uploader.CancelAsync()
        End If
        If HPusher_File_2_Uploader.IsBusy = True Then
            HPusher_File_2_Uploader.CancelAsync()
        End If
        If HPusher_File_3_Uploader.IsBusy = True Then
            HPusher_File_3_Uploader.CancelAsync()
        End If
        If HPusher_File_4_Uploader.IsBusy = True Then
            HPusher_File_4_Uploader.CancelAsync()
        End If
        If HPusher_File_5_Uploader.IsBusy = True Then
            HPusher_File_5_Uploader.CancelAsync()
        End If
    End Sub




    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.Close()
    End Sub


    Private Sub HGetter_File_1_Uploader_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles HPusher_File_1_Uploader.DoWork
        If TextBox2.Text = "" And TextBox6.Text = "" Then

        Else
            Button3.Enabled = True
            Button9.Enabled = False
            TextBox2.Enabled = False
            TextBox6.Enabled = False
            Label12.Text = "File 1: Uploading..."
            Label1.ForeColor = Color.Green
            Label7.ForeColor = Color.Green
            My.Computer.Network.UploadFile(TextBox2.Text, TextBox6.Text)
            Label12.Text = "File 1: Idle"
            Label1.ForeColor = Color.Red
            Label7.ForeColor = Color.Red
            Button3.Enabled = False
            TextBox2.Enabled = True
            TextBox6.Enabled = True
            Button9.Enabled = True
        End If
    End Sub

    Private Sub HGetter_File_2_Uploader_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles HPusher_File_2_Uploader.DoWork
        If TextBox3.Text = "" And TextBox1.Text = "" Then

        Else
            TextBox3.Enabled = False
            TextBox1.Enabled = False
            Button10.Enabled = False
            Button4.Enabled = True
            Label13.Text = "File 2: Uploading..."
            Label3.ForeColor = Color.Green
            Label2.ForeColor = Color.Green
            My.Computer.Network.UploadFile(TextBox3.Text, TextBox1.Text)
            Label13.Text = "File 2: Idle"
            Label3.ForeColor = Color.Red
            Label2.ForeColor = Color.Red
            Button4.Enabled = False
            TextBox3.Enabled = True
            TextBox1.Enabled = True
            Button10.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        HPusher_File_1_Uploader.RunWorkerAsync()
        HPusher_File_2_Uploader.RunWorkerAsync()
        HPusher_File_3_Uploader.RunWorkerAsync()
        HPusher_File_4_Uploader.RunWorkerAsync()
        HPusher_File_5_Uploader.RunWorkerAsync()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If HPusher_File_1_Uploader.IsBusy = True Then
            HPusher_File_1_Uploader.CancelAsync()
            Label12.Text = "File 1: Idle"


            'DESTROING ALL LAZZZZZZZZZZERS
            Label1.ForeColor = Color.Red
            Label2.ForeColor = Color.Red
            Label3.ForeColor = Color.Red
            Label4.ForeColor = Color.Red
            Label6.ForeColor = Color.Red
            Label7.ForeColor = Color.Red
            Label8.ForeColor = Color.Red
            Label9.ForeColor = Color.Red
            Label10.ForeColor = Color.Red
            Label11.ForeColor = Color.Red




            'Yes Budy
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False


            'Yes Budy
            Button9.Enabled = True
            Button10.Enabled = True
            Button11.Enabled = True
            Button12.Enabled = True
            Button13.Enabled = True

            'Yes Budy
            TextBox2.Enabled = True
            TextBox1.Enabled = True
            TextBox3.Enabled = True
            TextBox4.Enabled = True
            TextBox5.Enabled = True
            TextBox6.Enabled = True
            TextBox7.Enabled = True
            TextBox8.Enabled = True
            TextBox9.Enabled = True
            TextBox10.Enabled = True
        End If

        If HPusher_File_2_Uploader.IsBusy = True Then
            HPusher_File_2_Uploader.CancelAsync()
            Label13.Text = "File 2: Idle"
            Label3.ForeColor = Color.Red
            Label2.ForeColor = Color.Red

            'DESTROING ALL LAZZZZZZZZZZERS
            Label1.ForeColor = Color.Red
            Label2.ForeColor = Color.Red
            Label3.ForeColor = Color.Red
            Label4.ForeColor = Color.Red
            Label6.ForeColor = Color.Red
            Label7.ForeColor = Color.Red
            Label8.ForeColor = Color.Red
            Label9.ForeColor = Color.Red
            Label10.ForeColor = Color.Red
            Label11.ForeColor = Color.Red


            'Yes Budy
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False


            'Yes Budy
            Button9.Enabled = True
            Button10.Enabled = True
            Button11.Enabled = True
            Button12.Enabled = True
            Button13.Enabled = True

            'Yes Budy
            TextBox2.Enabled = True
            TextBox1.Enabled = True
            TextBox3.Enabled = True
            TextBox4.Enabled = True
            TextBox5.Enabled = True
            TextBox6.Enabled = True
            TextBox7.Enabled = True
            TextBox8.Enabled = True
            TextBox9.Enabled = True
            TextBox10.Enabled = True
        End If

        If HPusher_File_3_Uploader.IsBusy = True Then
            HPusher_File_3_Uploader.CancelAsync()
            Label14.Text = "File 3: Idle"
            Label9.ForeColor = Color.Red
            Label8.ForeColor = Color.Red



            'DESTROING ALL LAZZZZZZZZZZERS
            Label1.ForeColor = Color.Red
            Label2.ForeColor = Color.Red
            Label3.ForeColor = Color.Red
            Label4.ForeColor = Color.Red
            Label6.ForeColor = Color.Red
            Label7.ForeColor = Color.Red
            Label8.ForeColor = Color.Red
            Label9.ForeColor = Color.Red
            Label10.ForeColor = Color.Red
            Label11.ForeColor = Color.Red



            'Yes Budy
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False


            'Yes Budy
            Button9.Enabled = True
            Button10.Enabled = True
            Button11.Enabled = True
            Button12.Enabled = True
            Button13.Enabled = True

            'Yes Budy
            TextBox2.Enabled = True
            TextBox1.Enabled = True
            TextBox3.Enabled = True
            TextBox4.Enabled = True
            TextBox5.Enabled = True
            TextBox6.Enabled = True
            TextBox7.Enabled = True
            TextBox8.Enabled = True
            TextBox9.Enabled = True
            TextBox10.Enabled = True
        End If


        If HPusher_File_4_Uploader.IsBusy = True Then
            HPusher_File_4_Uploader.CancelAsync()
            Label15.Text = "File 4: Idle"
            Label6.ForeColor = Color.Red
            Label4.ForeColor = Color.Red


            'DESTROING ALL LAZZZZZZZZZZERS
            Label1.ForeColor = Color.Red
            Label2.ForeColor = Color.Red
            Label3.ForeColor = Color.Red
            Label4.ForeColor = Color.Red
            Label6.ForeColor = Color.Red
            Label7.ForeColor = Color.Red
            Label8.ForeColor = Color.Red
            Label9.ForeColor = Color.Red
            Label10.ForeColor = Color.Red
            Label11.ForeColor = Color.Red


            'Yes Budy
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False


            'Yes Budy
            Button9.Enabled = True
            Button10.Enabled = True
            Button11.Enabled = True
            Button12.Enabled = True
            Button13.Enabled = True

            'Yes Budy
            TextBox2.Enabled = True
            TextBox1.Enabled = True
            TextBox3.Enabled = True
            TextBox4.Enabled = True
            TextBox5.Enabled = True
            TextBox6.Enabled = True
            TextBox7.Enabled = True
            TextBox8.Enabled = True
            TextBox9.Enabled = True
            TextBox10.Enabled = True
        End If

        If HPusher_File_5_Uploader.IsBusy = True Then
            HPusher_File_5_Uploader.CancelAsync()
            Label16.Text = "File 5: Idle"
            Label11.ForeColor = Color.Red
            Label10.ForeColor = Color.Red



            'DESTROING ALL LAZZZZZZZZZZERS
            Label1.ForeColor = Color.Red
            Label2.ForeColor = Color.Red
            Label3.ForeColor = Color.Red
            Label4.ForeColor = Color.Red
            Label6.ForeColor = Color.Red
            Label7.ForeColor = Color.Red
            Label8.ForeColor = Color.Red
            Label9.ForeColor = Color.Red
            Label10.ForeColor = Color.Red
            Label11.ForeColor = Color.Red





            'Yes Budy
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False


            'Yes Budy
            Button9.Enabled = True
            Button10.Enabled = True
            Button11.Enabled = True
            Button12.Enabled = True
            Button13.Enabled = True

            'Yes Budy
            TextBox2.Enabled = True
            TextBox1.Enabled = True
            TextBox3.Enabled = True
            TextBox4.Enabled = True
            TextBox5.Enabled = True
            TextBox6.Enabled = True
            TextBox7.Enabled = True
            TextBox8.Enabled = True
            TextBox9.Enabled = True
            TextBox10.Enabled = True
        End If

    End Sub

    Private Sub HPusher_File_5_Uploader_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles HPusher_File_5_Uploader.DoWork
        If TextBox10.Text = "" And TextBox9.Text = "" Then

        Else


            TextBox10.Enabled = False
            TextBox9.Enabled = False
            Button7.Enabled = True
            Button13.Enabled = False
            Label16.Text = "File 5: Uploading..."
            Label11.ForeColor = Color.Green
            Label10.ForeColor = Color.Green
            My.Computer.Network.UploadFile(TextBox10.Text, TextBox9.Text)
            Label16.Text = "File 5: Idle"
            Label11.ForeColor = Color.Red
            Label10.ForeColor = Color.Red
            Button7.Enabled = False
            Button13.Enabled = True
            TextBox10.Enabled = True
            TextBox9.Enabled = True
        End If
    End Sub

    Private Sub HPusher_File_4_Uploader_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles HPusher_File_4_Uploader.DoWork
        If TextBox5.Text = "" And TextBox4.Text = "" Then

        Else
            TextBox5.Enabled = False
            TextBox4.Enabled = False
            Button6.Enabled = True
            Button12.Enabled = False
            Label15.Text = "File 4: Uploading..."
            Label6.ForeColor = Color.Green
            Label4.ForeColor = Color.Green
            My.Computer.Network.UploadFile(TextBox5.Text, TextBox4.Text)
            Label15.Text = "File 4: Idle"
            Label6.ForeColor = Color.Red
            Label4.ForeColor = Color.Red
            Button6.Enabled = False
            Button12.Enabled = True
            TextBox5.Enabled = True
            TextBox4.Enabled = True
        End If
    End Sub

    Private Sub HPusher_File_3_Uploader_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles HPusher_File_3_Uploader.DoWork
        If TextBox8.Text = "" And TextBox7.Text = "" Then

        Else
            TextBox8.Enabled = False
            TextBox7.Enabled = False
            Button5.Enabled = True
            Button11.Enabled = False
            Label14.Text = "File 3: Uploading..."
            Label9.ForeColor = Color.Green
            Label8.ForeColor = Color.Green
            My.Computer.Network.UploadFile(TextBox8.Text, TextBox7.Text)
            Label14.Text = "File 3: Idle"
            Label9.ForeColor = Color.Red
            Label8.ForeColor = Color.Red
            Button5.Enabled = False
            Button11.Enabled = True
            TextBox8.Enabled = True
            TextBox7.Enabled = True
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        HPusher_File_1_Uploader.CancelAsync()
        Label12.Text = "File 2: Idle"
        Label1.ForeColor = Color.Red
        Label7.ForeColor = Color.Red
        Button3.Enabled = False
        Button9.Enabled = True
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        HPusher_File_2_Uploader.CancelAsync()
        Label13.Text = "File 2: Idle"
        Label3.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Button4.Enabled = False
        Button10.Enabled = True
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        HPusher_File_3_Uploader.CancelAsync()
        Label14.Text = "File 3: Idle"
        Label9.ForeColor = Color.Red
        Label8.ForeColor = Color.Red
        Button4.Enabled = False
        Button11.Enabled = True
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        HPusher_File_4_Uploader.CancelAsync()
        Label15.Text = "File 4: Idle"
        Label6.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Button6.Enabled = False
        Button12.Enabled = True
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        HPusher_File_5_Uploader.CancelAsync()
        Label16.Text = "File 5: Idle"
        Label11.ForeColor = Color.Red
        Label10.ForeColor = Color.Red
        Button7.Enabled = False
        Button13.Enabled = True
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        HPusher_File_1_Uploader.RunWorkerAsync()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        HPusher_File_2_Uploader.RunWorkerAsync()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        HPusher_File_3_Uploader.RunWorkerAsync()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        HPusher_File_4_Uploader.RunWorkerAsync()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        HPusher_File_5_Uploader.RunWorkerAsync()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Me.Hide()
    End Sub
End Class