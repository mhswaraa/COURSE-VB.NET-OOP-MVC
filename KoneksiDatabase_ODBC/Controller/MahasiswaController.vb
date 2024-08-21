Public Class MahasiswaController
    ' Deklarasi variabel untuk model mahasiswa dan hasil operasi
    Dim model_mahasiswa As ModelMahasiswa
    Dim hasil As Boolean

    ' Fungsi untuk validasi data mahasiswa sebelum menambahkannya ke database
    Public Function validasiData(ByVal id_mhs As String, ByVal nama_mhs As String, ByVal no_hp As String, ByVal semester As String) As Boolean
        ' Memeriksa apakah data yang diperlukan tidak kosong
        If id_mhs = "" Or nama_mhs = "" Or no_hp = "" Then
            MsgBox("Data tidak Boleh Kosong")
        Else
            ' Jika data valid, buat instance dari ModelMahasiswa dan panggil fungsi tambahDataMahasiswa
            model_mahasiswa = New ModelMahasiswa
            hasil = model_mahasiswa.tambahDataMahasiswa(id_mhs, nama_mhs, no_hp, semester)
        End If
        ' Mengembalikan hasil dari operasi penambahan data
        Return hasil
    End Function
End Class
