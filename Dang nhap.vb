Imports System.Data.SqlClient
Public Class frmDangnhap

    Private Sub btnDangnhap_Click(sender As Object, e As EventArgs) Handles btnDangnhap.Click
        Dim chuoiketnoi As String = "workstation id=PS01943.mssql.somee.com;packet size=4096;user id=andhpps01943;pwd=mino241193;data source=PS01943.mssql.somee.com;persist security info=False;initial catalog=PS01943"
        Dim KetNoi As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim sqlAdapter As New SqlDataAdapter("select * from Nhanvien where Tendangnhap='" & TextBox1.Text & "' and Matkhau='" & TextBox2.Text & "' ", KetNoi)
        Dim tb As New DataTable

        Try
            KetNoi.Open()
            sqlAdapter.Fill(tb)
            If tb.Rows.Count > 0 Then
                MessageBox.Show("Đăng nhập thành công !")
                MAin.Show()
                Me.Hide()
            Else
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu !")
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub thoat_Click(sender As Object, e As EventArgs) Handles Thoat.Click
        If MessageBox.Show("Bạn có chắc muốn thoát không", "Thoát", MessageBoxButtons.YesNo) Then
            Me.Close()

        End If

    End Sub



End Class
