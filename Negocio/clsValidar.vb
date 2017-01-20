Public Class clsValidar
    Public Function Alfavetico(ByVal Caracter As String) As Boolean
        If (Asc(Caracter) >= 65 And Asc(Caracter) <= 90) Or (Asc(Caracter) >= 95 And Asc(Caracter) <= 122) Or (Asc(Caracter) = 8) Or (Asc(Caracter) = 32) Then
            Alfavetico = True
        Else
            Alfavetico = False
        End If
    End Function

    Public Function Numeros(ByVal Caracter As String) As Boolean
        If IsNumeric(Caracter) Then
            Numeros = True
        Else
            Numeros = False
        End If
    End Function
End Class
