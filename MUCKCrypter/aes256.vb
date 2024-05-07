Imports System.Text
Imports System.Security.Cryptography
Imports System.IO

Public Class AES256
    Private Shared msInOut As Object

    Public Shared Function EncryptDecrypt(text As String, password As String, isEncrypt As Boolean) As String
        Dim keyBytes As Byte() = Encoding.UTF8.GetBytes(password)
        Dim ivBytes As Byte() = New Byte(15) {}

        Dim aesAlg As New AesCryptoServiceProvider()

        aesAlg.Key = keyBytes
        aesAlg.IV = ivBytes
        aesAlg.Mode = CipherMode.CFB
        aesAlg.Padding = PaddingMode.PKCS7

        Dim cryptoTransform As ICryptoTransform

        If isEncrypt Then
            cryptoTransform = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV)
        Else
            cryptoTransform = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV)
        End If

        Using msInOut As New MemoryStream()
            Using csInOut As New CryptoStream(msInOut, cryptoTransform, If(isEncrypt, CryptoStreamMode.Write, CryptoStreamMode.Read))
                If isEncrypt Then
                    Using swEncrypt As New StreamWriter(csInOut)
                        swEncrypt.Write(text)
                    End Using
                Else
                    Using srDecrypt As New StreamReader(csInOut)
                        Return srDecrypt.ReadToEnd()
                    End Using
                End If
            End Using
        End Using

        aesAlg.Dispose() ' AesCryptoServiceProvider OFF

        Dim resultBytes As Byte() = msInOut.ToArray()

        If isEncrypt Then
            Return Convert.ToBase64String(resultBytes)
        Else
            Return Encoding.UTF8.GetString(resultBytes)
        End If
    End Function

    Friend Shared Function EncryptDecrypt(bfile As String, key As String) As String
        Throw New NotImplementedException()
    End Function
End Class