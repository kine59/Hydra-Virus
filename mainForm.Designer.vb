<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainForm))
        Me.oathLabel = New System.Windows.Forms.Label()
        Me.author = New System.Windows.Forms.Label()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'oathLabel
        '
        Me.oathLabel.AutoSize = True
        Me.oathLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oathLabel.Location = New System.Drawing.Point(160, 23)
        Me.oathLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.oathLabel.Name = "oathLabel"
        Me.oathLabel.Size = New System.Drawing.Size(0, 22)
        Me.oathLabel.TabIndex = 0
        Me.oathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'author
        '
        Me.author.AutoSize = True
        Me.author.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.author.Location = New System.Drawing.Point(11, 127)
        Me.author.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.author.Name = "author"
        Me.author.Size = New System.Drawing.Size(177, 15)
        Me.author.TabIndex = 1
        Me.author.Text = "Author: Nguyen Hoang Gia Bao"
        Me.author.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'logo
        '
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.Location = New System.Drawing.Point(30, 0)
        Me.logo.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(126, 124)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logo.TabIndex = 2
        Me.logo.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(284, 101)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(166, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(549, 144)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.author)
        Me.Controls.Add(Me.oathLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "mainForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hydra Virus"
        Me.TopMost = True
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents oathLabel As Label
    Friend WithEvents author As Label
    Friend WithEvents logo As PictureBox
    Friend WithEvents Button1 As Button
End Class
