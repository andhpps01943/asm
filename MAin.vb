Public Class MAin

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        End
    End Sub

  
    Private Sub MAin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SảnPhẩmToolStripMenuItem.Click
        frmQuanlysanpham.Show()
    End Sub

    Private Sub ĐăngNhậpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐăngNhậpToolStripMenuItem.Click
        frmDangnhap.Show()
    End Sub

    Private Sub ĐăngXuấtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐăngXuấtToolStripMenuItem.Click
        Me.Close()
        frmDangnhap.Show()
    End Sub

    Private Sub LoạiSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoạiSảnPhẩmToolStripMenuItem.Click
        frmLoaiSP.Show()
    End Sub
End Class