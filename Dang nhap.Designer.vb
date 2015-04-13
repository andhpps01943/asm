<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDangnhap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDangnhap))
        Me.Tên = New System.Windows.Forms.Label()
        Me.MatKhau = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btnDangnhap = New System.Windows.Forms.Button()
        Me.Thoat = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tên
        '
        Me.Tên.AutoSize = True
        Me.Tên.Location = New System.Drawing.Point(108, 219)
        Me.Tên.Name = "Tên"
        Me.Tên.Size = New System.Drawing.Size(32, 13)
        Me.Tên.TabIndex = 0
        Me.Tên.Text = "Tên :"
        '
        'MatKhau
        '
        Me.MatKhau.AutoSize = True
        Me.MatKhau.Location = New System.Drawing.Point(82, 246)
        Me.MatKhau.Name = "MatKhau"
        Me.MatKhau.Size = New System.Drawing.Size(58, 13)
        Me.MatKhau.TabIndex = 1
        Me.MatKhau.Text = "Mật khẩu :"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(169, 216)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(134, 20)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(169, 243)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(134, 20)
        Me.TextBox2.TabIndex = 3
        '
        'btnDangnhap
        '
        Me.btnDangnhap.Location = New System.Drawing.Point(124, 282)
        Me.btnDangnhap.Name = "btnDangnhap"
        Me.btnDangnhap.Size = New System.Drawing.Size(75, 23)
        Me.btnDangnhap.TabIndex = 4
        Me.btnDangnhap.Text = "Đăng Nhập"
        Me.btnDangnhap.UseVisualStyleBackColor = True
        '
        'Thoat
        '
        Me.Thoat.Location = New System.Drawing.Point(228, 282)
        Me.Thoat.Name = "Thoat"
        Me.Thoat.Size = New System.Drawing.Size(75, 23)
        Me.Thoat.TabIndex = 5
        Me.Thoat.Text = "Thoát"
        Me.Thoat.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.Harley_Davidson_Logo
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(382, 188)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'frmDangnhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(407, 319)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Thoat)
        Me.Controls.Add(Me.btnDangnhap)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MatKhau)
        Me.Controls.Add(Me.Tên)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDangnhap"
        Me.Text = "ĐĂNG NHẬP"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Tên As System.Windows.Forms.Label
    Friend WithEvents MatKhau As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents btnDangnhap As System.Windows.Forms.Button
    Friend WithEvents Thoat As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
