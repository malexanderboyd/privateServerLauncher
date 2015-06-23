<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.privateServerLauncher.My.Resources.Resources.tumblr_mo1j1iVamH1qmc8m1o1_500
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(717, 391)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.bcLauncher)
        Me.Controls.Add(Me.wotlkLauncher)
        Me.Controls.Add(Me.cataLauncher)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cataLauncher As System.Windows.Forms.Button
    Friend WithEvents wotlkLauncher As System.Windows.Forms.Button
    Friend WithEvents bcLauncher As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
