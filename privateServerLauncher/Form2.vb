Public Class Settings

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If (My.Settings.bcPath.Length > 0) Then
            bcPathText.Text = My.Settings.bcPath
        End If
        If (My.Settings.wotlkPath.Length > 0) Then
            wotlkPathText.Text = My.Settings.wotlkPath
        End If
        If (My.Settings.cataPath.Length > 0) Then
            cataPathText.Text = My.Settings.cataPath
        End If
        If (My.Settings.vanillaPath.Length > 0) Then
            vanillaPathText.Text = My.Settings.vanillaPath
        End If
    End Sub

    Private Sub bcPathBrowse_Click(sender As System.Object, e As System.EventArgs) Handles bcPathBrowse.Click
        If (bcFolderBrowserDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            bcPathText.Text = bcFolderBrowserDialog.SelectedPath
        End If
    End Sub

    Private Sub wotlkPathBrowse_Click(sender As System.Object, e As System.EventArgs) Handles wotlkPathBrowse.Click
        If (wotlkFolderBrowserDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            wotlkPathText.Text = wotlkFolderBrowserDialog.SelectedPath
        End If
    End Sub

    Private Sub cataPathBrowse_Click(sender As System.Object, e As System.EventArgs) Handles cataPathBrowse.Click
        If (cataFolderBrowserDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            cataPathText.Text = cataFolderBrowserDialog.SelectedPath
        End If
    End Sub

    Private Sub savePathsButton_Click(sender As System.Object, e As System.EventArgs) Handles savePathsButton.Click
        My.Settings.bcPath = bcPathText.Text
        My.Settings.wotlkPath = wotlkPathText.Text
        My.Settings.cataPath = cataPathText.Text
        My.Settings.vanillaPath = vanillaPathText.Text
        My.Settings.Save()
        Launcher.settupPaths()
        Me.Close()
    End Sub

    Private Sub vanillaPathButton_Click(sender As System.Object, e As System.EventArgs) Handles vanillaPathBrowse.Click
        If (vanillaPathBrowseDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            vanillaPathText.Text = vanillaPathBrowseDialog.SelectedPath
        End If
    End Sub


End Class