<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LicenseAgreement
    Inherits DevComponents.DotNetBar.Metro.MetroForm

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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LaTooltip = New DevComponents.DotNetBar.SuperTooltip()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(9, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(317, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "You Must Agree To The License Agreement Below To Continue..."
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.White
        Me.RichTextBox1.ForeColor = System.Drawing.Color.Black
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 56)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(754, 513)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = "This software is registered under GNU's General Public License Version 3 (GPLv3) " & _
            "which can be obtained at <http://gnu.org/licenses/gpl.txt>"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(648, 575)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 32)
        Me.LaTooltip.SetSuperTooltip(Me.Button1, New DevComponents.DotNetBar.SuperTooltipInfo("", "", "Decline The License Agreement", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray, False, False, New System.Drawing.Size(0, 0)))
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "&Decline"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(524, 575)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 32)
        Me.LaTooltip.SetSuperTooltip(Me.Button2, New DevComponents.DotNetBar.SuperTooltipInfo("", "", "Accept The License Agreement", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray, False, False, New System.Drawing.Size(0, 0)))
        Me.Button2.TabIndex = 3
        Me.Button2.Tag = "XC"
        Me.Button2.Text = "&Accept"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'LicenseAgreement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ClientSize = New System.Drawing.Size(786, 622)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LicenseAgreement"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "XC"
        Me.Text = "License Agreement"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents LaTooltip As DevComponents.DotNetBar.SuperTooltip
End Class
