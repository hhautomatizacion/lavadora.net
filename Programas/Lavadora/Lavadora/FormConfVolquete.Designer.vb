<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConfVolquete
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormConfVolquete))
        Me.HhNumericEntry1 = New hhNumericEntry.hhNumericEntry()
        Me.HhNumericEntry2 = New hhNumericEntry.hhNumericEntry()
        Me.Button1 = New hhMomentaryButton.hhMomentaryButton()
        Me.HhToggleButton21 = New hhToggleButton.hhToggleButton()
        Me.SuspendLayout()
        '
        'HhNumericEntry1
        '
        Me.HhNumericEntry1.AutoActualizar = False
        Me.HhNumericEntry1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HhNumericEntry1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhNumericEntry1.Decimales = 0
        Me.HhNumericEntry1.DireccionEscritura = Nothing
        Me.HhNumericEntry1.DireccionLectura = Nothing
        Me.HhNumericEntry1.Etiqueta = "Dwelltime volquete"
        Me.HhNumericEntry1.Factor = 1.0!
        Me.HhNumericEntry1.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.HhNumericEntry1.Link = Nothing
        Me.HhNumericEntry1.Location = New System.Drawing.Point(220, 50)
        Me.HhNumericEntry1.Name = "HhNumericEntry1"
        Me.HhNumericEntry1.Size = New System.Drawing.Size(220, 40)
        Me.HhNumericEntry1.TabIndex = 6
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
        Me.HhNumericEntry2.Decimales = 0
        Me.HhNumericEntry2.DireccionEscritura = Nothing
        Me.HhNumericEntry2.DireccionLectura = Nothing
        Me.HhNumericEntry2.Etiqueta = "Max tiempo volquete"
        Me.HhNumericEntry2.Factor = 1.0!
        Me.HhNumericEntry2.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.HhNumericEntry2.Link = Nothing
        Me.HhNumericEntry2.Location = New System.Drawing.Point(220, 95)
        Me.HhNumericEntry2.Name = "HhNumericEntry2"
        Me.HhNumericEntry2.Size = New System.Drawing.Size(220, 40)
        Me.HhNumericEntry2.TabIndex = 8
        Me.HhNumericEntry2.Text = "0"
        Me.HhNumericEntry2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.HhNumericEntry2.Tooltip = Nothing
        Me.HhNumericEntry2.Unidades = Nothing
        Me.HhNumericEntry2.Valor = 0
        Me.HhNumericEntry2.ValorMaximo = 0
        Me.HhNumericEntry2.ValorMinimo = 0
        '
        'Button1
        '
        Me.Button1.Appearance = System.Windows.Forms.Appearance.Button
        Me.Button1.AutoActualizar = False
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Button1.DireccionEscritura = Nothing
        Me.Button1.DireccionLectura = Nothing
        Me.Button1.Etiqueta = Nothing
        Me.Button1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Link = Nothing
        Me.Button1.Location = New System.Drawing.Point(688, 473)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 90)
        Me.Button1.TabIndex = 9
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'HhToggleButton21
        '
        Me.HhToggleButton21.Appearance = System.Windows.Forms.Appearance.Button
        Me.HhToggleButton21.AutoActualizar = False
        Me.HhToggleButton21.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhToggleButton21.DireccionEscritura = Nothing
        Me.HhToggleButton21.DireccionLectura = Nothing
        Me.HhToggleButton21.Etiqueta = "Habilita volquete"
        Me.HhToggleButton21.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.HhToggleButton21.Link = Nothing
        Me.HhToggleButton21.Location = New System.Drawing.Point(220, 141)
        Me.HhToggleButton21.Name = "HhToggleButton21"
        Me.HhToggleButton21.Size = New System.Drawing.Size(64, 64)
        Me.HhToggleButton21.TabIndex = 60
        Me.HhToggleButton21.Tooltip = Nothing
        Me.HhToggleButton21.UseVisualStyleBackColor = True
        '
        'FormConfVolquete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 575)
        Me.Controls.Add(Me.HhToggleButton21)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.HhNumericEntry2)
        Me.Controls.Add(Me.HhNumericEntry1)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormConfVolquete"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FormConfVolquete"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HhNumericEntry1 As hhNumericEntry.hhNumericEntry
    Friend WithEvents HhNumericEntry2 As hhNumericEntry.hhNumericEntry
    Friend WithEvents Button1 As hhMomentaryButton.hhMomentaryButton
    Friend WithEvents HhToggleButton21 As hhToggleButton.hhToggleButton
End Class
