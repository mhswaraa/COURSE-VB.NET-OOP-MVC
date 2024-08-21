Imports System.Data.Odbc

Public Class FormMahasiswa
    ' Deklarasi variabel untuk controller mahasiswa
    Dim ctrl_mahasiswa As MahasiswaController

    ' Event handler untuk klik tombol simpan
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Buat instance dari MahasiswaController dan panggil fungsi validasiData dengan data dari TextBox
        ctrl_mahasiswa = New MahasiswaController
        ctrl_mahasiswa.validasiData(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text)
    End Sub
End Class
