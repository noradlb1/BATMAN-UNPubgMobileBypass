Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Security.Cryptography
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Diagnostics
Imports LOGIN

Namespace Seal
    Class SealCheck
        Public Shared isValidDLL As Boolean = False

        Public Shared Sub HashChecks()
            'If CalculateMD5("Newtonsoft.Json.dll") <> "ae683e40c544859083b2b99e623fc0a1" OrElse CalculateMD5(GetType(LOGIN.Seal).Assembly.Location) <> "ae683e40c544859083b2b99e623fc0a1" Then
            '    MessageBox.Show("Hash check failed. Exiting...", "TrinitySeal", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            '    Process.GetCurrentProcess().Kill()
            'Else
            isValidDLL = True
            'End If
        End Sub

        Private Shared Function CalculateMD5(ByVal filename As String) As String
            Using md = MD5.Create()

                Using stream = File.OpenRead(filename)
                    Dim hash = md.ComputeHash(stream)
                    Return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant()
                End Using
            End Using
        End Function
    End Class
End Namespace
