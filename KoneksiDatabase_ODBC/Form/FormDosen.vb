Imports System.Data.Odbc

Public Class FormDosen
    ' Deklarasi variabel untuk controller dosen
    Dim ctrl_dosen As DosenController

    ' Event handler untuk klik tombol simpan
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Buat instance dari DosenController dan panggil fungsi validasiData dengan data dari TextBox
        ctrl_dosen = New DosenController
        ctrl_dosen.validasiData(TextBox1.Text, TextBox2.Text, TextBox3.Text)
    End Sub
End Class
