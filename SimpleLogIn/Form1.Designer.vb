<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        txtPassword = New TextBox()
        txtEmail = New TextBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.ImageAlign = ContentAlignment.MiddleRight
        Button1.Location = New Point(465, 196)
        Button1.Name = "Button1"
        Button1.Size = New Size(231, 68)
        Button1.TabIndex = 0
        Button1.Text = "Log in"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(141, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(140, 25)
        Label1.TabIndex = 1
        Label1.Text = "Enter your email"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(132, 85)
        Label2.Name = "Label2"
        Label2.Size = New Size(175, 25)
        Label2.TabIndex = 2
        Label2.Text = "Enter your password"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(313, 82)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(150, 31)
        txtPassword.TabIndex = 3
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(313, 28)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(150, 31)
        txtEmail.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtEmail)
        Controls.Add(txtPassword)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtEmail As TextBox
End Class
