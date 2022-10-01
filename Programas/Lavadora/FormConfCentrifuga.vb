Public Class FormConfCentrifuga
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UnAttach(Me)
        Me.Close()

    End Sub

    Private Sub FormConfCentrifuga_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HhNumericEntry1.Link = mMasterk
        HhNumericEntry1.DireccionLectura = "DW0750"
        HhNumericEntry1.DireccionEscritura = "DW0750"
        HhNumericEntry1.ValorMinimo = 1
        HhNumericEntry1.ValorMaximo = 30000
        HhNumericEntry1.AutoActualizar = True
        HhNumericEntry2.Link = mMasterk
        HhNumericEntry2.DireccionLectura = "DW0752"
        HhNumericEntry2.DireccionEscritura = "DW0752"
        HhNumericEntry2.ValorMinimo = 1
        HhNumericEntry2.ValorMaximo = 30000
        HhNumericEntry2.AutoActualizar = True
        HhNumericEntry3.Link = mMasterk
        HhNumericEntry3.DireccionLectura = "DW0754"
        HhNumericEntry3.DireccionEscritura = "DW0754"
        HhNumericEntry3.ValorMinimo = 1
        HhNumericEntry3.ValorMaximo = 30000
        HhNumericEntry3.AutoActualizar = True
        HhNumericEntry4.Link = mMasterk
        HhNumericEntry4.DireccionLectura = "DW0756"
        HhNumericEntry4.DireccionEscritura = "DW0756"
        HhNumericEntry4.ValorMinimo = 1
        HhNumericEntry4.ValorMaximo = 30000
        HhNumericEntry4.AutoActualizar = True
        HhNumericEntry5.Link = mMasterk
        HhNumericEntry5.DireccionLectura = "DW0770"
        HhNumericEntry5.DireccionEscritura = "DW0770"
        HhNumericEntry5.ValorMinimo = 1
        HhNumericEntry5.ValorMaximo = 30000
        HhNumericEntry5.AutoActualizar = True
        HhNumericEntry6.Link = mMasterk
        HhNumericEntry6.DireccionLectura = "DW0772"
        HhNumericEntry6.DireccionEscritura = "DW0772"
        HhNumericEntry6.ValorMinimo = 1
        HhNumericEntry6.ValorMaximo = 30000
        HhNumericEntry6.AutoActualizar = True
        HhNumericEntry7.Link = mMasterk
        HhNumericEntry7.DireccionLectura = "DW0774"
        HhNumericEntry7.DireccionEscritura = "DW0774"
        HhNumericEntry7.ValorMinimo = 1
        HhNumericEntry7.ValorMaximo = 30000
        HhNumericEntry7.AutoActualizar = True
        HhNumericEntry8.Link = mMasterk
        HhNumericEntry8.DireccionLectura = "DW0776"
        HhNumericEntry8.DireccionEscritura = "DW0776"
        HhNumericEntry8.ValorMinimo = 1
        HhNumericEntry8.ValorMaximo = 30000
        HhNumericEntry8.AutoActualizar = True

        HhNumericEntry9.Link = mMasterk
        HhNumericEntry9.DireccionLectura = "DW0760"
        HhNumericEntry9.DireccionEscritura = "DW0760"
        HhNumericEntry9.ValorMinimo = 1
        HhNumericEntry9.ValorMaximo = 30000
        HhNumericEntry9.AutoActualizar = True
        HhNumericEntry10.Link = mMasterk
        HhNumericEntry10.DireccionLectura = "DW0762"
        HhNumericEntry10.DireccionEscritura = "DW0762"
        HhNumericEntry10.ValorMinimo = 1
        HhNumericEntry10.ValorMaximo = 30000
        HhNumericEntry10.AutoActualizar = True
        HhNumericEntry11.Link = mMasterk
        HhNumericEntry11.DireccionLectura = "DW0764"
        HhNumericEntry11.DireccionEscritura = "DW0764"
        HhNumericEntry11.ValorMinimo = 1
        HhNumericEntry11.ValorMaximo = 30000
        HhNumericEntry11.AutoActualizar = True
        HhNumericEntry12.Link = mMasterk
        HhNumericEntry12.DireccionLectura = "DW0766"
        HhNumericEntry12.DireccionEscritura = "DW0766"
        HhNumericEntry12.ValorMinimo = 1
        HhNumericEntry12.ValorMaximo = 30000
        HhNumericEntry12.AutoActualizar = True
        HhNumericEntry13.Link = mMasterk
        HhNumericEntry13.DireccionLectura = "DW0780"
        HhNumericEntry13.DireccionEscritura = "DW0780"
        HhNumericEntry13.ValorMinimo = 1
        HhNumericEntry13.ValorMaximo = 30000
        HhNumericEntry13.AutoActualizar = True
        HhNumericEntry14.Link = mMasterk
        HhNumericEntry14.DireccionLectura = "DW0782"
        HhNumericEntry14.DireccionEscritura = "DW0782"
        HhNumericEntry14.ValorMinimo = 1
        HhNumericEntry14.ValorMaximo = 30000
        HhNumericEntry14.AutoActualizar = True
        HhNumericEntry15.Link = mMasterk
        HhNumericEntry15.DireccionLectura = "DW0784"
        HhNumericEntry15.DireccionEscritura = "DW0784"
        HhNumericEntry15.ValorMinimo = 1
        HhNumericEntry15.ValorMaximo = 30000
        HhNumericEntry15.AutoActualizar = True
        HhNumericEntry16.Link = mMasterk
        HhNumericEntry16.DireccionLectura = "DW0786"
        HhNumericEntry16.DireccionEscritura = "DW0786"
        HhNumericEntry16.ValorMinimo = 1
        HhNumericEntry16.ValorMaximo = 30000
        HhNumericEntry16.AutoActualizar = True



        Button1.Texto = "Aceptar"
    End Sub
End Class