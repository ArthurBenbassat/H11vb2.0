Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim lijn As String
        lijn = txtNederlands.Text.PadRight(20) & txtEngels.Text
        ListBox1.Items.Add(lijn)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim antwoord As DialogResult
        If ListBox1.SelectedIndex = -1 Then
            MessageBox.Show("Duid eerst iets aan")
        Else
            antwoord = MessageBox.Show("Bent u zeker dat u dit wilt verwijderen", "Denis", MessageBoxButtons.YesNo)
            If antwoord = DialogResult.Yes Then
                ListBox1.Items.Remove(ListBox1.SelectedItem)
            End If
        End If

    End Sub

    Private Sub NieuwToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NieuwToolStripMenuItem.Click
        ListBox1.Items.Clear()
        txtEngels.Text = ""
        txtNederlands.Text = ""
        txtNederlands.Focus()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim lijn As String

        With open
            .Filter = "tekstbestanden (*txt) | *.txt"
            .FileName = ""
            .InitialDirectory = "C:\Users\Arthur\Documents\bestanden"
            .Title = "openen"
        End With

        If open.ShowDialog = DialogResult.OK Then
            FileOpen(1, open.FileName, OpenMode.Input)
            Do While Not EOF(1)
                lijn = LineInput(1)
                ListBox1.Items.Add(lijn)
            Loop
            FileClose(1)
        End If

    End Sub

    Private Sub OpslaanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpslaanToolStripMenuItem.Click
        Dim teller As Integer

        If open.FileName = "" Then
            OpslaanAlsToolStripMenuItem_Click(sender, e)
        Else
            FileOpen(1, open.FileName, OpenMode.Output)
            For teller = 0 To ListBox1.Items.Count - 1
                PrintLine(1, ListBox1.Items(teller))
            Next
            FileClose(1)
        End If
    End Sub

    Private Sub OpslaanAlsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpslaanAlsToolStripMenuItem.Click
        Dim teller As Integer

        With save
            .Filter = "tekstbestanden (*txt) | *.txt"
            .FileName = ""
            .InitialDirectory = "C:\Users\Arthur\Documents\bestanden"
            .Title = "openen"
        End With

        If save.ShowDialog = DialogResult.OK Then
            FileOpen(1, open.FileName, OpenMode.Input)
            For teller = 0 To ListBox1.Items.Count - 1
                PrintLine(1, ListBox1.Items(teller))
            Next
            FileClose(1)
        Else
            MessageBox.Show("kIES EEN PAD")
        End If
    End Sub

    Private Sub OverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OverToolStripMenuItem.Click
        MessageBox.Show("Als u hulp nodig heeft, gelieve de zelfmoordlijn te bellen op het nummer: 1813")
    End Sub

End Class
