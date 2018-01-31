Public Class addfact

    Private Sub ButtonX2_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX2.Click
        If NumericUpDown1.Text = "0" Then
            MsgBox("Inserisci un rapporto UI/Cho", MsgBoxStyle.Critical, "Mhhh..")
        Else
            My.Settings.rappuicho = NumericUpDown1.Text
            Me.Hide()
        End If
    End Sub

    Private Sub ButtonX1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX1.Click
        Me.Hide()
    End Sub
End Class
'Copyright (C) 2017-2018, Gabriele Lobello.