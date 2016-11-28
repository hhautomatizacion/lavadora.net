<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConfCuentalitros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormConfCuentalitros))
        Me.Button1 = New System.Windows.Forms.Button
        Me.HhNumericEntry1 = New hhNumericEntry.hhNumericEntry
        Me.HhNumericEntry2 = New hhNumericEntry.hhNumericEntry
        Me.HhNumericEntry3 = New hhNumericEntry.hhNumericEntry
        Me.HhNumericDisplay1 = New hhNumericDisplay.hhNumericDisplay
        Me.HhNumericDisplay2 = New hhNumericDisplay.hhNumericDisplay
        Me.HhNumericEntry4 = New hhNumericEntry.hhNumericEntry
        Me.HhNumericEntry5 = New hhNumericEntry.hhNumericEntry
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(688, 473)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 90)
        Me.Button1.TabIndex = 3
        Me.Button1.UseVisualStyleBackColor = True
        '
        'HhNumericEntry1
        '
        Me.HhNumericEntry1.AutoActualizar = False
        Me.HhNumericEntry1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HhNumericEntry1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhNumericEntry1.DireccionEscritura = Nothing
        Me.HhNumericEntry1.DireccionLectura = Nothing
        Me.HhNumericEntry1.Etiqueta = "Offset de llenado"
        Me.HhNumericEntry1.Font = New System.Drawing.Font("Verdana", 20.0!)
        Me.HhNumericEntry1.Link = Nothing
        Me.HhNumericEntry1.Location = New System.Drawing.Point(247, 328)
        Me.HhNumericEntry1.Name = "HhNumericEntry1"
        Me.HhNumericEntry1.Size = New System.Drawing.Size(180, 40)
        Me.HhNumericEntry1.TabIndex = 5
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
        Me.HhNumericEntry2.Etiqueta = "Divisor"
        Me.HhNumericEntry2.Font = New System.Drawing.Font("Verdana", 20.0!)
        Me.HhNumericEntry2.Link = Nothing
        Me.HhNumericEntry2.Location = New System.Drawing.Point(247, 190)
        Me.HhNumericEntry2.Name = "HhNumericEntry2"
        Me.HhNumericEntry2.Size = New System.Drawing.Size(180, 40)
        Me.HhNumericEntry2.TabIndex = 7
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
        Me.HhNumericEntry3.Etiqueta = "Multiplo"
        Me.HhNumericEntry3.Font = New System.Drawing.Font("Verdana", 20.0!)
        Me.HhNumericEntry3.Link = Nothing
        Me.HhNumericEntry3.Location = New System.Drawing.Point(247, 236)
        Me.HhNumericEntry3.Name = "HhNumericEntry3"
        Me.HhNumericEntry3.Size = New System.Drawing.Size(180, 40)
        Me.HhNumericEntry3.TabIndex = 9
        Me.HhNumericEntry3.Text = "0"
        Me.HhNumericEntry3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.HhNumericEntry3.Tooltip = Nothing
        Me.HhNumericEntry3.Unidades = Nothing
        Me.HhNumericEntry3.Valor = 0
        Me.HhNumericEntry3.ValorMaximo = 0
        Me.HhNumericEntry3.ValorMinimo = 0
        '
        'HhNumericDisplay1
        '
        Me.HhNumericDisplay1.AutoActualizar = False
        Me.HhNumericDisplay1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HhNumericDisplay1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HhNumericDisplay1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhNumericDisplay1.DireccionLectura = Nothing
        Me.HhNumericDisplay1.Etiqueta = "Litros"
        Me.HhNumericDisplay1.Font = New System.Drawing.Font("Verdana", 20.0!)
        Me.HhNumericDisplay1.Link = Nothing
        Me.HhNumericDisplay1.Location = New System.Drawing.Point(247, 63)
        Me.HhNumericDisplay1.Name = "HhNumericDisplay1"
        Me.HhNumericDisplay1.Size = New System.Drawing.Size(180, 40)
        Me.HhNumericDisplay1.TabIndex = 11
        Me.HhNumericDisplay1.Text = "0"
        Me.HhNumericDisplay1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HhNumericDisplay1.Tooltip = Nothing
        Me.HhNumericDisplay1.Valor = 0
        Me.HhNumericDisplay1.ValorMaximo = 0
        Me.HhNumericDisplay1.ValorMinimo = 0
        '
        'HhNumericDisplay2
        '
        Me.HhNumericDisplay2.AutoActualizar = False
        Me.HhNumericDisplay2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HhNumericDisplay2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HhNumericDisplay2.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhNumericDisplay2.DireccionLectura = Nothing
        Me.HhNumericDisplay2.Etiqueta = "Pulsos"
        Me.HhNumericDisplay2.Font = New System.Drawing.Font("Verdana", 20.0!)
        Me.HhNumericDisplay2.Link = Nothing
        Me.HhNumericDisplay2.Location = New System.Drawing.Point(247, 114)
        Me.HhNumericDisplay2.Name = "HhNumericDisplay2"
        Me.HhNumericDisplay2.Size = New System.Drawing.Size(180, 40)
        Me.HhNumericDisplay2.TabIndex = 13
        Me.HhNumericDisplay2.Text = "0"
        Me.HhNumericDisplay2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HhNumericDisplay2.Tooltip = Nothing
        Me.HhNumericDisplay2.Valor = 0
        Me.HhNumericDisplay2.ValorMaximo = 0
        Me.HhNumericDisplay2.ValorMinimo = 0
        '
        'HhNumericEntry4
        '
        Me.HhNumericEntry4.AutoActualizar = False
        Me.HhNumericEntry4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HhNumericEntry4.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhNumericEntry4.DireccionEscritura = Nothing
        Me.HhNumericEntry4.DireccionLectura = Nothing
        Me.HhNumericEntry4.Etiqueta = "Sopleteo sondas"
        Me.HhNumericEntry4.Font = New System.Drawing.Font("Verdana", 20.0!)
        Me.HhNumericEntry4.Link = Nothing
        Me.HhNumericEntry4.Location = New System.Drawing.Point(247, 450)
        Me.HhNumericEntry4.Name = "HhNumericEntry4"
        Me.HhNumericEntry4.Size = New System.Drawing.Size(180, 40)
        Me.HhNumericEntry4.TabIndex = 20
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
        Me.HhNumericEntry5.Etiqueta = "Nivel min. calent."
        Me.HhNumericEntry5.Font = New System.Drawing.Font("Verdana", 20.0!)
        Me.HhNumericEntry5.Link = Nothing
        Me.HhNumericEntry5.Location = New System.Drawing.Point(247, 374)
        Me.HhNumericEntry5.Name = "HhNumericEntry5"
        Me.HhNumericEntry5.Size = New System.Drawing.Size(180, 40)
        Me.HhNumericEntry5.TabIndex = 28
        Me.HhNumericEntry5.Text = "0"
        Me.HhNumericEntry5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.HhNumericEntry5.Tooltip = Nothing
        Me.HhNumericEntry5.Unidades = Nothing
        Me.HhNumericEntry5.Valor = 0
        Me.HhNumericEntry5.ValorMaximo = 0
        Me.HhNumericEntry5.ValorMinimo = 0
        '
        'FormConfCuentalitros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 575)
        Me.Controls.Add(Me.HhNumericEntry5)
        Me.Controls.Add(Me.HhNumericEntry4)
        Me.Controls.Add(Me.HhNumericDisplay2)
        Me.Controls.Add(Me.HhNumericDisplay1)
        Me.Controls.Add(Me.HhNumericEntry3)
        Me.Controls.Add(Me.HhNumericEntry2)
        Me.Controls.Add(Me.HhNumericEntry1)
        Me.Controls.Add(Me.Button1)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormConfCuentalitros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FormConfCuentalitros"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents HhNumericEntry1 As hhNumericEntry.hhNumericEntry
    Friend WithEvents HhNumericEntry2 As hhNumericEntry.hhNumericEntry
    Friend WithEvents HhNumericEntry3 As hhNumericEntry.hhNumericEntry
    Friend WithEvents HhNumericDisplay1 As hhNumericDisplay.hhNumericDisplay
    Friend WithEvents HhNumericDisplay2 As hhNumericDisplay.hhNumericDisplay
    Friend WithEvents HhNumericEntry4 As hhNumericEntry.hhNumericEntry
    Friend WithEvents HhNumericEntry5 As hhNumericEntry.hhNumericEntry
End Class
