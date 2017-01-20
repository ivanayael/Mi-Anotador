Option Explicit On
Imports Negocio
Public Class frmVerNotas
    Dim Nota As New clsNota
    Dim Categoria As New clsCategoria
    Dim DS As DataSet 'declara el Dataset
    Dim DV As New DataView 'declara el dataview
    Dim DT As New DataTable 'declara el datatable
    Private Sub frmListadoNotas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            DT = Nota.Listar.Tables(0)
            DV = DT.DefaultView ' la muestra en un dataview por default
            DGVListado.DataSource = DV ' muestra la informacion en el Datagridview
        Catch ex As Exception
            MsgBox("No hay datos para cargar en la tabla", MsgBoxStyle.Exclamation, "Atención")
        End Try

        Try
            CargarCategorias()
        Catch ex As Exception
            MsgBox("No hay datos para cargar en la lista", MsgBoxStyle.Exclamation, "Atención")
        End Try
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try

            If Me.cboCategoria.SelectedIndex <> -1 And Me.txtAnotacion.Text = "" Then  ' si el texto de buscaque de la bitacora tiene algo
                DV.RowFilter = "Categoria ='" & Me.cboCategoria.Text & "'"  'busca según la descripcion de la bitácora
                Me.DGVListado.Refresh() 'refresca el datagridview
            ElseIf Me.cboCategoria.SelectedIndex = -1 And Me.txtAnotacion.Text <> "" Then
                DV.RowFilter = "Anotacion Like '%" & Me.txtAnotacion.Text & "%'"
                Me.DGVListado.Refresh() 'refresca el datagridview
            ElseIf Me.cboCategoria.SelectedIndex <> -1 And Me.txtAnotacion.Text <> "" Then
                DV.RowFilter = "Anotacion Like '%" & Me.txtAnotacion.Text & "%' and ID_Categoria ='" & Me.cboCategoria.Text & "'"
                Me.DGVListado.Refresh() 'refresca el datagridview
            ElseIf Me.cboCategoria.SelectedIndex = -1 And Me.txtAnotacion.Text = "" Then
                MsgBox("no se filtró nada, se mostrarán todos los datos", MsgBoxStyle.Exclamation, "Error")
                Try
                    DT = Nota.Listar.Tables(0)
                    DV = DT.DefaultView ' la muestra en un dataview por default
                    DGVListado.DataSource = DV ' muestra la informacion en el Datagridview
                    Me.DGVListado.Refresh()
                Catch ex As Exception
                    MsgBox("No hay datos para cargar en la tabla", MsgBoxStyle.Exclamation, "Atención")
                End Try
            End If
        Catch ex As Exception ' en caso de error, muestra una excepción
            MsgBox("No se encuentra coincidencia de búsqueda", MsgBoxStyle.Exclamation, "Error de búsqueda")
        End Try
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        Me.txtAnotacion.Clear()
        Me.cboCategoria.SelectedIndex = -1
        Try
            DT = Nota.Listar.Tables(0)
            DV = DT.DefaultView
            DGVListado.DataSource = DV
        Catch ex As Exception
            MsgBox("No hay datos para cargar en la tabla.", MsgBoxStyle.Exclamation, "Atención")
        End Try
    End Sub
    Private Sub CargarCategorias()
        Dim DS As DataSet
        DS = Categoria.CargarCategorias()
        Me.cboCategoria.DataSource = DS.Tables(0)
        Me.cboCategoria.DisplayMember = DS.Tables(0).Columns(1).Caption.ToString
        Me.cboCategoria.ValueMember = DS.Tables(0).Columns(0).Caption.ToString
        Me.cboCategoria.SelectedIndex = -1
    End Sub
End Class