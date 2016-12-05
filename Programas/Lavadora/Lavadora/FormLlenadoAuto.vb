Public Class FormLlenadoAuto


    Private Sub HhMomentaryButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HhMomentaryButton1.Click

        UnAttach(Me)
        Me.Close()
    End Sub
    Private Sub FormLlenadoAuto_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub



    
   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        UnAttach(Me)
        Me.Close()
    End Sub

    Private Sub HhToggleButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HhToggleButton4.CheckedChanged

    End Sub

    Private Sub HhNumericEntry1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HhNumericEntry1.TextChanged

    End Sub
End Class