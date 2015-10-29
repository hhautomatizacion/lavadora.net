<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTestMotor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button
        Me.HhToggleButton1 = New hhToggleButton.hhToggleButton
        Me.HhToggleButton2 = New hhToggleButton.hhToggleButton
        Me.HhNumericEntry1 = New hhNumericEntry.hhNumericEntry
        Me.HhNumericDisplay1 = New hhNumericDisplay.hhNumericDisplay
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(620, 463)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 100)
        Me.Button1.TabIndex = 63
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'HhToggleButton1
        '
        Me.HhToggleButton1.Appearance = System.Windows.Forms.Appearance.Button
        Me.HhToggleButton1.AutoActualizar = False
        Me.HhToggleButton1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhToggleButton1.DireccionEscritura = Nothing
        Me.HhToggleButton1.DireccionLectura = Nothing
        Me.HhToggleButton1.Etiqueta = "Izquierda"
        Me.HhToggleButton1.Font = New System.Drawing.Font("Papyrus", 14.0!)
        Me.HhToggleButton1.Link = Nothing
        Me.HhToggleButton1.Location = New System.Drawing.Point(244, 31)
        Me.HhToggleButton1.Name = "HhToggleButton1"
        Me.HhToggleButton1.Size = New System.Drawing.Size(45, 45)
        Me.HhToggleButton1.TabIndex = 65
        Me.HhToggleButton1.Tooltip = Nothing
        Me.HhToggleButton1.UseVisualStyleBackColor = True
        '
        'HhToggleButton2
        '
        Me.HhToggleButton2.Appearance = System.Windows.Forms.Appearance.Button
        Me.HhToggleButton2.AutoActualizar = False
        Me.HhToggleButton2.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhToggleButton2.DireccionEscritura = Nothing
        Me.HhToggleButton2.DireccionLectura = Nothing
        Me.HhToggleButton2.Etiqueta = "Derecha"
        Me.HhToggleButton2.Font = New System.Drawing.Font("Papyrus", 14.0!)
        Me.HhToggleButton2.Link = Nothing
        Me.HhToggleButton2.Location = New System.Drawing.Point(244, 82)
        Me.HhToggleButton2.Name = "HhToggleButton2"
        Me.HhToggleButton2.Size = New System.Drawing.Size(45, 45)
        Me.HhToggleButton2.TabIndex = 67
        Me.HhToggleButton2.Tooltip = Nothing
        Me.HhToggleButton2.UseVisualStyleBackColor = True
        '
        'HhNumericEntry1
        '
        Me.HhNumericEntry1.AutoActualizar = False
        Me.HhNumericEntry1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HhNumericEntry1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhNumericEntry1.DireccionEscritura = Nothing
        Me.HhNumericEntry1.DireccionLectura = Nothing
        Me.HhNumericEntry1.Etiqueta = "Frecuencia"
        Me.HhNumericEntry1.Font = New System.Drawing.Font("Papyrus", 14.0!)
        Me.HhNumericEntry1.Link = Nothing
        Me.HhNumericEntry1.Location = New System.Drawing.Point(244, 133)
        Me.HhNumericEntry1.Name = "HhNumericEntry1"
        Me.HhNumericEntry1.Size = New System.Drawing.Size(180, 40)
        Me.HhNumericEntry1.TabIndex = 69
        Me.HhNumericEntry1.Text = "0"
        Me.HhNumericEntry1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.HhNumericEntry1.Tooltip = Nothing
        Me.HhNumericEntry1.Unidades = Nothing
        Me.HhNumericEntry1.Valor = 0
        Me.HhNumericEntry1.ValorMaximo = 0
        Me.HhNumericEntry1.ValorMinimo = 0
        '
        'HhNumericDisplay1
        '
        Me.HhNumericDisplay1.AutoActualizar = False
        Me.HhNumericDisplay1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HhNumericDisplay1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HhNumericDisplay1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhNumericDisplay1.DireccionLectura = Nothing
        Me.HhNumericDisplay1.Etiqueta = "RPM"
        Me.HhNumericDisplay1.Font = New System.Drawing.Font("Papyrus", 14.0!)
        Me.HhNumericDisplay1.Link = Nothing
        Me.HhNumericDisplay1.Location = New System.Drawing.Point(640, 31)
        Me.HhNumericDisplay1.Name = "HhNumericDisplay1"
        Me.HhNumericDisplay1.Size = New System.Drawing.Size(130, 40)
        Me.HhNumericDisplay1.TabIndex = 71
        Me.HhNumericDisplay1.Text = "0"
        Me.HhNumericDisplay1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HhNumericDisplay1.Tooltip = Nothing
        Me.HhNumericDisplay1.Valor = 0
        Me.HhNumericDisplay1.ValorMaximo = 0
        Me.HhNumericDisplay1.ValorMinimo = 0
        '
        'FormTestMotor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 575)
        Me.Controls.Add(Me.HhNumericDisplay1)
        Me.Controls.Add(Me.HhNumericEntry1)
        Me.Controls.Add(Me.HhToggleButton2)
        Me.Controls.Add(Me.HhToggleButton1)
        Me.Controls.Add(Me.Button1)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormTestMotor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FormTestMotor"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents HhToggleButton1 As hhToggleButton.hhToggleButton
    Friend WithEvents HhToggleButton2 As hhToggleButton.hhToggleButton
    Friend WithEvents HhNumericEntry1 As hhNumericEntry.hhNumericEntry
    Friend WithEvents HhNumericDisplay1 As hhNumericDisplay.hhNumericDisplay
End Class
