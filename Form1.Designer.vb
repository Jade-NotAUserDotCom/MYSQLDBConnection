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
        SuspendLayout()
        ' 
        ' ButtonTest
        ' 
        ButtonTest.Location = New Point(290, 188)
        ButtonTest.Name = "ButtonTest"
        ButtonTest.Size = New Size(194, 75)
        ButtonTest.TabIndex = 0
        ButtonTest.Text = "MYSQL TEST"
        ButtonTest.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ButtonTest)
        Name = "Form1"
        Text = "MYSQL DATABASE Connection"
        ResumeLayout(False)
    End Sub

    Friend WithEvents ButtonTest As Button

End Class
