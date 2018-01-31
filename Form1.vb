Public Class Form1

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs)
        Form3.Show()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs)
        boluswizard.Show()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        info.Show()
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim stringa As New System.Net.WebClient
        Try
            Dim nuovaversione As String = stringa.DownloadString("http://devgeekfileshost.altervista.org/stable.txt")
            If Label13.Text = nuovaversione Then
                Label13.ForeColor = Color.DodgerBlue
            Else
                Label13.ForeColor = Color.OrangeRed
            End If
            If nuovaversione.Contains("3.0") = False Then
                MsgBox("Gentile beta tester, è disponibile una nuova versione da essere testata. Visita il sito http://www.meandiabetes.com/downloads/ per scaricarla", MsgBoxStyle.Information, "Info aggiornamenti")
            End If
        Catch ex As Exception
            MsgBox("Impossibile controllare la disponibilità di aggiornamenti", MsgBoxStyle.Critical, "Errore")
        End Try
        Try
            Dim richiesta As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://devgeekfileshost.altervista.org/Note.txt")
            Dim response As System.Net.HttpWebResponse = richiesta.GetResponse
            Dim leggi As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream)
            Dim testo As String = leggi.ReadToEnd
            TextBox1.Text = testo.ToString
        Catch ex As Exception
            MsgBox("Impossibile scaricare le ultime notizie! Connettiti ad una rete WiFi o ad un cavo Lan e riprova", MsgBoxStyle.Critical, "Errore di rete")
        End Try

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If My.Settings.lastglic = 0 Then
            Label3.Text = "Nessuna glicemia registrata"
            Label10.Visible = False
        Else
            Label10.Text = My.Settings.lastglic & " mg/dl"
            If My.Settings.lastglic > 170 Then
                Label10.ForeColor = Color.OrangeRed
            ElseIf My.Settings.lastglic < 60 Then
                Label10.ForeColor = Color.OrangeRed
            Else
                Label10.ForeColor = Color.DodgerBlue
            End If
        End If
    End Sub
    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        If My.Settings.nome = "" Then
            ButtonX5.Text = "Profilo"
        Else
            ButtonX5.Text = "Profilo " & My.Settings.nome
        End If
    End Sub

    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick
        If My.Settings.lastbolo = "" Then
            Label4.Text = "Nessun bolo registrato"
            Label7.Visible = False
        Else
            Label4.Text = "Ultimo bolo registrato:"
            Label7.Visible = True
            Label7.Text = My.Settings.lastbolo
        End If
    End Sub

    Private Sub ButtonX1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX1.Click
        Form3.Show()
    End Sub

    Private Sub ButtonX2_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX2.Click
        boluswizard.Show()
    End Sub

    Private Sub ButtonX3_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX3.Click
        altre_impostazioni.Show()
    End Sub

    Private Sub Timer5_Tick(sender As System.Object, e As System.EventArgs) Handles Timer5.Tick
        If My.Settings.UIS = 0 Then
            Label6.Text = "Nessuna sens. insulinica registrata"
            Label11.Visible = False
        Else
            Label6.Text = "Ultima sens. insulinica registrata:"
            Label11.Visible = True
            Label11.Text = My.Settings.UIS
            If My.Settings.UIS < 20 Then
                Label11.ForeColor = Color.OrangeRed
            Else
                Label11.ForeColor = Color.DodgerBlue
            End If
        End If
    End Sub

    Private Sub Timer4_Tick(sender As System.Object, e As System.EventArgs) Handles Timer4.Tick
        If My.Settings.rappuicho = 0 Then
            Label5.Text = "Nessun rapp. UI/Cho registrato"
            Label12.Visible = False
        Else
            Label5.Text = "Ultimo rapp. UI/Cho registrato:"
            Label12.Visible = True
            Label12.Text = My.Settings.rappuicho
            If My.Settings.rappuicho < 5 Then
                Label12.ForeColor = Color.OrangeRed
            Else
                Label12.ForeColor = Color.DodgerBlue
            End If
        End If
    End Sub

    Private Sub AutoBoloToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AutoBoloToolStripMenuItem.Click
        boluswizard.Show()
    End Sub

    Private Sub CalcolaconsigliatoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CalcolaconsigliatoToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub RappUIChoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RappUIChoToolStripMenuItem.Click
        addfact.Show()
    End Sub

    Private Sub SensInsulinicaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SensInsulinicaToolStripMenuItem.Click
        addfact2.Show()
    End Sub

    Private Sub ButtonX4_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX4.Click
        bolo_correttivo.Show()
    End Sub

    Private Sub ChangelogToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ChangelogToolStripMenuItem.Click
        changelog.Show()
    End Sub

    Private Sub InfoAppToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles InfoAppToolStripMenuItem.Click
        info.Show()
    End Sub

    Private Sub ButtonX5_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX5.Click
        profilo.Show()
    End Sub

    Private Sub SalvaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalvaToolStripMenuItem.Click
        My.Settings.Save()
        MsgBox("I dati sono stati salvati correttamente", MsgBoxStyle.Information, "Salvataggio completato")
    End Sub

    Private Sub SalvaEdEsciToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalvaEdEsciToolStripMenuItem.Click
        My.Settings.Save()
        MsgBox("I dati sono stati salvati correttamente", MsgBoxStyle.Information, "Arrivederci!")
        End
    End Sub

    Private Sub EsciToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EsciToolStripMenuItem.Click
        End
    End Sub

    Private Sub BoloCorrettivoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BoloCorrettivoToolStripMenuItem.Click
        bolo_correttivo.Show()
    End Sub

    Private Sub BugCrashToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BugCrashToolStripMenuItem.Click
        MsgBox("Per segnalare un  bug/crash scrivi all'indirizzo support@meandiabetes.com, per noi è molto importante!", MsgBoxStyle.Information, "Bug/Crush report")
    End Sub

    Private Sub InfoSviluppatoreToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles InfoSviluppatoreToolStripMenuItem.Click
        dev_info.Show()
    End Sub

    Private Sub Label13_Click(sender As System.Object, e As System.EventArgs) Handles Label13.Click

    End Sub
End Class
'Copyright (C) 2017-2018, Gabriele Lobello