<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCategorias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCategorias))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.txtCategoria = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtID = New System.Windows.Forms.TextBox
        Me.btnLimpiar = New System.Windows.Forms.Button
        Me.btnBaja = New System.Windows.Forms.Button
        Me.btnModificacion = New System.Windows.Forms.Button
        Me.btnAlta = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.txtCategoria)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(473, 70)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "&Categoría"
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = Global.Interfaz.My.Resources.Resources.buscar
        Me.btnBuscar.Location = New System.Drawing.Point(367, 17)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(99, 39)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.Text = "&Buscar"
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtCategoria
        '
        Me.txtCategoria.Location = New System.Drawing.Point(73, 27)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(288, 20)
        Me.txtCategoria.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(83, 13)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(49, 20)
        Me.txtID.TabIndex = 1
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Image = Global.Interfaz.My.Resources.Resources.limpiar
        Me.btnLimpiar.Location = New System.Drawing.Point(377, 116)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(99, 39)
        Me.btnLimpiar.TabIndex = 6
        Me.btnLimpiar.Text = "&Limpiar"
        Me.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnBaja
        '
        Me.btnBaja.Image = Global.Interfaz.My.Resources.Resources.quitar
        Me.btnBaja.Location = New System.Drawing.Point(256, 116)
        Me.btnBaja.Name = "btnBaja"
        Me.btnBaja.Size = New System.Drawing.Size(99, 39)
        Me.btnBaja.TabIndex = 5
        Me.btnBaja.Text = "&Quitar"
        Me.btnBaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBaja.UseVisualStyleBackColor = True
        '
        'btnModificacion
        '
        Me.btnModificacion.Image = Global.Interfaz.My.Resources.Resources.editar
        Me.btnModificacion.Location = New System.Drawing.Point(135, 116)
        Me.btnModificacion.Name = "btnModificacion"
        Me.btnModificacion.Size = New System.Drawing.Size(99, 39)
        Me.btnModificacion.TabIndex = 4
        Me.btnModificacion.Text = "&Modificar"
        Me.btnModificacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnModificacion.UseVisualStyleBackColor = True
        '
        'btnAlta
        '
        Me.btnAlta.Image = Global.Interfaz.My.Resources.Resources.agregar
        Me.btnAlta.Location = New System.Drawing.Point(16, 116)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(99, 39)
        Me.btnAlta.TabIndex = 3
        Me.btnAlta.Text = "&Agregar"
        Me.btnAlta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAlta.UseVisualStyleBackColor = True
        '
        'frmCategorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 169)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnBaja)
        Me.Controls.Add(Me.btnModificacion)
        Me.Controls.Add(Me.btnAlta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCategorias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Categorias"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnBaja As System.Windows.Forms.Button
    Friend WithEvents btnModificacion As System.Windows.Forms.Button
    Friend WithEvents btnAlta As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCategoria As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
End Class
