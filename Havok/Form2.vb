﻿Imports System.IO
Public Class Updates

    Private Sub GeckoWebBrowser1_Navigated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeckoWebBrowser1.Navigated
        Form1.PictureBox2.Visible = False
        Form1.Label9.Visible = False
        Form1.ListBox1.Items.Add("Loading Web Page 2... [Done]")
        Label1.Text = "Finishing up..."
    End Sub

    Private Sub GeckoWebBrowser1_Navigating(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeckoWebBrowser1.Navigating
        Form1.PictureBox2.Visible = True
        Form1.Label9.Visible = True
        Form1.Label9.Text = "Loading Web Page 2..."
        Form1.ListBox1.Items.Add("Loading Web Page 2...")
        Label1.Text = "Checking for updates..."
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        GeckoWebBrowser1.Visible = True
        GeckoWebBrowser1.Navigate("http://deavmi.github.io/Havok/#application")
    End Sub

    Private Sub GeckoWebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeckoWebBrowser1.DocumentCompleted
        Label1.Text = "Update check completed!"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox("We will now open a link in your browser to download the update package, sorry but Google ites doesn't allow direct file downloads.")

    End Sub

    Private Sub Updates_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.Havok_Interface_UseDoubleBuffers = "true" Then
            Me.DoubleBuffered = True
        End If
        If My.Settings.Havok_Interface_UseDoubleBuffers = "false" Then
            Me.DoubleBuffered = False
        End If
    End Sub
End Class
