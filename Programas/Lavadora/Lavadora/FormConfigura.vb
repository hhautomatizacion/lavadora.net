Public Class FormConfigura

    Private Sub FormConfigura_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button2.Etiqueta = "Sistema"

        Button3.Etiqueta = "Rotacion"

        Button4.Etiqueta = "Llenado"

        Button5.Etiqueta = "Aditivos"

        Button6.Etiqueta = "Mandos"

        Button1.Etiqueta = "Aceptar"
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        UnAttach(Me)
        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Using f As New FormConfSistema
            f.ShowDialog()
        End Using
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Using f As New FormConfRotacion
            f.ShowDialog()
        End Using
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Using f As New FormConfCuentalitros
            f.ShowDialog()
        End Using
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Using f As New FormConfQuimicos
            f.ShowDialog()
        End Using
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Using f As New FormConfVolquete
            f.ShowDialog()
        End Using
    End Sub
End Class