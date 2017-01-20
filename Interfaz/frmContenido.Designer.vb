<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContenido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContenido))
        Me.TPNotas = New System.Windows.Forms.TabPage
        Me.lblAyudaCategoría = New System.Windows.Forms.Label
        Me.TPMateria = New System.Windows.Forms.TabPage
        Me.lblAyudaMateria = New System.Windows.Forms.Label
        Me.AyudaTP = New System.Windows.Forms.TabControl
        Me.TPNotas.SuspendLayout()
        Me.TPMateria.SuspendLayout()
        Me.AyudaTP.SuspendLayout()
        Me.SuspendLayout()
        '
        'TPNotas
        '
        Me.TPNotas.Controls.Add(Me.lblAyudaCategoría)
        Me.TPNotas.Location = New System.Drawing.Point(4, 22)
        Me.TPNotas.Name = "TPNotas"
        Me.TPNotas.Padding = New System.Windows.Forms.Padding(3)
        Me.TPNotas.Size = New System.Drawing.Size(592, 374)
        Me.TPNotas.TabIndex = 2
        Me.TPNotas.Text = "Ayuda sobre Categorías"
        Me.TPNotas.UseVisualStyleBackColor = True
        '
        'lblAyudaCategoría
        '
        Me.lblAyudaCategoría.ForeColor = System.Drawing.Color.Maroon
        Me.lblAyudaCategoría.Location = New System.Drawing.Point(9, 12)
        Me.lblAyudaCategoría.Name = "lblAyudaCategoría"
        Me.lblAyudaCategoría.Size = New System.Drawing.Size(550, 350)
        Me.lblAyudaCategoría.TabIndex = 0
        Me.lblAyudaCategoría.Text = "Ayuda Sobre Categorías"
        '
        'TPMateria
        '
        Me.TPMateria.Controls.Add(Me.lblAyudaMateria)
        Me.TPMateria.Location = New System.Drawing.Point(4, 22)
        Me.TPMateria.Name = "TPMateria"
        Me.TPMateria.Padding = New System.Windows.Forms.Padding(3)
        Me.TPMateria.Size = New System.Drawing.Size(592, 374)
        Me.TPMateria.TabIndex = 0
        Me.TPMateria.Text = "Ayuda sobre Notas"
        Me.TPMateria.UseVisualStyleBackColor = True
        '
        'lblAyudaMateria
        '
        Me.lblAyudaMateria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblAyudaMateria.Location = New System.Drawing.Point(9, 12)
        Me.lblAyudaMateria.Name = "lblAyudaMateria"
        Me.lblAyudaMateria.Size = New System.Drawing.Size(550, 350)
        Me.lblAyudaMateria.TabIndex = 0
        Me.lblAyudaMateria.Text = "Ayuda Sobre Notas"
        '
        'AyudaTP
        '
        Me.AyudaTP.Controls.Add(Me.TPMateria)
        Me.AyudaTP.Controls.Add(Me.TPNotas)
        Me.AyudaTP.Location = New System.Drawing.Point(21, 9)
        Me.AyudaTP.Name = "AyudaTP"
        Me.AyudaTP.SelectedIndex = 0
        Me.AyudaTP.Size = New System.Drawing.Size(600, 400)
        Me.AyudaTP.TabIndex = 0
        '
        'frmContenido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 419)
        Me.Controls.Add(Me.AyudaTP)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmContenido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contenido de la Ayuda"
        Me.TPNotas.ResumeLayout(False)
        Me.TPMateria.ResumeLayout(False)
        Me.AyudaTP.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TPNotas As System.Windows.Forms.TabPage
    Friend WithEvents lblAyudaCategoría As System.Windows.Forms.Label
    Friend WithEvents TPMateria As System.Windows.Forms.TabPage
    Friend WithEvents lblAyudaMateria As System.Windows.Forms.Label
    Friend WithEvents AyudaTP As System.Windows.Forms.TabControl
End Class
