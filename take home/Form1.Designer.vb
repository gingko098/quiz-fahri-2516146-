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
        Me.txtNA = New System.Windows.Forms.TextBox()
        Me.txtNKTP = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.txtbukupinjam = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtJK = New System.Windows.Forms.TextBox()
        Me.txtTBD = New System.Windows.Forms.TextBox()
        Me.txtHPB = New System.Windows.Forms.TextBox()
        Me.txtTB = New System.Windows.Forms.TextBox()
        Me.txtUYB = New System.Windows.Forms.TextBox()
        Me.txtkembali = New System.Windows.Forms.TextBox()
        Me.txttanggalpeminjaman = New System.Windows.Forms.DateTimePicker()
        Me.txttanggalpengembalian = New System.Windows.Forms.DateTimePicker()
        Me.Hasil = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(167, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TRANSAKSI PEMINJAMAN BUKU"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(97, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No. Anggota"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(116, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "No. KTP"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(84, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nama Lengkap"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(125, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Alamat"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(2, 223)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(162, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Nama Buku Yang Akan Dipinjam"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(58, 279)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Tanggal Peminjaman"
        '
        'txtNA
        '
        Me.txtNA.Location = New System.Drawing.Point(187, 58)
        Me.txtNA.Name = "txtNA"
        Me.txtNA.Size = New System.Drawing.Size(164, 20)
        Me.txtNA.TabIndex = 7
        '
        'txtNKTP
        '
        Me.txtNKTP.Location = New System.Drawing.Point(187, 84)
        Me.txtNKTP.Name = "txtNKTP"
        Me.txtNKTP.Size = New System.Drawing.Size(164, 20)
        Me.txtNKTP.TabIndex = 8
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(187, 110)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(164, 20)
        Me.txtnama.TabIndex = 9
        '
        'txtalamat
        '
        Me.txtalamat.Location = New System.Drawing.Point(187, 136)
        Me.txtalamat.Multiline = True
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtalamat.Size = New System.Drawing.Size(201, 58)
        Me.txtalamat.TabIndex = 10
        '
        'txtbukupinjam
        '
        Me.txtbukupinjam.Location = New System.Drawing.Point(187, 207)
        Me.txtbukupinjam.Multiline = True
        Me.txtbukupinjam.Name = "txtbukupinjam"
        Me.txtbukupinjam.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtbukupinjam.Size = New System.Drawing.Size(201, 58)
        Me.txtbukupinjam.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(58, 306)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Tanggal Pengembalian"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(53, 332)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Jumlah Keterlambatan"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(69, 358)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Total Biaya Denda"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(40, 384)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(124, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Harga Peminjaman Buku"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(103, 406)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Total Bayar"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(44, 433)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(120, 13)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Uang Yang di Bayarkan"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(108, 457)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 13)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Kembalian"
        '
        'txtJK
        '
        Me.txtJK.Location = New System.Drawing.Point(187, 325)
        Me.txtJK.Name = "txtJK"
        Me.txtJK.Size = New System.Drawing.Size(160, 20)
        Me.txtJK.TabIndex = 24
        '
        'txtTBD
        '
        Me.txtTBD.Location = New System.Drawing.Point(187, 351)
        Me.txtTBD.Name = "txtTBD"
        Me.txtTBD.Size = New System.Drawing.Size(160, 20)
        Me.txtTBD.TabIndex = 25
        '
        'txtHPB
        '
        Me.txtHPB.Location = New System.Drawing.Point(187, 377)
        Me.txtHPB.Name = "txtHPB"
        Me.txtHPB.Size = New System.Drawing.Size(160, 20)
        Me.txtHPB.TabIndex = 26
        '
        'txtTB
        '
        Me.txtTB.Location = New System.Drawing.Point(187, 403)
        Me.txtTB.Name = "txtTB"
        Me.txtTB.Size = New System.Drawing.Size(160, 20)
        Me.txtTB.TabIndex = 27
        '
        'txtUYB
        '
        Me.txtUYB.Location = New System.Drawing.Point(187, 426)
        Me.txtUYB.Name = "txtUYB"
        Me.txtUYB.Size = New System.Drawing.Size(160, 20)
        Me.txtUYB.TabIndex = 28
        '
        'txtkembali
        '
        Me.txtkembali.Location = New System.Drawing.Point(187, 450)
        Me.txtkembali.Name = "txtkembali"
        Me.txtkembali.Size = New System.Drawing.Size(160, 20)
        Me.txtkembali.TabIndex = 29
        '
        'txttanggalpeminjaman
        '
        Me.txttanggalpeminjaman.Location = New System.Drawing.Point(190, 278)
        Me.txttanggalpeminjaman.Name = "txttanggalpeminjaman"
        Me.txttanggalpeminjaman.Size = New System.Drawing.Size(160, 20)
        Me.txttanggalpeminjaman.TabIndex = 31
        '
        'txttanggalpengembalian
        '
        Me.txttanggalpengembalian.Location = New System.Drawing.Point(190, 304)
        Me.txttanggalpengembalian.Name = "txttanggalpengembalian"
        Me.txttanggalpengembalian.Size = New System.Drawing.Size(160, 20)
        Me.txttanggalpengembalian.TabIndex = 32
        '
        'Hasil
        '
        Me.Hasil.Location = New System.Drawing.Point(420, 280)
        Me.Hasil.Name = "Hasil"
        Me.Hasil.Size = New System.Drawing.Size(75, 23)
        Me.Hasil.TabIndex = 33
        Me.Hasil.Text = "Hasil"
        Me.Hasil.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 493)
        Me.Controls.Add(Me.Hasil)
        Me.Controls.Add(Me.txttanggalpengembalian)
        Me.Controls.Add(Me.txttanggalpeminjaman)
        Me.Controls.Add(Me.txtkembali)
        Me.Controls.Add(Me.txtUYB)
        Me.Controls.Add(Me.txtTB)
        Me.Controls.Add(Me.txtHPB)
        Me.Controls.Add(Me.txtTBD)
        Me.Controls.Add(Me.txtJK)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtbukupinjam)
        Me.Controls.Add(Me.txtalamat)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txtNKTP)
        Me.Controls.Add(Me.txtNA)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNA As System.Windows.Forms.TextBox
    Friend WithEvents txtNKTP As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents txtalamat As System.Windows.Forms.TextBox
    Friend WithEvents txtbukupinjam As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtJK As System.Windows.Forms.TextBox
    Friend WithEvents txtTBD As System.Windows.Forms.TextBox
    Friend WithEvents txtHPB As System.Windows.Forms.TextBox
    Friend WithEvents txtTB As System.Windows.Forms.TextBox
    Friend WithEvents txtUYB As System.Windows.Forms.TextBox
    Friend WithEvents txtkembali As System.Windows.Forms.TextBox
    Friend WithEvents txttanggalpeminjaman As System.Windows.Forms.DateTimePicker
    Friend WithEvents txttanggalpengembalian As System.Windows.Forms.DateTimePicker
    Friend WithEvents Hasil As System.Windows.Forms.Button

End Class
