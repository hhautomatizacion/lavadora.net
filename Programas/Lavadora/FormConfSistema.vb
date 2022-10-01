Public Class FormConfSistema
    Private Sub FormConfSistema_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        HhToggleButton1.Etiqueta = "Auto-iniciar"
        If My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).GetValue(Application.ProductName, "") = "" Then
            HhToggleButton1.Checked = False
        Else
            HhToggleButton1.Checked = True
        End If
        HhToggleButton2.Etiqueta = "PermiteSalir"
        HhToggleButton2.Checked = bPermitirSalir
        HhToggleButton3.Etiqueta = "Depuracion"
        HhToggleButton3.Checked = bDepuracion

        For Each sPuertoSerie As String In My.Computer.Ports.SerialPortNames
            HhComboEntry1.Items.Add(sPuertoSerie)
        Next
        HhComboEntry1.LongitudTexto = 5
        HhComboEntry1.Text = sNombrePuerto


        Using fonts As New System.Drawing.Text.InstalledFontCollection
            For Each f As FontFamily In fonts.Families
                HhComboEntry2.Items.Add(f.Name)
                HhComboEntry4.Items.Add(f.Name)
                HhComboEntry6.Items.Add(f.Name)
            Next
        End Using
        HhComboEntry2.LongitudTexto = 255
        HhComboEntry2.Text = GetSetting("hhControls", "Font", "FontName", "Verdana")
        HhComboEntry4.LongitudTexto = 255
        HhComboEntry4.Text = GetSetting("hhControls", "Font", "LabelFontName", "Verdana")
        HhComboEntry6.LongitudTexto = 255
        HhComboEntry6.Text = GetSetting("hhControls", "Font", "ButtonFontName", "Verdana")

        Dim i As Integer
        For i = 2 To 60 Step 2
            HhComboEntry3.Items.Add(i.ToString)
            HhComboEntry5.Items.Add(i.ToString)
            HhComboEntry7.Items.Add(i.ToString)
        Next

        TabControl1.Font = New Font(sNombreFuente, iTamanioFuente)

        HhComboEntry3.LongitudTexto = 2
        HhComboEntry3.Text = GetSetting("hhControls", "Font", "FontSize", "18")
        HhComboEntry5.LongitudTexto = 2
        HhComboEntry5.Text = GetSetting("hhControls", "Font", "LabelFontSize", "14")
        HhComboEntry7.LongitudTexto = 2
        HhComboEntry7.Text = GetSetting("hhControls", "Font", "ButtonFontSize", "10")

        Button1.Texto = "Aceptar"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        sNombrePuerto = HhComboEntry1.Text
        sNombreFuente = HhComboEntry2.Text
        iTamanioFuente = Val(HhComboEntry3.Text)
        sNombreFuenteEtiquetas = HhComboEntry4.Text
        iTamanioFuenteEtiquetas = Val(HhComboEntry5.Text)
        sNombreFuenteBotones = HhComboEntry6.Text
        iTamanioFuenteBotones = Val(HhComboEntry7.Text)

        If Len(sNombrePuerto) Then
            AbrirPuerto()

        Else
            MsgBox("Puerto no valido")
        End If
        If Len(sNombreFuente) And Len(sNombreFuenteBotones) And Len(sNombreFuenteEtiquetas) Then
            If iTamanioFuente > 0 And iTamanioFuenteBotones > 0 And iTamanioFuenteEtiquetas > 0 Then
                GuardarOpciones()
            Else
                MsgBox("Tamaño de letra no valido")
            End If
        Else
            MsgBox("Tipo de letra no valida")
        End If


        Me.Close()
    End Sub

    Private Sub HhComboEntry6_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles HhComboEntry6.TextChanged
        Try
            Label3.Font = New Font(HhComboEntry6.Text, Val(HhComboEntry7.Text))
            Label3.Text = HhComboEntry6.Text
        Catch ex As Exception

        End Try
    End Sub
    Private Sub HhComboEntry7_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles HhComboEntry7.TextChanged
        Try
            Label3.Font = New Font(HhComboEntry6.Text, Val(HhComboEntry7.Text))
            Label3.Text = HhComboEntry6.Text
        Catch ex As Exception

        End Try
    End Sub
    Private Sub HhComboEntry4_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles HhComboEntry4.TextChanged
        Try
            Label2.Font = New Font(HhComboEntry4.Text, Val(HhComboEntry5.Text))
            Label2.Text = HhComboEntry4.Text
        Catch ex As Exception

        End Try
    End Sub
    Private Sub HhComboEntry5_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles HhComboEntry5.TextChanged
        Try
            Label2.Font = New Font(HhComboEntry4.Text, Val(HhComboEntry5.Text))
            Label2.Text = HhComboEntry4.Text
        Catch ex As Exception

        End Try
    End Sub
    Private Sub HhComboEntry2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles HhComboEntry2.TextChanged
        Try
            Label1.Font = New Font(HhComboEntry2.Text, Val(HhComboEntry3.Text))
            Label1.Text = HhComboEntry2.Text
        Catch ex As Exception

        End Try
    End Sub


    Private Sub HhComboEntry3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles HhComboEntry3.TextChanged
        Try
            Label1.Font = New Font(HhComboEntry2.Text, Val(HhComboEntry3.Text))
            Label1.Text = HhComboEntry2.Text
        Catch ex As Exception

        End Try
    End Sub
    Private Sub HhToggleButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles HhToggleButton1.Click
        If HhToggleButton1.Checked Then
            My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue(Application.ProductName, Application.ExecutablePath)
        Else
            My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue(Application.ProductName)
        End If
    End Sub
    Private Sub HhToggleButton3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles HhToggleButton3.Click
        bDepuracion = HhToggleButton3.Checked
    End Sub
    Private Sub HhToggleButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles HhToggleButton2.Click
        bPermitirSalir = HhToggleButton2.Checked
    End Sub

End Class