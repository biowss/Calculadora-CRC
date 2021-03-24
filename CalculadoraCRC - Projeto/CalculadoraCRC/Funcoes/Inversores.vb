Module Inversores
    Function inversorHexa(valor As String) As String
        Dim inverso As String
        Dim tamanho As Int16

        inverso = ""
        tamanho = valor.Length

        If (tamanho Mod 2) = 0 Then
            For i = tamanho To 2 Step -2
                inverso += valor.Substring(i - 2, 2)
            Next
        Else
            For i = tamanho To 1 Step -1
                inverso += valor.Substring(i - 1, 1)
            Next
        End If
        Return inverso
    End Function
End Module
