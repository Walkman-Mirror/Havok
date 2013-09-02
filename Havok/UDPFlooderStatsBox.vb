Public Class UDPFlooderStatsBox

    Private Sub UDPFlooderStatsBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.Havok_Interface_UseDoubleBuffers = "true" Then
            Me.DoubleBuffered = True
        End If
        If My.Settings.Havok_Interface_UseDoubleBuffers = "false" Then
            Me.DoubleBuffered = False
        End If
    End Sub

    Private Sub LabelX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelX2.TextChanged
        If LabelX2.Text = "Data Recieved: 0" Then
            LabelX2.ForeColor = Color.Red
        Else
            LabelX2.ForeColor = Color.Green
        End If
    End Sub
End Class