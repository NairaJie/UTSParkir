<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CmdTambah = New System.Windows.Forms.Button()
        Me.CmdSimpan = New System.Windows.Forms.Button()
        Me.CmdUpdate = New System.Windows.Forms.Button()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtPlat = New System.Windows.Forms.TextBox()
        Me.txtLama = New System.Windows.Forms.TextBox()
        Me.txtTambahan = New System.Windows.Forms.TextBox()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.dtpMasuk = New System.Windows.Forms.DateTimePicker()
        Me.cmbJenis = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DgTampil = New System.Windows.Forms.DataGridView()
        CType(Me.DgTampil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(266, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INPUT DATA PARKIR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID TRANSAKSI"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "PLAT NOMOR"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "TANGGAL MASUK"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(50, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "JENIS KENDARAAN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(50, 269)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "HARGA/JAM"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(50, 315)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(50, 363)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "BIAYA TAMBAHAN"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(50, 406)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "TOTAL BAYAR"
        '
        'CmdTambah
        '
        Me.CmdTambah.Location = New System.Drawing.Point(53, 451)
        Me.CmdTambah.Name = "CmdTambah"
        Me.CmdTambah.Size = New System.Drawing.Size(109, 23)
        Me.CmdTambah.TabIndex = 9
        Me.CmdTambah.Text = "TAMBAH"
        Me.CmdTambah.UseVisualStyleBackColor = True
        '
        'CmdSimpan
        '
        Me.CmdSimpan.Location = New System.Drawing.Point(225, 451)
        Me.CmdSimpan.Name = "CmdSimpan"
        Me.CmdSimpan.Size = New System.Drawing.Size(109, 23)
        Me.CmdSimpan.TabIndex = 10
        Me.CmdSimpan.Text = "SIMPAN"
        Me.CmdSimpan.UseVisualStyleBackColor = True
        '
        'CmdUpdate
        '
        Me.CmdUpdate.Location = New System.Drawing.Point(384, 451)
        Me.CmdUpdate.Name = "CmdUpdate"
        Me.CmdUpdate.Size = New System.Drawing.Size(109, 23)
        Me.CmdUpdate.TabIndex = 11
        Me.CmdUpdate.Text = "UPDATE"
        Me.CmdUpdate.UseVisualStyleBackColor = True
        '
        'BtnKeluar
        '
        Me.BtnKeluar.Location = New System.Drawing.Point(537, 451)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(109, 23)
        Me.BtnKeluar.TabIndex = 12
        Me.BtnKeluar.Text = "KELUAR"
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(208, 76)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(204, 20)
        Me.txtId.TabIndex = 13
        '
        'txtPlat
        '
        Me.txtPlat.Location = New System.Drawing.Point(208, 122)
        Me.txtPlat.Name = "txtPlat"
        Me.txtPlat.Size = New System.Drawing.Size(204, 20)
        Me.txtPlat.TabIndex = 14
        '
        'txtLama
        '
        Me.txtLama.Location = New System.Drawing.Point(208, 308)
        Me.txtLama.Name = "txtLama"
        Me.txtLama.Size = New System.Drawing.Size(164, 20)
        Me.txtLama.TabIndex = 15
        '
        'txtTambahan
        '
        Me.txtTambahan.Location = New System.Drawing.Point(208, 360)
        Me.txtTambahan.Name = "txtTambahan"
        Me.txtTambahan.Size = New System.Drawing.Size(164, 20)
        Me.txtTambahan.TabIndex = 16
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(208, 263)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(164, 20)
        Me.txtHarga.TabIndex = 17
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(208, 406)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(164, 20)
        Me.txtTotal.TabIndex = 18
        '
        'dtpMasuk
        '
        Me.dtpMasuk.Location = New System.Drawing.Point(208, 169)
        Me.dtpMasuk.Name = "dtpMasuk"
        Me.dtpMasuk.Size = New System.Drawing.Size(200, 20)
        Me.dtpMasuk.TabIndex = 19
        '
        'cmbJenis
        '
        Me.cmbJenis.FormattingEnabled = True
        Me.cmbJenis.Items.AddRange(New Object() {"Motor", "Mobil"})
        Me.cmbJenis.Location = New System.Drawing.Point(208, 219)
        Me.cmbJenis.Name = "cmbJenis"
        Me.cmbJenis.Size = New System.Drawing.Size(164, 21)
        Me.cmbJenis.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(49, 315)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "LAMA PARKIR"
        '
        'DgTampil
        '
        Me.DgTampil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgTampil.Location = New System.Drawing.Point(53, 507)
        Me.DgTampil.Name = "DgTampil"
        Me.DgTampil.Size = New System.Drawing.Size(593, 150)
        Me.DgTampil.TabIndex = 22
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 585)
        Me.Controls.Add(Me.DgTampil)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmbJenis)
        Me.Controls.Add(Me.dtpMasuk)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.txtTambahan)
        Me.Controls.Add(Me.txtLama)
        Me.Controls.Add(Me.txtPlat)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.BtnKeluar)
        Me.Controls.Add(Me.CmdUpdate)
        Me.Controls.Add(Me.CmdSimpan)
        Me.Controls.Add(Me.CmdTambah)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "UTS TYPE A"
        CType(Me.DgTampil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents CmdTambah As Button
    Friend WithEvents CmdSimpan As Button
    Friend WithEvents CmdUpdate As Button
    Friend WithEvents BtnKeluar As Button
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtPlat As TextBox
    Friend WithEvents txtLama As TextBox
    Friend WithEvents txtTambahan As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents dtpMasuk As DateTimePicker
    Friend WithEvents cmbJenis As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents DgTampil As DataGridView
End Class
