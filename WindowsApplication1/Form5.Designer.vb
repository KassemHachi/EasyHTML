<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.UpDownPosition = New System.Windows.Forms.TrackBar()
        Me.LeftRightPosition = New System.Windows.Forms.TrackBar()
        Me.ChkNewTab = New System.Windows.Forms.CheckBox()
        Me.ChkImage = New System.Windows.Forms.CheckBox()
        Me.ChkBtn = New System.Windows.Forms.CheckBox()
        Me.ChkTxt = New System.Windows.Forms.CheckBox()
        Me.ChkUrl = New System.Windows.Forms.CheckBox()
        Me.FontClrCode = New System.Windows.Forms.Label()
        Me.FontClr = New System.Windows.Forms.Button()
        Me.ImageSizeY = New System.Windows.Forms.NumericUpDown()
        Me.ImageSizeX = New System.Windows.Forms.NumericUpDown()
        Me.FontNum = New System.Windows.Forms.NumericUpDown()
        Me.UrlImg = New System.Windows.Forms.TextBox()
        Me.TitleImg = New System.Windows.Forms.TextBox()
        Me.UrlTitle = New System.Windows.Forms.TextBox()
        Me.TitleText = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.UpDownPosition, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeftRightPosition, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageSizeY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageSizeX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FontNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(-1, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(867, 641)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.UpDownPosition)
        Me.TabPage1.Controls.Add(Me.LeftRightPosition)
        Me.TabPage1.Controls.Add(Me.ChkNewTab)
        Me.TabPage1.Controls.Add(Me.ChkImage)
        Me.TabPage1.Controls.Add(Me.ChkBtn)
        Me.TabPage1.Controls.Add(Me.ChkTxt)
        Me.TabPage1.Controls.Add(Me.ChkUrl)
        Me.TabPage1.Controls.Add(Me.FontClrCode)
        Me.TabPage1.Controls.Add(Me.FontClr)
        Me.TabPage1.Controls.Add(Me.ImageSizeY)
        Me.TabPage1.Controls.Add(Me.ImageSizeX)
        Me.TabPage1.Controls.Add(Me.FontNum)
        Me.TabPage1.Controls.Add(Me.UrlImg)
        Me.TabPage1.Controls.Add(Me.TitleImg)
        Me.TabPage1.Controls.Add(Me.UrlTitle)
        Me.TabPage1.Controls.Add(Me.TitleText)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(859, 615)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Button , Text , Image , Link"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'UpDownPosition
        '
        Me.UpDownPosition.BackColor = System.Drawing.Color.White
        Me.UpDownPosition.Location = New System.Drawing.Point(153, 564)
        Me.UpDownPosition.Maximum = 2000
        Me.UpDownPosition.Minimum = 1
        Me.UpDownPosition.Name = "UpDownPosition"
        Me.UpDownPosition.Size = New System.Drawing.Size(566, 45)
        Me.UpDownPosition.TabIndex = 5
        Me.UpDownPosition.TickStyle = System.Windows.Forms.TickStyle.None
        Me.UpDownPosition.Value = 1
        '
        'LeftRightPosition
        '
        Me.LeftRightPosition.BackColor = System.Drawing.Color.White
        Me.LeftRightPosition.Location = New System.Drawing.Point(153, 513)
        Me.LeftRightPosition.Maximum = 2000
        Me.LeftRightPosition.Minimum = 1
        Me.LeftRightPosition.Name = "LeftRightPosition"
        Me.LeftRightPosition.Size = New System.Drawing.Size(566, 45)
        Me.LeftRightPosition.TabIndex = 5
        Me.LeftRightPosition.TickStyle = System.Windows.Forms.TickStyle.None
        Me.LeftRightPosition.Value = 1
        '
        'ChkNewTab
        '
        Me.ChkNewTab.AutoSize = True
        Me.ChkNewTab.Enabled = False
        Me.ChkNewTab.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkNewTab.Location = New System.Drawing.Point(153, 342)
        Me.ChkNewTab.Name = "ChkNewTab"
        Me.ChkNewTab.Size = New System.Drawing.Size(170, 29)
        Me.ChkNewTab.TabIndex = 4
        Me.ChkNewTab.Text = "Show in new tab"
        Me.ChkNewTab.UseVisualStyleBackColor = True
        '
        'ChkImage
        '
        Me.ChkImage.AutoSize = True
        Me.ChkImage.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkImage.Location = New System.Drawing.Point(9, 370)
        Me.ChkImage.Name = "ChkImage"
        Me.ChkImage.Size = New System.Drawing.Size(83, 29)
        Me.ChkImage.TabIndex = 4
        Me.ChkImage.Text = "Image"
        Me.ChkImage.UseVisualStyleBackColor = True
        '
        'ChkBtn
        '
        Me.ChkBtn.AutoSize = True
        Me.ChkBtn.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkBtn.Location = New System.Drawing.Point(6, 6)
        Me.ChkBtn.Name = "ChkBtn"
        Me.ChkBtn.Size = New System.Drawing.Size(87, 29)
        Me.ChkBtn.TabIndex = 4
        Me.ChkBtn.Text = "Button"
        Me.ChkBtn.UseVisualStyleBackColor = True
        '
        'ChkTxt
        '
        Me.ChkTxt.AutoSize = True
        Me.ChkTxt.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkTxt.Location = New System.Drawing.Point(6, 86)
        Me.ChkTxt.Name = "ChkTxt"
        Me.ChkTxt.Size = New System.Drawing.Size(66, 29)
        Me.ChkTxt.TabIndex = 4
        Me.ChkTxt.Text = "Text"
        Me.ChkTxt.UseVisualStyleBackColor = True
        '
        'ChkUrl
        '
        Me.ChkUrl.AutoSize = True
        Me.ChkUrl.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkUrl.Location = New System.Drawing.Point(6, 258)
        Me.ChkUrl.Name = "ChkUrl"
        Me.ChkUrl.Size = New System.Drawing.Size(65, 29)
        Me.ChkUrl.TabIndex = 4
        Me.ChkUrl.Text = "Link"
        Me.ChkUrl.UseVisualStyleBackColor = True
        '
        'FontClrCode
        '
        Me.FontClrCode.AutoSize = True
        Me.FontClrCode.Enabled = False
        Me.FontClrCode.Location = New System.Drawing.Point(215, 210)
        Me.FontClrCode.Name = "FontClrCode"
        Me.FontClrCode.Size = New System.Drawing.Size(50, 13)
        Me.FontClrCode.TabIndex = 3
        Me.FontClrCode.Text = "#000000"
        '
        'FontClr
        '
        Me.FontClr.BackColor = System.Drawing.Color.Black
        Me.FontClr.Enabled = False
        Me.FontClr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FontClr.Location = New System.Drawing.Point(153, 191)
        Me.FontClr.Name = "FontClr"
        Me.FontClr.Size = New System.Drawing.Size(56, 50)
        Me.FontClr.TabIndex = 2
        Me.FontClr.UseVisualStyleBackColor = False
        '
        'ImageSizeY
        '
        Me.ImageSizeY.Enabled = False
        Me.ImageSizeY.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImageSizeY.Location = New System.Drawing.Point(279, 474)
        Me.ImageSizeY.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.ImageSizeY.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ImageSizeY.Name = "ImageSizeY"
        Me.ImageSizeY.Size = New System.Drawing.Size(120, 33)
        Me.ImageSizeY.TabIndex = 1
        Me.ImageSizeY.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'ImageSizeX
        '
        Me.ImageSizeX.Enabled = False
        Me.ImageSizeX.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImageSizeX.Location = New System.Drawing.Point(153, 474)
        Me.ImageSizeX.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.ImageSizeX.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ImageSizeX.Name = "ImageSizeX"
        Me.ImageSizeX.Size = New System.Drawing.Size(120, 33)
        Me.ImageSizeX.TabIndex = 1
        Me.ImageSizeX.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'FontNum
        '
        Me.FontNum.Enabled = False
        Me.FontNum.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FontNum.Location = New System.Drawing.Point(153, 152)
        Me.FontNum.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.FontNum.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.FontNum.Name = "FontNum"
        Me.FontNum.Size = New System.Drawing.Size(120, 33)
        Me.FontNum.TabIndex = 1
        Me.FontNum.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'UrlImg
        '
        Me.UrlImg.Enabled = False
        Me.UrlImg.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UrlImg.Location = New System.Drawing.Point(153, 432)
        Me.UrlImg.MaxLength = 1000
        Me.UrlImg.Name = "UrlImg"
        Me.UrlImg.Size = New System.Drawing.Size(330, 33)
        Me.UrlImg.TabIndex = 0
        '
        'TitleImg
        '
        Me.TitleImg.Enabled = False
        Me.TitleImg.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleImg.Location = New System.Drawing.Point(153, 393)
        Me.TitleImg.MaxLength = 1000
        Me.TitleImg.Name = "TitleImg"
        Me.TitleImg.Size = New System.Drawing.Size(330, 33)
        Me.TitleImg.TabIndex = 0
        '
        'UrlTitle
        '
        Me.UrlTitle.Enabled = False
        Me.UrlTitle.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UrlTitle.Location = New System.Drawing.Point(153, 303)
        Me.UrlTitle.MaxLength = 1000
        Me.UrlTitle.Name = "UrlTitle"
        Me.UrlTitle.Size = New System.Drawing.Size(330, 33)
        Me.UrlTitle.TabIndex = 0
        '
        'TitleText
        '
        Me.TitleText.Enabled = False
        Me.TitleText.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleText.Location = New System.Drawing.Point(153, 113)
        Me.TitleText.MaxLength = 1000
        Me.TitleText.Name = "TitleText"
        Me.TitleText.Size = New System.Drawing.Size(330, 33)
        Me.TitleText.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(859, 615)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(736, 643)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 31)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 675)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.UpDownPosition, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeftRightPosition, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageSizeY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageSizeX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FontNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TitleText As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents FontClrCode As Label
    Friend WithEvents FontClr As Button
    Friend WithEvents FontNum As NumericUpDown
    Friend WithEvents UpDownPosition As TrackBar
    Friend WithEvents LeftRightPosition As TrackBar
    Friend WithEvents ChkNewTab As CheckBox
    Friend WithEvents ChkImage As CheckBox
    Friend WithEvents ChkTxt As CheckBox
    Friend WithEvents ChkUrl As CheckBox
    Friend WithEvents ImageSizeY As NumericUpDown
    Friend WithEvents ImageSizeX As NumericUpDown
    Friend WithEvents UrlTitle As TextBox
    Friend WithEvents ChkBtn As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TitleImg As TextBox
    Friend WithEvents UrlImg As TextBox
End Class
