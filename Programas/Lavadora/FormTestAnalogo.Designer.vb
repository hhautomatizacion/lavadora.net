<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTestAnalogo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTestAnalogo))
        Me.HhNumericDisplay1 = New hhNumericDisplay.hhNumericDisplay()
        Me.Button1 = New hhMomentaryButton.hhMomentaryButton()
        Me.HhLabel1 = New hhLabel.hhLabel()
        Me.SuspendLayout()
        '
        'HhNumericDisplay1
        '
        Me.HhNumericDisplay1.AutoActualizar = False
        Me.HhNumericDisplay1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HhNumericDisplay1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HhNumericDisplay1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhNumericDisplay1.DireccionLectura = Nothing
        Me.HhNumericDisplay1.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.HhNumericDisplay1.Link = Nothing
        Me.HhNumericDisplay1.Location = New System.Drawing.Point(248, 135)
        Me.HhNumericDisplay1.Name = "HhNumericDisplay1"
        Me.HhNumericDisplay1.Size = New System.Drawing.Size(200, 40)
        Me.HhNumericDisplay1.TabIndex = 73
        Me.HhNumericDisplay1.Text = "0"
        Me.HhNumericDisplay1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HhNumericDisplay1.Tooltip = Nothing
        Me.HhNumericDisplay1.Valor = 0
        Me.HhNumericDisplay1.ValorMaximo = 0
        Me.HhNumericDisplay1.ValorMinimo = 0
        '
        'Button1
        '
        Me.Button1.Appearance = System.Windows.Forms.Appearance.Button
        Me.Button1.AutoActualizar = False
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Button1.DireccionEscritura = Nothing
        Me.Button1.DireccionLectura = Nothing
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Link = Nothing
        Me.Button1.Location = New System.Drawing.Point(691, 474)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 90)
        Me.Button1.TabIndex = 74
        Me.Button1.Text = "Salir"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.Texto = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'HhLabel1
        '
        Me.HhLabel1.AutoActualizar = False
        Me.HhLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.HhLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HhLabel1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhLabel1.DireccionLectura = Nothing
        Me.HhLabel1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.HhLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HhLabel1.Link = Nothing
        Me.HhLabel1.Location = New System.Drawing.Point(55, 135)
        Me.HhLabel1.LongitudTexto = 0
        Me.HhLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.HhLabel1.Name = "HhLabel1"
        Me.HhLabel1.Size = New System.Drawing.Size(188, 40)
        Me.HhLabel1.TabIndex = 75
        Me.HhLabel1.Text = "ADC1"
        Me.HhLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HhLabel1.Texto = "ADC1"
        Me.HhLabel1.Tooltip = Nothing
        '
        'FormTestAnalogo
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(800, 575)
        Me.Controls.Add(Me.HhLabel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.HhNumericDisplay1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FormTestAnalogo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FormTestAnalogo"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HhNumericDisplay1 As hhNumericDisplay.hhNumericDisplay
    Friend WithEvents Button1 As hhMomentaryButton.hhMomentaryButton
    Friend WithEvents HhLabel1 As hhLabel.hhLabel
End Class
