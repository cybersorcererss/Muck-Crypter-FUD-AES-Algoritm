Imports System.Security.Cryptography

Friend Class AesCryptoServiceProvider
    Public Sub New()
    End Sub

    Public Property Key As Byte()
    Public Property IV As Byte()
    Public Property Mode As CipherMode
    Public Property Padding As PaddingMode

    Friend Sub Dispose()
        Throw New NotImplementedException()
    End Sub

    Friend Function CreateEncryptor(key() As Byte, ıV() As Byte) As ICryptoTransform
        Throw New NotImplementedException()
    End Function

    Friend Function CreateDecryptor(key() As Byte, ıV() As Byte) As ICryptoTransform
        Throw New NotImplementedException()
    End Function
End Class
