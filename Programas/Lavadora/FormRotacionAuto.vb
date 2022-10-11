Public Class FormRotacionAuto

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        UnAttach(Me)
        Me.Close()
    End Sub

    Private Sub FormRotacionAuto_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
     
        Me.Dispose()
    End Sub

    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub



    Private Sub HhMomentaryButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HhMomentaryButton1.Click
        DialogResult = vbOK
        UnAttach(Me)
        Me.Close()
    End Sub
End Class