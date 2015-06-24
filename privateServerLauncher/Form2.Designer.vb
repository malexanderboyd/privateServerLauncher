<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Me.bcPathBrowse = New System.Windows.Forms.Button()
        Me.wotlkPathBrowse = New System.Windows.Forms.Button()
        Me.cataPathBrowse = New System.Windows.Forms.Button()
        Me.bcPathText = New System.Windows.Forms.TextBox()
        Me.bcPathLabel = New System.Windows.Forms.Label()
        Me.wotlkPathLabel = New System.Windows.Forms.Label()
        Me.wotlkPathText = New System.Windows.Forms.TextBox()
        Me.cataPathText = New System.Windows.Forms.TextBox()
        Me.cataPathLabel = New System.Windows.Forms.Label()
        Me.bcFolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.wotlkFolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.cataFolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.savePathsButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bcPathBrowse
        '
        Me.bcPathBrowse.Location = New System.Drawing.Point(551, 51)
        Me.bcPathBrowse.Name = "bcPathBrowse"
        Me.bcPathBrowse.Size = New System.Drawing.Size(25, 23)
        Me.bcPathBrowse.TabIndex = 0
        Me.bcPathBrowse.Text = "..."
        Me.bcPathBrowse.UseVisualStyleBackColor = True
        '
        'wotlkPathBrowse
        '
        Me.wotlkPathBrowse.Location = New System.Drawing.Point(552, 99)
        Me.wotlkPathBrowse.Name = "wotlkPathBrowse"
        Me.wotlkPathBrowse.Size = New System.Drawing.Size(24, 23)
        Me.wotlkPathBrowse.TabIndex = 1
        Me.wotlkPathBrowse.Text = "..."
        Me.wotlkPathBrowse.UseVisualStyleBackColor = True
        '
        'cataPathBrowse
        '
        Me.cataPathBrowse.Location = New System.Drawing.Point(552, 147)
        Me.cataPathBrowse.Name = "cataPathBrowse"
        Me.cataPathBrowse.Size = New System.Drawing.Size(26, 23)
        Me.cataPathBrowse.TabIndex = 2
        Me.cataPathBrowse.Text = "..."
        Me.cataPathBrowse.UseVisualStyleBackColor = True
        '
        'bcPathText
        '
        Me.bcPathText.Location = New System.Drawing.Point(118, 54)
        Me.bcPathText.Name = "bcPathText"
        Me.bcPathText.Size = New System.Drawing.Size(396, 20)
        Me.bcPathText.TabIndex = 3
        '
        'bcPathLabel
        '
        Me.bcPathLabel.AutoSize = True
        Me.bcPathLabel.Location = New System.Drawing.Point(33, 56)
        Me.bcPathLabel.Name = "bcPathLabel"
        Me.bcPathLabel.Size = New System.Drawing.Size(46, 13)
        Me.bcPathLabel.TabIndex = 4
        Me.bcPathLabel.Text = "BC Path"
        '
        'wotlkPathLabel
        '
        Me.wotlkPathLabel.AutoSize = True
        Me.wotlkPathLabel.Location = New System.Drawing.Point(33, 108)
        Me.wotlkPathLabel.Name = "wotlkPathLabel"
        Me.wotlkPathLabel.Size = New System.Drawing.Size(74, 13)
        Me.wotlkPathLabel.TabIndex = 5
        Me.wotlkPathLabel.Text = "WOTLK  Path"
        '
        'wotlkPathText
        '
        Me.wotlkPathText.Location = New System.Drawing.Point(118, 101)
        Me.wotlkPathText.Name = "wotlkPathText"
        Me.wotlkPathText.Size = New System.Drawing.Size(396, 20)
        Me.wotlkPathText.TabIndex = 6
        '
        'cataPathText
        '
        Me.cataPathText.Location = New System.Drawing.Point(118, 150)
        Me.cataPathText.Name = "cataPathText"
        Me.cataPathText.Size = New System.Drawing.Size(396, 20)
        Me.cataPathText.TabIndex = 7
        '
        'cataPathLabel
        '
        Me.cataPathLabel.AutoSize = True
        Me.cataPathLabel.Location = New System.Drawing.Point(33, 157)
        Me.cataPathLabel.Name = "cataPathLabel"
        Me.cataPathLabel.Size = New System.Drawing.Size(54, 13)
        Me.cataPathLabel.TabIndex = 8
        Me.cataPathLabel.Text = "Cata Path"
        '
        'savePathsButton
        '
        Me.savePathsButton.Location = New System.Drawing.Point(269, 211)
        Me.savePathsButton.Name = "savePathsButton"
        Me.savePathsButton.Size = New System.Drawing.Size(75, 23)
        Me.savePathsButton.TabIndex = 9
        Me.savePathsButton.Text = "Save"
        Me.savePathsButton.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 257)
        Me.Controls.Add(Me.savePathsButton)
        Me.Controls.Add(Me.cataPathLabel)
        Me.Controls.Add(Me.cataPathText)
        Me.Controls.Add(Me.wotlkPathText)
        Me.Controls.Add(Me.wotlkPathLabel)
        Me.Controls.Add(Me.bcPathLabel)
        Me.Controls.Add(Me.bcPathText)
        Me.Controls.Add(Me.cataPathBrowse)
        Me.Controls.Add(Me.wotlkPathBrowse)
        Me.Controls.Add(Me.bcPathBrowse)
        Me.Name = "Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bcPathBrowse As System.Windows.Forms.Button
    Friend WithEvents wotlkPathBrowse As System.Windows.Forms.Button
    Friend WithEvents cataPathBrowse As System.Windows.Forms.Button
    Friend WithEvents bcPathText As System.Windows.Forms.TextBox
    Friend WithEvents bcPathLabel As System.Windows.Forms.Label
    Friend WithEvents wotlkPathLabel As System.Windows.Forms.Label
    Friend WithEvents wotlkPathText As System.Windows.Forms.TextBox
    Friend WithEvents cataPathText As System.Windows.Forms.TextBox
    Friend WithEvents cataPathLabel As System.Windows.Forms.Label
    Friend WithEvents bcFolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents wotlkFolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents cataFolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents savePathsButton As System.Windows.Forms.Button
End Class
