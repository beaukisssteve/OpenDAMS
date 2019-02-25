<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Open_DAMS
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Open_DAMS))
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuildIndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexEverythingInFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilteredIndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigureSystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AssetsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageLibraryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindImageByAttributeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VideoLibraryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocumentLibraryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileLibraryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutOpenDAMSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TSSL01 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Filename = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fileextension = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Filetype = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Path = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SavedData = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.AssetsToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(895, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.ExportToolStripMenuItem, Me.ImportToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save As"
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.ExportToolStripMenuItem.Text = "Export"
        '
        'ImportToolStripMenuItem
        '
        Me.ImportToolStripMenuItem.Name = "ImportToolStripMenuItem"
        Me.ImportToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.ImportToolStripMenuItem.Text = "Import"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuildIndexToolStripMenuItem, Me.ConfigureSystemToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'BuildIndexToolStripMenuItem
        '
        Me.BuildIndexToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IndexEverythingInFolderToolStripMenuItem, Me.FilteredIndexToolStripMenuItem})
        Me.BuildIndexToolStripMenuItem.Name = "BuildIndexToolStripMenuItem"
        Me.BuildIndexToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.BuildIndexToolStripMenuItem.Text = "Build Index"
        '
        'IndexEverythingInFolderToolStripMenuItem
        '
        Me.IndexEverythingInFolderToolStripMenuItem.Name = "IndexEverythingInFolderToolStripMenuItem"
        Me.IndexEverythingInFolderToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.IndexEverythingInFolderToolStripMenuItem.Text = "Index Everything in Folder"
        '
        'FilteredIndexToolStripMenuItem
        '
        Me.FilteredIndexToolStripMenuItem.Name = "FilteredIndexToolStripMenuItem"
        Me.FilteredIndexToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.FilteredIndexToolStripMenuItem.Text = "Filtered Index"
        '
        'ConfigureSystemToolStripMenuItem
        '
        Me.ConfigureSystemToolStripMenuItem.Name = "ConfigureSystemToolStripMenuItem"
        Me.ConfigureSystemToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ConfigureSystemToolStripMenuItem.Text = "Configure System"
        '
        'AssetsToolStripMenuItem
        '
        Me.AssetsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImageLibraryToolStripMenuItem, Me.VideoLibraryToolStripMenuItem, Me.DocumentLibraryToolStripMenuItem, Me.FileLibraryToolStripMenuItem})
        Me.AssetsToolStripMenuItem.Name = "AssetsToolStripMenuItem"
        Me.AssetsToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AssetsToolStripMenuItem.Text = "Assets"
        '
        'ImageLibraryToolStripMenuItem
        '
        Me.ImageLibraryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FindImageByAttributeToolStripMenuItem})
        Me.ImageLibraryToolStripMenuItem.Name = "ImageLibraryToolStripMenuItem"
        Me.ImageLibraryToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.ImageLibraryToolStripMenuItem.Text = "Image Library"
        '
        'FindImageByAttributeToolStripMenuItem
        '
        Me.FindImageByAttributeToolStripMenuItem.Name = "FindImageByAttributeToolStripMenuItem"
        Me.FindImageByAttributeToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.FindImageByAttributeToolStripMenuItem.Text = "Find Image by attribute"
        '
        'VideoLibraryToolStripMenuItem
        '
        Me.VideoLibraryToolStripMenuItem.Name = "VideoLibraryToolStripMenuItem"
        Me.VideoLibraryToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.VideoLibraryToolStripMenuItem.Text = "Video Library"
        '
        'DocumentLibraryToolStripMenuItem
        '
        Me.DocumentLibraryToolStripMenuItem.Name = "DocumentLibraryToolStripMenuItem"
        Me.DocumentLibraryToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.DocumentLibraryToolStripMenuItem.Text = "Document Library"
        '
        'FileLibraryToolStripMenuItem
        '
        Me.FileLibraryToolStripMenuItem.Name = "FileLibraryToolStripMenuItem"
        Me.FileLibraryToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.FileLibraryToolStripMenuItem.Text = "File Library"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewHelpToolStripMenuItem, Me.AboutOpenDAMSToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ViewHelpToolStripMenuItem
        '
        Me.ViewHelpToolStripMenuItem.Name = "ViewHelpToolStripMenuItem"
        Me.ViewHelpToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.ViewHelpToolStripMenuItem.Text = "View Help"
        '
        'AboutOpenDAMSToolStripMenuItem
        '
        Me.AboutOpenDAMSToolStripMenuItem.Name = "AboutOpenDAMSToolStripMenuItem"
        Me.AboutOpenDAMSToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.AboutOpenDAMSToolStripMenuItem.Text = "About Open DAMS"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(12, 27)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSSL01, Me.ToolStripSplitButton1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 529)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(895, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TSSL01
        '
        Me.TSSL01.Name = "TSSL01"
        Me.TSSL01.Size = New System.Drawing.Size(42, 17)
        Me.TSSL01.Text = "SSL_01"
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripSplitButton1.Image = CType(resources.GetObject("ToolStripSplitButton1.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(32, 20)
        Me.ToolStripSplitButton1.Text = "ToolStripSplitButton1"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Filename, Me.Fileextension, Me.Filetype, Me.Path, Me.SavedData})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 54)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(829, 299)
        Me.DataGridView1.TabIndex = 3
        '
        'Filename
        '
        Me.Filename.HeaderText = "File Name"
        Me.Filename.Name = "Filename"
        '
        'Fileextension
        '
        Me.Fileextension.HeaderText = "File Extension"
        Me.Fileextension.Name = "Fileextension"
        '
        'Filetype
        '
        Me.Filetype.HeaderText = "FileType"
        Me.Filetype.Name = "Filetype"
        '
        'Path
        '
        Me.Path.HeaderText = "File Path"
        Me.Path.Name = "Path"
        '
        'SavedData
        '
        Me.SavedData.HeaderText = "Last Saved"
        Me.SavedData.Name = "SavedData"
        '
        'Open_DAMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 551)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Open_DAMS"
        Me.Text = "Open DAMS"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuildIndexToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IndexEverythingInFolderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FilteredIndexToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfigureSystemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AssetsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImageLibraryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FindImageByAttributeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VideoLibraryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DocumentLibraryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileLibraryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewHelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutOpenDAMSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents TSSL01 As ToolStripStatusLabel
    Friend WithEvents ToolStripSplitButton1 As ToolStripSplitButton
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents BindingSource2 As BindingSource
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Filename As DataGridViewTextBoxColumn
    Friend WithEvents Fileextension As DataGridViewTextBoxColumn
    Friend WithEvents Filetype As DataGridViewTextBoxColumn
    Friend WithEvents Path As DataGridViewTextBoxColumn
    Friend WithEvents SavedData As DataGridViewTextBoxColumn
End Class
