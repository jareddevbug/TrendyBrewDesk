<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class loadingscr
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loadingscr))
        Me.LoadingPanel = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LoadingPanel
        '
        Me.LoadingPanel.Location = New System.Drawing.Point(0, 504)
        Me.LoadingPanel.Name = "LoadingPanel"
        Me.LoadingPanel.Size = New System.Drawing.Size(20, 19)
        Me.LoadingPanel.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("HP Simplified", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 473)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'loadingscr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(763, 523)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LoadingPanel)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "loadingscr"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "loadingscr"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LoadingPanel As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
End Class
