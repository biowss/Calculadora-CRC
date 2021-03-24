Module ConversorDeDecimais
    Function decToBin(valor As Int64) As String
        Dim numeroBinario As String

        numeroBinario = Convert.ToString(valor, 2)

        Return numeroBinario
    End Function

    Function decToHexa(valor As Int64) As String
        Dim numeroHexadecimal As String

        numeroHexadecimal = Convert.ToString(valor, 16).ToUpper

        Return numeroHexadecimal
    End Function
End Module
