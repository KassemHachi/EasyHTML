Imports System.Drawing.Color

Public Class Form5
    Dim AllTxtCd As String = ""
    Dim AllBtnCd As String = ""
    Dim AllUrlCd As String = ""
    Dim AllImgCd As String = ""
    Dim AllMovcd As String = ""
    Sub color()
        Dim Color As Color = FontClr.BackColor
        Dim colorString As String = String.Format("#{0:X2}{1:X2}{2:X2}", Color.R, Color.G, Color.B)
        FontClrCode.Text = colorString

    End Sub

    Sub Btn(ByVal FontAndText As String, ByVal Img As String, ByVal mov As String)
        If ChkTxt.Checked = True Then
            AllBtnCd = "<button " & mov & " >  " & FontAndText & " </button>" & vbNewLine
        ElseIf ChkImage.Checked = True Then
            AllBtnCd = "<button " & mov & " > " & Img & " </button>" & vbNewLine
        End If

    End Sub
    Sub Txt()
        If ChkBtn.Checked = True Or ChkUrl.Checked = True Then
            AllTxtCd = "<font size='" & FontNum.Value & "' color='" & FontClrCode.Text & "'>" & TitleText.Text & "</font>" & vbNewLine
        Else
            AllTxtCd = "<p > " & TitleText.Text & " </p>" & vbNewLine
        End If
    End Sub
    Sub Lnk(ByVal BtnCd As String, ByVal img As String, txt As String)

        If ChkBtn.Checked = True Then


            AllUrlCd = "<a href = '" & UrlTitle.Text & " ' "
            If ChkNewTab.Checked = True Then
                AllUrlCd += "target='_blank' >"
            End If
            AllUrlCd += BtnCd & "</a>" & vbNewLine

        ElseIf ChkTxt.Checked = True Then

            AllUrlCd = "<a href = '" & UrlTitle.Text & " ' "
                If ChkNewTab.Checked = True Then
                    AllUrlCd += "target='_blank' >"
                End If
                AllUrlCd += txt & "</a>" & vbNewLine

            ElseIf ChkImage.Checked = True Then

                AllUrlCd = "<a href='" & UrlTitle.Text & " ' " & img
            If ChkNewTab.Checked = True Then
                AllUrlCd += "target='_blank' >"
            End If
            AllUrlCd += "</a>" & vbNewLine
        End If

    End Sub

    Sub img()
        AllImgCd = "<img"
        If ChkBtn.Checked = False Then
            AllImgCd += AllMovcd
        End If
        AllImgCd += "  alt='" & TitleImg.Text & "' src='" & UrlImg.Text & "' height = '" & ImageSizeX.Value & "' width ='" & ImageSizeY.Value & "' ></img>" & vbNewLine

    End Sub

    Sub MovEnbl()
        If ChkBtn.Checked = True Or ChkImage.Checked = True Or ChkTxt.Enabled = True Or ChkUrl.Checked = True Then
            UpDownPosition.Enabled = True
            LeftRightPosition.Enabled = True
        Else
            UpDownPosition.Enabled = False
            LeftRightPosition.Enabled = False
        End If
    End Sub
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FontClr_Click(sender As Object, e As EventArgs) Handles FontClr.Click
        Dim cd As New ColorDialog
        If cd.ShowDialog = DialogResult.OK Then
            FontClr.BackColor = cd.Color
            color()

        End If
    End Sub

    Private Sub ChkTxt_CheckedChanged(sender As Object, e As EventArgs) Handles ChkTxt.CheckedChanged
        If ChkTxt.Checked = True Then
            TitleText.Enabled = True
            FontClr.Enabled = True
            FontClrCode.Enabled = True
            FontNum.Enabled = True
            ChkImage.Checked = False

        Else
            TitleText.Enabled = False
            FontClr.Enabled = False
            FontClrCode.Enabled = False
            FontNum.Enabled = False
            MovEnbl()
        End If
    End Sub

    Private Sub ChkUrl_CheckedChanged(sender As Object, e As EventArgs) Handles ChkUrl.CheckedChanged
        If ChkUrl.Checked = True Then
            UrlTitle.Enabled = True
            ChkNewTab.Enabled = True
        Else
            UrlTitle.Enabled = False
            ChkNewTab.Enabled = False
            MovEnbl()
        End If
    End Sub

    Private Sub ChkImage_CheckedChanged(sender As Object, e As EventArgs) Handles ChkImage.CheckedChanged
        If ChkImage.Checked = True Then
            TitleImg.Enabled = True
            UrlImg.Enabled = True
            ImageSizeX.Enabled = True
            ImageSizeY.Enabled = True
            ChkTxt.Checked = False
        Else
            TitleImg.Enabled = False
            UrlImg.Enabled = False
            ImageSizeX.Enabled = False
            ImageSizeY.Enabled = False
            MovEnbl()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TabControl1.SelectedIndex = 0 Then

            If ChkTxt.Checked = True Then
                Txt()
            ElseIf ChkImage.Checked = True Then
                img()
            End If

            If ChkBtn.Checked = True Then
                Btn(AllTxtCd, AllImgCd, AllMovcd)
            Else chkbtn.Checked = True And ChkImage.Checked = False
                Btn(AllTxtCd, AllImgCd, AllMovcd)
                Form2.HtmlTxt.AppendText(AllBtnCd)
            End If
            If ChkUrl.Checked = True Then
                Lnk(AllBtnCd, AllImgCd, AllTxtCd)
                Form2.HtmlTxt.AppendText(AllUrlCd)
            End If


            Me.Hide()
        End If
    End Sub

    Private Sub LeftRightPosition_Scroll(sender As Object, e As EventArgs) Handles LeftRightPosition.Scroll
        AllMovcd = "style='Margin-Left:  " & LeftRightPosition.Value.ToString & "px ;    Margin-Top:  " & UpDownPosition.Value.ToString & "px;'"
    End Sub

    Private Sub UpDownPosition_Scroll(sender As Object, e As EventArgs) Handles UpDownPosition.Scroll
        AllMovcd = "style='Margin-Left:  " & LeftRightPosition.Value.ToString & "px ;    Margin-Top:  " & UpDownPosition.Value.ToString & "px;'"
    End Sub
End Class