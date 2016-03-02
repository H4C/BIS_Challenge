Imports System.Security.Cryptography
Imports System.Text
Public Class Form1
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If txtID.Text = My.Resources.id Then
            If GetHash(txtPW.Text) = My.Resources.pw Then
                MessageBox.Show("Cftu Pg Uif Cftu")

            Else
                    Environment.Exit(0)
            End If
        Else
            Environment.Exit(0)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Environment.Exit(0)
    End Sub

    Shared Function GetHash(theInput As String) As String

        Using hasher As MD5 = MD5.Create()


            Dim insu As Byte() = hasher.ComputeHash(Encoding.UTF8.GetBytes(theInput))

            Dim babo As New StringBuilder()

            For n As Integer = 0 To insu.Length - 1
                babo.Append(insu(n).ToString("X2"))
            Next n

            Return babo.ToString()
        End Using

    End Function
End Class