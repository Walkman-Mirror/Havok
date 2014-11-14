Public Class NetStatus

    Private Sub NetStatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.Havok_Interface_UseDoubleBuffers = "true" Then
            Me.DoubleBuffered = True
        End If
        If My.Settings.Havok_Interface_UseDoubleBuffers = "false" Then
            Me.DoubleBuffered = False
        End If
        'Gets The Computer's Name
        LabelX1.Text = My.Computer.Name
    End Sub


    Private Sub Network_Connected()
        PictureBox1.Visible = False
        PictureBox2.Visible = True
        Form1.ToolStripStatusLabel1.Text = "You Are Connected To A Network!"
        Form1.ToolStripStatusLabel1.ForeColor = Color.Green
        LabelX2.Text = "Connected!"
        LabelX2.ForeColor = Color.Green
    End Sub

    Private Sub Network_Disconnected()
        PictureBox1.Visible = True
        PictureBox2.Visible = False
        Form1.ToolStripStatusLabel1.Text = "You Are Not Connected To A Network!"
        Form1.ToolStripStatusLabel1.ForeColor = Color.Red
        LabelX2.Text = "Disconnected."
        LabelX2.ForeColor = Color.Red
    End Sub

    Private Sub status_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If My.Computer.Network.IsAvailable = True Then
            Network_Connected()
        Else
            Network_Disconnected()
        End If
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
End Class