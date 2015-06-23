Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub bcLauncher_Click(sender As System.Object, e As System.EventArgs) Handles bcLauncher.Click
        ' Dim realmPath As String = Nothing
        Dim realmName As String = Nothing
        ' realmPath = InputBox("Enter your Realmlist Path.", "Realmlist Path", , , )
        realmName = InputBox("Enter your new Realmlist.", "Realmlist Edit", , , )

        If Not String.IsNullOrEmpty(realmName) Then
            FileOpen(1, "F:\Programs\World of Warcraft 2.4.3\realmlist.wtf", OpenMode.Output)
            PrintLine(1, "set realmlist " + realmName)
            FileClose(1)
        End If

        System.Diagnostics.Process.Start("F:\Programs\World of Warcraft 2.4.3\wow.exe")
    End Sub

    Private Sub wotlkLauncher_Click(sender As System.Object, e As System.EventArgs) Handles wotlkLauncher.Click
        '  Dim realmPath As String = Nothing
        Dim realmName As String = Nothing
        ' realmPath = InputBox("Enter your Realmlist Path.", "Realmlist Path", , , )
        realmName = InputBox("Enter your new Realmlist.", "Realmlist Edit", , , )

        If Not String.IsNullOrEmpty(realmName) Then
            FileOpen(1, "F:\Programs\World of Warcraft 3.3.5\Data\enUS\realmlist.wtf", OpenMode.Output)
            PrintLine(1, "set realmlist " + realmName)
            FileClose(1)
        End If

        System.Diagnostics.Process.Start("F:\Programs\World of Warcraft 3.3.5\wow.exe")
    End Sub

    Private Sub cataLauncher_Click(sender As System.Object, e As System.EventArgs) Handles cataLauncher.Click

        ' Dim realmPath As String = Nothing
        Dim realmName As String = Nothing
        ' realmPath = InputBox("Enter your Realmlist Path.", "Realmlist Path", , , )
        realmName = InputBox("Enter your new Realmlist.", "Realmlist Edit", , , )

        If Not String.IsNullOrEmpty(realmName) Then
            FileOpen(1, "F:\Programs\World ofWarcraft 4.3.4\Data\enGB\realmlist.wtf", OpenMode.Output) 'Hard coded in because I'm too lazy to find path always for personal use.'
            PrintLine(1, "set realmlist " + realmName)
            FileClose(1)
        End If
        System.Diagnostics.Process.Start("F:\Programs\World ofWarcraft 4.3.4\WoW-x64.exe")
    End Sub

    Private Sub exitButton_Click(sender As System.Object, e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
