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
        ButtonTest = New Button()
        Login = New Button()
        Label1 = New Label()
        Label2 = New Label()
        NameUser = New TextBox()
        WordPass = New TextBox()
        SuspendLayout()
        ' 
        ' ButtonTest
        ' 
        ButtonTest.Location = New Point(12, 12)
        ButtonTest.Name = "ButtonTest"
        ButtonTest.Size = New Size(153, 48)
        ButtonTest.TabIndex = 0
        ButtonTest.Text = "Connection Test"
        ButtonTest.UseVisualStyleBackColor = True
        ' 
        ' Login
        ' 
        Login.Location = New Point(308, 296)
        Login.Name = "Login"
        Login.Size = New Size(167, 65)
        Login.TabIndex = 1
        Login.Text = "Login"
        Login.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(53, 119)
        Label1.Name = "Label1"
        Label1.Size = New Size(213, 47)
        Label1.TabIndex = 2
        Label1.Text = "Username: "
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(53, 182)
        Label2.Name = "Label2"
        Label2.Size = New Size(213, 47)
        Label2.TabIndex = 3
        Label2.Text = "Password: "
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' NameUser
        ' 
        NameUser.Location = New Point(261, 139)
        NameUser.Name = "NameUser"
        NameUser.Size = New Size(267, 23)
        NameUser.TabIndex = 4
        ' 
        ' WordPass
        ' 
        WordPass.Location = New Point(261, 202)
        WordPass.Name = "WordPass"
        WordPass.PasswordChar = "*"c
        WordPass.Size = New Size(267, 23)
        WordPass.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(555, 405)
        Controls.Add(WordPass)
        Controls.Add(NameUser)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Login)
        Controls.Add(ButtonTest)
        Name = "Form1"
        Text = "MYSQL DATABASE Connection"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ButtonTest As Button
    Friend WithEvents Login As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NameUser As TextBox
    Friend WithEvents WordPass As TextBox

End Class
