Public Class clsCategoria
    Private _ID_Categoria As Integer
    Private _Categoria As String

    Public Property ID_Categoria() As Integer
        Get
            Return _ID_Categoria
        End Get
        Set(ByVal value As Integer)
            _ID_Categoria = value
        End Set
    End Property

    Public Property Categoria() As String
        Get
            Return _Categoria
        End Get
        Set(ByVal value As String)
            _Categoria = value
        End Set
    End Property
    Public Sub New()

    End Sub

    Public Sub New(ByVal ID_Categoria As Integer, ByVal Categoria As String)
        Me.ID_Categoria = ID_Categoria
        Me.Categoria = Categoria
    End Sub
    Public Sub Alta(ByVal Categoria As String)
        Dim Datos As New Datos.clsAcceso
        Dim DS As DataSet
        Dim Consulta As String = ""
        Consulta = "Insert into Categoria (Categoria) values ('" & Categoria & "')"
        DS = Datos.EjecutarConsultaDS(Consulta)
    End Sub

    Public Function Baja(ByVal ID_Categoria As Integer) As DataSet
        Dim Datos As New Datos.clsAcceso
        Dim DS As DataSet
        Dim Consulta As String = ""
        Consulta = "Delete from Categoria where ID_Categoria=" & ID_Categoria & ""
        DS = Datos.EjecutarConsultaDS(Consulta)
        Return DS
    End Function

    Public Function Modificacion(ByVal ID_Categoria As Integer, ByVal Categoria As String) As DataSet
        Dim Datos As New Datos.clsAcceso
        Dim DS As DataSet
        Dim Consulta As String = ""
        Consulta = "update Categoria set Categoria ='" & Categoria & "' where ID_Categoria=" & ID_Categoria & ""
        DS = Datos.EjecutarConsultaDS(Consulta)
        Return DS
    End Function
    Public Function Buscar(ByVal Categoria As String) As DataSet
        Dim Datos As New Datos.clsAcceso
        Dim DS As DataSet
        Dim Consulta As String = ""
        Consulta = "select * from Categoria where Categoria like '" & Categoria & "%'"
        DS = Datos.EjecutarConsultaDS(Consulta)
        Return DS
    End Function
    Public Function CargarCategorias() As DataSet
        Dim Datos As New Datos.clsAcceso
        Dim DS As DataSet
        Dim Consulta As String = ""
        Consulta = "select ID_Categoria, Categoria from Categoria"
        DS = Datos.EjecutarConsultaDS(Consulta)
        Return DS
    End Function
End Class

