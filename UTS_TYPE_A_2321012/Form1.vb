Imports MySql.Data.MySqlClient
Public Class Form1
    Dim strkon As String = "server=localhost;uid=root;database=uts_A_2321012"
    Dim kon As New MySqlConnection(strkon)
    Dim perintah As New MySqlCommand
    Dim mda As New MySqlDataAdapter
    Dim ds As New DataSet
    Dim cek As MySqlDataReader
    Dim harga, tambah, total As Double

    Sub tidakaktif()
        txtId.Enabled = False
        txtPlat.Enabled = False
        dtpMasuk.Enabled = False
        cmbJenis.Enabled = False
        txtHarga.Enabled = False
        txtLama.Enabled = False
        txtTambahan.Enabled = False
        txtTotal.Enabled = False

        txtId.BackColor = Color.Gray
        txtPlat.BackColor = Color.Gray
        dtpMasuk.BackColor = Color.Gray
        cmbJenis.BackColor = Color.Gray
        txtHarga.BackColor = Color.Gray
        txtLama.BackColor = Color.Gray
        txtTambahan.BackColor = Color.Gray
        txtTotal.BackColor = Color.Gray


        CmdSimpan.Enabled = False
        CmdUpdate.Enabled = False
    End Sub


    Sub aktif()
        txtId.Enabled = True
        txtPlat.Enabled = True
        dtpMasuk.Enabled = True
        cmbJenis.Enabled = True
        txtHarga.Enabled = True
        txtLama.Enabled = True
        txtTambahan.Enabled = True
        txtTotal.Enabled = True

        txtId.BackColor = Color.White
        txtPlat.BackColor = Color.White
        dtpMasuk.BackColor = Color.White
        cmbJenis.BackColor = Color.White
        txtHarga.BackColor = Color.White
        txtLama.BackColor = Color.White
        txtTambahan.BackColor = Color.White
        txtTotal.BackColor = Color.White


        CmdSimpan.Enabled = True
        CmdUpdate.Enabled = True

    End Sub

    Sub bersih()
        txtId.Text = ""
        txtPlat.Text = ""
        dtpMasuk.Text = ""
        cmbJenis.Text = ""
        txtHarga.Text = ""
        txtLama.Text = ""
        txtTambahan.Text = ""
        txtTotal.Text = ""
    End Sub

    Sub tampil()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from parkir"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "parkir")
        DgTampil.DataSource = ds.Tables("parkir")
        kon.Close()
    End Sub

    Private Sub txtId_TextChanged(sender As Object, e As KeyEventArgs) Handles txtId.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                kon.Open()
                perintah.Connection = kon
                perintah.CommandType = CommandType.Text
                perintah.CommandText = "select * from parkir " &
                " where Id='" & txtId.Text & "'"
                cek = perintah.ExecuteReader
                cek.Read()
                MsgBox("data sudah ada...!", MsgBoxStyle.Information, "Pesan")
                If cek.HasRows Then
                    txtPlat.Text = cek.Item("Plat")
                    dtpMasuk.Value = cek.Item("TanggalMasuk")
                    cmbJenis.Text = cek.Item("Jenis")
                    txtHarga.Text = cek.Item("Harga")
                    txtLama.Text = cek.Item("lama")
                    txtTambahan.Text = cek.Item("BiayaTambahan")
                    txtTotal.Text = cek.Item("Total")
                    CmdSimpan.Enabled = False
                End If
                kon.Close()
                ' tidakaktif()
                CmdTambah.Enabled = True
        End Select
    End Sub

    Private Sub CmdTambah_Click(sender As Object, e As EventArgs) Handles CmdTambah.Click
        aktif()
        txtId.Focus()
        CmdTambah.Enabled = False
    End Sub

    Private Sub CmdSimpan_Click(sender As Object, e As EventArgs) Handles CmdSimpan.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "insert into parkir values " &
        " ('" & txtId.Text & "', '" & txtPlat.Text & "', " &
        " '" & Format(dtpMasuk.Value, "yyyy-MM-dd") & "', " &
        " '" & cmbJenis.Text & "', '" & harga & "','" & txtLama.Text & "', " &
        " '" & tambah & "', ' " & total & " ')"
        perintah.ExecuteNonQuery()
        kon.Close()
        MsgBox("data berhasil disimpan", MsgBoxStyle.Information, "Pesan")
        tampil()
        bersih()
        tidakaktif()
        CmdTambah.Enabled = True
    End Sub

    Private Sub txtLama_TextChanged(sender As Object, e As EventArgs) Handles txtLama.TextChanged
        If Val(txtLama.Text) > 3 Then
            tambah = 1000 * Val(txtLama.Text)
        Else
            tambah = 0
        End If

        txtTambahan.Text = Format(tambah, "Rp ###,###,##")
        total = harga + tambah
        txtTotal.Text = Format(total, "Rp ###,###,##")
    End Sub

    Private Sub CmdUpdate_Click(sender As Object, e As EventArgs) Handles CmdUpdate.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "Update parkir set plat =  '" & txtPlat.Text & "' ,
        TanggalMasuk = '" & Format(dtpMasuk.Value, "yyyy-MM-dd") & "',
        Jenis = '" & cmbJenis.Text & "', Harga = '" & harga & "',
        Lama = '" & txtLama.Text & "', BiayaTambahan = '" & tambah & "',
        Total  = '" & total & "' where Id ='" & txtId.Text & "'"
        perintah.ExecuteNonQuery()
        kon.Close()
        tampil()
        bersih()
        tidakaktif()
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Me.Close()
    End Sub

    Private Sub cmbJenis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbJenis.SelectedIndexChanged
        Select Case cmbJenis.SelectedIndex
            Case 0
                harga = 2000

            Case 1
                harga = 5000
        End Select
        txtHarga.Text = Format(harga, "Rp ###,###,##")

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tidakaktif()
        bersih()
        tampil()
    End Sub
End Class
