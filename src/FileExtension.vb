Imports System
Imports System.Text
Imports System.IO
''' <summary>
'''      MessageBox.Show(New FileExtension().ToFileSize(New FileInfo(OpenFileDialog1.FileName).Length))
''' </summary>
Public Class FileExtension

    Private Shared Function ThreeNonZeroDigits(value As Double) As String
        If value >= 100 Then
            Return value.ToString("0,0")
        ElseIf value >= 10 Then
            Return value.ToString("0.0")
        Else
            Return value.ToString("0.00")
        End If
    End Function

    Friend Shared Function ToFileSize(value As Double) As String
        Dim suffixes As String() = {"Bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB"}
        For i As Integer = 0 To suffixes.Length - 1
            If value <= Math.Pow(1024, i + 1) Then
                Return ThreeNonZeroDigits(value / Math.Pow(1024, i)) & " " & suffixes(i)
            End If
        Next
        Return ThreeNonZeroDigits(value / Math.Pow(1024, suffixes.Length - 1)) & " " & suffixes(suffixes.Length - 1)
    End Function

#Region "Hash"
    Friend Shared Function Sha1Hash(value As String) As String
        Dim inStream As Stream = File.OpenRead(value)
        Return BitConverter.ToString(System.Security.Cryptography.SHA1.Create().ComputeHash(inStream))
        inStream.Close()
    End Function
    Friend Shared Function Sha256Hash(value As String) As String
        Dim inStream As Stream = File.OpenRead(value)
        Return BitConverter.ToString(System.Security.Cryptography.SHA256.Create().ComputeHash(inStream))
        inStream.Close()
    End Function
    Friend Shared Function Sha384Hash(value As String) As String
        Dim inStream As Stream = File.OpenRead(value)
        Return BitConverter.ToString(System.Security.Cryptography.SHA384.Create().ComputeHash(inStream))
        inStream.Close()
    End Function
    Friend Shared Function Sha512Hash(value As String) As String
        Dim inStream As Stream = File.OpenRead(value)
        Return BitConverter.ToString(System.Security.Cryptography.SHA512.Create().ComputeHash(inStream))
        inStream.Close()
    End Function
    Friend Shared Function MD5Hash(value As String) As String
        Dim inStream As Stream = File.OpenRead(value)
        Return BitConverter.ToString(System.Security.Cryptography.MD5.Create().ComputeHash(inStream))
        inStream.Close()
    End Function

#End Region
End Class
