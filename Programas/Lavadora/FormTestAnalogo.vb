Public Class FormTestAnalogo
    Private Sub FormTestAnalogo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HhNumericDisplay1.Link = mMasterk
        HhNumericDisplay1.DireccionLectura = "DW4980"
        HhNumericDisplay1.AutoActualizar = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class