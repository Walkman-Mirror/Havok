Imports System.IO
Public Class Tolly

    Private Sub Tolly_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.Havok_Interface_UseDoubleBuffers = "true" Then
            Me.DoubleBuffered = True
        End If
        If My.Settings.Havok_Interface_UseDoubleBuffers = "false" Then
            Me.DoubleBuffered = False
        End If
        LabelX1.Text = My.Application.Info.ProductName
        LabelX2.Text = My.Application.Info.Version.ToString
        ProgressBarX1.Text = "Starting Up..."
    End Sub
End Class

