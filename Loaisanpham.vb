Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmLoaiSP
    Dim tb As New DataTable
    Dim connect As String = "workstation id=PS01943.mssql.somee.com;packet size=4096;user id=andhpps01943;pwd=mino241193;data source=PS01943.mssql.somee.com;persist security info=False;initial catalog=PS01943"
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblMaSp.Click

    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        End
    End Sub

    Private Sub btnThemloai_Click(sender As Object, e As EventArgs) Handles btnThemloai.Click
        Dim ketnoi As New SqlConnection(connect)
        Dim stradd As String = "insert into LoaiSanPham (MaSP,Tenloai,Xuatxu) values('" & txtMaSp.Text & "','" & txtTenloai.Text & "' ,'" & txtXuatxu.Text & "')"

        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            ketnoi.Open()
            com.ExecuteNonQuery()
            ketnoi.Close()
            MessageBox.Show("Thêm thành công")
        Catch ex As Exception
            MessageBox.Show("Lỗi!")
        End Try
        tb.Clear()
       


    
    End Sub
End Class