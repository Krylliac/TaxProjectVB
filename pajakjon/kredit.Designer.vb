<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class kredit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(kredit))
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(12, 116)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(269, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "PRANESTYA GAUNG WICAKSONO"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.BackgroundImage = CType(resources.GetObject("Button14.BackgroundImage"), System.Drawing.Image)
        Me.Button14.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button14.Location = New System.Drawing.Point(371, 116)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(99, 23)
        Me.Button14.TabIndex = 10
        Me.Button14.Text = "201751101"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.BackgroundImage = CType(resources.GetObject("Button17.BackgroundImage"), System.Drawing.Image)
        Me.Button17.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button17.Location = New System.Drawing.Point(395, 280)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(75, 43)
        Me.Button17.TabIndex = 16
        Me.Button17.Text = "KEMBALI"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'kredit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(489, 346)
        Me.Controls.Add(Me.Button17)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Button3)
        Me.Name = "kredit"
        Me.Text = "201751101"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Button17 As System.Windows.Forms.Button
End Class
