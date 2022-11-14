Public Class FormTemperaturaAuto
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        UnAttach(Me)
        Me.Close()
    End Sub

    Private Sub FormCalefaccionManual_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub HhMomentaryButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HhMomentaryButton1.Click
        DialogResult = vbOK
        Me.Close()
    End Sub

    Private Sub HhToggleButton2_Click(sender As Object, e As EventArgs) Handles HhToggleButton2.Click

    End Sub

    Private Sub HhToggleButton2_CheckedChanged(sender As Object, e As EventArgs) Handles HhToggleButton2.CheckedChanged
        HhNumericEntry2.Enabled = HhToggleButton2.Checked
    End Sub
End Class