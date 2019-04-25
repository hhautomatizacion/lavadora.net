
Public Class FormAutomatico
    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        UnAttach(Me)
        Me.Close()
    End Sub

    Private Sub FormAutomatico_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub FormAutomatico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mMasterk.EstablecerBoolean("MX0001", True)

        HhNumericDisplay1.Link = mMasterk
        HhNumericDisplay1.DireccionLectura = "DW0030"
        HhNumericDisplay1.Etiqueta = "Temperatura"
        HhNumericDisplay1.Tooltip = "Temperatura actual"
        HhNumericDisplay1.ValorMaximo = 80
        HhNumericDisplay1.ValorMinimo = 0
        HhNumericDisplay1.AutoActualizar = True

        HhNumericDisplay2.Link = mMasterk
        HhNumericDisplay2.DireccionLectura = "DW0560"
        HhNumericDisplay2.Etiqueta = "Set"
        HhNumericDisplay2.Tooltip = "Temperatura programada"
        HhNumericDisplay2.AutoActualizar = True

        HhNumericDisplay3.Link = mMasterk
        HhNumericDisplay3.DireccionLectura = "DW0508"
        HhNumericDisplay3.Etiqueta = "Volumen baño"
        HhNumericDisplay3.Tooltip = "Litros actual"
        HhNumericDisplay3.AutoActualizar = True

        HhNumericDisplay4.Link = mMasterk
        HhNumericDisplay4.DireccionLectura = "DW0512"
        HhNumericDisplay4.Etiqueta = "Set"
        HhNumericDisplay4.Tooltip = "Litros programados"
        HhNumericDisplay4.AutoActualizar = True

        HhNumericDisplay5.Link = mMasterk
        HhNumericDisplay5.DireccionLectura = "DW0514"
        HhNumericDisplay5.Etiqueta = "RPM"
        HhNumericDisplay5.Tooltip = "Velocidad actual"
        HhNumericDisplay5.AutoActualizar = True

        HhNumericDisplay6.Link = mMasterk
        HhNumericDisplay6.DireccionLectura = "DW0020"
        HhNumericDisplay6.Etiqueta = "Set"
        HhNumericDisplay6.Tooltip = "Velocidad programada"
        HhNumericDisplay6.AutoActualizar = True

        HhTimeCounterDisplay1.Link = mMasterk
        HhTimeCounterDisplay1.DireccionLectura = "DW0660"
        HhTimeCounterDisplay1.Etiqueta = "Tiempo paso"
        HhTimeCounterDisplay1.Tooltip = "Tiempo paso"
        HhTimeCounterDisplay1.AutoActualizar = True

        HhTimeCounterDisplay2.Link = mMasterk
        HhTimeCounterDisplay2.DireccionLectura = "DW0658"
        HhTimeCounterDisplay2.Etiqueta = "Duracion paso"
        HhTimeCounterDisplay2.Tooltip = "Duracion paso"
        HhTimeCounterDisplay2.AutoActualizar = True

        HhTimeCounterDisplay3.Link = mMasterk
        HhTimeCounterDisplay3.DireccionLectura = "DW0650"
        HhTimeCounterDisplay3.Etiqueta = "Tiempo rec."
        HhTimeCounterDisplay3.Tooltip = "Tiempo receta"
        HhTimeCounterDisplay3.AutoActualizar = True

        HhTimeCounterDisplay4.Etiqueta = "Duracion rec."
        HhTimeCounterDisplay4.Tooltip = "Duracion receta"
        HhTimeCounterDisplay4.AutoActualizar = False

        HhMomentaryButton1.Link = mMasterk
        HhMomentaryButton1.DireccionEscritura = "MX0B"
        HhMomentaryButton1.DireccionLectura = "MX0100"
        HhMomentaryButton1.Etiqueta = "Play"
        HhMomentaryButton1.AutoActualizar = True

        HhMomentaryButton2.Link = mMasterk
        HhMomentaryButton2.DireccionEscritura = "MX0243"
        HhMomentaryButton2.DireccionLectura = "MX0241"
        HhMomentaryButton2.Etiqueta = "Pause"
        HhMomentaryButton2.AutoActualizar = True

        HhMomentaryButton3.Link = mMasterk
        HhMomentaryButton3.DireccionEscritura = "MX0C"
        HhMomentaryButton3.Etiqueta = "Stop"

        HhMomentaryButton4.Link = mMasterk
        HhMomentaryButton4.DireccionEscritura = "MX0075"
        HhMomentaryButton4.Etiqueta = "Editar"

        Button1.Etiqueta = "Salir"
        Button3.Etiqueta = "Salta paso"
        Button4.Etiqueta = "Recetas"
        Button5.Etiqueta = "Mandos"

        HhGridDisplay1.Link = mMasterk
        HhGridDisplay1.DireccionLectura = "DW2000"
        HhGridDisplay1.DireccionPaso = "DW0600"
        HhGridDisplay1.LongitudPaso = 10
        HhGridDisplay1.LongitudTexto = 4
        HhGridDisplay1.MostrarSeleccion = True
        HhGridDisplay1.Inicializar()
        HhGridDisplay1.AutoActualizar = True
    End Sub
    Private Sub HhNumericDisplay6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HhNumericDisplay6.TextChanged
        HhNumericDisplay6.ValorMaximo = Val(HhNumericDisplay6.Text)
        HhNumericDisplay6.ValorMinimo = Val(HhNumericDisplay6.Text)
        HhNumericDisplay5.ValorMaximo = Val(HhNumericDisplay6.Text) + 1
        HhNumericDisplay5.ValorMinimo = Val(HhNumericDisplay6.Text) - 1
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Using f As New FormCambiaPaso
            f.ShowDialog()
        End Using
    End Sub
    Private Sub HhGridDisplay1_Inicializado(ByVal sender As Object, ByVal e As System.EventArgs) Handles HhGridDisplay1.Inicializado
        HhTimeCounterDisplay4.Valor = HhGridDisplay1.DuracionReceta
        HhTimeCounterDisplay3.ValorMaximo = HhTimeCounterDisplay4.Valor
    End Sub
    Private Sub HhTimeCounterDisplay2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HhTimeCounterDisplay2.TextChanged
        HhTimeCounterDisplay1.ValorMaximo = HhTimeCounterDisplay2.Valor
        HhTimeCounterDisplay2.ValorMaximo = HhTimeCounterDisplay2.Valor
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim bArchivoExiste As Boolean
        Dim cPasos As New Collection
        Dim bf As New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter

        HhDialogoArchivos1.Unidad = Environment.CurrentDirectory
        HhDialogoArchivos1.Extension = "*.REC"
        HhDialogoArchivos1.Longitud = 20
        HhDialogoArchivos1.ShowDialog()

        If Len(HhDialogoArchivos1.NombreCompleto) Then
            Try
                If My.Computer.FileSystem.FileExists(HhDialogoArchivos1.NombreCompleto) Then
                    bArchivoExiste = True
                End If
            Catch ex As Exception
                Exit Sub
            End Try
            If bArchivoExiste Then
                Dim fs As New System.IO.FileStream(HhDialogoArchivos1.NombreCompleto, IO.FileMode.Open)
                Try
                    cPasos = bf.Deserialize(fs)
                Catch ex As Exception
                Finally
                    HhGridDisplay1.Receta = cPasos
                End Try
                fs.Close()
            End If
        End If
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Using fForm As New FormMandos
            If mMasterk.ObtenerBoolean("MX0100") Then
                Using m As New hhMsgBox.hhMsgBox
                    m.Mensaje = "La maquina esta trabajando. Parar la maquina?"
                    m.Link = mMasterk
                    m.Tamanio = 50
                    m.Imagen = My.Resources.traffic_lights_green
                    m.TextoOk = ""
                    m.TextoCancel = ""
                    m.ImagenOk = My.Resources.control_stop_blue
                    m.ImagenCancel = My.Resources.cross
                    m.DireccionOk = "MX0C"
                    m.DireccionCancel = "MX0B"
                    m.ShowDialog()
                    If m.Resultado = Windows.Forms.DialogResult.OK Then
                        fForm.ShowDialog()
                    End If
                End Using
            Else
                fForm.ShowDialog()
            End If
        End Using
    End Sub

    Private Sub HhNumericDisplay4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HhNumericDisplay4.TextChanged
        Dim iValue As Integer
        iValue = Val(HhNumericDisplay4.Text)
        HhNumericDisplay4.ValorMaximo = iValue
        HhNumericDisplay4.ValorMinimo = iValue
        HhNumericDisplay3.ValorMaximo = iValue + 2
        HhNumericDisplay3.ValorMinimo = iValue - 2
    End Sub



    Private Sub HhNumericDisplay2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles HhNumericDisplay2.TextChanged
        Dim iValue As Integer
        iValue = Val(HhNumericDisplay2.Text)
        HhNumericDisplay2.ValorMaximo = iValue
        HhNumericDisplay2.ValorMinimo = iValue
        If iValue = 0 Then
            HhNumericDisplay1.ValorMaximo = 44
            HhNumericDisplay1.ValorMinimo = 5
        Else
            HhNumericDisplay1.ValorMaximo = iValue + 2
            HhNumericDisplay1.ValorMinimo = iValue - 2
        End If

    End Sub

    Private Sub HhMomentaryButton4_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles HhMomentaryButton4.MouseUp
        Using f As New FormEditorAuto
            Do
                Application.DoEvents()
            Loop Until mMasterk.ObtenerBoolean("MX0123") = False
            f.HhGridDisplay1.Receta = HhGridDisplay1.Receta
            f.ShowDialog()
        End Using
        HhGridDisplay1.AutoActualizar = False
        HhGridDisplay1.Inicializar()
        HhGridDisplay1.AutoActualizar = True
    End Sub

    Private Sub HhTimeCounterDisplay4_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles HhTimeCounterDisplay4.TextChanged
        HhTimeCounterDisplay4.ValorMaximo = HhTimeCounterDisplay4.Valor
    End Sub


End Class