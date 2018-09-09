Public Class Form1
    Public s As String = Form4.Label1.Text
    Sub creatHTML()
        Dim writer As IO.StreamWriter = IO.File.CreateText(s)
        writer.Write(Form2.HtmlTxt.Text)
        writer.Close()
    End Sub
    Sub Style()
        With Form2
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
        End With
        With Form3
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
        End With
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form4.ShowDialog()
    End Sub

    Private Sub BuildAsHtmlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuildAsHtmlToolStripMenuItem.Click
        creatHTML()
    End Sub

    Private Sub HtmlCodeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HtmlCodeToolStripMenuItem1.Click
        Form2.Show()
        Style()

    End Sub

    Private Sub RunnigToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RunnigToolStripMenuItem.Click
        Form3.Show()
        Style()

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Easy HTML" & vbNewLine & "V1.1" & vbNewLine & "Created by : King Of Software" & vbNewLine & "Email : alixhachi@outlook.com" & vbNewLine & "2018")
    End Sub

    Private Sub NewPageWebToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewPageWebToolStripMenuItem.Click
        If MsgBox("do you save your page", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then
            creatHTML()
            Form4.RadioButton1.Checked = True
            Form4.chk()
            Form4.EnblBtn()
            Form4.ShowDialog()
        ElseIf MsgBox("do you save your page", MsgBoxStyle.YesNoCancel) = MsgBoxResult.No Then
            Form4.ShowDialog()
        End If
    End Sub

    Private Sub OpenPageWebToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenPageWebToolStripMenuItem.Click
        If MsgBox("do you save your page", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then
            creatHTML()
            Form4.RadioButton1.Checked = True
            Form4.chk()
            Form4.EnblBtn()
            Form4.ShowDialog()
        ElseIf MsgBox("do you save your page", MsgBoxStyle.YesNoCancel) = MsgBoxResult.No Then
            Form4.ShowDialog()
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        If MsgBox("do you save your page and exit", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then
            creatHTML()
            End
        ElseIf MsgBox("do you save your page  and exit", MsgBoxStyle.YesNoCancel) = MsgBoxResult.No Then
            End
        End If
    End Sub
End Class
