Public Class FormConfigura

    Private Sub FormConfigura_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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
        Using f As New FormConfAditivos
            f.ShowDialog()
        End Using
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Using f As New FormConfCentrifuga

            f.ShowDialog()
        End Using
    End Sub

    Private Sub HhMomentaryButton1_Click(sender As Object, e As EventArgs) Handles HhMomentaryButton1.Click
        Using f As New FormConfVolquete
            f.ShowDialog()
        End Using
    End Sub

    Private Sub HhMomentaryButton2_Click(sender As Object, e As EventArgs) Handles HhMomentaryButton2.Click
        Using f As New FormConfUsuarios
            f.ShowDialog()
        End Using
    End Sub

    Private Sub HhMomentaryButton3_Click(sender As Object, e As EventArgs) Handles HhMomentaryButton3.Click
        Using f As New FormConfMaquina
            f.ShowDialog()
        End Using
    End Sub
End Class