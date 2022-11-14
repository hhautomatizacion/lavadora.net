Public Class FormConfMaquina
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub FormConfMaquina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HhToggleButton1.Link = mMasterk
        HhToggleButton1.DireccionEscritura = "KX00"
        HhToggleButton1.DireccionLectura = "KX00"
        HhToggleButton1.AutoActualizar = True

        HhToggleButton2.Link = mMasterk
        HhToggleButton2.DireccionEscritura = "KX01"
        HhToggleButton2.DireccionLectura = "KX01"
        HhToggleButton2.AutoActualizar = True

        HhToggleButton3.Link = mMasterk
        HhToggleButton3.DireccionEscritura = "KX02"
        HhToggleButton3.DireccionLectura = "KX02"
        HhToggleButton3.AutoActualizar = True

        HhToggleButton4.Link = mMasterk
        HhToggleButton4.DireccionEscritura = "KX03"
        HhToggleButton4.DireccionLectura = "KX03"
        HhToggleButton4.AutoActualizar = True
    End Sub
End Class