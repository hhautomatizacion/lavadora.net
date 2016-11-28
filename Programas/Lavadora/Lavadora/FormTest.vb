Public Class FormTest

    Private Sub FormTest_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        mMasterk.EstablecerBoolean("MX00", False)
    End Sub

    Private Sub FormTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        mMasterk.EstablecerBoolean("MX00", True)

        HhToggleButton1.Link = mMasterk
        HhToggleButton2.Link = mMasterk
        HhToggleButton3.Link = mMasterk
        HhToggleButton4.Link = mMasterk
        HhToggleButton5.Link = mMasterk
        HhToggleButton6.Link = mMasterk
        HhToggleButton7.Link = mMasterk
        HhToggleButton8.Link = mMasterk
        HhToggleButton9.Link = mMasterk
        HhToggleButton10.Link = mMasterk
        HhToggleButton11.Link = mMasterk
        HhToggleButton12.Link = mMasterk
        HhToggleButton13.Link = mMasterk
        HhToggleButton14.Link = mMasterk
        HhToggleButton15.Link = mMasterk
        HhToggleButton16.Link = mMasterk
        HhToggleButton17.Link = mMasterk
        HhToggleButton18.Link = mMasterk
        HhToggleButton19.Link = mMasterk
        HhToggleButton20.Link = mMasterk
        HhToggleButton21.Link = mMasterk
        HhToggleButton22.Link = mMasterk
        HhToggleButton23.Link = mMasterk
        HhToggleButton24.Link = mMasterk
        HhToggleButton25.Link = mMasterk
        HhToggleButton26.Link = mMasterk
        HhToggleButton27.Link = mMasterk
        HhToggleButton28.Link = mMasterk
        HhToggleButton29.Link = mMasterk
        HhToggleButton30.Link = mMasterk
        HhToggleButton31.Link = mMasterk

        HhToggleButton1.DireccionLectura = "PX05"
        HhToggleButton2.DireccionLectura = "PX06"
        HhToggleButton3.DireccionLectura = "PX07"
        HhToggleButton4.DireccionLectura = "PX08"
        HhToggleButton5.DireccionLectura = "PX09"
        HhToggleButton6.DireccionLectura = "PX0A"
        HhToggleButton7.DireccionLectura = "PX0B"
        HhToggleButton8.DireccionLectura = "PX0C"
        HhToggleButton9.DireccionLectura = "PX0D"
        HhToggleButton10.DireccionLectura = "PX04"
        HhToggleButton11.DireccionLectura = "PX00"
        HhToggleButton12.DireccionLectura = "PX0E"
        HhToggleButton13.DireccionLectura = "PX0F"
        HhToggleButton14.DireccionLectura = "PX10"
        HhToggleButton15.DireccionLectura = "PX11"
        HhToggleButton16.DireccionLectura = "PX12"
        HhToggleButton17.DireccionLectura = "PX13"
        HhToggleButton18.DireccionLectura = "PX40"
        HhToggleButton19.DireccionLectura = "PX41"
        HhToggleButton20.DireccionLectura = "PX42"
        HhToggleButton21.DireccionLectura = "PX43"
        HhToggleButton22.DireccionLectura = "PX44"
        HhToggleButton23.DireccionLectura = "PX45"
        HhToggleButton24.DireccionLectura = "PX46"
        HhToggleButton25.DireccionLectura = "PX47"
        HhToggleButton26.DireccionLectura = "PX48"
        HhToggleButton27.DireccionLectura = "PX49"
        HhToggleButton28.DireccionLectura = "PX4A"
        HhToggleButton29.DireccionLectura = "PX4B"
        HhToggleButton30.DireccionLectura = "PX4C"
        HhToggleButton31.DireccionLectura = "PX4D"

        HhToggleButton1.DireccionEscritura = "PX05"
        HhToggleButton2.DireccionEscritura = "PX06"
        HhToggleButton3.DireccionEscritura = "PX07"
        HhToggleButton4.DireccionEscritura = "PX08"
        HhToggleButton5.DireccionEscritura = "PX09"
        HhToggleButton6.DireccionEscritura = "PX0A"
        HhToggleButton7.DireccionEscritura = "PX0B"
        HhToggleButton8.DireccionEscritura = "PX0C"
        HhToggleButton9.DireccionEscritura = "PX0D"
        HhToggleButton10.DireccionEscritura = "PX04"
        HhToggleButton11.DireccionEscritura = "PX00"
        HhToggleButton12.DireccionEscritura = "PX0E"
        HhToggleButton13.DireccionEscritura = "PX0F"
        HhToggleButton14.DireccionEscritura = "PX10"
        HhToggleButton15.DireccionEscritura = "PX11"
        HhToggleButton16.DireccionEscritura = "PX12"
        HhToggleButton17.DireccionEscritura = "PX13"
        HhToggleButton18.DireccionEscritura = "MX140"
        HhToggleButton19.DireccionEscritura = "MX141"
        HhToggleButton20.DireccionEscritura = "MX142"
        HhToggleButton21.DireccionEscritura = "MX143"
        HhToggleButton22.DireccionEscritura = "MX144"
        HhToggleButton23.DireccionEscritura = "MX145"
        HhToggleButton24.DireccionEscritura = "MX146"
        HhToggleButton25.DireccionEscritura = "MX147"
        HhToggleButton26.DireccionEscritura = "MX148"
        HhToggleButton27.DireccionEscritura = "MX149"
        HhToggleButton28.DireccionEscritura = "MX14A"
        HhToggleButton29.DireccionEscritura = "MX14B"
        HhToggleButton30.DireccionEscritura = "MX14C"
        HhToggleButton31.DireccionEscritura = "MX14D"

        HhToggleButton1.Tooltip = "Paro emergencia|P05 - 101 (NC)"
        HhToggleButton2.Tooltip = "Start|P06 - 102"
        HhToggleButton3.Tooltip = "Termico motor|P07 - 104 (NC)"
        HhToggleButton4.Tooltip = "Alarma variador|P08 - 105 (NC)"
        HhToggleButton5.Tooltip = "Velocidad minima|P09 - 106"
        HhToggleButton6.Tooltip = "Puerta abierta|P0A - 107"
        HhToggleButton7.Tooltip = "Puerta cerrada|P0B - 108"
        HhToggleButton8.Tooltip = "Sonda nivel medio|P0C - 202"
        HhToggleButton9.Tooltip = "Sonda nivel bajo|P0D - 203"
        HhToggleButton10.Tooltip = "Sensor cesto|P04 - 204"
        HhToggleButton11.Tooltip = "Cuentalitros|P00 - 205"
        HhToggleButton12.Tooltip = "Maquina arriba|P0E - 206"
        HhToggleButton13.Tooltip = "Maquina horizontal|P0F - 207"
        HhToggleButton14.Tooltip = "Maquina abajo|P10 - 208"
        HhToggleButton15.Tooltip = "Introducir quimicos|P11 - 303"
        HhToggleButton16.Tooltip = "Enjuague quimicos|P12 - 304"
        HhToggleButton17.Tooltip = "Sonda nivel quimicos|P13 - 307"
        HhToggleButton18.Tooltip = "Start|P40 - 1001"
        HhToggleButton19.Tooltip = "Desague|P41 - 1003"
        HhToggleButton20.Tooltip = "Agua fria|P42 - 1004"
        HhToggleButton21.Tooltip = "Agua caliente|P43 - 1005"
        HhToggleButton22.Tooltip = "Agua tratada|P44"
        HhToggleButton23.Tooltip = "Vapor|P45 - 1007"
        HhToggleButton24.Tooltip = "Abrir puerta|P46 - 1008"
        HhToggleButton25.Tooltip = "Cerrar puerta|P47 - 2001"
        HhToggleButton26.Tooltip = "Seguros puerta|P48 - 2002"
        HhToggleButton27.Tooltip = "Bajar maquina|P49 - 2006"
        HhToggleButton28.Tooltip = "Bomba cubeta|P4A - 3001"
        HhToggleButton29.Tooltip = "Enjuague cubeta|P4B - 3002"
        HhToggleButton30.Tooltip = "Unidad hidraulica|P4C - 3005"
        HhToggleButton31.Tooltip = "Torreta|P4D - 3006"

        HhToggleButton1.Etiqueta = "Emergencia OK"
        HhToggleButton2.Etiqueta = "Start"
        HhToggleButton3.Etiqueta = "Termico OK"
        HhToggleButton4.Etiqueta = "Variador OK"
        HhToggleButton5.Etiqueta = "Velocidad minima"
        HhToggleButton6.Etiqueta = "Puerta abierta"
        HhToggleButton7.Etiqueta = "Puerta cerrada"
        HhToggleButton8.Etiqueta = "Sonda medio"
        HhToggleButton9.Etiqueta = "Sonda bajo"
        HhToggleButton10.Etiqueta = "Sensor cesto"
        HhToggleButton11.Etiqueta = "Cuentalitros"
        HhToggleButton12.Etiqueta = "Maq. arriba"
        HhToggleButton13.Etiqueta = "Maq. horizontal"
        HhToggleButton14.Etiqueta = "Maq. abajo"
        HhToggleButton15.Etiqueta = "Intro quimicos"
        HhToggleButton16.Etiqueta = "Enjuague quim."
        HhToggleButton17.Etiqueta = "Sonda quimicos"

        HhToggleButton18.Etiqueta = "Start"
        HhToggleButton19.Etiqueta = "Desague"
        HhToggleButton20.Etiqueta = "Agua fria"
        HhToggleButton21.Etiqueta = "Agua caliente"
        HhToggleButton22.Etiqueta = "Agua tratada"
        HhToggleButton23.Etiqueta = "Vapor"
        HhToggleButton24.Etiqueta = "Abrir puerta"
        HhToggleButton25.Etiqueta = "Cerrar puerta"
        HhToggleButton26.Etiqueta = "Libera seguros"
        HhToggleButton27.Etiqueta = "Bajar maquina"
        HhToggleButton28.Etiqueta = "Bomba quimicos"
        HhToggleButton29.Etiqueta = "Enjuague quim."
        HhToggleButton30.Etiqueta = "Volquete"
        HhToggleButton31.Etiqueta = "Torreta"


        HhToggleButton1.AutoActualizar = True
        HhToggleButton2.AutoActualizar = True
        HhToggleButton3.AutoActualizar = True
        HhToggleButton4.AutoActualizar = True
        HhToggleButton5.AutoActualizar = True
        HhToggleButton6.AutoActualizar = True
        HhToggleButton7.AutoActualizar = True
        HhToggleButton8.AutoActualizar = True
        HhToggleButton9.AutoActualizar = True
        HhToggleButton10.AutoActualizar = True
        HhToggleButton11.AutoActualizar = True
        HhToggleButton12.AutoActualizar = True
        HhToggleButton13.AutoActualizar = True
        HhToggleButton14.AutoActualizar = True
        HhToggleButton15.AutoActualizar = True
        HhToggleButton16.AutoActualizar = True
        HhToggleButton17.AutoActualizar = True
        HhToggleButton18.AutoActualizar = True
        HhToggleButton19.AutoActualizar = True
        HhToggleButton20.AutoActualizar = True
        HhToggleButton21.AutoActualizar = True
        HhToggleButton22.AutoActualizar = True
        HhToggleButton23.AutoActualizar = True
        HhToggleButton24.AutoActualizar = True
        HhToggleButton25.AutoActualizar = True
        HhToggleButton26.AutoActualizar = True
        HhToggleButton27.AutoActualizar = True
        HhToggleButton28.AutoActualizar = True
        HhToggleButton29.AutoActualizar = True
        HhToggleButton30.AutoActualizar = True
        HhToggleButton31.AutoActualizar = True

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        UnAttach(Me)
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Using f As New FormTestMotor
            CambiarLetra(f)
            f.ShowDialog()
        End Using

    End Sub
End Class