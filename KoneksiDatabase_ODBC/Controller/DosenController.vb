Public Class DosenController
    ' Deklarasi variabel untuk model dosen dan hasil operasi
    Dim model_dosen As ModelDosen
    Dim hasil As Boolean

    ' Fungsi untuk validasi data dosen sebelum menambahkannya ke database
    Public Function validasiData(ByVal id_dsn As String, ByVal nama_dsn As String, ByVal email As String) As Boolean
        ' Memeriksa apakah data yang diperlukan tidak kosong
        If id_dsn = "" Or nama_dsn = "" Or email = "" Then
            MsgBox("Data Tidak Boleh Kosong")
        Else
            ' Jika data valid, buat instance dari ModelDosen dan panggil fungsi TambahDataDosen
            model_dosen = New ModelDosen
            hasil = model_dosen.TambahDataDosen(id_dsn, nama_dsn, email)
        End If
        ' Mengembalikan hasil dari operasi penambahan data
        Return hasil
    End Function
End Class
