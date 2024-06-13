<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScanRFID
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScanRFID))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Guna2Button7 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(625, 392)
        Me.Panel1.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.TextBox1)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.Location = New System.Drawing.Point(635, 112)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(122, 67)
        Me.Panel5.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Scan SUKI CARD"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(631, 360)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Note:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("HP Simplified", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label12.Location = New System.Drawing.Point(670, 364)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(246, 16)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Wait 5 seconds before scanning a new card."
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 15
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.Interval = 450
        Me.Guna2AnimateWindow1.TargetForm = Me
        '
        'Guna2Button7
        '
        Me.Guna2Button7.Animated = True
        Me.Guna2Button7.AnimatedGIF = True
        Me.Guna2Button7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button7.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button7.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button7.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button7.ForeColor = System.Drawing.Color.White
        Me.Guna2Button7.HoverState.ForeColor = System.Drawing.Color.Gray
        Me.Guna2Button7.Location = New System.Drawing.Point(912, 12)
        Me.Guna2Button7.Name = "Guna2Button7"
        Me.Guna2Button7.Size = New System.Drawing.Size(31, 23)
        Me.Guna2Button7.TabIndex = 9
        Me.Guna2Button7.Text = "X"
        Me.Guna2Button7.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase
        Me.Guna2Button7.UseTransparentBackground = True
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.BorderRadius = 10
        Me.Guna2Elipse2.TargetControl = Me.PictureBox1
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Button1.BorderRadius = 8
        Me.Guna2Button1.BorderThickness = 1
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(874, 323)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(75, 36)
        Me.Guna2Button1.TabIndex = 10
        Me.Guna2Button1.Text = "Suki here"
        Me.Guna2Button1.UseTransparentBackground = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(635, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(308, 345)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 35)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(108, 21)
        Me.TextBox1.TabIndex = 11
        '
        'Guna2Button2
        '
        Me.Guna2Button2.Animated = True
        Me.Guna2Button2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Button2.BorderRadius = 8
        Me.Guna2Button2.BorderThickness = 1
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.Location = New System.Drawing.Point(793, 323)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(75, 36)
        Me.Guna2Button2.TabIndex = 11
        Me.Guna2Button2.Text = "Confirm"
        Me.Guna2Button2.UseTransparentBackground = True
        '
        'ScanRFID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(955, 392)
        Me.ControlBox = False
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.Guna2Button7)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ScanRFID"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2Button7 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
End Class
