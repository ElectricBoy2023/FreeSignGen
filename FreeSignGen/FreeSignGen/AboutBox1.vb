Public NotInheritable Class AboutBox1

    Private Sub AboutBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Ustaw tytuł formularza.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("Informacje o {0}", ApplicationTitle)
        ' Zainicjuj cały tekst wyświetlany w polu Informacje o.
        ' TODO: Dostosuj informacje o zestawie aplikacji w okienku „Aplikacja” projektu 
        '    okno dialogowe właściwości (w menu „Projekt”).
        Me.LabelProductNameXX.Text = My.Application.Info.ProductName
        Me.LabelVersionXX.Text = String.Format("Wersja {0}", My.Application.Info.Version.ToString)
        Me.LabelCopyrightXX.Text = My.Application.Info.Copyright
        Me.LabelCompanyNameXX.Text = My.Application.Info.CompanyName
        Me.TextBoxDescriptionXX.Text = My.Application.Info.Description
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

End Class
