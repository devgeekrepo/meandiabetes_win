Public Class profilo

    Private Sub profilo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.nome
        TextBox2.Text = My.Settings.cognome
        NumericUpDown1.Text = My.Settings.eta
        TextBox5.Text = My.Settings.rappuicho
        TextBox4.Text = My.Settings.UIS
        Me.Text = "Profilo " & My.Settings.nome
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Form3.Show()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Form3.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        addfact2.Show()
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        addfact.Show()
    End Sub

    Private Sub ButtonX1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX1.Click
        TextBox1.Text = My.Settings.nome
        TextBox2.Text = My.Settings.cognome
        NumericUpDown1.Text = My.Settings.eta
        TextBox5.Text = My.Settings.rappuicho
        TextBox4.Text = My.Settings.UIS
    End Sub

    Private Sub ButtonX2_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX2.Click
        My.Settings.nome = TextBox1.Text
        My.Settings.cognome = TextBox2.Text
        My.Settings.eta = NumericUpDown1.Text
    End Sub
End Class
'Copyright (C) 2017-2018, Gabriele Lobello.