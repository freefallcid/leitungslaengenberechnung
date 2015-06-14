Public Class frm_Main

    Private Sub btn_beenden_Click(sender As Object, e As EventArgs) Handles btn_beenden.Click
        End
    End Sub

    Private Sub btn_berechnen_Click(sender As Object, e As EventArgs) Handles btn_berechnen.Click
        o230_spannungsabfall.Text = Math.Round(CDec(i230_spannung.Text) * CDec(i230_abfall.Text) / 100, 2)
        o230_querschnitt.Text = Math.Round((2 * CDec(i230_laenge.Text) * CDec(i230_strom.Text) * CDec(i230_wirkungsgrad.Text)) / (CDec(i230_leitwert.Text) * CDec(o230_spannungsabfall.Text)), 2)
    End Sub

    Private Sub btn_beenden400_Click(sender As Object, e As EventArgs) Handles btn_beenden400.Click
        End
    End Sub

    Private Sub btn_berechnen400_Click(sender As Object, e As EventArgs) Handles btn_berechnen400.Click
        o400_spannungsabfall.Text = Math.Round(CDec(i400_spannung.Text) * CDec(i400_abfall.Text) / 100, 2)
        o400_querschnitt.Text = Math.Round((1.732 * CDec(i400_laenge.Text) * CDec(i400_strom.Text) * CDec(i400_wirkungsgrad.Text)) / (CDec(i400_leitwert.Text) * CDec(o400_spannungsabfall.Text)), 2)
    End Sub

    Private Sub btn_beendenAus_Click(sender As Object, e As EventArgs) Handles btn_beendenAus.Click
        End
    End Sub
    Public Sub checkSettings()
        If check_unter32A.Checked = False Then
            iAus_faktor.Text = "3,5"
            iAus_nennspannung.SelectedIndex = 1
            If CDec(iAus_nennstrom.Text) < 32 Then
                iAus_nennstrom.Text = "32"
            End If
        Else
            If iAus_type.Text = "Schmelz" Or iAus_type.Text = "C" Then
                iAus_faktor.Text = "10"
            ElseIf iAus_type.Text = "B" Then
                iAus_faktor.Text = "5"
            ElseIf iAus_type.Text = "D" Then
                iAus_faktor.Text = "20"
            End If
        End If
    End Sub
    Private Sub check_unter32A_CheckedChanged(sender As Object, e As EventArgs) Handles check_unter32A.CheckedChanged
        checkSettings()
    End Sub

    Private Sub check_ueber32A_CheckedChanged(sender As Object, e As EventArgs) Handles check_ueber32A.CheckedChanged
        checkSettings()
    End Sub

    Private Sub iAus_nennspannung_SelectedIndexChanged(sender As Object, e As EventArgs) Handles iAus_nennspannung.SelectedIndexChanged
        checkSettings()
    End Sub

    Private Sub iAus_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles iAus_type.SelectedIndexChanged
        checkSettings()
    End Sub

    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iAus_nennspannung.SelectedIndex = 0
        iAus_type.SelectedIndex = 0
    End Sub

    Private Sub btn_berechnenAus_Click(sender As Object, e As EventArgs) Handles btn_berechnenAus.Click
        checkSettings()
        oAus_ausschaltstrom.Text = CDec(iAus_nennstrom.Text) * CDec(iAus_faktor.Text)
        If CDec(iAus_nennspannung.Text) >= CDec(iAus_schleife.Text) * CDec(oAus_ausschaltstrom.Text) Then
            oAus_ergebnis.BackColor = Color.Green
        Else
            oAus_ergebnis.BackColor = Color.Red
        End If
        oAus_rechnung.Text = Math.Round(CDec(iAus_nennspannung.Text), 2) & " >= " & Math.Round(CDec(iAus_schleife.Text), 2) & " * " & Math.Round(CDec(oAus_ausschaltstrom.Text), 2) & Chr(13) & Chr(10) & Math.Round(CDec(iAus_nennspannung.Text), 2) & " >= " & Math.Round(CDec(iAus_schleife.Text) * CDec(oAus_ausschaltstrom.Text), 2)
    End Sub
End Class
