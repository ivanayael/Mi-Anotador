Option Explicit On
Imports Negocio
Public Class frmNotas
    Dim Nota As New clsNota
    Dim Categoria As New clsCategoria
    Dim Validar As New clsValidar
    Dim Retorno As Boolean
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If Me.txtAnotacion.Text <> "" Then
            Try
                Dim DS As New DataSet
                DS = Nota.Buscar(Me.txtAnotacion.Text)
                Me.txtID.Text = DS.Tables(0).Rows(0).Item(0)
                Me.txtAnotacion.Text = DS.Tables(0).Rows(0).Item(1)
                Me.cboCategoria.SelectedValue = DS.Tables(0).Rows(0).Item(2)
                Me.txtFecha.Text = DS.Tables(0).Rows(0).Item(3)
                Me.btnAlta.Enabled = True
                Me.btnBaja.Enabled = True
                Me.btnModificacion.Enabled = True
                Me.btnBuscar.Enabled = True
            Catch ex As Exception
                MsgBox("No se encuentra coincidencia de búsqueda", MsgBoxStyle.Exclamation, "Error de búsqueda")
                Me.btnLimpiar.PerformClick()
            End Try
        Else : MsgBox("No se filtró nada", MsgBoxStyle.Information, "Error de Filtro")
        End If
    End Sub
    Private Sub btnAlta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlta.Click
        If Validar_Contenido_A() = False Then
            MsgBox("Campos en blanco ¡¡completalos!!", MsgBoxStyle.Information, "Error")
            Exit Sub
        Else
            Nota.Alta(Me.txtAnotacion.Text, Me.cboCategoria.SelectedValue, Me.txtFecha.Text)
            Me.btnLimpiar.PerformClick()
        End If
    End Sub
    Private Sub btnModificacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificacion.Click
        If Validar_Contenido_M() = False Then
            MsgBox("Campos en blanco ¡¡completalos!!", MsgBoxStyle.Information, "Error")
            Exit Sub
        Else
            Nota.Modificacion(Me.txtID.Text, Me.txtAnotacion.Text, Me.cboCategoria.SelectedValue)
            Me.btnLimpiar.PerformClick()
        End If
    End Sub
    Private Sub btnBaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBaja.Click
        If Validar_Contenido() = False Then
            MsgBox("Campos en blanco ¡¡completalos!!", MsgBoxStyle.Information, "Error")
            Exit Sub
        Else
            Nota.Baja(Me.txtID.Text)
            Me.btnLimpiar.PerformClick()
        End If
    End Sub
    Private Sub frmParciales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtID.ReadOnly = True
        Me.txtID.Enabled = False
        Me.btnLimpiar.PerformClick()
        CargarCategorias()
    End Sub
    Private Sub RefrescarBotones()
        Me.btnAlta.Enabled = True
        Me.btnBaja.Enabled = False
        Me.btnModificacion.Enabled = False
        Me.btnBuscar.Enabled = True
    End Sub
    Private Sub Limpiar()
        Me.txtID.Clear()
        Me.txtAnotacion.Clear()
        Me.cboCategoria.SelectedIndex = -1
        Me.txtFecha.Clear()
    End Sub

    Private Function Validar_Contenido() As Boolean
        If Me.txtID.Text = "" Or Me.txtAnotacion.Text = "" Or Me.txtFecha.Text = "" Or Me.cboCategoria.SelectedIndex = -1 Then
            Return False
        Else
            Return True
        End If
    End Function
    Private Function Validar_Contenido_M() As Boolean
        If Me.txtID.Text = "" Or Me.txtAnotacion.Text = "" Or Me.cboCategoria.SelectedIndex = -1 Then
            Return False
        Else
            Return True
        End If
    End Function
    Private Function Validar_Contenido_A() As Boolean
        If Me.txtAnotacion.Text = "" Or Me.cboCategoria.SelectedIndex = -1 Or Me.txtFecha.Text = "" Then
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub txtAnotacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnotacion.KeyPress
        Retorno = Validar.Alfavetico(e.KeyChar.ToString)
        If Retorno = False Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub
    Private Sub txtID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtID.KeyPress
        Retorno = Validar.Numeros(e.KeyChar.ToString)
        If Retorno = False Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub
    Private Sub txtFecha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFecha.KeyPress
        Retorno = Validar.Numeros(e.KeyChar.ToString)
        If Retorno = False Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub
    Private Sub CargarCategorias()
        Try
            Dim DS As DataSet
            DS = Categoria.CargarCategorias()
            Me.cboCategoria.DataSource = DS.Tables(0)
            Me.cboCategoria.DisplayMember = DS.Tables(0).Columns(1).Caption.ToString
            Me.cboCategoria.ValueMember = DS.Tables(0).Columns(0).Caption.ToString
            Me.cboCategoria.SelectedIndex = -1
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Atención")
        End Try
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        Limpiar()
        RefrescarBotones()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechaActual.Click
        Dim result As DialogResult
        result = MessageBox.Show("Se sobreescribira cualquier contenido del campo 'Fecha', ¿Desea continuar?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.txtFecha.Text = FormatDateTime(Date.Now, DateFormat.ShortDate)
        End If
    End Sub
End Class