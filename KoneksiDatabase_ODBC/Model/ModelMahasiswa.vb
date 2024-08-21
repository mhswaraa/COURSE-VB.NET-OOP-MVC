Imports System.Data.Odbc

Public Class ModelMahasiswa
    ' Deklarasi variabel untuk menyimpan query dan objek koneksi
    Dim q As String
    Dim koneksi As KoneksiDB

    ' Fungsi untuk menambahkan data mahasiswa ke dalam tabel mahasiswa
    Public Function tambahDataMahasiswa(ByVal id_mhs As String, ByVal nama_mhs As String, ByVal no_hp As String, ByVal semester As String) As Boolean
        Try
            ' Membuat query SQL dengan format string
            q = "INSERT INTO mahasiswa(id_mhs, nama_mhs, no_hp, semester) VALUES ('{0}', '{1}', '{2}', '{3}')"
            q = String.Format(q, id_mhs, nama_mhs, no_hp, semester)

            ' Membuat instance baru dari KoneksiDB dan menjalankan query
            koneksi = New KoneksiDB
            koneksi.jalankanQuery(q)
        Catch ex As Exception
            ' Menangkap dan menampilkan pesan kesalahan jika terjadi exception
            MessageBox.Show(ex.Message)
        End Try
        ' Mengembalikan nilai True jika operasi berhasil
        Return True
    End Function
End Class
