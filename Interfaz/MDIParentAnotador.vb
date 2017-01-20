Imports System.Windows.Forms
Imports System.IO

Public Class MDIParentAnotador

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadaToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticleToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles VerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles HorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OrganizarIconosToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CerrarTodoToolStripMenuItem.Click
        ' Cierre todos los formularios secundarios del primario.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private Sub MDIParentAnotador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not File.Exists(System.AppDomain.CurrentDomain.BaseDirectory & "\MisAnotaciones.mdb") Then
            MsgBox("No Se Encuentra la Base de Datos 'MisAnotaciones.mdb', se Cerrará la Aplicación", MsgBoxStyle.Critical, "Error - Base de Datos")
            Me.Close()
        End If
    End Sub

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Dim Bienvenida As New SSAnotador
        If Not Bienvenida.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.Close()
        End If
        Bienvenida.Dispose()
        Application.DoEvents()
    End Sub

    Private Sub Fecha_Hora_Actual_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fecha_Hora_Actual.Tick
        Me.lblFecha.Text = "Fecha Actual: " & FormatDateTime(Date.Now, DateFormat.LongDate)
        Me.lblHora.Text = "Hora Actual: " & FormatDateTime(Date.Now, DateFormat.LongTime)
    End Sub
    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub VerNotasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerNotasToolStripMenuItem.Click
        Dim VerNotas As New frmVerNotas
        VerNotas.MdiParent = Me
        VerNotas.Show()
    End Sub

    Private Sub ABMNotasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABMNotasToolStripMenuItem.Click
        Dim Nota As New frmNotas
        Nota.MdiParent = Me
        Nota.Show()
    End Sub

    Private Sub ABMCategoriasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABMCategoriasToolStripMenuItem.Click
        Dim Categ As New frmCategorias
        Categ.MdiParent = Me
        Categ.Show()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Dim About As New frmAcercaDe
        About.MdiParent = Me
        About.Show()
    End Sub

    Private Sub ContenidoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContenidoToolStripMenuItem.Click
        Dim Ayuda As New frmContenido
        Ayuda.MdiParent = Me
        Ayuda.Show()
    End Sub

    Private Sub BarraDeHerramientasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarraDeHerramientasToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.BarraDeHerramientasToolStripMenuItem.Checked
    End Sub

    Private Sub BarraDeEstadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarraDeEstadoToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.BarraDeEstadoToolStripMenuItem.Checked
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        ABMNotasToolStripMenuItem.PerformClick()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Me.ABMCategoriasToolStripMenuItem.PerformClick()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Me.VerNotasToolStripMenuItem.PerformClick()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Me.ContenidoToolStripMenuItem.PerformClick()
    End Sub


End Class
