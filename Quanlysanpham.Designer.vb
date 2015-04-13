<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanlysanpham
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuanlysanpham))
        Me.lblMaSp = New System.Windows.Forms.Label()
        Me.lblTenSP = New System.Windows.Forms.Label()
        Me.lblDongia = New System.Windows.Forms.Label()
        Me.lblSoluong = New System.Windows.Forms.Label()
        Me.lblChitietSP = New System.Windows.Forms.Label()
        Me.txtMaSP = New System.Windows.Forms.TextBox()
        Me.txtTenSp = New System.Windows.Forms.TextBox()
        Me.txtDongia = New System.Windows.Forms.TextBox()
        Me.txtSoluong = New System.Windows.Forms.TextBox()
        Me.txtChitietsanpham = New System.Windows.Forms.TextBox()
        Me.DataView = New System.Windows.Forms.DataGridView()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtLoai = New System.Windows.Forms.TextBox()
        Me.lblLoai = New System.Windows.Forms.Label()
        CType(Me.DataView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMaSp
        '
        Me.lblMaSp.AutoSize = True
        Me.lblMaSp.Location = New System.Drawing.Point(21, 29)
        Me.lblMaSp.Name = "lblMaSp"
        Me.lblMaSp.Size = New System.Drawing.Size(74, 13)
        Me.lblMaSp.TabIndex = 0
        Me.lblMaSp.Text = "Mã sản phẩm:"
        '
        'lblTenSP
        '
        Me.lblTenSP.AutoSize = True
        Me.lblTenSP.Location = New System.Drawing.Point(21, 56)
        Me.lblTenSP.Name = "lblTenSP"
        Me.lblTenSP.Size = New System.Drawing.Size(78, 13)
        Me.lblTenSP.TabIndex = 1
        Me.lblTenSP.Text = "Tên sản phẩm:"
        '
        'lblDongia
        '
        Me.lblDongia.AutoSize = True
        Me.lblDongia.Location = New System.Drawing.Point(21, 81)
        Me.lblDongia.Name = "lblDongia"
        Me.lblDongia.Size = New System.Drawing.Size(47, 13)
        Me.lblDongia.TabIndex = 2
        Me.lblDongia.Text = "Đơn giá:"
        '
        'lblSoluong
        '
        Me.lblSoluong.AutoSize = True
        Me.lblSoluong.Location = New System.Drawing.Point(21, 108)
        Me.lblSoluong.Name = "lblSoluong"
        Me.lblSoluong.Size = New System.Drawing.Size(52, 13)
        Me.lblSoluong.TabIndex = 3
        Me.lblSoluong.Text = "Số lượng:"
        '
        'lblChitietSP
        '
        Me.lblChitietSP.AutoSize = True
        Me.lblChitietSP.Location = New System.Drawing.Point(21, 135)
        Me.lblChitietSP.Name = "lblChitietSP"
        Me.lblChitietSP.Size = New System.Drawing.Size(91, 13)
        Me.lblChitietSP.TabIndex = 4
        Me.lblChitietSP.Text = "Chi tiết sản phẩm:"
        '
        'txtMaSP
        '
        Me.txtMaSP.Location = New System.Drawing.Point(135, 26)
        Me.txtMaSP.Name = "txtMaSP"
        Me.txtMaSP.Size = New System.Drawing.Size(116, 20)
        Me.txtMaSP.TabIndex = 0
        '
        'txtTenSp
        '
        Me.txtTenSp.Location = New System.Drawing.Point(135, 53)
        Me.txtTenSp.Name = "txtTenSp"
        Me.txtTenSp.Size = New System.Drawing.Size(169, 20)
        Me.txtTenSp.TabIndex = 1
        '
        'txtDongia
        '
        Me.txtDongia.Location = New System.Drawing.Point(135, 78)
        Me.txtDongia.Name = "txtDongia"
        Me.txtDongia.Size = New System.Drawing.Size(139, 20)
        Me.txtDongia.TabIndex = 2
        '
        'txtSoluong
        '
        Me.txtSoluong.Location = New System.Drawing.Point(135, 105)
        Me.txtSoluong.Name = "txtSoluong"
        Me.txtSoluong.Size = New System.Drawing.Size(94, 20)
        Me.txtSoluong.TabIndex = 3
        '
        'txtChitietsanpham
        '
        Me.txtChitietsanpham.Location = New System.Drawing.Point(135, 132)
        Me.txtChitietsanpham.Name = "txtChitietsanpham"
        Me.txtChitietsanpham.Size = New System.Drawing.Size(269, 20)
        Me.txtChitietsanpham.TabIndex = 4
        '
        'DataView
        '
        Me.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataView.Location = New System.Drawing.Point(12, 203)
        Me.DataView.Name = "DataView"
        Me.DataView.Size = New System.Drawing.Size(610, 150)
        Me.DataView.TabIndex = 10
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(272, 174)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(83, 23)
        Me.btnThem.TabIndex = 11
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(361, 174)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(83, 23)
        Me.btnSua.TabIndex = 12
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(450, 174)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(83, 23)
        Me.btnXoa.TabIndex = 13
        Me.btnXoa.Text = "Xoá"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(539, 174)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(83, 23)
        Me.btnThoat.TabIndex = 14
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.Harley_Davidson_Logo
        Me.PictureBox1.Location = New System.Drawing.Point(422, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 109)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'txtLoai
        '
        Me.txtLoai.Location = New System.Drawing.Point(135, 158)
        Me.txtLoai.Name = "txtLoai"
        Me.txtLoai.Size = New System.Drawing.Size(100, 20)
        Me.txtLoai.TabIndex = 5
        '
        'lblLoai
        '
        Me.lblLoai.AutoSize = True
        Me.lblLoai.Location = New System.Drawing.Point(21, 161)
        Me.lblLoai.Name = "lblLoai"
        Me.lblLoai.Size = New System.Drawing.Size(30, 13)
        Me.lblLoai.TabIndex = 17
        Me.lblLoai.Text = "Loại:"
        '
        'frmQuanlysanpham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(635, 369)
        Me.Controls.Add(Me.lblLoai)
        Me.Controls.Add(Me.txtLoai)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.DataView)
        Me.Controls.Add(Me.txtChitietsanpham)
        Me.Controls.Add(Me.txtSoluong)
        Me.Controls.Add(Me.txtDongia)
        Me.Controls.Add(Me.txtTenSp)
        Me.Controls.Add(Me.txtMaSP)
        Me.Controls.Add(Me.lblChitietSP)
        Me.Controls.Add(Me.lblSoluong)
        Me.Controls.Add(Me.lblDongia)
        Me.Controls.Add(Me.lblTenSP)
        Me.Controls.Add(Me.lblMaSp)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmQuanlysanpham"
        Me.Text = "QUẢN LÝ SẢN PHẨM"
        CType(Me.DataView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMaSp As System.Windows.Forms.Label
    Friend WithEvents lblTenSP As System.Windows.Forms.Label
    Friend WithEvents lblDongia As System.Windows.Forms.Label
    Friend WithEvents lblSoluong As System.Windows.Forms.Label
    Friend WithEvents lblChitietSP As System.Windows.Forms.Label
    Friend WithEvents txtMaSP As System.Windows.Forms.TextBox
    Friend WithEvents txtTenSp As System.Windows.Forms.TextBox
    Friend WithEvents txtDongia As System.Windows.Forms.TextBox
    Friend WithEvents txtSoluong As System.Windows.Forms.TextBox
    Friend WithEvents txtChitietsanpham As System.Windows.Forms.TextBox
    Friend WithEvents DataView As System.Windows.Forms.DataGridView
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtLoai As System.Windows.Forms.TextBox
    Friend WithEvents lblLoai As System.Windows.Forms.Label
End Class
