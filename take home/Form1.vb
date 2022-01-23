Public Class Form1
    Dim jumlahhari As String
    Dim denda As Double
    Dim totdenda As Double
    Dim pinjam As Double
    Dim totbayar As Double
    Dim bayar As Double
    Dim kembali As Double
    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttanggalpengembalian.ValueChanged
        
    End Sub

    Private Sub txtJK_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtJK.TextChanged
        
    End Sub

    Private Sub txtTBD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTBD.TextChanged
       

    End Sub

    Private Sub txtHPB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHPB.TextChanged
        
    End Sub

    Private Sub txtUYB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUYB.TextChanged
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hasil.Click
        jumlahhari = DateDiff("d", txttanggalpeminjaman.Value, txttanggalpengembalian.Value)
        txtJK.Text = jumlahhari

        If jumlahhari < 7 Then
            denda = 5000
        ElseIf jumlahhari < 14 Then
            denda = 7000
        ElseIf jumlahhari < 30 Then
            denda = 25000
        Else
            denda = 100000
        End If

        totdenda = jumlahhari * denda
        txtTBD.Text = totdenda
        txtTBD.Text = Format(totdenda, "Rp ###,###,##")

        pinjam = Val(txtHPB.Text)
        totbayar = totdenda + pinjam
        txtTB.Text = totbayar
        txtTB.Text = Format(totbayar, "Rp ###,###,###")


        bayar = Val(txtUYB.Text)
        kembali = bayar - totbayar
        txtkembali.Text = kembali
        txtkembali.Text = Format(kembali, " Rp ###,###,###")

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtNA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNA.TextChanged

    End Sub
End Class
