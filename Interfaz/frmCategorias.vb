Option Explicit On
Imports Negocio
Public Class frmCategorias
    Dim Categoria As New clsCategoria
    Dim Validar As New clsValidar
    Dim Retorno As Boolean
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If Me.txtCategoria.Text <> "" Then
            Try
                Dim DS As New DataSet
                DS = Categoria.Buscar(Me.txtCategoria.Text)
                Me.txtID.Text = DS.Tables(0).Rows(0).Item(0)
                Me.txtCategoria.Text = DS.Tables(0).Rows(0).Item(1)
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
            Categoria.Alta(Me.txtCategoria.Text)
            Me.btnLimpiar.PerformClick()
        End If
    End Sub
    Private Sub btnModificacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificacion.Click
        If Validar_Contenido() = False Then
            MsgBox("Campos en blanco ¡¡completalos!!", MsgBoxStyle.Information, "Error")
            Exit Sub
        Else
            Categoria.Modificacion(Me.txtID.Text, Me.txtCategoria.Text)
            Me.btnLimpiar.PerformClick()
        End If
    End Sub
    Private Sub btnBaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBaja.Click
        If Validar_Contenido() = False Then
            MsgBox("Campos en blanco ¡¡completalos!!", MsgBoxStyle.Information, "Error")
            Exit Sub
        Else
            Categoria.Baja(Me.txtID.Text)
            Me.btnLimpiar.PerformClick()
        End If
    End Sub
    Private Sub frmParciales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtID.ReadOnly = True
        Me.txtID.Enabled = False
        Me.btnLimpiar.PerformClick()
    End Sub
    Private Sub RefrescarBotones()
        Me.btnAlta.Enabled = True
        Me.btnBaja.Enabled = False
        Me.btnModificacion.Enabled = False
        Me.btnBuscar.Enabled = True
    End Sub
    Private Sub Limpiar()
        Me.txtID.Clear()
        Me.txtCategoria.Clear()
    End Sub

    Private Function Validar_Contenido() As Boolean
        If Me.txtID.Text = "" Or Me.txtCategoria.Text = "" Then
            Return False
        Else
            Return True
        End If
    End Function
    Private Function Validar_Contenido_A() As Boolean
        If Me.txtCategoria.Text = "" Then
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub txtContenido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCategoria.KeyPress
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
    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        Limpiar()
        RefrescarBotones()
    End Sub
End Class