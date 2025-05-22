<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCompany = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnOpenLink = New System.Windows.Forms.Button()
        Me.btnSHA256 = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtName
        '
        resources.ApplyResources(Me.txtName, "txtName")
        Me.txtName.Name = "txtName"
        Me.txtName.Tag = "txtName"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.Name = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'txtCompany
        '
        resources.ApplyResources(Me.txtCompany, "txtCompany")
        Me.txtCompany.Name = "txtCompany"
        '
        'Button3
        '
        resources.ApplyResources(Me.Button3, "Button3")
        Me.Button3.Name = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'txtLocation
        '
        resources.ApplyResources(Me.txtLocation, "txtLocation")
        Me.txtLocation.Name = "txtLocation"
        '
        'Button5
        '
        resources.ApplyResources(Me.Button5, "Button5")
        Me.Button5.Name = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'btnOpenLink
        '
        resources.ApplyResources(Me.btnOpenLink, "btnOpenLink")
        Me.btnOpenLink.Name = "btnOpenLink"
        Me.btnOpenLink.UseVisualStyleBackColor = True
        '
        'btnSHA256
        '
        resources.ApplyResources(Me.btnSHA256, "btnSHA256")
        Me.btnSHA256.Name = "btnSHA256"
        Me.btnSHA256.UseVisualStyleBackColor = True
        '
        'Button4
        '
        resources.ApplyResources(Me.Button4, "Button4")
        Me.Button4.Name = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnSHA256)
        Me.Controls.Add(Me.btnOpenLink)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCompany)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCompany As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents btnOpenLink As Button
    Friend WithEvents btnSHA256 As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Button4 As Button
End Class
