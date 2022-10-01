Public Class FormLlenadoAuto


    Private Sub HhMomentaryButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HhMomentaryButton1.Click

        Me.Close()
    End Sub
    Private Sub FormLlenadoAuto_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        UnAttach(Me)
        Me.Dispose()
    End Sub

    Private Sub HhMomentaryButton2_Click(sender As Object, e As EventArgs) Handles HhMomentaryButton2.Click
        Me.Close()

    End Sub
End Class