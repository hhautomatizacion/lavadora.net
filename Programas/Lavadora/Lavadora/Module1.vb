Module Module1
    Declare Function SetComputerName Lib "kernel32" Alias "SetComputerNameA" (ByVal lpComputerName As String) As Long
    Public cParametros As Collection
    Public sPuerto As New System.IO.Ports.SerialPort
    Public sNombreFuente As String
    Public iTamanioFuente As Integer
    Public sNombrePuerto As String
    Public sTerminal As String
    Public sVersion As String
    Public bPermitirSalir As Boolean
    Public WithEvents mMasterk As MasterKlib.MasterK
    Public Function ChangeComputerName(ByVal sNewComputerName As String) As Boolean
        Return CBool(SetComputerName(sNewComputerName))
    End Function
    Public Sub ClearBit(ByRef MyByte, ByVal MyBit)
        Dim BitMask As Int16
        BitMask = 2 ^ (MyBit)
        MyByte = MyByte And Not BitMask
    End Sub
    Public Function ExamineBit(ByVal MyByte, ByVal MyBit) As Boolean
        Dim BitMask As Int16
        BitMask = 2 ^ (MyBit)
        ExamineBit = ((MyByte And BitMask) > 0)
    End Function
    Public Sub SetBit(ByRef MyByte, ByVal MyBit)
        Dim BitMask As Int16
        BitMask = 2 ^ (MyBit)
        MyByte = MyByte Or BitMask
    End Sub
    Public Sub ToggleBit(ByRef MyByte, ByVal MyBit)
        Dim BitMask As Int16
        BitMask = 2 ^ (MyBit)
        MyByte = MyByte Xor BitMask
    End Sub
    Sub CambiarLetra(ByVal f As Object)
        Dim c As Control
        For Each c In f.Controls
            If c.GetType Is GetType(Button) Then
                c.Cursor = Cursors.Cross
                c.Font = New Font(sNombreFuente, iTamanioFuente)
            End If
            If c.GetType Is GetType(TextBox) Then
                c.Cursor = Cursors.Cross
                c.Font = New Font(sNombreFuente, iTamanioFuente)
            End If
            If c.GetType Is GetType(TableLayoutPanel) Then
                c.Cursor = Cursors.Cross
                CambiarLetra(c)
            End If
            If c.GetType Is GetType(SplitterPanel) Then
                c.Cursor = Cursors.Cross
                CambiarLetra(c)
            End If
            If c.GetType Is GetType(SplitContainer) Then
                c.Cursor = Cursors.Cross
                CambiarLetra(c)
            End If
            If c.GetType Is GetType(GroupBox) Then
                c.Cursor = Cursors.Cross
                CambiarLetra(c)
            End If
        Next
    End Sub
    Function Version() As String
        Dim sVer As String
        'If (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed) Then
        Try
            With System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion
                sVer = .Major & "." & .Minor & "." & .Build
            End With
        Catch
            sVer = "Desconocido"
        End Try
        'Else
        'sVer = "Desconocido"
        'End If
        Return sVer
    End Function
    Sub CargarOpciones()
        sTerminal = System.Net.Dns.GetHostName
        sNombrePuerto = GetSetting("Lavadora", "Principal", "Puerto", "COM1")
        sNombreFuente = GetSetting("hhcontrols", "font", "name", "Verdana")
        iTamanioFuente = Val(GetSetting("hhcontrols", "font", "size", "14"))
        bPermitirSalir = -Val(GetSetting("Lavadora", "Principal", "PermitirSalir", "0"))
        sVersion = GetSetting("Lavadora", "Principal", "Version", "")
        If sVersion <> Version() Then
            sVersion = Version()
            GuardarOpciones()
        End If

    End Sub
    Sub GuardarOpciones()
        SaveSetting("Lavadora", "Principal", "Puerto", sNombrePuerto)
        SaveSetting("Lavadora", "Principal", "Version", sVersion)
        SaveSetting("hhcontrols", "font", "name", sNombreFuente)
        SaveSetting("hhcontrols", "font", "size", iTamanioFuente.ToString)
    End Sub
    Sub UnAttach(ByVal f As Form)
        Dim c As Object
        For Each c In f.Controls
            Try
                Application.DoEvents()
                c.autoactualizar = False
            Catch ex As Exception
            End Try
        Next
    End Sub
    Sub AbrirPuerto()
        If sPuerto.IsOpen Then
            sPuerto.Close()
        End If
        With sPuerto
            .PortName = sNombrePuerto
            .BaudRate = 57600
            .Parity = IO.Ports.Parity.None
            .DataBits = 8
            .StopBits = IO.Ports.StopBits.One
            .ReceivedBytesThreshold = 1
            .ReadTimeout = 40
        End With
        Try
            sPuerto.Open()
            sPuerto.DiscardInBuffer()
        Catch
            MsgBox("No se puede abrir el puerto " & sPuerto.PortName)
        End Try
    End Sub
    Private Sub mMasterk_Fail(ByVal sender As Object, ByVal e As MasterKlib.MyEventArgs) Handles mMasterk.Fail
        FormLavadora.HhAnimacion1.BackColor = Color.Red
    End Sub
    Private Sub mMasterk_RX(ByVal sender As Object, ByVal e As MasterKlib.MyEventArgs) Handles mMasterk.RX
        FormLavadora.HhAnimacion2.Animar()
    End Sub
    Private Sub mMasterk_Timeout(ByVal sender As Object, ByVal e As MasterKlib.MyEventArgs) Handles mMasterk.Timeout

        FormLavadora.HhAnimacion2.BackColor = Color.Red

    End Sub
    Private Sub mMasterk_TX(ByVal sender As Object, ByVal e As MasterKlib.MyEventArgs) Handles mMasterk.TX
        FormLavadora.HhAnimacion1.Animar()
    End Sub
End Module
