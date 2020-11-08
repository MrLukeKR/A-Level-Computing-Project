Imports System.Security.Cryptography
Module Encryption
    Private Key As String = "CBMSP455W0RD!"
    Private EncryptionProvider As New TripleDESCryptoServiceProvider
    Private Function TruncateHash(ByVal Key As String, ByVal Length As Integer) As Byte()
        Dim SHA1Provider As New SHA1CryptoServiceProvider
        Dim KeyBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(Key)
        Dim Hash() As Byte = SHA1Provider.ComputeHash(KeyBytes)
        ReDim Preserve Hash(Length - 1)
        Return Hash
    End Function
    Sub Setkey(ByVal Key As String)
        EncryptionProvider.Key = TruncateHash(Key, EncryptionProvider.KeySize \ 8)
        EncryptionProvider.IV = TruncateHash("", EncryptionProvider.BlockSize \ 8)
    End Sub
    Function Encrypt(ByVal Plaintext As String)
        Setkey(Key)
        Dim PlaintextToByte() As Byte = System.Text.Encoding.Unicode.GetBytes(Plaintext)
        Dim MemoryStream As New System.IO.MemoryStream
        Dim EncryptionStream As New CryptoStream(MemoryStream, EncryptionProvider.CreateEncryptor, CryptoStreamMode.Write)
        EncryptionStream.Write(PlaintextToByte, 0, PlaintextToByte.Length)
        EncryptionStream.FlushFinalBlock()
        Return Convert.ToBase64String(MemoryStream.ToArray)
    End Function
End Module
