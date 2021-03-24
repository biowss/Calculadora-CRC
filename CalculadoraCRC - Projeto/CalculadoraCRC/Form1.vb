Imports System.Text.RegularExpressions
Public Class Calculadora
    Dim dec, hexa, bin, direto, inverso, crc As String
    Public Property unsigned As Object

    Private Sub txtDec_TextChanged(sender As Object, e As EventArgs) Handles txtDec.TextChanged
        Try
            dec = txtDec.Text

            If dec <> "" Then
                txtBin.Text = formatBin(decToBin(dec), ".")
                txtHexa.Text = formatHexa(decToHexa(dec), ".")
            End If

        Catch erro As System.OverflowException
            MessageBox.Show(erro.Message)

        Catch erro As Exception
            txtDec.Text = Regex.Replace(txtDec.Text, "[^0-9]", "")
        End Try
    End Sub

    Private Sub txtHexa_TextChanged(sender As Object, e As EventArgs) Handles txtHexa.TextChanged
        Try
            hexa = formatRemove(txtHexa.Text, ".")

            If hexa <> "" Then
                txtDec.Text = hexaToDec(hexa)
                txtBin.Text = formatBin(hexaToBin(hexa), ".")
                txtHexa.SelectionStart = txtHexa.TextLength
            End If

        Catch erro As System.OverflowException
            MessageBox.Show(erro.Message)

        Catch erro As Exception
            txtHexa.Text = Regex.Replace(txtHexa.Text, "[^A-Fa-f0-9\.]", "")

        End Try
    End Sub

    Private Sub txtBin_TextChanged(sender As Object, e As EventArgs) Handles txtBin.TextChanged
        Try
            bin = formatRemove(txtBin.Text, ".")

            If bin <> "" Then
                txtDec.Text = binToDec(bin)
                txtHexa.Text = formatHexa(binToHexa(bin), ".")
                txtBin.SelectionStart = txtBin.TextLength
            End If

        Catch erro As System.OverflowException
            MessageBox.Show(erro.Message)

        Catch erro As Exception
            txtBin.Text = Regex.Replace(txtBin.Text, "[^0-1\.]", "")
        End Try
    End Sub

    Private Sub txtDireto_TextChanged(sender As Object, e As EventArgs) Handles txtDireto.TextChanged
        Try
            direto = formatRemove(txtDireto.Text, " ")

            If direto <> "" Then
                txtDireto.Text = formatHexa(direto, " ")
                txtInverso.Text = formatHexa(inversorHexa(direto), " ")
                txtDireto.SelectionStart = txtDireto.TextLength

            End If

        Catch erro As System.OverflowException
            MessageBox.Show(erro.Message)

        Catch erro As Exception
            txtDireto.Text = Regex.Replace(txtDireto.Text, "[^A-Fa-f0-9 ]", "")
        End Try
    End Sub
    Private Sub txtInverso_TextChanged(sender As Object, e As EventArgs) Handles txtInverso.TextChanged
        Try
            inverso = formatRemove(txtInverso.Text, " ")

            If inverso <> "" Then
                txtInverso.Text = formatHexa(inverso, " ")
                txtDireto.Text = formatHexa(inversorHexa(inverso), " ")
                txtInverso.SelectionStart = txtInverso.TextLength

            End If

        Catch erro As System.OverflowException
            MessageBox.Show(erro.Message)

        Catch erro As Exception
            txtInverso.Text = Regex.Replace(txtInverso.Text, "[^A-Fa-f0-9 ]", "")
        End Try
    End Sub



End Class
