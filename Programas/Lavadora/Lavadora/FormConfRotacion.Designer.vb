<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConfRotacion
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
        Me.HhNumericEntry1 = New hhNumericEntry.hhNumericEntry
        Me.HhNumericEntry2 = New hhNumericEntry.hhNumericEntry
        Me.HhNumericEntry3 = New hhNumericEntry.hhNumericEntry
        Me.HhNumericEntry4 = New hhNumericEntry.hhNumericEntry
        Me.HhNumericEntry5 = New hhNumericEntry.hhNumericEntry
        Me.HhNumericEntry6 = New hhNumericEntry.hhNumericEntry
        Me.HhNumericEntry7 = New hhNumericEntry.hhNumericEntry
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(658, 463)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 100)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'HhNumericEntry1
        '
        Me.HhNumericEntry1.AutoActualizar = False
        Me.HhNumericEntry1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HhNumericEntry1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhNumericEntry1.DireccionEscritura = Nothing
        Me.HhNumericEntry1.DireccionLectura = Nothing
        Me.HhNumericEntry1.Etiqueta = "RPM a 60Hz"
        Me.HhNumericEntry1.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.HhNumericEntry1.Link = Nothing
        Me.HhNumericEntry1.Location = New System.Drawing.Point(281, 85)
        Me.HhNumericEntry1.Name = "HhNumericEntry1"
        Me.HhNumericEntry1.Size = New System.Drawing.Size(180, 40)
        Me.HhNumericEntry1.TabIndex = 4
        Me.HhNumericEntry1.Text = "0"
        Me.HhNumericEntry1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.HhNumericEntry1.Tooltip = Nothing
        Me.HhNumericEntry1.Unidades = Nothing
        Me.HhNumericEntry1.Valor = 0
        Me.HhNumericEntry1.ValorMaximo = 0
        Me.HhNumericEntry1.ValorMinimo = 0
        '
        'HhNumericEntry2
        '
        Me.HhNumericEntry2.AutoActualizar = False
        Me.HhNumericEntry2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HhNumericEntry2.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhNumericEntry2.DireccionEscritura = Nothing
        Me.HhNumericEntry2.DireccionLectura = Nothing
        Me.HhNumericEntry2.Etiqueta = "Frec. maxima"
        Me.HhNumericEntry2.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.HhNumericEntry2.Link = Nothing
        Me.HhNumericEntry2.Location = New System.Drawing.Point(281, 131)
        Me.HhNumericEntry2.Name = "HhNumericEntry2"
        Me.HhNumericEntry2.Size = New System.Drawing.Size(180, 40)
        Me.HhNumericEntry2.TabIndex = 6
        Me.HhNumericEntry2.Text = "0"
        Me.HhNumericEntry2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.HhNumericEntry2.Tooltip = Nothing
        Me.HhNumericEntry2.Unidades = Nothing
        Me.HhNumericEntry2.Valor = 0
        Me.HhNumericEntry2.ValorMaximo = 0
        Me.HhNumericEntry2.ValorMinimo = 0
        '
        'HhNumericEntry3
        '
        Me.HhNumericEntry3.AutoActualizar = False
        Me.HhNumericEntry3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HhNumericEntry3.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhNumericEntry3.DireccionEscritura = Nothing
        Me.HhNumericEntry3.DireccionLectura = Nothing
        Me.HhNumericEntry3.Etiqueta = "Vel. descarga"
        Me.HhNumericEntry3.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.HhNumericEntry3.Link = Nothing
        Me.HhNumericEntry3.Location = New System.Drawing.Point(281, 192)
        Me.HhNumericEntry3.Name = "HhNumericEntry3"
        Me.HhNumericEntry3.Size = New System.Drawing.Size(180, 40)
        Me.HhNumericEntry3.TabIndex = 8
        Me.HhNumericEntry3.Text = "0"
        Me.HhNumericEntry3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.HhNumericEntry3.Tooltip = Nothing
        Me.HhNumericEntry3.Unidades = Nothing
        Me.HhNumericEntry3.Valor = 0
        Me.HhNumericEntry3.ValorMaximo = 0
        Me.HhNumericEntry3.ValorMinimo = 0
        '
        'HhNumericEntry4
        '
        Me.HhNumericEntry4.AutoActualizar = False
        Me.HhNumericEntry4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HhNumericEntry4.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhNumericEntry4.DireccionEscritura = Nothing
        Me.HhNumericEntry4.DireccionLectura = Nothing
        Me.HhNumericEntry4.Etiqueta = "Tiempo descarga"
        Me.HhNumericEntry4.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.HhNumericEntry4.Link = Nothing
        Me.HhNumericEntry4.Location = New System.Drawing.Point(281, 238)
        Me.HhNumericEntry4.Name = "HhNumericEntry4"
        Me.HhNumericEntry4.Size = New System.Drawing.Size(180, 40)
        Me.HhNumericEntry4.TabIndex = 10
        Me.HhNumericEntry4.Text = "0"
        Me.HhNumericEntry4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.HhNumericEntry4.Tooltip = Nothing
        Me.HhNumericEntry4.Unidades = Nothing
        Me.HhNumericEntry4.Valor = 0
        Me.HhNumericEntry4.ValorMaximo = 0
        Me.HhNumericEntry4.ValorMinimo = 0
        '
        'HhNumericEntry5
        '
        Me.HhNumericEntry5.AutoActualizar = False
        Me.HhNumericEntry5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HhNumericEntry5.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhNumericEntry5.DireccionEscritura = Nothing
        Me.HhNumericEntry5.DireccionLectura = Nothing
        Me.HhNumericEntry5.Etiqueta = "Reg. frec. variador"
        Me.HhNumericEntry5.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.HhNumericEntry5.Link = Nothing
        Me.HhNumericEntry5.Location = New System.Drawing.Point(281, 39)
        Me.HhNumericEntry5.Name = "HhNumericEntry5"
        Me.HhNumericEntry5.Size = New System.Drawing.Size(180, 40)
        Me.HhNumericEntry5.TabIndex = 12
        Me.HhNumericEntry5.Text = "0"
        Me.HhNumericEntry5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.HhNumericEntry5.Tooltip = Nothing
        Me.HhNumericEntry5.Unidades = Nothing
        Me.HhNumericEntry5.Valor = 0
        Me.HhNumericEntry5.ValorMaximo = 0
        Me.HhNumericEntry5.ValorMinimo = 0
        '
        'HhNumericEntry6
        '
        Me.HhNumericEntry6.AutoActualizar = False
        Me.HhNumericEntry6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HhNumericEntry6.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhNumericEntry6.DireccionEscritura = Nothing
        Me.HhNumericEntry6.DireccionLectura = Nothing
        Me.HhNumericEntry6.Etiqueta = "Vel. despedrado"
        Me.HhNumericEntry6.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.HhNumericEntry6.Link = Nothing
        Me.HhNumericEntry6.Location = New System.Drawing.Point(281, 299)
        Me.HhNumericEntry6.Name = "HhNumericEntry6"
        Me.HhNumericEntry6.Size = New System.Drawing.Size(180, 40)
        Me.HhNumericEntry6.TabIndex = 14
        Me.HhNumericEntry6.Text = "0"
        Me.HhNumericEntry6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.HhNumericEntry6.Tooltip = Nothing
        Me.HhNumericEntry6.Unidades = Nothing
        Me.HhNumericEntry6.Valor = 0
        Me.HhNumericEntry6.ValorMaximo = 0
        Me.HhNumericEntry6.ValorMinimo = 0
        '
        'HhNumericEntry7
        '
        Me.HhNumericEntry7.AutoActualizar = False
        Me.HhNumericEntry7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HhNumericEntry7.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhNumericEntry7.DireccionEscritura = Nothing
        Me.HhNumericEntry7.DireccionLectura = Nothing
        Me.HhNumericEntry7.Etiqueta = "Acel. rotacion"
        Me.HhNumericEntry7.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.HhNumericEntry7.Link = Nothing
        Me.HhNumericEntry7.Location = New System.Drawing.Point(281, 360)
        Me.HhNumericEntry7.Name = "HhNumericEntry7"
        Me.HhNumericEntry7.Size = New System.Drawing.Size(180, 40)
        Me.HhNumericEntry7.TabIndex = 16
        Me.HhNumericEntry7.Text = "0"
        Me.HhNumericEntry7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.HhNumericEntry7.Tooltip = Nothing
        Me.HhNumericEntry7.Unidades = Nothing
        Me.HhNumericEntry7.Valor = 0
        Me.HhNumericEntry7.ValorMaximo = 0
        Me.HhNumericEntry7.ValorMinimo = 0
        '
        'FormConfRotacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 575)
        Me.Controls.Add(Me.HhNumericEntry7)
        Me.Controls.Add(Me.HhNumericEntry6)
        Me.Controls.Add(Me.HhNumericEntry5)
        Me.Controls.Add(Me.HhNumericEntry4)
        Me.Controls.Add(Me.HhNumericEntry3)
        Me.Controls.Add(Me.HhNumericEntry2)
        Me.Controls.Add(Me.HhNumericEntry1)
        Me.Controls.Add(Me.Button1)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormConfRotacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FormConfRotacion"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents HhNumericEntry1 As hhNumericEntry.hhNumericEntry
    Friend WithEvents HhNumericEntry2 As hhNumericEntry.hhNumericEntry
    Friend WithEvents HhNumericEntry3 As hhNumericEntry.hhNumericEntry
    Friend WithEvents HhNumericEntry4 As hhNumericEntry.hhNumericEntry
    Friend WithEvents HhNumericEntry5 As hhNumericEntry.hhNumericEntry
    Friend WithEvents HhNumericEntry6 As hhNumericEntry.hhNumericEntry
    Friend WithEvents HhNumericEntry7 As hhNumericEntry.hhNumericEntry
End Class
