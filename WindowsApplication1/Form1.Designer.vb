<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HtmlCodeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunnigToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuildAsHtmlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewPageWebToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenPageWebToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditPageOnlineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(895, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewPageWebToolStripMenuItem, Me.OpenPageWebToolStripMenuItem, Me.EditPageOnlineToolStripMenuItem, Me.ToolStripSeparator1, Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HtmlCodeToolStripMenuItem1, Me.RunnigToolStripMenuItem, Me.BuildAsHtmlToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'HtmlCodeToolStripMenuItem1
        '
        Me.HtmlCodeToolStripMenuItem1.Name = "HtmlCodeToolStripMenuItem1"
        Me.HtmlCodeToolStripMenuItem1.Size = New System.Drawing.Size(175, 22)
        Me.HtmlCodeToolStripMenuItem1.Text = "Html code window"
        '
        'RunnigToolStripMenuItem
        '
        Me.RunnigToolStripMenuItem.Name = "RunnigToolStripMenuItem"
        Me.RunnigToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.RunnigToolStripMenuItem.Text = "Runnig window"
        '
        'BuildAsHtmlToolStripMenuItem
        '
        Me.BuildAsHtmlToolStripMenuItem.Name = "BuildAsHtmlToolStripMenuItem"
        Me.BuildAsHtmlToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.BuildAsHtmlToolStripMenuItem.Text = "Build as html "
        '
        'NewPageWebToolStripMenuItem
        '
        Me.NewPageWebToolStripMenuItem.Name = "NewPageWebToolStripMenuItem"
        Me.NewPageWebToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.NewPageWebToolStripMenuItem.Text = "New page web"
        '
        'OpenPageWebToolStripMenuItem
        '
        Me.OpenPageWebToolStripMenuItem.Name = "OpenPageWebToolStripMenuItem"
        Me.OpenPageWebToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.OpenPageWebToolStripMenuItem.Text = "open page web"
        '
        'EditPageOnlineToolStripMenuItem
        '
        Me.EditPageOnlineToolStripMenuItem.Name = "EditPageOnlineToolStripMenuItem"
        Me.EditPageOnlineToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.EditPageOnlineToolStripMenuItem.Text = "Edit page online"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(156, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 486)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HtmlCodeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RunnigToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuildAsHtmlToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewPageWebToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenPageWebToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditPageOnlineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
