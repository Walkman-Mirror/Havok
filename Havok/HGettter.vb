Imports System.IO
Public Class HGettter





    Private Sub HGettter_Claaaaaaosed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosing
        Form1.PictureBox2.Hide()
        Form1.Label9.Visible = "False"
        Form1.Button2.Enabled = "True"
        Form1.Button4.Enabled = "False"
        Form1.ComboBox1.Enabled = "True"
        Form1.ListBox1.Items.Add("---------------------------")
        Form1.ListBox1.Items.Add("Stoping HGetter...")
        Form1.TextBox1.Enabled = "True"
        Form1.TextBox2.Enabled = "True"
        Form1.TextBox3.Enabled = "True"
        If HGetter_File_1_Downloader.IsBusy = True Then
            HGetter_File_1_Downloader.CancelAsync()
        End If
        If HGetter_File_2_Downloader.IsBusy = True Then
            HGetter_File_2_Downloader.CancelAsync()
        End If
        If HGetter_File_3_Downloader.IsBusy = True Then
            HGetter_File_3_Downloader.CancelAsync()
        End If
        If HGetter_File_4_Downloader.IsBusy = True Then
            HGetter_File_4_Downloader.CancelAsync()
        End If
        If HGetter_File_5_Downloader.IsBusy = True Then
            HGetter_File_5_Downloader.CancelAsync()
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub HGetter_File_1_Downloader_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles HGetter_File_1_Downloader.DoWork
        If TextBox2.Text = "" And TextBox6.Text = "" Then

        Else
            Button3.Enabled = True
            Button9.Enabled = False
            TextBox2.Enabled = False
            TextBox6.Enabled = False
            Label12.Text = "File 1: Downloading..."
            Label1.ForeColor = Color.Green
            Label7.ForeColor = Color.Green
            My.Computer.Network.DownloadFile(TextBox2.Text, TextBox6.Text)
        End If
    End Sub

    Private Sub HGetter_File_1_Downloader_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles HGetter_File_1_Downloader.RunWorkerCompleted
        If TextBox2.Text = "" And TextBox6.Text = "" Then

        Else
            Label12.Text = "File 1: Idle"
            Label1.ForeColor = Color.Red
            Label7.ForeColor = Color.Red
            Button3.Enabled = False
            TextBox2.Enabled = True
            TextBox6.Enabled = True
            Button9.Enabled = True
        End If
    End Sub

    Private Sub HGetter_File_2_Downloader_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles HGetter_File_2_Downloader.RunWorkerCompleted
        If TextBox3.Text = "" And TextBox1.Text = "" Then

        Else
            Label13.Text = "File 2: Idle"
            Label3.ForeColor = Color.Red
            Label2.ForeColor = Color.Red
            Button4.Enabled = False
            TextBox3.Enabled = True
            TextBox1.Enabled = True
            Button10.Enabled = True
        End If
    End Sub

    Private Sub HGetter_File_3_Downloader_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles HGetter_File_3_Downloader.RunWorkerCompleted
        If TextBox8.Text = "" And TextBox7.Text = "" Then

        Else
            Label14.Text = "File 3: Idle"
            Label9.ForeColor = Color.Red
            Label8.ForeColor = Color.Red
            Button5.Enabled = False
            Button11.Enabled = True
            TextBox8.Enabled = True
            TextBox7.Enabled = True
        End If
    End Sub

    Private Sub HGetter_File_4_Downloader_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles HGetter_File_4_Downloader.RunWorkerCompleted
        If TextBox5.Text = "" And TextBox4.Text = "" Then

        Else

            Label15.Text = "File 4: Idle"
            Label6.ForeColor = Color.Red
            Label4.ForeColor = Color.Red
            Button6.Enabled = False
            Button12.Enabled = True
            TextBox5.Enabled = True
            TextBox4.Enabled = True
        End If
    End Sub

    Private Sub HGetter_File_5_Downloader_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles HGetter_File_5_Downloader.RunWorkerCompleted
        If TextBox10.Text = "" And TextBox9.Text = "" Then

        Else
            Label16.Text = "File 5: Idle"
            Label11.ForeColor = Color.Red
            Label10.ForeColor = Color.Red
            Button7.Enabled = False
            Button13.Enabled = True
            TextBox10.Enabled = True
            TextBox9.Enabled = True
        End If
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If HGetter_File_1_Downloader.IsBusy = True Then
            HGetter_File_1_Downloader.CancelAsync()
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

        If HGetter_File_2_Downloader.IsBusy = True Then
            HGetter_File_2_Downloader.CancelAsync()
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

        If HGetter_File_3_Downloader.IsBusy = True Then
            HGetter_File_3_Downloader.CancelAsync()
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


        If HGetter_File_4_Downloader.IsBusy = True Then
            HGetter_File_4_Downloader.CancelAsync()
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

        If HGetter_File_5_Downloader.IsBusy = True Then
            HGetter_File_5_Downloader.CancelAsync()
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
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        HGetter_File_1_Downloader.RunWorkerAsync()
        HGetter_File_2_Downloader.RunWorkerAsync()
        HGetter_File_3_Downloader.RunWorkerAsync()
        HGetter_File_4_Downloader.RunWorkerAsync()
        HGetter_File_5_Downloader.RunWorkerAsync()
    End Sub

    Private Sub HGettter_Closed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosed
        Form1.ListBox1.Items.Add("---------------------------")
        Form1.ListBox1.Items.Add("HGetter Has Stopped!")
    End Sub


    Private Sub HGettter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form1.ListBox1.Items.Add("---------------------------")
        Form1.ListBox1.Items.Add("HGetter Has Started!")
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
        HGetter_File_1_Downloader.WorkerSupportsCancellation = True
        HGetter_File_2_Downloader.WorkerSupportsCancellation = True
        HGetter_File_3_Downloader.WorkerSupportsCancellation = True
        HGetter_File_4_Downloader.WorkerSupportsCancellation = True
        HGetter_File_5_Downloader.WorkerSupportsCancellation = True

    End Sub

    Private Sub HGetter_File_2_Downloader_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles HGetter_File_2_Downloader.DoWork
        If TextBox3.Text = "" And TextBox1.Text = "" Then

        Else
            TextBox3.Enabled = False
            TextBox1.Enabled = False
            Button10.Enabled = False
            Button4.Enabled = True
            Label13.Text = "File 2: Downloading..."
            Label3.ForeColor = Color.Green
            Label2.ForeColor = Color.Green
            My.Computer.Network.DownloadFile(TextBox3.Text, TextBox1.Text)

        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        HGetter_File_2_Downloader.CancelAsync()
        Label13.Text = "File 2: Idle"
        Label3.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Button4.Enabled = False
        Button10.Enabled = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        HGetter_File_1_Downloader.CancelAsync()
        Label12.Text = "File 2: Idle"
        Label1.ForeColor = Color.Red
        Label7.ForeColor = Color.Red
        Button3.Enabled = False
        Button9.Enabled = True
    End Sub

    Private Sub HGetter_File_3_Downloader_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles HGetter_File_3_Downloader.DoWork
        If TextBox8.Text = "" And TextBox7.Text = "" Then

        Else
            TextBox8.Enabled = False
            TextBox7.Enabled = False
            Button5.Enabled = True
            Button11.Enabled = False
            Label14.Text = "File 3: Downloading..."
            Label9.ForeColor = Color.Green
            Label8.ForeColor = Color.Green
            My.Computer.Network.DownloadFile(TextBox8.Text, TextBox7.Text)
         
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        HGetter_File_1_Downloader.RunWorkerAsync()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        HGetter_File_2_Downloader.RunWorkerAsync()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        HGetter_File_3_Downloader.RunWorkerAsync()
    End Sub

    Private Sub HGetter_File_4_Downloader_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles HGetter_File_4_Downloader.DoWork
        If TextBox5.Text = "" And TextBox4.Text = "" Then

        Else
            TextBox5.Enabled = False
            TextBox4.Enabled = False
            Button6.Enabled = True
            Button12.Enabled = False
            Label15.Text = "File 4: Downloading..."
            Label6.ForeColor = Color.Green
            Label4.ForeColor = Color.Green
            My.Computer.Network.DownloadFile(TextBox5.Text, TextBox4.Text)
        End If
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        HGetter_File_4_Downloader.RunWorkerAsync()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        HGetter_File_3_Downloader.CancelAsync()
        Label14.Text = "File 3: Idle"
        Label9.ForeColor = Color.Red
        Label8.ForeColor = Color.Red
        Button4.Enabled = False
        Button11.Enabled = True
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        HGetter_File_4_Downloader.CancelAsync()
        Label15.Text = "File 4: Idle"
        Label6.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Button6.Enabled = False
        Button12.Enabled = True
    End Sub

    Private Sub HGetter_File_5_Downloader_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles HGetter_File_5_Downloader.DoWork
        If TextBox10.Text = "" And TextBox9.Text = "" Then

        Else


            TextBox10.Enabled = False
            TextBox9.Enabled = False
            Button7.Enabled = True
            Button13.Enabled = False
            Label16.Text = "File 5: Downloading..."
            Label11.ForeColor = Color.Green
            Label10.ForeColor = Color.Green
            My.Computer.Network.DownloadFile(TextBox10.Text, TextBox9.Text)
       
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        HGetter_File_5_Downloader.CancelAsync()
        Label16.Text = "File 5: Idle"
        Label11.ForeColor = Color.Red
        Label10.ForeColor = Color.Red
        Button7.Enabled = False
        Button13.Enabled = True
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        HGetter_File_5_Downloader.RunWorkerAsync()
    End Sub
End Class
