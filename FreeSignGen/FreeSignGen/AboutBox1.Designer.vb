<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutBox1
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Friend WithEvents TableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents LabelProductNameXX As System.Windows.Forms.Label
    Friend WithEvents LabelVersionXX As System.Windows.Forms.Label
    Friend WithEvents LabelCompanyNameXX As System.Windows.Forms.Label
    Friend WithEvents TextBoxDescriptionXX As System.Windows.Forms.TextBox
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents LabelCopyrightXX As System.Windows.Forms.Label

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutBox1))
        Me.TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.LabelProductNameXX = New System.Windows.Forms.Label()
        Me.LabelVersionXX = New System.Windows.Forms.Label()
        Me.LabelCopyrightXX = New System.Windows.Forms.Label()
        Me.LabelCompanyNameXX = New System.Windows.Forms.Label()
        Me.TextBoxDescriptionXX = New System.Windows.Forms.TextBox()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel.SuspendLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel
        '
        Me.TableLayoutPanel.ColumnCount = 2
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.0!))
        Me.TableLayoutPanel.Controls.Add(Me.LogoPictureBox, 0, 0)
        Me.TableLayoutPanel.Controls.Add(Me.LabelProductNameXX, 1, 0)
        Me.TableLayoutPanel.Controls.Add(Me.LabelVersionXX, 1, 1)
        Me.TableLayoutPanel.Controls.Add(Me.LabelCopyrightXX, 1, 2)
        Me.TableLayoutPanel.Controls.Add(Me.LabelCompanyNameXX, 1, 3)
        Me.TableLayoutPanel.Controls.Add(Me.TextBoxDescriptionXX, 1, 4)
        Me.TableLayoutPanel.Controls.Add(Me.OKButton, 1, 5)
        Me.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel.Location = New System.Drawing.Point(9, 9)
        Me.TableLayoutPanel.Name = "TableLayoutPanel"
        Me.TableLayoutPanel.RowCount = 6
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel.Size = New System.Drawing.Size(396, 258)
        Me.TableLayoutPanel.TabIndex = 0
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(3, 3)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.TableLayoutPanel.SetRowSpan(Me.LogoPictureBox, 6)
        Me.LogoPictureBox.Size = New System.Drawing.Size(124, 252)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'LabelProductNameXX
        '
        Me.LabelProductNameXX.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelProductNameXX.Location = New System.Drawing.Point(136, 0)
        Me.LabelProductNameXX.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.LabelProductNameXX.MaximumSize = New System.Drawing.Size(0, 17)
        Me.LabelProductNameXX.Name = "LabelProductNameXX"
        Me.LabelProductNameXX.Size = New System.Drawing.Size(257, 17)
        Me.LabelProductNameXX.TabIndex = 0
        Me.LabelProductNameXX.Text = "FreeSignGen"
        Me.LabelProductNameXX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelVersionXX
        '
        Me.LabelVersionXX.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelVersionXX.Location = New System.Drawing.Point(136, 25)
        Me.LabelVersionXX.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.LabelVersionXX.MaximumSize = New System.Drawing.Size(0, 17)
        Me.LabelVersionXX.Name = "LabelVersionXX"
        Me.LabelVersionXX.Size = New System.Drawing.Size(257, 17)
        Me.LabelVersionXX.TabIndex = 0
        Me.LabelVersionXX.Text = "1.0"
        Me.LabelVersionXX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelCopyrightXX
        '
        Me.LabelCopyrightXX.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelCopyrightXX.Location = New System.Drawing.Point(136, 50)
        Me.LabelCopyrightXX.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.LabelCopyrightXX.MaximumSize = New System.Drawing.Size(0, 17)
        Me.LabelCopyrightXX.Name = "LabelCopyrightXX"
        Me.LabelCopyrightXX.Size = New System.Drawing.Size(257, 17)
        Me.LabelCopyrightXX.TabIndex = 0
        Me.LabelCopyrightXX.Text = "This program is non-commercial only."
        Me.LabelCopyrightXX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelCompanyNameXX
        '
        Me.LabelCompanyNameXX.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelCompanyNameXX.Location = New System.Drawing.Point(136, 75)
        Me.LabelCompanyNameXX.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.LabelCompanyNameXX.MaximumSize = New System.Drawing.Size(0, 17)
        Me.LabelCompanyNameXX.Name = "LabelCompanyNameXX"
        Me.LabelCompanyNameXX.Size = New System.Drawing.Size(257, 17)
        Me.LabelCompanyNameXX.TabIndex = 0
        Me.LabelCompanyNameXX.Text = "Winverse"
        Me.LabelCompanyNameXX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxDescriptionXX
        '
        Me.TextBoxDescriptionXX.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxDescriptionXX.Location = New System.Drawing.Point(136, 103)
        Me.TextBoxDescriptionXX.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.TextBoxDescriptionXX.Multiline = True
        Me.TextBoxDescriptionXX.Name = "TextBoxDescriptionXX"
        Me.TextBoxDescriptionXX.ReadOnly = True
        Me.TextBoxDescriptionXX.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxDescriptionXX.Size = New System.Drawing.Size(257, 123)
        Me.TextBoxDescriptionXX.TabIndex = 0
        Me.TextBoxDescriptionXX.TabStop = False
        Me.TextBoxDescriptionXX.Text = "A free CA generator." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "NON-COMMERCIAL USAGE ONLY!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "YT: @Winverse_Official"
        '
        'OKButton
        '
        Me.OKButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.OKButton.Location = New System.Drawing.Point(318, 232)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 0
        Me.OKButton.Text = "&OK"
        '
        'AboutBox1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.OKButton
        Me.ClientSize = New System.Drawing.Size(414, 276)
        Me.Controls.Add(Me.TableLayoutPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AboutBox1"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About"
        Me.TableLayoutPanel.ResumeLayout(False)
        Me.TableLayoutPanel.PerformLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

End Class
