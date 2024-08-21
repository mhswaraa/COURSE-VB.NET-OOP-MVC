Imports System.Data.Odbc

Public Class ModelDosen
    ' Deklarasi variabel untuk menyimpan query dan objek koneksi
    Dim q As String
    Dim koneksi As KoneksiDB

    ' Fungsi untuk menambahkan data dosen ke dalam tabel dosen
    Public Function TambahDataDosen(ByVal id_dns As String, ByVal nama_dns As String, ByVal email As String) As Boolean
        Try
            ' Membuat query SQL dengan format string
            q = "INSERT INTO dosen (id_dsn, nama_dsn, email) VALUES ('{0}', '{1}', '{2}')"
            q = String.Format(q, id_dns, nama_dns, email)

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
