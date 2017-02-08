Module Module1
    Declare Function SetComputerName Lib "kernel32" Alias "SetComputerNameA" (ByVal lpComputerName As String) As Long
    Public cParametros As Collection
    Public sPuerto As New System.IO.Ports.SerialPort
    Public sNombreFuente As String
    Public iTamanioFuente As Integer
    Public sNombreFuenteBotones As String
    Public iTamanioFuenteBotones As Integer
    Public sNombreFuenteEtiquetas As String
    Public iTamanioFuenteEtiquetas As Integer
    Public sNombrePuerto As String
    Public sTerminal As String
    Public sVersion As String
    Public bDepuracion As Boolean
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
    Function Version() As String
        Dim sVer As String

        Try

            sVer = My.Application.Deployment.CurrentVersion.ToString
        Catch
            Try
                sVer = Application.ProductVersion
            Catch ex As Exception
                sVer = "Desconocido"
            End Try
        End Try
        Return sVer
    End Function
    Sub CargarOpciones()
        sTerminal = System.Net.Dns.GetHostName
        sNombrePuerto = GetSetting("Lavadora", "Principal", "Puerto", "COM1")
        sNombreFuente = GetSetting("hhControls", "Font", "Name", "Verdana")
        iTamanioFuente = Val(GetSetting("hhControls", "Font", "Size", "14"))
        sNombreFuenteBotones = GetSetting("hhControls", "Font", "ButtonFontName", "Verdana")
        iTamanioFuenteBotones = Val(GetSetting("hhControls", "Font", "ButtonFontSize", "10"))
        sNombreFuenteEtiquetas = GetSetting("hhControls", "Font", "LabelFontName", "Verdana")
        iTamanioFuenteEtiquetas = Val(GetSetting("hhControls", "Font", "LabelFontSize", "10"))
        bDepuracion = -Val(GetSetting("Lavadora", "Principal", "Depuracion", "0"))
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
        SaveSetting("hhControls", "Font", "Name", sNombreFuente)
        SaveSetting("hhControls", "Font", "Size", iTamanioFuente.ToString)
        SaveSetting("hhControls", "Font", "ButtonFontName", sNombreFuenteBotones)
        SaveSetting("hhControls", "Font", "ButtonFontSize", iTamanioFuenteBotones.ToString)
        SaveSetting("hhControls", "Font", "LabelFontName", sNombreFuenteEtiquetas)
        SaveSetting("hhControls", "Font", "LabelFontSize", iTamanioFuenteEtiquetas.ToString)
        SaveSetting("Lavadora", "Principal", "Depuracion", -bDepuracion)
        SaveSetting("Lavadora", "Principal", "PermitirSalir", -bPermitirSalir)
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
