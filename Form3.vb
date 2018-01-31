Public Class Form3

    Private Sub ButtonX2_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX2.Click
        If NumericUpDown1.Text = "0" Then
            MsgBox("Insersci le tue unità di basale", MsgBoxStyle.Critical, "Errore")
        ElseIf NumericUpDown2.Text = "0" Then
            MsgBox("Inserisci le tue unità di bolo giornaliere", MsgBoxStyle.Critical, "Errore")
        Else
            Dim basal As Integer = NumericUpDown1.Text
            Dim bolus As Integer = NumericUpDown2.Text
            Dim rapp As Integer = 500 / (basal + bolus)
            Label6.Visible = True
            Label6.Text = rapp
            My.Settings.rappuicho = rapp
        Dim totalUI As Integer = basal + bolus
        Dim si As Integer = 1500 / totalUI
            Label5.Text = si
            If si < 20 Then
                Label5.ForeColor = System.Drawing.Color.OrangeRed
                My.Settings.UIS = si
            Else
                My.Settings.UIS = si
            End If
            Label5.Show()
        End If
    End Sub

    Private Sub ButtonX1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX1.Click
        If NumericUpDown1.Text = "0" Then
            MsgBox("Insersci le tue unità di basale", MsgBoxStyle.Critical, "Errore")
        ElseIf NumericUpDown2.Text = "0" Then
            MsgBox("Inserisci le tue unità di bolo giornaliere", MsgBoxStyle.Critical, "Errore")
        Else
            Dim basal As Integer = NumericUpDown1.Text
            Dim bolus As Integer = NumericUpDown2.Text
            Dim rapp As Integer = 500 / (basal + bolus)
            Label6.Visible = True
            Label6.Text = rapp
            My.Settings.rappuicho = rapp
            Dim totalUI As Integer = basal + bolus
            Dim si As Integer = 1500 / totalUI
            Label5.Text = si
            If si < 20 Then
                Label5.ForeColor = System.Drawing.Color.OrangeRed
                My.Settings.UIS = si
            Else
                My.Settings.UIS = si
            End If
            Label5.Show()
        End If
    End Sub
End Class
'Copytight (C) 2017-2018, Gabriele Lobello.