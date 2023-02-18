<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frame3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.List_jenis = New System.Windows.Forms.ComboBox()
        Me.Btn_addjenis = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Thrg_brg = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Tjenis_brg = New System.Windows.Forms.TextBox()
        Me.Tjml_beli = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Command1 = New System.Windows.Forms.Button()
        Me.Lbl_totalbayar = New System.Windows.Forms.Label()
        Me.Command2 = New System.Windows.Forms.Button()
        Me.Command3 = New System.Windows.Forms.Button()
        Me.Command4 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Command5 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Db1 = New System.Windows.Forms.TextBox()
        Me.Db6 = New System.Windows.Forms.TextBox()
        Me.Db5 = New System.Windows.Forms.TextBox()
        Me.Db4 = New System.Windows.Forms.TextBox()
        Me.Db3 = New System.Windows.Forms.TextBox()
        Me.Db2 = New System.Windows.Forms.TextBox()
        Me.Command6 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Lbl_totalbeli = New System.Windows.Forms.Label()
        Me.Lbl_thanks = New System.Windows.Forms.Label()
        Me.Lbl_date = New System.Windows.Forms.Label()
        Me.Lbl_time = New System.Windows.Forms.Label()
        Me.List_brg = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtjam = New System.Windows.Forms.Label()
        Me.txttanggal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 78)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Jenis Barang"
        '
        'List_jenis
        '
        Me.List_jenis.FormattingEnabled = True
        Me.List_jenis.Items.AddRange(New Object() {"Rokok", "Mie"})
        Me.List_jenis.Location = New System.Drawing.Point(112, 74)
        Me.List_jenis.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.List_jenis.Name = "List_jenis"
        Me.List_jenis.Size = New System.Drawing.Size(140, 22)
        Me.List_jenis.TabIndex = 1
        '
        'Btn_addjenis
        '
        Me.Btn_addjenis.Location = New System.Drawing.Point(294, 71)
        Me.Btn_addjenis.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Btn_addjenis.Name = "Btn_addjenis"
        Me.Btn_addjenis.Size = New System.Drawing.Size(88, 25)
        Me.Btn_addjenis.TabIndex = 2
        Me.Btn_addjenis.Text = "Tambah Jenis Barang"
        Me.Btn_addjenis.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(300, 135)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 14)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Harga Barang"
        '
        'Thrg_brg
        '
        Me.Thrg_brg.Location = New System.Drawing.Point(406, 131)
        Me.Thrg_brg.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Thrg_brg.Name = "Thrg_brg"
        Me.Thrg_brg.Size = New System.Drawing.Size(116, 20)
        Me.Thrg_brg.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(300, 178)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 14)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Jenis Barang"
        '
        'Tjenis_brg
        '
        Me.Tjenis_brg.Location = New System.Drawing.Point(406, 174)
        Me.Tjenis_brg.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Tjenis_brg.Name = "Tjenis_brg"
        Me.Tjenis_brg.Size = New System.Drawing.Size(116, 20)
        Me.Tjenis_brg.TabIndex = 7
        '
        'Tjml_beli
        '
        Me.Tjml_beli.Location = New System.Drawing.Point(406, 214)
        Me.Tjml_beli.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Tjml_beli.Name = "Tjml_beli"
        Me.Tjml_beli.Size = New System.Drawing.Size(116, 20)
        Me.Tjml_beli.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(300, 218)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 14)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Jumlah Beli"
        '
        'Command1
        '
        Me.Command1.Location = New System.Drawing.Point(294, 260)
        Me.Command1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Command1.Name = "Command1"
        Me.Command1.Size = New System.Drawing.Size(96, 31)
        Me.Command1.TabIndex = 10
        Me.Command1.Text = "Total Bayar"
        Me.Command1.UseVisualStyleBackColor = True
        '
        'Lbl_totalbayar
        '
        Me.Lbl_totalbayar.AutoSize = True
        Me.Lbl_totalbayar.Location = New System.Drawing.Point(403, 271)
        Me.Lbl_totalbayar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_totalbayar.Name = "Lbl_totalbayar"
        Me.Lbl_totalbayar.Size = New System.Drawing.Size(0, 14)
        Me.Lbl_totalbayar.TabIndex = 11
        '
        'Command2
        '
        Me.Command2.Location = New System.Drawing.Point(294, 314)
        Me.Command2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Command2.Name = "Command2"
        Me.Command2.Size = New System.Drawing.Size(96, 25)
        Me.Command2.TabIndex = 12
        Me.Command2.Text = "Clear"
        Me.Command2.UseVisualStyleBackColor = True
        '
        'Command3
        '
        Me.Command3.Location = New System.Drawing.Point(809, 358)
        Me.Command3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Command3.Name = "Command3"
        Me.Command3.Size = New System.Drawing.Size(88, 25)
        Me.Command3.TabIndex = 13
        Me.Command3.Text = "Exit"
        Me.Command3.UseVisualStyleBackColor = True
        '
        'Command4
        '
        Me.Command4.Location = New System.Drawing.Point(611, 96)
        Me.Command4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Command4.Name = "Command4"
        Me.Command4.Size = New System.Drawing.Size(88, 25)
        Me.Command4.TabIndex = 14
        Me.Command4.Text = "Add Bayar"
        Me.Command4.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Command5
        '
        Me.Command5.Location = New System.Drawing.Point(744, 96)
        Me.Command5.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Command5.Name = "Command5"
        Me.Command5.Size = New System.Drawing.Size(88, 25)
        Me.Command5.TabIndex = 15
        Me.Command5.Text = "Clear"
        Me.Command5.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(608, 151)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 14)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Data Beli"
        '
        'Db1
        '
        Me.Db1.Location = New System.Drawing.Point(611, 178)
        Me.Db1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Db1.Name = "Db1"
        Me.Db1.Size = New System.Drawing.Size(79, 20)
        Me.Db1.TabIndex = 21
        '
        'Db6
        '
        Me.Db6.Location = New System.Drawing.Point(784, 214)
        Me.Db6.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Db6.Name = "Db6"
        Me.Db6.Size = New System.Drawing.Size(79, 20)
        Me.Db6.TabIndex = 22
        '
        'Db5
        '
        Me.Db5.Location = New System.Drawing.Point(698, 214)
        Me.Db5.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Db5.Name = "Db5"
        Me.Db5.Size = New System.Drawing.Size(79, 20)
        Me.Db5.TabIndex = 23
        '
        'Db4
        '
        Me.Db4.Location = New System.Drawing.Point(611, 214)
        Me.Db4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Db4.Name = "Db4"
        Me.Db4.Size = New System.Drawing.Size(79, 20)
        Me.Db4.TabIndex = 24
        '
        'Db3
        '
        Me.Db3.Location = New System.Drawing.Point(784, 178)
        Me.Db3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Db3.Name = "Db3"
        Me.Db3.Size = New System.Drawing.Size(79, 20)
        Me.Db3.TabIndex = 25
        '
        'Db2
        '
        Me.Db2.Location = New System.Drawing.Point(698, 178)
        Me.Db2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Db2.Name = "Db2"
        Me.Db2.Size = New System.Drawing.Size(79, 20)
        Me.Db2.TabIndex = 26
        '
        'Command6
        '
        Me.Command6.Location = New System.Drawing.Point(611, 263)
        Me.Command6.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Command6.Name = "Command6"
        Me.Command6.Size = New System.Drawing.Size(87, 25)
        Me.Command6.TabIndex = 27
        Me.Command6.Text = "Total Bayar"
        Me.Command6.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(706, 268)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(22, 14)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Rp"
        '
        'Lbl_totalbeli
        '
        Me.Lbl_totalbeli.AutoSize = True
        Me.Lbl_totalbeli.Location = New System.Drawing.Point(741, 268)
        Me.Lbl_totalbeli.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_totalbeli.Name = "Lbl_totalbeli"
        Me.Lbl_totalbeli.Size = New System.Drawing.Size(0, 14)
        Me.Lbl_totalbeli.TabIndex = 29
        '
        'Lbl_thanks
        '
        Me.Lbl_thanks.AutoSize = True
        Me.Lbl_thanks.Location = New System.Drawing.Point(608, 305)
        Me.Lbl_thanks.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_thanks.Name = "Lbl_thanks"
        Me.Lbl_thanks.Size = New System.Drawing.Size(0, 14)
        Me.Lbl_thanks.TabIndex = 30
        '
        'Lbl_date
        '
        Me.Lbl_date.AutoSize = True
        Me.Lbl_date.Location = New System.Drawing.Point(607, 397)
        Me.Lbl_date.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_date.Name = "Lbl_date"
        Me.Lbl_date.Size = New System.Drawing.Size(0, 14)
        Me.Lbl_date.TabIndex = 32
        '
        'Lbl_time
        '
        Me.Lbl_time.AutoSize = True
        Me.Lbl_time.Location = New System.Drawing.Point(735, 397)
        Me.Lbl_time.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_time.Name = "Lbl_time"
        Me.Lbl_time.Size = New System.Drawing.Size(0, 14)
        Me.Lbl_time.TabIndex = 34
        '
        'List_brg
        '
        Me.List_brg.FormattingEnabled = True
        Me.List_brg.ItemHeight = 14
        Me.List_brg.Location = New System.Drawing.Point(113, 134)
        Me.List_brg.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.List_brg.Name = "List_brg"
        Me.List_brg.Size = New System.Drawing.Size(139, 102)
        Me.List_brg.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(199, 369)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 14)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Tanggal"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(51, 369)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 14)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Waktu"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(419, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 14)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "PROGRAM KASIR"
        '
        'txtjam
        '
        Me.txtjam.AutoSize = True
        Me.txtjam.Location = New System.Drawing.Point(109, 369)
        Me.txtjam.Name = "txtjam"
        Me.txtjam.Size = New System.Drawing.Size(0, 14)
        Me.txtjam.TabIndex = 39
        '
        'txttanggal
        '
        Me.txttanggal.AutoSize = True
        Me.txttanggal.Location = New System.Drawing.Point(273, 369)
        Me.txttanggal.Name = "txttanggal"
        Me.txttanggal.Size = New System.Drawing.Size(0, 14)
        Me.txttanggal.TabIndex = 40
        '
        'Frame3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(933, 386)
        Me.Controls.Add(Me.txttanggal)
        Me.Controls.Add(Me.txtjam)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.List_brg)
        Me.Controls.Add(Me.Lbl_time)
        Me.Controls.Add(Me.Lbl_date)
        Me.Controls.Add(Me.Lbl_thanks)
        Me.Controls.Add(Me.Lbl_totalbeli)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Command6)
        Me.Controls.Add(Me.Db2)
        Me.Controls.Add(Me.Db3)
        Me.Controls.Add(Me.Db4)
        Me.Controls.Add(Me.Db5)
        Me.Controls.Add(Me.Db6)
        Me.Controls.Add(Me.Db1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Command5)
        Me.Controls.Add(Me.Command4)
        Me.Controls.Add(Me.Command3)
        Me.Controls.Add(Me.Command2)
        Me.Controls.Add(Me.Lbl_totalbayar)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.Tjml_beli)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Tjenis_brg)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Thrg_brg)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Btn_addjenis)
        Me.Controls.Add(Me.List_jenis)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Lucida Bright", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Frame3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents List_jenis As ComboBox
    Friend WithEvents Btn_addjenis As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Thrg_brg As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Tjenis_brg As TextBox
    Friend WithEvents Tjml_beli As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Command1 As Button
    Friend WithEvents Lbl_totalbayar As Label
    Friend WithEvents Command2 As Button
    Friend WithEvents Command3 As Button
    Friend WithEvents Command4 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Command5 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Db1 As TextBox
    Friend WithEvents Db6 As TextBox
    Friend WithEvents Db5 As TextBox
    Friend WithEvents Db4 As TextBox
    Friend WithEvents Db3 As TextBox
    Friend WithEvents Db2 As TextBox
    Friend WithEvents Command6 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Lbl_totalbeli As Label
    Friend WithEvents Lbl_thanks As Label
    Friend WithEvents Lbl_date As Label
    Friend WithEvents Lbl_time As Label
    Friend WithEvents List_brg As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtjam As Label
    Friend WithEvents txttanggal As Label
End Class
