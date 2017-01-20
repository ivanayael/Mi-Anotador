Public Class clsNota
    Private _ID_Nota As Integer
    Private _Anotacion As String
    Private _ID_Categoria As String
    Private _Fecha As String

    Public Property ID_Nota() As Integer
        Get
            Return _ID_Nota
        End Get
        Set(ByVal value As Integer)
            _ID_Nota = value
        End Set
    End Property

    Public Property Anotacion() As String
        Get
            Return _Anotacion
        End Get
        Set(ByVal value As String)
            _Anotacion = value
        End Set
    End Property

    Public Property ID_Categoria() As Integer
        Get
            Return _ID_Categoria
        End Get
        Set(ByVal value As Integer)
            _ID_Categoria = value
        End Set
    End Property

    Public Property Fecha() As String
        Get
            Return _Fecha
        End Get
        Set(ByVal value As String)
            _Fecha = value
        End Set
    End Property
    Public Sub New()

    End Sub

    Public Sub New(ByVal ID_Nota As Integer, ByVal Anotacion As String, ByVal ID_Categoria As Integer, ByVal Fecha As String)
        Me.ID_Nota = ID_Nota
        Me.Anotacion = Anotacion
        Me.ID_Categoria = ID_Categoria
        Me.Fecha = Fecha
    End Sub
    Public Sub Alta(ByVal Anotacion As String, ByVal ID_Categoria As Integer, ByVal Fecha As String)
        Dim Datos As New Datos.clsAcceso
        Dim DS As DataSet
        Dim Consulta As String = ""
        Consulta = "Insert into Anotacion (Anotacion, ID_Categoria, Fecha) values ('" & Anotacion & "','" & ID_Categoria & "','" & Fecha & "')"
        DS = Datos.EjecutarConsultaDS(Consulta)
    End Sub

    Public Function Baja(ByVal ID_Nota As Integer) As DataSet
        Dim Datos As New Datos.clsAcceso
        Dim DS As DataSet
        Dim Consulta As String = ""
        Consulta = "Delete from Anotacion where ID_Nota=" & ID_Nota & ""
        DS = Datos.EjecutarConsultaDS(Consulta)
        Return DS
    End Function

    Public Function Modificacion(ByVal ID_Nota As Integer, ByVal Anotacion As String, ByVal ID_Categoria As Integer) As DataSet
        Dim Datos As New Datos.clsAcceso
        Dim DS As DataSet
        Dim Consulta As String = ""
        Consulta = "update Anotacion set Anotacion ='" & Anotacion & "', ID_Categoria='" & ID_Categoria & "' where ID_Nota=" & ID_Nota & ""
        DS = Datos.EjecutarConsultaDS(Consulta)
        Return DS
    End Function

    Public Function Buscar(ByVal Anotacion As String) As DataSet
        Dim Datos As New Datos.clsAcceso
        Dim DS As DataSet
        Dim Consulta As String = ""
        Consulta = "select * from Anotacion where Anotacion like '" & Anotacion & "%'"
        DS = Datos.EjecutarConsultaDS(Consulta)
        Return DS
    End Function
    Public Function Listar() As DataSet
        Dim Datos As New Datos.clsAcceso
        Dim DS As DataSet
        Dim Consulta As String = ""
        Consulta = "SELECT Anotacion.Anotacion, Categoria.Categoria, Anotacion.Fecha FROM (Anotacion INNER JOIN Categoria ON Anotacion.ID_Categoria = Categoria.ID_Categoria)"
        DS = Datos.EjecutarConsultaDS(Consulta)
        Return DS
    End Function
    Public Function CargarAnotacion() As DataSet
        Dim Datos As New Datos.clsAcceso
        Dim DS As DataSet
        Dim Consulta As String = ""
        Consulta = "select ID_Nota, Anotacion from Anotacion"
        DS = Datos.EjecutarConsultaDS(Consulta)
        Return DS
    End Function
End Class
