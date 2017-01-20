<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVerNotas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVerNotas))
        Me.gbFiltro = New System.Windows.Forms.GroupBox
        Me.btnLimpiar = New System.Windows.Forms.Button
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboCategoria = New System.Windows.Forms.ComboBox
        Me.txtAnotacion = New System.Windows.Forms.TextBox
        Me.DGVListado = New System.Windows.Forms.DataGridView
        Me.gbFiltro.SuspendLayout()
        CType(Me.DGVListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbFiltro
        '
        Me.gbFiltro.Controls.Add(Me.btnLimpiar)
        Me.gbFiltro.Controls.Add(Me.btnBuscar)
        Me.gbFiltro.Controls.Add(Me.Label2)
        Me.gbFiltro.Controls.Add(Me.Label1)
        Me.gbFiltro.Controls.Add(Me.cboCategoria)
        Me.gbFiltro.Controls.Add(Me.txtAnotacion)
        Me.gbFiltro.Location = New System.Drawing.Point(56, 13)
        Me.gbFiltro.Name = "gbFiltro"
        Me.gbFiltro.Size = New System.Drawing.Size(680, 124)
        Me.gbFiltro.TabIndex = 0
        Me.gbFiltro.TabStop = False
        Me.gbFiltro.Text = "Filtros"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Image = Global.Interfaz.My.Resources.Resources.limpiar
        Me.btnLimpiar.Location = New System.Drawing.Point(581, 65)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(82, 39)
        Me.btnLimpiar.TabIndex = 5
        Me.btnLimpiar.Text = "&Limpiar"
        Me.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = Global.Interfaz.My.Resources.Resources.buscar
        Me.btnBuscar.Location = New System.Drawing.Point(581, 22)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(82, 37)
        Me.btnBuscar.TabIndex = 4
        Me.btnBuscar.Text = "&Buscar"
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Categoría:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Anotacion:"
        '
        'cboCategoria
        '
        Me.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategoria.FormattingEnabled = True
        Me.cboCategoria.Location = New System.Drawing.Point(88, 90)
        Me.cboCategoria.Name = "cboCategoria"
        Me.cboCategoria.Size = New System.Drawing.Size(362, 21)
        Me.cboCategoria.TabIndex = 3
        '
        'txtAnotacion
        '
        Me.txtAnotacion.Location = New System.Drawing.Point(88, 17)
        Me.txtAnotacion.Multiline = True
        Me.txtAnotacion.Name = "txtAnotacion"
        Me.txtAnotacion.Size = New System.Drawing.Size(475, 67)
        Me.txtAnotacion.TabIndex = 1
        '
        'DGVListado
        '
        Me.DGVListado.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGVListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVListado.Location = New System.Drawing.Point(12, 143)
        Me.DGVListado.Name = "DGVListado"
        Me.DGVListado.Size = New System.Drawing.Size(768, 412)
        Me.DGVListado.TabIndex = 1
        '
        'frmVerNotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 569)
        Me.Controls.Add(Me.gbFiltro)
        Me.Controls.Add(Me.DGVListado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVerNotas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ver las Anotaciones"
        Me.gbFiltro.ResumeLayout(False)
        Me.gbFiltro.PerformLayout()
        CType(Me.DGVListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbFiltro As System.Windows.Forms.GroupBox
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents txtAnotacion As System.Windows.Forms.TextBox
    Friend WithEvents DGVListado As System.Windows.Forms.DataGridView
End Class
