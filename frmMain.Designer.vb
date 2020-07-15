<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnClick_Me = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnClick_Me
        '
        Me.btnClick_Me.Location = New System.Drawing.Point(316, 67)
        Me.btnClick_Me.Name = "btnClick_Me"
        Me.btnClick_Me.Size = New System.Drawing.Size(189, 62)
        Me.btnClick_Me.TabIndex = 0
        Me.btnClick_Me.Text = "Click Me!"
        Me.btnClick_Me.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(316, 228)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(189, 62)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Bye Bye"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClick_Me)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnClick_Me As Button
    Friend WithEvents btnExit As Button
End Class
