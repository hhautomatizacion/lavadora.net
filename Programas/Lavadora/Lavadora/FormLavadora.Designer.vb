<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLavadora
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
        Me.components = New System.ComponentModel.Container
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.HhMsgBox1 = New hhMsgBox.hhMsgBox
        Me.HhAnimacion1 = New hhAnimacion.hhAnimacion
        Me.HhAnimacion2 = New hhAnimacion.hhAnimacion
        Me.Label1 = New System.Windows.Forms.Label
        Me.HhBooleanLabel1 = New hhBooleanLabel.hhBooleanLabel
        Me.HhBooleanLabel2 = New hhBooleanLabel.hhBooleanLabel
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.Label4 = New System.Windows.Forms.Label
        Me.HhCharacterDisplay2 = New hhCharacterDisplay.hhCharacterDisplay
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer
        Me.Label3 = New System.Windows.Forms.Label
        Me.HhCharacterDisplay1 = New hhCharacterDisplay.hhCharacterDisplay
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer
        Me.Label5 = New System.Windows.Forms.Label
        Me.HhCharacterDisplay3 = New hhCharacterDisplay.hhCharacterDisplay
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.AutoSize = False
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 575)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 25)
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Timer1
        '
        '
        'HhMsgBox1
        '
        Me.HhMsgBox1.DireccionCancel = Nothing
        Me.HhMsgBox1.DireccionOk = Nothing
        Me.HhMsgBox1.Link = Nothing
        Me.HhMsgBox1.Mensaje = Nothing
        Me.HhMsgBox1.Tamanio = 0
        Me.HhMsgBox1.TextoCancel = Nothing
        Me.HhMsgBox1.TextoOk = Nothing
        '
        'HhAnimacion1
        '
        Me.HhAnimacion1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HhAnimacion1.Color1 = System.Drawing.Color.Empty
        Me.HhAnimacion1.Color2 = System.Drawing.Color.Empty
        Me.HhAnimacion1.Intervalo = 0
        Me.HhAnimacion1.Location = New System.Drawing.Point(0, 0)
        Me.HhAnimacion1.Name = "HhAnimacion1"
        Me.HhAnimacion1.PasoActual = 0
        Me.HhAnimacion1.Pasos = 0
        Me.HhAnimacion1.Size = New System.Drawing.Size(16, 16)
        Me.HhAnimacion1.TabIndex = 0
        Me.HhAnimacion1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HhAnimacion2
        '
        Me.HhAnimacion2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HhAnimacion2.Color1 = System.Drawing.Color.Empty
        Me.HhAnimacion2.Color2 = System.Drawing.Color.Empty
        Me.HhAnimacion2.Intervalo = 0
        Me.HhAnimacion2.Location = New System.Drawing.Point(22, 0)
        Me.HhAnimacion2.Name = "HhAnimacion2"
        Me.HhAnimacion2.PasoActual = 0
        Me.HhAnimacion2.Pasos = 0
        Me.HhAnimacion2.Size = New System.Drawing.Size(16, 16)
        Me.HhAnimacion2.TabIndex = 9
        Me.HhAnimacion2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(205, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Reloj"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HhBooleanLabel1
        '
        Me.HhBooleanLabel1.AutoActualizar = False
        Me.HhBooleanLabel1.AutoSize = True
        Me.HhBooleanLabel1.ColorFondoFalso = System.Drawing.Color.Empty
        Me.HhBooleanLabel1.ColorFondoVerdadero = System.Drawing.Color.Empty
        Me.HhBooleanLabel1.ColorTextoFalso = System.Drawing.Color.Empty
        Me.HhBooleanLabel1.ColorTextoVerdadero = System.Drawing.Color.Empty
        Me.HhBooleanLabel1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhBooleanLabel1.DireccionLectura = Nothing
        Me.HhBooleanLabel1.Link = Nothing
        Me.HhBooleanLabel1.Location = New System.Drawing.Point(65, 116)
        Me.HhBooleanLabel1.Name = "HhBooleanLabel1"
        Me.HhBooleanLabel1.Size = New System.Drawing.Size(0, 13)
        Me.HhBooleanLabel1.TabIndex = 11
        Me.HhBooleanLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HhBooleanLabel1.TextoFalso = Nothing
        Me.HhBooleanLabel1.TextoVerdadero = Nothing
        Me.HhBooleanLabel1.Valor = False
        '
        'HhBooleanLabel2
        '
        Me.HhBooleanLabel2.AutoActualizar = False
        Me.HhBooleanLabel2.AutoSize = True
        Me.HhBooleanLabel2.ColorFondoFalso = System.Drawing.Color.Empty
        Me.HhBooleanLabel2.ColorFondoVerdadero = System.Drawing.Color.Empty
        Me.HhBooleanLabel2.ColorTextoFalso = System.Drawing.Color.Empty
        Me.HhBooleanLabel2.ColorTextoVerdadero = System.Drawing.Color.Empty
        Me.HhBooleanLabel2.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhBooleanLabel2.DireccionLectura = Nothing
        Me.HhBooleanLabel2.Link = Nothing
        Me.HhBooleanLabel2.Location = New System.Drawing.Point(122, 205)
        Me.HhBooleanLabel2.Name = "HhBooleanLabel2"
        Me.HhBooleanLabel2.Size = New System.Drawing.Size(0, 13)
        Me.HhBooleanLabel2.TabIndex = 12
        Me.HhBooleanLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HhBooleanLabel2.TextoFalso = Nothing
        Me.HhBooleanLabel2.TextoVerdadero = Nothing
        Me.HhBooleanLabel2.Valor = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(800, 575)
        Me.SplitContainer1.SplitterDistance = 464
        Me.SplitContainer1.SplitterWidth = 10
        Me.SplitContainer1.TabIndex = 14
        Me.SplitContainer1.TabStop = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.SplitContainer2, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.SplitContainer3, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.SplitContainer4, 0, 3)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(464, 575)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 462)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label4)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.HhCharacterDisplay2)
        Me.SplitContainer2.Size = New System.Drawing.Size(458, 51)
        Me.SplitContainer2.SplitterDistance = 235
        Me.SplitContainer2.TabIndex = 4
        Me.SplitContainer2.TabStop = False
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(235, 51)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Version PC:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'HhCharacterDisplay2
        '
        Me.HhCharacterDisplay2.AutoActualizar = False
        Me.HhCharacterDisplay2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HhCharacterDisplay2.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhCharacterDisplay2.DireccionLectura = Nothing
        Me.HhCharacterDisplay2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HhCharacterDisplay2.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.HhCharacterDisplay2.Link = Nothing
        Me.HhCharacterDisplay2.Location = New System.Drawing.Point(0, 0)
        Me.HhCharacterDisplay2.Longitud = 0
        Me.HhCharacterDisplay2.Name = "HhCharacterDisplay2"
        Me.HhCharacterDisplay2.Size = New System.Drawing.Size(219, 51)
        Me.HhCharacterDisplay2.TabIndex = 5
        Me.HhCharacterDisplay2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(3, 405)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label3)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.HhCharacterDisplay1)
        Me.SplitContainer3.Size = New System.Drawing.Size(458, 51)
        Me.SplitContainer3.SplitterDistance = 235
        Me.SplitContainer3.TabIndex = 5
        Me.SplitContainer3.TabStop = False
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(235, 51)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Maquina:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'HhCharacterDisplay1
        '
        Me.HhCharacterDisplay1.AutoActualizar = False
        Me.HhCharacterDisplay1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HhCharacterDisplay1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhCharacterDisplay1.DireccionLectura = Nothing
        Me.HhCharacterDisplay1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HhCharacterDisplay1.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.HhCharacterDisplay1.Link = Nothing
        Me.HhCharacterDisplay1.Location = New System.Drawing.Point(0, 0)
        Me.HhCharacterDisplay1.Longitud = 0
        Me.HhCharacterDisplay1.Name = "HhCharacterDisplay1"
        Me.HhCharacterDisplay1.Size = New System.Drawing.Size(219, 51)
        Me.HhCharacterDisplay1.TabIndex = 7
        Me.HhCharacterDisplay1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(3, 519)
        Me.SplitContainer4.Name = "SplitContainer4"
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.Label5)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.HhCharacterDisplay3)
        Me.SplitContainer4.Size = New System.Drawing.Size(458, 53)
        Me.SplitContainer4.SplitterDistance = 235
        Me.SplitContainer4.TabIndex = 6
        Me.SplitContainer4.TabStop = False
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(235, 53)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Version PLC:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'HhCharacterDisplay3
        '
        Me.HhCharacterDisplay3.AutoActualizar = False
        Me.HhCharacterDisplay3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HhCharacterDisplay3.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhCharacterDisplay3.DireccionLectura = Nothing
        Me.HhCharacterDisplay3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HhCharacterDisplay3.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.HhCharacterDisplay3.Link = Nothing
        Me.HhCharacterDisplay3.Location = New System.Drawing.Point(0, 0)
        Me.HhCharacterDisplay3.Longitud = 0
        Me.HhCharacterDisplay3.Name = "HhCharacterDisplay3"
        Me.HhCharacterDisplay3.Size = New System.Drawing.Size(219, 53)
        Me.HhCharacterDisplay3.TabIndex = 6
        Me.HhCharacterDisplay3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Button7, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Button2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button6, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Button4, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button3, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 1, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(326, 575)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Button7
        '
        Me.Button7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button7.Location = New System.Drawing.Point(3, 432)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(147, 140)
        Me.Button7.TabIndex = 11
        Me.Button7.Text = "Test"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button2.Location = New System.Drawing.Point(3, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(147, 137)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Manual"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button4.Location = New System.Drawing.Point(156, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(147, 137)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Automatico"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button3.Location = New System.Drawing.Point(156, 289)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(147, 137)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Configura"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.Location = New System.Drawing.Point(156, 432)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 140)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Salida"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button6.Location = New System.Drawing.Point(3, 289)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(147, 137)
        Me.Button6.TabIndex = 12
        Me.Button6.Text = "Mandos"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'FormLavadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.HhBooleanLabel2)
        Me.Controls.Add(Me.HhBooleanLabel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.HhAnimacion2)
        Me.Controls.Add(Me.HhAnimacion1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormLavadora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Lavadora"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        Me.SplitContainer4.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HhAnimacion1 As hhAnimacion.hhAnimacion
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents HhMsgBox1 As hhMsgBox.hhMsgBox
    Friend WithEvents HhAnimacion2 As hhAnimacion.hhAnimacion
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents HhBooleanLabel1 As hhBooleanLabel.hhBooleanLabel
    Friend WithEvents HhBooleanLabel2 As hhBooleanLabel.hhBooleanLabel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents HhCharacterDisplay2 As hhCharacterDisplay.hhCharacterDisplay
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents HhCharacterDisplay1 As hhCharacterDisplay.hhCharacterDisplay
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents HhCharacterDisplay3 As hhCharacterDisplay.hhCharacterDisplay
    Friend WithEvents Button6 As System.Windows.Forms.Button

End Class
