<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Launcher
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
        Me.cataLauncher = New System.Windows.Forms.Button()
        Me.wotlkLauncher = New System.Windows.Forms.Button()
        Me.bcLauncher = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.settings = New System.Windows.Forms.Button()
        Me.bcPathLabel = New System.Windows.Forms.Label()
        Me.wotlkPathLabel = New System.Windows.Forms.Label()
        Me.cataPathLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cataLauncher
        '
        Me.cataLauncher.Location = New System.Drawing.Point(580, 356)
        Me.cataLauncher.Name = "cataLauncher"
        Me.cataLauncher.Size = New System.Drawing.Size(75, 23)
        Me.cataLauncher.TabIndex = 0
        Me.cataLauncher.Text = "Cataclysm"
        Me.cataLauncher.UseVisualStyleBackColor = True
        '
        'wotlkLauncher
        '
        Me.wotlkLauncher.Location = New System.Drawing.Point(299, 356)
        Me.wotlkLauncher.Name = "wotlkLauncher"
        Me.wotlkLauncher.Size = New System.Drawing.Size(136, 23)
        Me.wotlkLauncher.TabIndex = 1
        Me.wotlkLauncher.Text = "WOTLK"
        Me.wotlkLauncher.UseVisualStyleBackColor = True
        '
        'bcLauncher
        '
        Me.bcLauncher.Location = New System.Drawing.Point(31, 354)
        Me.bcLauncher.Name = "bcLauncher"
        Me.bcLauncher.Size = New System.Drawing.Size(136, 23)
        Me.bcLauncher.TabIndex = 2
        Me.bcLauncher.Text = "Burning Crusade"
        Me.bcLauncher.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(683, 2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(22, 19)
        Me.exitButton.TabIndex = 3
        Me.exitButton.Text = "X"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'settings
        '
        Me.settings.Location = New System.Drawing.Point(13, 13)
        Me.settings.Name = "settings"
        Me.settings.Size = New System.Drawing.Size(75, 23)
        Me.settings.TabIndex = 4
        Me.settings.Text = "Settings"
        Me.settings.UseVisualStyleBackColor = True
        '
        'bcPathLabel
        '
        Me.bcPathLabel.AutoSize = True
        Me.bcPathLabel.Location = New System.Drawing.Point(79, 338)
        Me.bcPathLabel.Name = "bcPathLabel"
        Me.bcPathLabel.Size = New System.Drawing.Size(0, 13)
        Me.bcPathLabel.TabIndex = 6
        '
        'wotlkPathLabel
        '
        Me.wotlkPathLabel.AutoSize = True
        Me.wotlkPathLabel.Location = New System.Drawing.Point(348, 340)
        Me.wotlkPathLabel.Name = "wotlkPathLabel"
        Me.wotlkPathLabel.Size = New System.Drawing.Size(0, 13)
        Me.wotlkPathLabel.TabIndex = 7
        '
        'cataPathLabel
        '
        Me.cataPathLabel.AutoSize = True
        Me.cataPathLabel.Location = New System.Drawing.Point(598, 338)
        Me.cataPathLabel.Name = "cataPathLabel"
        Me.cataPathLabel.Size = New System.Drawing.Size(0, 13)
        Me.cataPathLabel.TabIndex = 8
        '
        'Launcher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.privateServerLauncher.My.Resources.Resources.tumblr_mo1j1iVamH1qmc8m1o1_500
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(717, 391)
        Me.Controls.Add(Me.cataPathLabel)
        Me.Controls.Add(Me.wotlkPathLabel)
        Me.Controls.Add(Me.bcPathLabel)
        Me.Controls.Add(Me.settings)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.bcLauncher)
        Me.Controls.Add(Me.wotlkLauncher)
        Me.Controls.Add(Me.cataLauncher)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Launcher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cataLauncher As System.Windows.Forms.Button
    Friend WithEvents wotlkLauncher As System.Windows.Forms.Button
    Friend WithEvents bcLauncher As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents settings As System.Windows.Forms.Button
    Friend WithEvents bcPathLabel As System.Windows.Forms.Label
    Friend WithEvents wotlkPathLabel As System.Windows.Forms.Label
    Friend WithEvents cataPathLabel As System.Windows.Forms.Label

End Class
