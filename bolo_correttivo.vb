Public Class bolo_correttivo

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        If TextBox1.Text <> "" Then
            Dim glic As Integer = TextBox1.Text
            If glic < 170 Then
                Timer2.Enabled = True
                Label7.Visible = True
                Label7.Text = "Questa non è un'iperglicemia"
                Label7.ForeColor = Color.OrangeRed
            Else
                Label7.Visible = False
                End If
        Else
                Label7.Visible = False
            End If
    End Sub
    Private Sub TextBox1_KeyPress(ByVal sender As Object, _
               ByVal e As System.Windows.Forms.KeyPressEventArgs) _
                Handles TextBox1.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If KeyAscii < 48 And KeyAscii <> 24 And KeyAscii <> 8 Then
            KeyAscii = 0
        ElseIf KeyAscii > 57 Then
            KeyAscii = 0
        End If
        If e.KeyChar = "0" And TextBox1.TextLength = 0 Then
            KeyAscii = 0
        End If
        e.KeyChar = Chr(KeyAscii)
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, _
              ByVal e As System.Windows.Forms.KeyPressEventArgs) _
               Handles TextBox3.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If KeyAscii < 48 And KeyAscii <> 24 And KeyAscii <> 8 Then
            KeyAscii = 0
        ElseIf KeyAscii > 57 Then
            KeyAscii = 0
        End If
        If e.KeyChar = "0" And TextBox3.TextLength = 0 Then
            KeyAscii = 0
        End If
        e.KeyChar = Chr(KeyAscii)
    End Sub

    Private Sub ButtonX2_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX2.Click
        If TextBox1.Text = "" Then
            MsgBox("Inserisci una glicemia, altrimenti non potrò aiutarti", MsgBoxStyle.Critical, "Errore")
        Else
        Dim glic = TextBox1.Text
        If glic < 170 Then
            MsgBox("Non sei in iperglicemia, non c'è bisogno di correggere con un bolo!", MsgBoxStyle.Exclamation, "Tranquillo!")
        Else
            If CheckBox1.Checked = True Then
                If My.Settings.UIS = 0 Then
                    MsgBox("Non hai registrato nessuna sensibilità insulinica!" & vbNewLine & "Prova ad inserirla manualmente o premi su 'Calcola sensibilità insulinica", MsgBoxStyle.Critical, "Errore")
                    Else
                        Label4.Show()
                        Label4.Text = glic / My.Settings.UIS & " UI"
                End If
            Else
                If TextBox3.Text = "" Then
                    MsgBox("Inserisci una sensibilita insulinica!", MsgBoxStyle.Critical, "Errore")
                    Else
                        Label4.Show()
                        Label4.Text = glic / TextBox3.Text & " UI"
                End If
            End If
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If CheckBox1.Checked = True Then
            TextBox3.Visible = False
            LinkLabel1.Visible = True
        Else
            TextBox3.Visible = True
            LinkLabel1.Visible = False
        End If
    End Sub
End Class
'Copyright (C) 2017-2018, Gabriele Lobello.