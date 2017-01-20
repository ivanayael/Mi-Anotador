<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNotas))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.lblCampo2 = New System.Windows.Forms.Label
        Me.txtAnotacion = New System.Windows.Forms.TextBox
        Me.lblCampo4 = New System.Windows.Forms.Label
        Me.lblCampo3 = New System.Windows.Forms.Label
        Me.lblCampo1 = New System.Windows.Forms.Label
        Me.cboCategoria = New System.Windows.Forms.ComboBox
        Me.txtFecha = New System.Windows.Forms.MaskedTextBox
        Me.txtID = New System.Windows.Forms.TextBox
        Me.btnLimpiar = New System.Windows.Forms.Button
        Me.btnBaja = New System.Windows.Forms.Button
        Me.btnModificacion = New System.Windows.Forms.Button
        Me.btnAlta = New System.Windows.Forms.Button
        Me.btnFechaActual = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.lblCampo2)
        Me.GroupBox1.Controls.Add(Me.txtAnotacion)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(668, 273)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar"
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = Global.Interfaz.My.Resources.Resources.buscar
        Me.btnBuscar.Location = New System.Drawing.Point(551, 22)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(99, 39)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.Text = "&Buscar"
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'lblCampo2
        '
        Me.lblCampo2.AutoSize = True
        Me.lblCampo2.Location = New System.Drawing.Point(4, 25)
        Me.lblCampo2.Name = "lblCampo2"
        Me.lblCampo2.Size = New System.Drawing.Size(55, 13)
        Me.lblCampo2.TabIndex = 2
        Me.lblCampo2.Text = "&Anotación"
        '
        'txtAnotacion
        '
        Me.txtAnotacion.Location = New System.Drawing.Point(75, 22)
        Me.txtAnotacion.Multiline = True
        Me.txtAnotacion.Name = "txtAnotacion"
        Me.txtAnotacion.Size = New System.Drawing.Size(454, 236)
        Me.txtAnotacion.TabIndex = 0
        '
        'lblCampo4
        '
        Me.lblCampo4.AutoSize = True
        Me.lblCampo4.Location = New System.Drawing.Point(16, 332)
        Me.lblCampo4.Name = "lblCampo4"
        Me.lblCampo4.Size = New System.Drawing.Size(54, 13)
        Me.lblCampo4.TabIndex = 4
        Me.lblCampo4.Text = "&Categoría"
        '
        'lblCampo3
        '
        Me.lblCampo3.AutoSize = True
        Me.lblCampo3.Location = New System.Drawing.Point(16, 359)
        Me.lblCampo3.Name = "lblCampo3"
        Me.lblCampo3.Size = New System.Drawing.Size(37, 13)
        Me.lblCampo3.TabIndex = 6
        Me.lblCampo3.Text = "&Fecha"
        '
        'lblCampo1
        '
        Me.lblCampo1.AutoSize = True
        Me.lblCampo1.Location = New System.Drawing.Point(16, 15)
        Me.lblCampo1.Name = "lblCampo1"
        Me.lblCampo1.Size = New System.Drawing.Size(18, 13)
        Me.lblCampo1.TabIndex = 0
        Me.lblCampo1.Text = "&ID"
        '
        'cboCategoria
        '
        Me.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategoria.FormattingEnabled = True
        Me.cboCategoria.Location = New System.Drawing.Point(87, 329)
        Me.cboCategoria.Name = "cboCategoria"
        Me.cboCategoria.Size = New System.Drawing.Size(454, 21)
        Me.cboCategoria.TabIndex = 3
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(87, 356)
        Me.txtFecha.Mask = "00/00/0000"
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(64, 20)
        Me.txtFecha.TabIndex = 5
        Me.txtFecha.ValidatingType = GetType(Date)
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(87, 12)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(50, 20)
        Me.txtID.TabIndex = 1
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Image = Global.Interfaz.My.Resources.Resources.limpiar
        Me.btnLimpiar.Location = New System.Drawing.Point(563, 329)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(99, 39)
        Me.btnLimpiar.TabIndex = 10
        Me.btnLimpiar.Text = "&Limpiar"
        Me.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnBaja
        '
        Me.btnBaja.Image = Global.Interfaz.My.Resources.Resources.quitar
        Me.btnBaja.Location = New System.Drawing.Point(426, 401)
        Me.btnBaja.Name = "btnBaja"
        Me.btnBaja.Size = New System.Drawing.Size(99, 39)
        Me.btnBaja.TabIndex = 9
        Me.btnBaja.Text = "&Quitar"
        Me.btnBaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBaja.UseVisualStyleBackColor = True
        '
        'btnModificacion
        '
        Me.btnModificacion.Image = Global.Interfaz.My.Resources.Resources.editar
        Me.btnModificacion.Location = New System.Drawing.Point(297, 401)
        Me.btnModificacion.Name = "btnModificacion"
        Me.btnModificacion.Size = New System.Drawing.Size(99, 39)
        Me.btnModificacion.TabIndex = 8
        Me.btnModificacion.Text = "&Modificar"
        Me.btnModificacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnModificacion.UseVisualStyleBackColor = True
        '
        'btnAlta
        '
        Me.btnAlta.Image = Global.Interfaz.My.Resources.Resources.agregar
        Me.btnAlta.Location = New System.Drawing.Point(168, 401)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(99, 39)
        Me.btnAlta.TabIndex = 7
        Me.btnAlta.Text = "&Agregar"
        Me.btnAlta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAlta.UseVisualStyleBackColor = True
        '
        'btnFechaActual
        '
        Me.btnFechaActual.Location = New System.Drawing.Point(168, 354)
        Me.btnFechaActual.Name = "btnFechaActual"
        Me.btnFechaActual.Size = New System.Drawing.Size(99, 23)
        Me.btnFechaActual.TabIndex = 11
        Me.btnFechaActual.Text = "Fecha Actual"
        Me.btnFechaActual.UseVisualStyleBackColor = True
        '
        'frmNotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 469)
        Me.Controls.Add(Me.btnFechaActual)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnBaja)
        Me.Controls.Add(Me.btnModificacion)
        Me.Controls.Add(Me.btnAlta)
        Me.Controls.Add(Me.lblCampo4)
        Me.Controls.Add(Me.lblCampo3)
        Me.Controls.Add(Me.lblCampo1)
        Me.Controls.Add(Me.cboCategoria)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.txtID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmNotas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anotaciones"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents lblCampo2 As System.Windows.Forms.Label
    Friend WithEvents txtAnotacion As System.Windows.Forms.TextBox
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnBaja As System.Windows.Forms.Button
    Friend WithEvents btnModificacion As System.Windows.Forms.Button
    Friend WithEvents btnAlta As System.Windows.Forms.Button
    Friend WithEvents lblCampo4 As System.Windows.Forms.Label
    Friend WithEvents lblCampo3 As System.Windows.Forms.Label
    Friend WithEvents lblCampo1 As System.Windows.Forms.Label
    Friend WithEvents cboCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents txtFecha As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents btnFechaActual As System.Windows.Forms.Button
End Class
