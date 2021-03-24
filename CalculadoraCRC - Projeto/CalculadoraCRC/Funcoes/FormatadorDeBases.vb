Module FormatadorDeBases
    Function formatBin(valor As String, separador As Char) As String
        Dim tamanho As Int16

        tamanho = valor.Length

        For i = tamanho To 5 Step -4
            valor = valor.Insert(i - 4, separador)
        Next

        Return valor
    End Function

    Function formatHexa(valor As String, separador As Char) As String
        Dim tamanho As Int16

        tamanho = valor.Length

        For i = tamanho To 3 Step -2
            valor = valor.Insert(i - 2, separador)
        Next

        Return valor.ToUpper
    End Function
    Function formatRemove(valor As String, separador As Char) As String
        Return valor.Replace(separador, "")
    End Function
End Module


