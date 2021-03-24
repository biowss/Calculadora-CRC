Module ConversorDeHexadecimais
    Function hexaToDec(valor As String) As String
        Dim numeroDecimal As String

        numeroDecimal = Convert.ToInt64(valor, 16)

        Return numeroDecimal
    End Function

    Function hexaToBin(valor As String) As String
        Dim numeroBinario As String

        numeroBinario = Convert.ToString(Convert.ToInt64(valor, 16), 2)

        Return numeroBinario
    End Function

End Module
