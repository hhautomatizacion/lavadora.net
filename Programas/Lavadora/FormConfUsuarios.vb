Imports hhComboEntry
Imports hhNumericEntry

Public Class FormConfUsuarios
    Dim sPassword1 As String
    Dim sPassword2 As String
    Dim sPassword3 As String
    Dim sPermisos1 As String
    Dim sPermisos2 As String
    Dim sPermisos3 As String
    Dim sPermisos4 As String
    Private Sub FormConfUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        sPassword1 = GetSetting("Lavadora", "Permisos", "Password1")
        sPassword2 = GetSetting("Lavadora", "Permisos", "Password2")
        sPassword3 = GetSetting("Lavadora", "Permisos", "Password3")

        sPermisos1 = Val(GetSetting("Lavadora", "Permisos", "NivelSaltaPaso")).ToString
        sPermisos2 = Val(GetSetting("Lavadora", "Permisos", "NivelEditarReceta")).ToString
        sPermisos3 = Val(GetSetting("Lavadora", "Permisos", "NivelConfigurar")).ToString
        sPermisos4 = Val(GetSetting("Lavadora", "Permisos", "NivelPruebas")).ToString
        HhNumericEntry1.Valor = Val(sPassword1)
        HhNumericEntry2.Valor = Val(sPassword2)
        HhNumericEntry3.Valor = Val(sPassword3)
        HhComboEntry1.Text = sPermisos1
        HhComboEntry2.Text = sPermisos2
        HhComboEntry3.Text = sPermisos3
        HhComboEntry4.Text = sPermisos4
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sPassword1 = HhNumericEntry1.Valor.ToString
        sPassword2 = HhNumericEntry2.Valor.ToString
        sPassword3 = HhNumericEntry3.Valor.ToString
        sPermisos1 = HhComboEntry1.Text
        sPermisos2 = HhComboEntry2.Text
        sPermisos3 = HhComboEntry3.Text
        sPermisos4 = HhComboEntry4.Text

        SaveSetting("Lavadora", "Permisos", "Password1", sPassword1)
        SaveSetting("Lavadora", "Permisos", "Password2", sPassword2)
        SaveSetting("Lavadora", "Permisos", "Password3", sPassword3)

        SaveSetting("Lavadora", "Permisos", "NivelSaltaPaso", sPermisos1)
        SaveSetting("Lavadora", "Permisos", "NivelEditarReceta", sPermisos2)
        SaveSetting("Lavadora", "Permisos", "NivelConfigurar", sPermisos3)
        SaveSetting("Lavadora", "Permisos", "NivelPruebas", sPermisos4)

        Me.Close()

    End Sub

End Class