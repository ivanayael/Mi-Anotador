Imports System.Data
Imports System.Data.OleDb
Public Class clsAcceso
    Dim CN As OleDbConnection
    Dim COM As OleDbCommand
    Dim DR As OleDbDataReader
    Dim DA As OleDbDataAdapter
    Private Sub Conectar()
        CN = New OleDbConnection
        CN.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & System.AppDomain.CurrentDomain.BaseDirectory & "\MisAnotaciones.mdb"
        CN.Open()
    End Sub
    Private Sub Desconectar()
        CN.Dispose()
        CN = Nothing
    End Sub
    Public Function EjecutarConsultaDR(ByVal consulta As String) As Integer
        Dim Cm As New OleDbCommand
        Cm.CommandText = consulta
        Cm.CommandType = CommandType.Text
        Conectar()
        Cm.Connection = CN
        Cm.ExecuteNonQuery()
        Cm.Dispose()
        Desconectar()
        Return 1
    End Function
    Public Function EjecutarConsultaDS(ByVal Consulta As String) As DataSet
        Dim DS As New DataSet
        Dim COM As New OleDbCommand
        Conectar()
        Dim DA As New OleDbDataAdapter(Consulta, CN)
        DA.Fill(DS)
        DA.Dispose()
        Desconectar()
        Return DS
    End Function
End Class
