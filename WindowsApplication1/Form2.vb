Public Class Form2

    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        If ListBox1.SelectedIndex = 0 Then
            Form5.Show()
        ElseIf ListBox1.SelectedIndex = 1 Then
            HtmlTxt.AppendText("<br>" & vbNewLine)
        ElseIf ListBox1.SelectedIndex = 2 Then
            HtmlTxt.AppendText("<input type='text' name='name' value='TextBox'> ")
        ElseIf ListBox1.SelectedIndex = 3 Then
            HtmlTxt.AppendText("<input type='password' name='name' value='passwordBox'> ")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.WebBrowser1.DocumentText = "<html> <body>" & Me.HtmlTxt.Text & "</html> </body>"
        Me.Hide()
        Form3.Show()
        Form1.Style()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.s = Form4.Label1.Text
        Form1.creatHTML()
        Diagnostics.Process.Start("file:///" & Form1.s)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim tc As String = HtmlTxt.Text
        tc = tc.Replace("<a", "< a " & vbNewLine)
        tc = tc.Replace("</a>", vbNewLine & "</a>")
        tc = tc.Replace("<button", "< button " & vbNewLine)
        tc = tc.Replace("</button>", vbNewLine & "</button> ")
        tc = tc.Replace("<font", "< font " & vbNewLine)
        tc = tc.Replace("</font>", vbNewLine & "</font> ")
        tc = tc.Replace("<img", "< img " & vbNewLine)
        tc = tc.Replace("</img>", vbNewLine & "</img> ")
        HtmlTxt.Text = tc
    End Sub
End Class