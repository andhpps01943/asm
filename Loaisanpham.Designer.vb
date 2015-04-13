<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoaiSP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoaiSP))
        Me.lblMaSp = New System.Windows.Forms.Label()
        Me.lblTenloai = New System.Windows.Forms.Label()
        Me.lblXuatxu = New System.Windows.Forms.Label()
        Me.txtMaSp = New System.Windows.Forms.TextBox()
        Me.txtTenloai = New System.Windows.Forms.TextBox()
        Me.txtXuatxu = New System.Windows.Forms.TextBox()
        Me.btnThemloai = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMaSp
        '
        Me.lblMaSp.AutoSize = True
        Me.lblMaSp.Location = New System.Drawing.Point(12, 27)
        Me.lblMaSp.Name = "lblMaSp"
        Me.lblMaSp.Size = New System.Drawing.Size(74, 13)
        Me.lblMaSp.TabIndex = 0
        Me.lblMaSp.Text = "Mã sản phẩm:"
        '
        'lblTenloai
        '
        Me.lblTenloai.AutoSize = True
        Me.lblTenloai.Location = New System.Drawing.Point(12, 57)
        Me.lblTenloai.Name = "lblTenloai"
        Me.lblTenloai.Size = New System.Drawing.Size(48, 13)
        Me.lblTenloai.TabIndex = 1
        Me.lblTenloai.Text = "Tên loại:"
        '
        'lblXuatxu
        '
        Me.lblXuatxu.AutoSize = True
        Me.lblXuatxu.Location = New System.Drawing.Point(12, 89)
        Me.lblXuatxu.Name = "lblXuatxu"
        Me.lblXuatxu.Size = New System.Drawing.Size(46, 13)
        Me.lblXuatxu.TabIndex = 2
        Me.lblXuatxu.Text = "Xuất xứ:"
        '
        'txtMaSp
        '
        Me.txtMaSp.Location = New System.Drawing.Point(110, 24)
        Me.txtMaSp.Name = "txtMaSp"
        Me.txtMaSp.Size = New System.Drawing.Size(99, 20)
        Me.txtMaSp.TabIndex = 3
        '
        'txtTenloai
        '
        Me.txtTenloai.Location = New System.Drawing.Point(110, 54)
        Me.txtTenloai.Name = "txtTenloai"
        Me.txtTenloai.Size = New System.Drawing.Size(135, 20)
        Me.txtTenloai.TabIndex = 4
        '
        'txtXuatxu
        '
        Me.txtXuatxu.Location = New System.Drawing.Point(110, 86)
        Me.txtXuatxu.Name = "txtXuatxu"
        Me.txtXuatxu.Size = New System.Drawing.Size(119, 20)
        Me.txtXuatxu.TabIndex = 5
        '
        'btnThemloai
        '
        Me.btnThemloai.Location = New System.Drawing.Point(38, 136)
        Me.btnThemloai.Name = "btnThemloai"
        Me.btnThemloai.Size = New System.Drawing.Size(92, 32)
        Me.btnThemloai.TabIndex = 6
        Me.btnThemloai.Text = "Thêm"
        Me.btnThemloai.UseVisualStyleBackColor = True
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(154, 136)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(91, 32)
        Me.btnThoat.TabIndex = 7
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.Harley_Davidson_Logo
        Me.PictureBox1.Location = New System.Drawing.Point(276, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(162, 94)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'frmLoaiSP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(450, 185)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnThemloai)
        Me.Controls.Add(Me.txtXuatxu)
        Me.Controls.Add(Me.txtTenloai)
        Me.Controls.Add(Me.txtMaSp)
        Me.Controls.Add(Me.lblXuatxu)
        Me.Controls.Add(Me.lblTenloai)
        Me.Controls.Add(Me.lblMaSp)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLoaiSP"
        Me.Text = "LOẠI SẢN PHẨM"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMaSp As System.Windows.Forms.Label
    Friend WithEvents lblTenloai As System.Windows.Forms.Label
    Friend WithEvents lblXuatxu As System.Windows.Forms.Label
    Friend WithEvents txtMaSp As System.Windows.Forms.TextBox
    Friend WithEvents txtTenloai As System.Windows.Forms.TextBox
    Friend WithEvents txtXuatxu As System.Windows.Forms.TextBox
    Friend WithEvents btnThemloai As System.Windows.Forms.Button
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
