Imports System.Data.Odbc

Public Class KoneksiDB
    ' Deklarasi variabel untuk digunakan dalam koneksi dan operasi database
    Dim dr As OdbcDataReader
    Dim cmd As OdbcCommand
    Dim conn As OdbcConnection
    Dim dt As DataTable
    ' String koneksi untuk terhubung dengan database menggunakan DSN (Data Source Name)
    Dim strConn As String = "dsn=db_test"

    ' Fungsi untuk menjalankan query SQL
    Public Function jalankanQuery(ByVal q As String) As Boolean
        Try
            ' Membuat koneksi baru menggunakan string koneksi
            conn = New OdbcConnection(strConn)
            ' Membuka koneksi ke database
            conn.Open()
            ' Membuat command baru untuk menjalankan query
            cmd = New OdbcCommand(q, conn)
            ' Menjalankan query yang tidak mengembalikan hasil (misalnya INSERT, UPDATE, DELETE)
            cmd.ExecuteNonQuery()

            ' Menampilkan pesan bahwa data tersimpan
            MessageBox.Show("Data Tersimpan")
            ' Menutup koneksi setelah operasi selesai
            conn.Close()
        Catch ex As Exception
            ' Menangkap dan menampilkan pesan kesalahan jika terjadi exception
            MessageBox.Show(ex.Message)
        End Try
        ' Mengembalikan nilai True jika operasi berhasil
        Return True
    End Function
End Class
