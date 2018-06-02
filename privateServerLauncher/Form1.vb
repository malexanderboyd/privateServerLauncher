Public Class Launcher

    Dim bcPath As String
    Dim wotlkPath As String
    Dim cataPath As String
    Dim vanillaPath As String
    Dim legionPath As String
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' Testing Purposes for right now...
        ' My.Settings.Reset()

        settupPaths()


    End Sub
    Public Function settupPaths() As Boolean


        Dim pathChecker1 As Boolean
        Dim pathChecker2 As Boolean
        Dim pathChecker3 As Boolean
        Dim pathChecker4 As Boolean
        Dim pathChecker5 As Boolean
        pathChecker1 = False
        pathChecker2 = False
        pathChecker3 = False
        pathChecker4 = False
        pathChecker5 = False
        If My.Settings.vanillaPath <> "" Then
            pathChecker4 = True
            vanillaPath = My.Settings.vanillaPath
        End If
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
        If My.Settings.legionPath <> "" Then
            pathChecker5 = True
            legionPath = My.Settings.legionPath
        End If

        If pathChecker1 = False Then
            bcPathLabel.Text = " BC Path not set!"
        Else
            bcPathLabel.Text = ""
        End If

        If pathChecker2 = False Then
            wotlkPathLabel.Text = "wotlk Path not set!"
        Else
            wotlkPathLabel.Text = ""
        End If

        If pathChecker3 = False Then
            cataPathLabel.Text = "cata Path not set!"
        Else
            cataPathLabel.Text = ""
        End If
        If pathChecker4 = False Then
            vanillaPathText.Text = "vanilla Path not set!"
        Else
            vanillaPathText.Text = "legion path not set!"
        End If



        Return True

    End Function
    Private Sub bcLauncher_Click(sender As System.Object, e As System.EventArgs) Handles bcLauncher.Click
        ' Dim realmPath As String = Nothing
        Dim realmName As String = Nothing
        ' realmPath = InputBox("Enter your Realmlist Path.", "Realmlist Path", , , )
        realmName = InputBox("Enter your new Realmlist.", "Realmlist Edit", , , )
        If (bcPath.Length > 0) Then
            deleteCacheAndWDB(bcPath)
            If Not String.IsNullOrEmpty(realmName) Then
                FileOpen(1, bcPath + "\realmlist.wtf", OpenMode.Output)
                PrintLine(1, "set realmlist " + realmName)
                FileClose(1)
            End If
            System.Diagnostics.Process.Start(bcPath + "\wow.exe")
        Else


        End If


    End Sub

    Private Sub wotlkLauncher_Click(sender As System.Object, e As System.EventArgs) Handles wotlkLauncher.Click
        '  Dim realmPath As String = Nothing
        Dim realmName As String = Nothing
        ' realmPath = InputBox("Enter your Realmlist Path.", "Realmlist Path", , , )
        realmName = InputBox("Enter your new Realmlist.", "Realmlist Edit", , , )
        If (wotlkPath.Length > 0) Then
            deleteCacheAndWDB(wotlkPath)
            If Not String.IsNullOrEmpty(realmName) Then
                FileOpen(1, wotlkPath + "\Data\enUS\realmlist.wtf", OpenMode.Output)
                PrintLine(1, "set realmlist " + realmName)
                FileClose(1)
            End If
            System.Diagnostics.Process.Start(wotlkPath + "\wow.exe")
        Else


        End If




    End Sub

    Private Sub cataLauncher_Click(sender As System.Object, e As System.EventArgs) Handles cataLauncher.Click

        ' Dim realmPath As String = Nothing
        Dim realmName As String = Nothing
        ' realmPath = InputBox("Enter your Realmlist Path.", "Realmlist Path", , , )
        realmName = InputBox("Enter your new Realmlist.", "Realmlist Edit", , , )
        If (cataPath.Length > 0) Then
            deleteCacheAndWDB(cataPath)
            If Not String.IsNullOrEmpty(realmName) Then
                FileOpen(1, cataPath + "\Data\enGB\realmlist.wtf", OpenMode.Output) 'Hard coded in because I'm too lazy to find path always for personal use.'
                PrintLine(1, "set realmlist " + realmName)
                FileClose(1)
            End If
            System.Diagnostics.Process.Start(cataPath + "\WoW-x64.exe")
        Else


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

    Private Sub vanillaLauncher_Click(sender As System.Object, e As System.EventArgs) Handles vanillaLauncher.Click
        ' Dim realmPath As String = Nothing
        Dim realmName As String = Nothing
        ' realmPath = InputBox("Enter your Realmlist Path.", "Realmlist Path", , , )
        realmName = InputBox("Enter your new Realmlist.", "Realmlist Edit", , , )
        If (vanillaPath.Length > 0) Then
            deleteCacheAndWDB(vanillaPath)
            If Not String.IsNullOrEmpty(realmName) Then
                FileOpen(1, vanillaPath + "\realmlist.wtf", OpenMode.Output)
                PrintLine(1, "set realmlist " + realmName)
                FileClose(1)
            End If
            System.Diagnostics.Process.Start(vanillaPath + "\WoW.exe")
        Else


        End If
    End Sub

    Private Sub LegionButton_Click(sender As Object, e As EventArgs) Handles legionButton.Click
        ' Dim realmPath As String = Nothing
        Dim realmName As String = Nothing
        ' realmPath = InputBox("Enter your Realmlist Path.", "Realmlist Path", , , )
        realmName = InputBox("Enter your new Realmlist.", "Realmlist Edit", , , )
        If (legionPath.Length > 0) Then
            deleteCacheAndWDB(legionPath)
            If Not String.IsNullOrEmpty(realmName) Then
                FileOpen(1, legionPath + "\Data\enGB\realmlist.wtf", OpenMode.Output) 'Hard coded in because I'm too lazy to find path always for personal use.'
                PrintLine(1, "set realmlist " + realmName)
                FileClose(1)
            End If
            System.Diagnostics.Process.Start(legionPath + "\WoW.exe")
        Else


        End If
    End Sub

    Public Function deleteCacheAndWDB(path As String) As Boolean
        If (path.Length > 0) Then
            Dim cachePath As String = My.Computer.FileSystem.CombinePath(path, "Cache")
            Dim wdbPath As String = My.Computer.FileSystem.CombinePath(path, "WDB")
            If (System.IO.Directory.Exists(cachePath)) Then
                System.IO.Directory.Delete(cachePath, True)
                Debug.Print("Deleted Cache")
            End If
            If (System.IO.Directory.Exists(wdbPath)) Then
                System.IO.Directory.Delete(wdbPath, True)
                Debug.Print("Deleted WDB")
            End If
            Return True
        End If
        Return False
    End Function

End Class
