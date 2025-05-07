Imports System.Data.SQLite
Imports System.IO

Module Geral
    Public admin As Boolean

    Public Sub veradm(a)
        If a = 1 Then
            admin = True
        Else
            admin = False

        End If
    End Sub

End Module
