Public Class Form3
    Private Sub Form3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form2.Show()
        Form1.Style()
    End Sub
End Class