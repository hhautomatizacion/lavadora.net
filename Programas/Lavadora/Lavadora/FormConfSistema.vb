Public Class FormConfSistema

   

    Private Sub FormConfSistema_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        For Each sPuertoSerie As String In My.Computer.Ports.SerialPortNames
            HhComboEntry1.Items.Add(sPuertoSerie)
        Next
        HhComboEntry1.LongitudTexto = 5
        HhComboEntry1.Text = sNombrePuerto


        Using fonts As New System.Drawing.Text.InstalledFontCollection

            For Each f As FontFamily In fonts.Families

                HhComboEntry2.Items.Add(f.Name)
            Next
        End Using
        HhComboEntry2.LongitudTexto = 255
        HhComboEntry2.Text = GetSetting("hhControls", "Font", "Name", "Verdana")

        Dim i As Integer
        For i = 2 To 60 Step 2
            HhComboEntry3.Items.Add(i.ToString)
        Next

        HhComboEntry3.LongitudTexto = 2
        HhComboEntry3.Text = GetSetting("hhControls", "Font", "Size", "14")



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        sNombrePuerto = HhComboEntry1.Text
        sNombreFuente = HhComboEntry2.Text
        iTamanioFuente = Val(HhComboEntry3.Text)

        If Len(sNombrePuerto) Then
            AbrirPuerto()
            If Len(sNombreFuente) Then
                If iTamanioFuente > 0 Then
                    GuardarOpciones()
                Else
                    MsgBox("Tamaño de letra no valido")
                End If
            Else
                MsgBox("Tipo de letra no valida")
            End If
        Else
            MsgBox("Puerto no valido")
        End If



        Me.Close()
    End Sub

    Private Sub HhComboEntry2_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles HhComboEntry2.Move
        HhComboEntry3.Top = HhComboEntry2.Top + HhComboEntry2.Height + 5
    End Sub



    Private Sub HhComboEntry2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles HhComboEntry2.TextChanged
        Try
            Label1.Font = New Font(HhComboEntry2.Text, Val(HhComboEntry3.Text))
            Label1.Text = HhComboEntry2.Text
        Catch ex As Exception

        End Try
    End Sub

    Private Sub HhComboEntry3_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles HhComboEntry3.Move
        Label1.Top = HhComboEntry3.Top + HhComboEntry3.Height + 5
    End Sub

    Private Sub HhComboEntry3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HhComboEntry3.SelectedIndexChanged

    End Sub

    Private Sub HhComboEntry3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles HhComboEntry3.TextChanged
        Try
            Label1.Font = New Font(HhComboEntry2.Text, Val(HhComboEntry3.Text))
            Label1.Text = HhComboEntry2.Text
        Catch ex As Exception

        End Try
    End Sub

    Private Sub HhComboEntry1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles HhComboEntry1.Resize
        HhComboEntry2.Top = HhComboEntry1.Top + HhComboEntry1.Height + 10
    End Sub

    Private Sub HhComboEntry1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HhComboEntry1.SelectedIndexChanged

    End Sub

    Private Sub HhComboEntry2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HhComboEntry2.SelectedIndexChanged

    End Sub
End Class