Public Class frmHoofd
	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim bedrag As Decimal


	End Sub



	Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
		tijd.Text = CStr(TimeOfDay)
	End Sub



	Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
		frmInfoProduct.Show()

	End Sub

	Private Sub cboArtikels_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboArtikels.SelectedIndexChanged

	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnVoegToe.Click
		lstAssortiment.Items.Add(cboArtikels.Text)

		Select Case cboArtikels.Text
			Case "S/FTP CAT8 kabel - 0.25 meter"

				lblBedrag.Text += 10
			Case "S/FTP CAT8 kabel - 1 meter"
				lblBedrag.Text += 10.5

		End Select

	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnVerwijderen.Click
		lstAssortiment.Items.Remove(lstAssortiment.SelectedItem)
	End Sub

	Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
		'*** sluit het programma
		Me.Close()
	End Sub
End Class
