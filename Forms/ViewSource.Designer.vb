<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSource
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewSource))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GeckoWebBrowser1 = New Gecko.GeckoWebBrowser()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.AutomaticRefresher = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Location = New System.Drawing.Point(-5, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 35)
        Me.Panel1.TabIndex = 21
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(520, -2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(26, 23)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "_"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-2, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(46, 46)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Ubuntu", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(228, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 24)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "View Source"
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Location = New System.Drawing.Point(552, -2)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(26, 23)
        Me.Button8.TabIndex = 6
        Me.Button8.Text = "X"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button17
        '
        Me.Button17.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button17.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button17.Image = CType(resources.GetObject("Button17.Image"), System.Drawing.Image)
        Me.Button17.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button17.Location = New System.Drawing.Point(435, 468)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(138, 27)
        Me.Button17.TabIndex = 1
        Me.Button17.Text = "&Refresh Source"
        Me.Button17.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(13, 468)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 27)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "&Copy To Clipboard"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(157, 468)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(138, 27)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "&Save As Text File "
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GeckoWebBrowser1
        '
        Me.GeckoWebBrowser1.DisableWmImeSetContext = False
        Me.GeckoWebBrowser1.Location = New System.Drawing.Point(13, 76)
        Me.GeckoWebBrowser1.Name = "GeckoWebBrowser1"
        Me.GeckoWebBrowser1.NoDefaultContextMenu = True
        Me.GeckoWebBrowser1.Size = New System.Drawing.Size(560, 386)
        Me.GeckoWebBrowser1.TabIndex = 41
        Me.GeckoWebBrowser1.UseHttpActivityObserver = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Ubuntu", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(13, 41)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(37, 29)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "&<"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Ubuntu", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(56, 41)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(37, 29)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "&>"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(99, 41)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(474, 29)
        Me.LabelX1.TabIndex = 44
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'AutomaticRefresher
        '
        '
        'ViewSource
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 507)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GeckoWebBrowser1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button17)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ViewSource"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Source"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button17 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GeckoWebBrowser1 As Gecko.GeckoWebBrowser
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents AutomaticRefresher As System.Windows.Forms.Timer
End Class
