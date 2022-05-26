Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Button_Chrome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Chrome.Click
        Dim p As New Process()
        p.StartInfo.FileName = "chrome.exe"
        p.Start()
    End Sub

    Private Sub Button_Word_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Word.Click
        Dim p As New Process()
        p.StartInfo.FileName = "WINWORD.EXE"
        p.Start()
    End Sub

    Private Sub Button_PowerPoint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_PowerPoint.Click
        Dim p As New Process()
        p.StartInfo.FileName = "POWERPNT.EXE"
        p.Start()
    End Sub

    Private Sub Button_Excel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Excel.Click
        Dim p As New Process()
        p.StartInfo.FileName = "EXCEL.EXE"
        p.Start()
    End Sub

    Private Sub Button_Internet_Google_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Internet_Google.Click
        Dim p As New Process()
        p.StartInfo.FileName = "chrome.exe"
        p.StartInfo.Arguments = "google.com"
        p.Start()
    End Sub

    Private Sub Button_Internet_Facebook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Internet_Facebook.Click
        Dim p As New Process()
        p.StartInfo.FileName = "chrome.exe"
        p.StartInfo.Arguments = "facebook.com"
        p.Start()
    End Sub
End Class
