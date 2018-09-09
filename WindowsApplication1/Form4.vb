Public Class Form4
    Sub chk()
        If RadioButton1.Checked = True Then
            RadioButton2.Checked = False
            Label1.Enabled = True
            TextBox1.Enabled = True

            LinkLabel1.Enabled = False
            Label2.Enabled = False

        ElseIf RadioButton2.Checked = True Then
            RadioButton1.Checked = False
            Label1.Enabled = False
            TextBox1.Enabled = False

            LinkLabel1.Enabled = True
            Label2.Enabled = True
        End If
    End Sub
    Sub EnblBtn()
        If TextBox1.Text <> "" And RadioButton1.Checked = True Or Label2.Text <> "" And RadioButton2.Checked = True Then
            Button2.Enabled = True
        End If
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "D:\" + TextBox1.Text + ".html"
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        chk()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        chk()
    End Sub
    Dim ofd As New OpenFileDialog
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        ofd.Filter = "html files |*.html"
        If ofd.ShowDialog = DialogResult.OK Then
            Label2.Text = ofd.FileName
        End If
        EnblBtn()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.UseWaitCursor = True

        If RadioButton1.Checked = True Then
            Form1.s = Label1.Text
            Form1.creatHTML()
            Me.Hide()
            Form2.Show()
            Form1.Style()
        ElseIf RadioButton2.Checked = True Then
            Try
                Form1.s = Label2.Text
                Dim sw As IO.StreamReader = New IO.StreamReader(Form1.s)
                Form2.HtmlTxt.Text = sw.ReadToEnd
                sw.Close()
                Me.Hide()
                Form2.Show()
                Form1.Style()
            Catch ex As Exception
                MsgBox("Oops !!" & vbNewLine & "file is failed")
            End Try
        End If
        Me.UseWaitCursor = False
    End Sub

    Private Sub Form4_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        End
    End Sub
    Dim pth As String = My.Application.Info.DirectoryPath

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Label1.Text = "D:\" + TextBox1.Text + ".html"
        EnblBtn()
    End Sub

End Class