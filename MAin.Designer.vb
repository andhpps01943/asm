<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MAin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MAin))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HệThốngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ĐăngXuấtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ĐăngNhậpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThoátToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NhânViênToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DanhSáchNhânViênToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThôngTinNhânViênToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NhânViênToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrợGiúpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LiênHệToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.BảnQuyềnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LoạiSảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HệThốngToolStripMenuItem, Me.NhânViênToolStripMenuItem, Me.QuảnLýToolStripMenuItem, Me.TrợGiúpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(374, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HệThốngToolStripMenuItem
        '
        Me.HệThốngToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ĐăngXuấtToolStripMenuItem, Me.ĐăngNhậpToolStripMenuItem, Me.ThoátToolStripMenuItem})
        Me.HệThốngToolStripMenuItem.Name = "HệThốngToolStripMenuItem"
        Me.HệThốngToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.HệThốngToolStripMenuItem.Text = "Hệ thống"
        '
        'ĐăngXuấtToolStripMenuItem
        '
        Me.ĐăngXuấtToolStripMenuItem.Name = "ĐăngXuấtToolStripMenuItem"
        Me.ĐăngXuấtToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.ĐăngXuấtToolStripMenuItem.Text = "Đăng xuất"
        '
        'ĐăngNhậpToolStripMenuItem
        '
        Me.ĐăngNhậpToolStripMenuItem.Name = "ĐăngNhậpToolStripMenuItem"
        Me.ĐăngNhậpToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.ĐăngNhậpToolStripMenuItem.Text = "Đăng nhập"
        '
        'ThoátToolStripMenuItem
        '
        Me.ThoátToolStripMenuItem.Name = "ThoátToolStripMenuItem"
        Me.ThoátToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.ThoátToolStripMenuItem.Text = "Thoát"
        '
        'NhânViênToolStripMenuItem
        '
        Me.NhânViênToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DanhSáchNhânViênToolStripMenuItem, Me.ThôngTinNhânViênToolStripMenuItem})
        Me.NhânViênToolStripMenuItem.Name = "NhânViênToolStripMenuItem"
        Me.NhânViênToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.NhânViênToolStripMenuItem.Text = "Nhân viên"
        '
        'DanhSáchNhânViênToolStripMenuItem
        '
        Me.DanhSáchNhânViênToolStripMenuItem.Name = "DanhSáchNhânViênToolStripMenuItem"
        Me.DanhSáchNhânViênToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.DanhSáchNhânViênToolStripMenuItem.Text = "Danh sách nhân viên"
        '
        'ThôngTinNhânViênToolStripMenuItem
        '
        Me.ThôngTinNhânViênToolStripMenuItem.Name = "ThôngTinNhânViênToolStripMenuItem"
        Me.ThôngTinNhânViênToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.ThôngTinNhânViênToolStripMenuItem.Text = "Thông tin nhân viên"
        '
        'QuảnLýToolStripMenuItem
        '
        Me.QuảnLýToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SảnPhẩmToolStripMenuItem, Me.NhânViênToolStripMenuItem1, Me.LoạiSảnPhẩmToolStripMenuItem})
        Me.QuảnLýToolStripMenuItem.Name = "QuảnLýToolStripMenuItem"
        Me.QuảnLýToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.QuảnLýToolStripMenuItem.Text = "Quản lý"
        '
        'SảnPhẩmToolStripMenuItem
        '
        Me.SảnPhẩmToolStripMenuItem.Name = "SảnPhẩmToolStripMenuItem"
        Me.SảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SảnPhẩmToolStripMenuItem.Text = "Sản phẩm"
        '
        'NhânViênToolStripMenuItem1
        '
        Me.NhânViênToolStripMenuItem1.Name = "NhânViênToolStripMenuItem1"
        Me.NhânViênToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.NhânViênToolStripMenuItem1.Text = "Nhân viên"
        '
        'TrợGiúpToolStripMenuItem
        '
        Me.TrợGiúpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LiênHệToolStripMenuItem, Me.BảnQuyềnToolStripMenuItem})
        Me.TrợGiúpToolStripMenuItem.Name = "TrợGiúpToolStripMenuItem"
        Me.TrợGiúpToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.TrợGiúpToolStripMenuItem.Text = "Trợ giúp"
        '
        'LiênHệToolStripMenuItem
        '
        Me.LiênHệToolStripMenuItem.Name = "LiênHệToolStripMenuItem"
        Me.LiênHệToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.LiênHệToolStripMenuItem.Text = "Liên hệ"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(157, 36)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 2
        '
        'BảnQuyềnToolStripMenuItem
        '
        Me.BảnQuyềnToolStripMenuItem.Name = "BảnQuyềnToolStripMenuItem"
        Me.BảnQuyềnToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.BảnQuyềnToolStripMenuItem.Text = "Bản quyền"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 276)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(374, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(183, 17)
        Me.ToolStripStatusLabel1.Text = "Đặng Huỳnh Phước An - PS01943"
        '
        'LoạiSảnPhẩmToolStripMenuItem
        '
        Me.LoạiSảnPhẩmToolStripMenuItem.Name = "LoạiSảnPhẩmToolStripMenuItem"
        Me.LoạiSảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LoạiSảnPhẩmToolStripMenuItem.Text = "Loại sản phẩm"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.Harley_Davidson_Logo
        Me.PictureBox1.Location = New System.Drawing.Point(32, 71)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(309, 187)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'MAin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(374, 298)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MAin"
        Me.Text = "HỆ THỐNG"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HệThốngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ĐăngXuấtToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ĐăngNhậpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThoátToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NhânViênToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DanhSáchNhânViênToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThôngTinNhânViênToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuảnLýToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SảnPhẩmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NhânViênToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrợGiúpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LiênHệToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents BảnQuyềnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LoạiSảnPhẩmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
