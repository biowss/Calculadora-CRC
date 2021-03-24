Module ConversorDeBinarios
    Function binToDec(valor As String) As String
        Dim numeroDecimal As String

        numeroDecimal = Convert.ToInt64(valor, 2).ToString

        Return numeroDecimal
    End Function

    Function binToHexa(valor As String) As String
        Dim numeroHexadecimal As String

        numeroHexadecimal = Convert.ToString(Convert.ToInt64(valor, 2), 16).ToUpper

        Return numeroHexadecimal
    End Function
End Module
