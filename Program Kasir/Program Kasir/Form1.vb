Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock

Public Class Frame3
    Private Const V As Boolean = True

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub btn_addjenis_Click()

    End Sub

    Private Sub List_jenis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles List_jenis.SelectedIndexChanged

    End Sub

    Private Sub Command1_Click(sender As Object, e As EventArgs) Handles Command1.Click
        Lbl_totalbayar.Text = Val(Thrg_brg.Text) * Val(Tjml_beli.Text)
    End Sub

    Private Sub Command2_Click(sender As Object, e As EventArgs) Handles Command2.Click
        Thrg_brg.Text = ""
        Tjenis_brg.Text = ""
        Tjml_beli.Text = ""
        Lbl_totalbayar.Text = ""
    End Sub

    Private Sub Command3_Click(sender As Object, e As EventArgs) Handles Command3.Click
        End

    End Sub

    Private Sub Command4_Click(sender As Object, e As EventArgs) Handles Command4.Click
        Dim total As String
        total = Lbl_totalbayar.Text

        If Db1.Text = "" Then
            Db1.Text = total
        ElseIf Db2.Text = "" Then
            Db2.Text = total
        ElseIf Db3.Text = "" Then
            Db3.Text = total
        ElseIf Db4.Text = "" Then
            Db4.Text = total
        ElseIf Db5.Text = "" Then
            Db5.Text = total
        ElseIf Db6.Text = "" Then
            Db6.Text = total
        Else
            MsgBox("Data bayar sudah penuh!")
        End If
    End Sub

    Private Sub Btn_addjenis_Click(sender As Object, e As EventArgs) Handles Btn_addjenis.Click
        List_brg.ClearSelected()
        If List_jenis.Text = "Rokok" Then
            List_brg.Items.Add("Dji Sam Soe")
            List_brg.Items.Add("Djarum Super")
            List_brg.Items.Add("Starmild")
            List_brg.Items.Add("Neomild")
            List_brg.Items.Add("Signature")
        ElseIf List_jenis.Text = "Mie" Then
            List_brg.Items.Add("Indomie")
            List_brg.Items.Add("Supermie")
            List_brg.Items.Add("Popmie")
            List_brg.Items.Add("Sarimie")
            List_brg.Items.Add("Mie Sedap")
        End If
    End Sub

    Private Sub Command5_Click(sender As Object, e As EventArgs) Handles Command5.Click
        Db1.Text = ""
        Db2.Text = ""
        Db3.Text = ""
        Db4.Text = ""
        Db5.Text = ""
        Db6.Text = ""
        Lbl_totalbeli.Text = ""
        Lbl_thanks.Text = ""
    End Sub

    Private Sub Command6_Click(sender As Object, e As EventArgs) Handles Command6.Click
        Dim total_beli As Double
        total_beli = Val(Db1.Text) + Val(Db2.Text) + Val(Db3.Text) + Val(Db4.Text) + Val(Db5.Text) + Val(Db6.Text)
        Lbl_totalbeli.Text = total_beli
        Lbl_thanks.Text = "Terimakasih telah berbelanja di CapTigaOrang market :)"
    End Sub

    Private Sub List_brg_SelectedIndexChanged(sender As Object, e As EventArgs) Handles List_brg.SelectedIndexChanged
        Dim harga As Double
        Dim jenis As String
        If List_jenis.Text = "Rokok" Then
            jenis = "Rokok"
            Select Case List_brg.Text
                Case "Dji Sam Soe"
                    harga = 12000
                Case "Djarum Super"
                    harga = 10000
                Case "Starmild"
                    harga = 11000
                Case "Neomild"
                    harga = 10500
                Case "Signature"
                    harga = 14000
            End Select
        ElseIf List_jenis.Text = "Mie" Then
            jenis = "Mie"
            Select Case List_brg.Text
                Case "Indomie"
                    harga = 1500
                Case "Supermie"
                    harga = 1400
                Case "Popmie"
                    harga = 6000
                Case "Sarimie"
                    harga = 1300
                Case "Mie Sedap"
                    harga = 1200
            End Select
        End If

        Thrg_brg.Text = harga
        Tjenis_brg.Text = jenis

        Tjml_beli.Text = ""
        Lbl_totalbayar.Text = ""
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtjam.Text = DateAndTime.Now.ToLongTimeString
        txttanggal.Text = DateAndTime.Now.ToLongDateString
    End Sub

    Private Sub Frame3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub
End Class
