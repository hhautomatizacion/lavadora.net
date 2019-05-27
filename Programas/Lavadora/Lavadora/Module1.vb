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
    Structure LUID
        Dim UsedPart As Integer
        Dim IgnoredForNowHigh32BitPart As Integer
    End Structure

    Structure TOKEN_PRIVILEGES
        Dim PrivilegeCount As Integer
        Dim TheLuid As LUID
        Dim Attributes As Integer
    End Structure

    'The API functions below are all used to give the application the proper privilege so the OS will allow the app to Shutdown Windows.
    Declare Function OpenProcessToken Lib "advapi32" (ByVal ProcessHandle As IntPtr, ByVal DesiredAccess As Integer, ByRef TokenHandle As Integer) As Integer
    Declare Function LookupPrivilegeValue Lib "advapi32" Alias "LookupPrivilegeValueA" (ByVal lpSystemName As String, ByVal lpName As String, ByRef lpLuid As LUID) As Integer
    Declare Function AdjustTokenPrivileges Lib "advapi32" (ByVal TokenHandle As Integer, ByVal DisableAllPrivileges As Boolean, ByRef NewState As TOKEN_PRIVILEGES, ByVal BufferLength As Integer, ByRef PreviousState As TOKEN_PRIVILEGES, ByRef ReturnLength As Integer) As Integer

    'This sub will do all of the work of setting up your apps process using the APIs posted above to get the proper privileges to shutdown the OS. I originally got this function from msdn and converted it from VB 6.0 to VB.Net and did a tweak here and there.
    Sub AdjustToken()
        Const TOKEN_ADJUST_PRIVILEGES As Int32 = &H20
        Const TOKEN_QUERY As Int32 = &H8
        Const SE_PRIVILEGE_ENABLED As Int32 = &H2
        Dim hdlProcessHandle As IntPtr
        Dim hdlTokenHandle As Int32
        Dim tmpLuid As LUID
        Dim tkp As TOKEN_PRIVILEGES
        Dim tkpNewButIgnored As TOKEN_PRIVILEGES
        Dim lBufferNeeded As Int32
        hdlProcessHandle = Process.GetCurrentProcess.Handle
        OpenProcessToken(hdlProcessHandle, (TOKEN_ADJUST_PRIVILEGES Or TOKEN_QUERY), hdlTokenHandle)
        'Get the LUID for shutdown privilege.
        LookupPrivilegeValue("", "SeShutdownPrivilege", tmpLuid)
        tkp.PrivilegeCount = 1 'One privilege to set
        tkp.TheLuid = tmpLuid
        tkp.Attributes = SE_PRIVILEGE_ENABLED
        'Enable the shutdown privilege in the access token of this process.
        Dim retval As Int32
        retval = AdjustTokenPrivileges(hdlTokenHandle, False, tkp, Len(tkpNewButIgnored), tkpNewButIgnored, lBufferNeeded)
        If (retval = 0) Then
            MessageBox.Show(System.Runtime.InteropServices.Marshal.GetLastWin32Error().ToString())
        End If
    End Sub

    'The function used to actually send the request to shutdown windows. Set the 'shutdownTypes' parameter to whether you want windows to "shutdown, reboot, logOff, ect..."
    Declare Function ExitWindowsEx Lib "user32" (ByVal shutdownType As Integer, ByVal dwReserved As Integer) As Integer

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
        sNombreFuente = GetSetting("hhControls", "Font", "FontName", "Verdana")
        iTamanioFuente = Val(GetSetting("hhControls", "Font", "FontSize", "14"))
        sNombreFuenteEtiquetas = GetSetting("hhControls", "Font", "LabelFontName", "Verdana")
        iTamanioFuenteEtiquetas = Val(GetSetting("hhControls", "Font", "LabelFontSize", "10"))
        sNombreFuenteBotones = GetSetting("hhControls", "Font", "ButtonFontName", "Verdana")
        iTamanioFuenteBotones = Val(GetSetting("hhControls", "Font", "ButtonFontSize", "8"))
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
        SaveSetting("hhControls", "Font", "FontName", sNombreFuente)
        SaveSetting("hhControls", "Font", "FontSize", iTamanioFuente.ToString)
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
                c = Nothing
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
