Imports System.Security.Cryptography
Imports System.Security.Cryptography.X509Certificates
Imports System.Diagnostics

Public Class Form1
    Private Sub btnSHA1_Click(sender As Object, e As EventArgs)
        GenerateCertificate(HashAlgorithmName.SHA1, "SHA1")
    End Sub

    Private Sub btnSHA256_Click(sender As Object, e As EventArgs) Handles btnSHA256.Click
        GenerateCertificate(HashAlgorithmName.SHA256, "SHA256")
    End Sub

    Private Sub GenerateCertificate(hashAlg As HashAlgorithmName, suffix As String)
        Try
            Using rsa As RSA = RSA.Create(2048)
                Dim name As String = txtName.Text.Trim()
                Dim company As String = txtCompany.Text.Trim()
                Dim location As String = txtLocation.Text.Trim()

                If String.IsNullOrWhiteSpace(name) OrElse String.IsNullOrWhiteSpace(company) OrElse String.IsNullOrWhiteSpace(location) Then
                    MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                Dim dn As String = $"CN={name}, O={company}, L={location}"
                Dim notBefore = DateTimeOffset.UtcNow
                Dim notAfter = notBefore.AddYears(50)

                Dim req = New CertificateRequest(dn, rsa, hashAlg, RSASignaturePadding.Pkcs1)
                req.CertificateExtensions.Add(New X509BasicConstraintsExtension(True, False, 0, True)) ' is CA
                req.CertificateExtensions.Add(New X509KeyUsageExtension(X509KeyUsageFlags.KeyCertSign Or X509KeyUsageFlags.CrlSign, True))
                req.CertificateExtensions.Add(New X509SubjectKeyIdentifierExtension(req.PublicKey, False))

                Dim cert = req.CreateSelfSigned(notBefore, notAfter)

                Using sfd As New SaveFileDialog()
                    sfd.Filter = "PFX files (*.pfx)|*.pfx|P12 files (*.p12)|*.p12"
                    sfd.FileName = $"{name}_FakeCA_{suffix}.pfx"
                    If sfd.ShowDialog() = DialogResult.OK Then
                        Dim pfxData = cert.Export(X509ContentType.Pfx)
                        System.IO.File.WriteAllBytes(sfd.FileName, pfxData)
                        MessageBox.Show($"Saved {suffix} cert to: {sfd.FileName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show(
            "This is your CA's name."
        )
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show(
            "This is your company/organization's name."
)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show(
            "This is your company/organization's residence."
)
    End Sub

    Private Sub btnOpenLink_Click(sender As Object, e As EventArgs) Handles btnOpenLink.Click
        Process.Start(New ProcessStartInfo With {
        .FileName = "https://www.youtube.com/@Winverse_Official",
        .UseShellExecute = True
    })
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim aboutWindow As New AboutBox1()
        aboutWindow.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim aboutWindow As New Form2()
        aboutWindow.ShowDialog()
    End Sub
End Class