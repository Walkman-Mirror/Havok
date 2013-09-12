Imports System.IO
Public Class Tolly

    Private Sub Tolly_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LabelX1.ForeColor = Color.Black
        LabelX2.ForeColor = Color.Black
        LabelX1.Text = My.Application.Info.ProductName
        LabelX2.Text = My.Application.Info.Version.ToString
        ProgressBarX1.Text = "Starting Up..."
        StartupDepotChecker.RunWorkerAsync()
        If My.Settings.Havok_Interface_ChestaGUI = "1" Then
            ProgressBarX1.Text = "Starting Up... (With Chesta)"
        End If
        If My.Settings.Havok_Interface_ChestaGUI = "0" Then
            ProgressBarX1.Text = "Starting Up..."
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles StartupDepotChecker.DoWork
        If File.Exists("C:\WINDOWS\Fonts\Ubuntu-R.ttf") Then

        Else
            ProgressBarX1.Text = "Downloading Files..."
            My.Computer.Network.DownloadFile("http://deavmi.3owl.com/wp-content/projects/havok/file_store/Ubuntu-R.ttf", "C:\WINDOWS\Fonts\Ubuntu-R.ttf")
            ProgressBarX1.Text = "Starting Up..."
        End If
    End Sub

    Private Sub LabelX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelX1.Click

    End Sub

    Private Sub LabelX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelX2.Click

    End Sub
End Class

