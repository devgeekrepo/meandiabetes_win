Public Class boluswizard
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If CheckBox1.Checked = True Then
            TextBox3.Visible = False
            LinkLabel1.Visible = True
        Else
            TextBox3.Visible = True
            LinkLabel1.Visible = False
        End If
        If CheckBox2.Checked = True Then
            TextBox4.Visible = False
            LinkLabel2.Visible = True
        Else
            TextBox4.Visible = True
            LinkLabel2.Visible = False
        End If
    End Sub



    Private Sub boluswizard_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

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

    Private Sub TextBox2_KeyPress(ByVal sender As Object, _
               ByVal e As System.Windows.Forms.KeyPressEventArgs) _
                Handles TextBox2.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If KeyAscii < 48 And KeyAscii <> 24 And KeyAscii <> 8 Then
            KeyAscii = 0
        ElseIf KeyAscii > 57 Then
            KeyAscii = 0
        End If
        If e.KeyChar = "0" And TextBox2.TextLength = 0 Then
            KeyAscii = 0
        End If
        e.KeyChar = Chr(KeyAscii)
    End Sub
    Private Sub TextBox4_KeyPress(ByVal sender As Object, _
              ByVal e As System.Windows.Forms.KeyPressEventArgs) _
               Handles TextBox4.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If KeyAscii < 48 And KeyAscii <> 24 And KeyAscii <> 8 Then
            KeyAscii = 0
        ElseIf KeyAscii > 57 Then
            KeyAscii = 0
        End If
        If e.KeyChar = "0" And TextBox4.TextLength = 0 Then
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

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        If TextBox1.Text <> "" Then
            Dim glic As Integer = TextBox1.Text
            If glic < 80 Then
                Timer2.Enabled = True
                Label7.Visible = True
                Label7.Text = "Sei in ipoglicemia"
                Label7.ForeColor = Color.OrangeRed
            ElseIf glic > 170 Then
                Timer2.Enabled = True
                Label7.Visible = True
                Label7.Text = "Sei in iperglicemia!"
                Label7.ForeColor = Color.OrangeRed
            ElseIf TextBox1.Text = "" Then
                Timer2.Enabled = False
            Else
                Timer2.Enabled = True
                Label7.Visible = True
                Label7.Text = "Ok!"
                Label7.ForeColor = Color.DeepSkyBlue
            End If
        Else
            Label7.Visible = False
        End If
    End Sub

    Private Sub ButtonX2_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX2.Click
        If TextBox1.Text = "" Then
            MsgBox("Inserisci un valore glicemico", MsgBoxStyle.Critical, "Errore")
        ElseIf TextBox2.Text = "" Then
            MsgBox("Inserisci una quantità di carboidrati (in grammi)", MsgBoxStyle.Critical, "Errore")
        Else
            Dim glic As Integer = TextBox1.Text
            My.Settings.lastglic = glic
            Dim cho As Integer = TextBox2.Text
            Label4.Visible = True
            Dim bolo As Integer
            If glic > 150 Then
                If CheckBox2.Checked = True Then
                    If CheckBox1.Checked = True Then
                        bolo = ((glic - 120) / My.Settings.UIS) + (cho / My.Settings.rappuicho)
                        Label4.Text = bolo & " UI"
                        My.Settings.lastbolo = Label4.Text

                    Else
                        bolo = ((glic - 120) / My.Settings.UIS) + (cho / TextBox4.Text)
                        Label4.Text = bolo & " UI"
                        My.Settings.lastbolo = Label4.Text

                    End If
                Else
                    If CheckBox1.Checked = True Then
                        bolo = ((glic - 120) / TextBox3.Text) + (cho / My.Settings.rappuicho)
                        Label4.Text = bolo & " UI"
                        My.Settings.lastbolo = Label4.Text

                    Else
                        bolo = ((glic - 120) / TextBox3.Text) + (cho / TextBox4.Text)
                        Label4.Text = bolo & " UI"
                        My.Settings.lastbolo = Label4.Text

                    End If
                End If
            Else
                If CheckBox2.Checked = True Then
                    bolo = cho / My.Settings.rappuicho
                    Label4.Text = bolo & " UI"
                    My.Settings.lastbolo = Label4.Text

                Else
                    bolo = cho / TextBox4.Text
                    Label4.Text = bolo & " UI"
                    My.Settings.lastbolo = Label4.Text

                End If

            End If
        End If
    End Sub
End Class
'Copyright (C) 2017-2018, Gabriele Lobello.