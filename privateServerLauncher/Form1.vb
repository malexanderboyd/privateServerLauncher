Public Class Launcher

    Dim bcPath As String
    Dim wotlkPath As String
    Dim cataPath As String

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' Testing Purposes for right now...
        ' My.Settings.Reset()

        settupPaths()


    End Sub
    Public Function settupPaths() As Boolean


        Dim pathChecker1 As Boolean
        Dim pathChecker2 As Boolean
        Dim pathChecker3 As Boolean
        pathChecker1 = False
        pathChecker2 = False
        pathChecker3 = False
        If My.Settings.bcPath <> "" Then
            pathChecker1 = True
            bcPath = My.Settings.bcPath
        End If
        If My.Settings.wotlkPath <> "" Then
            pathChecker2 = True
            wotlkPath = My.Settings.wotlkPath
        End If
        If My.Settings.cataPath <> "" Then
            pathChecker3 = True
            cataPath = My.Settings.cataPath
        End If

        If pathChecker1 = False Then
            bcPathLabel.Text = "Path not set!"
        Else
            bcPathLabel.Text = ""
        End If

        If pathChecker2 = False Then
            wotlkPathLabel.Text = "Path not set!"
        Else
            wotlkPathLabel.Text = ""
        End If

        If pathChecker3 = False Then
            cataPathLabel.Text = "Path not set!"
        Else
            cataPathLabel.Text = ""
        End If




        Return True

    End Function
    Private Sub bcLauncher_Click(sender As System.Object, e As System.EventArgs) Handles bcLauncher.Click
        ' Dim realmPath As String = Nothing
        Dim realmName As String = Nothing
        ' realmPath = InputBox("Enter your Realmlist Path.", "Realmlist Path", , , )
        realmName = InputBox("Enter your new Realmlist.", "Realmlist Edit", , , )

        If Not String.IsNullOrEmpty(realmName) Then
            FileOpen(1, "F:\Programs\World of Warcraft 2.4.3\realmlist.wtf", OpenMode.Output)
            PrintLine(1, "set realmlist " + realmName)
            FileClose(1)
            If (bcPath.Length > 0) Then
                System.Diagnostics.Process.Start(bcPath + "\wow.exe")
            Else


            End If
        End If


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
            If (wotlkPath.Length > 0) Then
                System.Diagnostics.Process.Start(wotlkPath + "\wow.exe")
            Else


            End If

        End If




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
            If (cataPath.Length > 0) Then
                System.Diagnostics.Process.Start(cataPath + "\WoW-x64.exe")
            Else


            End If
        End If

    End Sub

    Private Sub exitButton_Click(sender As System.Object, e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub settings_Click(sender As System.Object, e As System.EventArgs) Handles settings.Click
        Dim Form2 As New Settings
        Form2.Show()
        Me.Refresh()
    End Sub
End Class
