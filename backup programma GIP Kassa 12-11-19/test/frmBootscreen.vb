Public Class frmBootscreen
	Private Sub frmBootscreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'*** start de timer en verberg de startknop
		timerBoot.Start()
		btnOpen.Hide()
	End Sub


	Private Sub timerBoot_Tick(sender As Object, e As EventArgs) Handles timerBoot.Tick
		'*** verhoog laadbar en wanneer deze vol is, toon de open knop
		ProgressBar1.Increment(4)

		lblProcent.Text = ProgressBar1.Value & (" %")
		If ProgressBar1.Value = 100 Then
			btnOpen.Show()
		End If

	End Sub

	Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
		'*** sluit het bootscreen en open het programma
		frmHoofd.Show()
		Me.Hide()
	End Sub
End Class