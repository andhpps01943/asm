Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmQuanlysanpham
    Dim tb As New DataTable
    Dim connect As String = "workstation id=PS01943.mssql.somee.com;packet size=4096;user id=andhpps01943;pwd=mino241193;data source=PS01943.mssql.somee.com;persist security info=False;initial catalog=PS01943"
    Private Sub frmQuanlysanpham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'tạo đối tượng kết nối tới Data Trên Somee.com thông qua chuỗi kết nối connectstr
        Dim KetNoi As New SqlConnection(connect)
        'Tạo đối tượng chạy câu truy vấn 
        Dim sqlAdapter As New SqlDataAdapter("select MaSP as 'Mã sản phẩm', TenSP as 'Tên sản phẩm', Dongia as 'Đơn giá', Soluong as 'Số lượng', ChitietSP as 'Chi tiết sản phẩm', Loaisanpham_Maloai as 'Loại sản phẩm' from SanPham", KetNoi)
        Try
            KetNoi.Open()
            'Đổ dữ liệu trên Table vào Datatable trên máy
            sqlAdapter.Fill(tb)
        Catch ex As Exception
        End Try
        'Hiển thị dữ liệu Từ Datatable ra giao diện thông qua Datagridview
        DataView.DataSource = tb
        KetNoi.Close()
    End Sub
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim ketnoi As New SqlConnection(connect)
        Dim stradd As String = "insert into Sanpham (MaSP,TenSP,Dongia,Soluong,ChitietSP,Loaisanpham_Maloai) values('" & txtMaSP.Text & "','" & txtTenSp.Text & "' ,'" & txtDongia.Text & "','" & txtSoluong.Text & "','" & txtChitietsanpham.Text & "','" & txtLoai.Text & "')"

        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            ketnoi.Open()
            com.ExecuteNonQuery()
            ketnoi.Close()
            MessageBox.Show("Thêm sản phẩm thành công")
        Catch ex As Exception
            MessageBox.Show("Lỗi!")
        End Try
        tb.Clear()
        DataView.DataSource = tb
        DataView.DataSource = Nothing
        xuat_lai_sql()


    End Sub
    Private Sub xuat_lai_sql()

        Dim KetNoi As New SqlConnection(connect)
        Dim sqlAdapter As New SqlDataAdapter("select MaSP as 'Mã sản phẩm', TenSP as 'Tên sản phẩm', Dongia as 'Đơn giá', Soluong as 'Số lượng', ChitietSP as 'Chi tiết sản phẩm',Loaisanpham_Maloai as 'Loại sản phẩm' from SanPham", KetNoi)

        Try
            sqlAdapter.Fill(tb)
        Catch ex As Exception

        End Try
        DataView.DataSource = tb
        KetNoi.Close()
    End Sub

    
    Private Sub DataView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataView.CellContentClick

        Dim dr As DataRow = tb.NewRow
        Dim index As Integer = DataView.CurrentCell.RowIndex
        txtMaSP.Text = DataView.Item(0, index).Value
        txtTenSp.Text = DataView.Item(1, index).Value
        txtDongia.Text = DataView.Item(2, index).Value
        txtSoluong.Text = DataView.Item(3, index).Value
        txtChitietsanpham.Text = DataView.Item(4, index).Value
        txtLoai.Text = DataView.Item(5, index).Value
    End Sub


    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        End
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim ketnoi As New SqlConnection(connect)
        ketnoi.Open()
        Dim stradd As String = "Delete from  Sanpham where MaSP = @MaSP"
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@MaSP", txtMaSP.Text)
            com.ExecuteNonQuery()
            ketnoi.Close()
            MessageBox.Show("Xóa dữ liệu thành công")
        Catch ex As Exception
            MessageBox.Show("Lỗi!")
        End Try
        tb.Clear()
        DataView.DataSource = tb
        DataView.DataSource = Nothing
        xuat_lai_sql()

    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim ketnoi As New SqlConnection(connect)
        ketnoi.Open()
        Dim stradd As String = "UPDATE Sanpham SET TenSP = @TenSP,  Dongia = @Dongia, Soluong = @Soluong, ChitietSP = @ChitietSP, Loaisanpham_Maloai = @Loaisanpham_Maloai where MaSP = @MaSP"
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@MaSP", txtMaSP.Text)
            com.Parameters.AddWithValue("@TenSP", txtTenSp.Text)
            com.Parameters.AddWithValue("@Loaisanpham_Maloai", txtLoai.Text)
            com.Parameters.AddWithValue("@Dongia", txtDongia.Text)
            com.Parameters.AddWithValue("@Soluong", txtSoluong.Text)
            com.Parameters.AddWithValue("@ChitietSP", txtChitietsanpham.Text)
            com.ExecuteNonQuery()
            ketnoi.Close()
            MessageBox.Show("Sửa thành công")

        Catch ex As Exception
            MessageBox.Show("Lỗi! Nhập sai kiểu kí tự.")
        End Try
        tb.Clear()
        DataView.DataSource = tb
        DataView.DataSource = Nothing
        xuat_lai_sql()

    End Sub
End Class