<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SukiCardUsers
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
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Guna2TextBox3 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2TextBox2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Separator2 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.BorderRadius = 10
        Me.Guna2Panel2.BorderThickness = 2
        Me.Guna2Panel2.Controls.Add(Me.ListView1)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Separator1)
        Me.Guna2Panel2.Controls.Add(Me.Label3)
        Me.Guna2Panel2.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Guna2Panel2.Location = New System.Drawing.Point(12, 32)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Padding = New System.Windows.Forms.Padding(6)
        Me.Guna2Panel2.Size = New System.Drawing.Size(550, 368)
        Me.Guna2Panel2.TabIndex = 29
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListView1.ForeColor = System.Drawing.Color.White
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.LabelEdit = True
        Me.ListView1.Location = New System.Drawing.Point(9, 35)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(532, 324)
        Me.ListView1.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListView1.TabIndex = 15
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "RFID"
        Me.ColumnHeader1.Width = 145
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Full Name"
        Me.ColumnHeader2.Width = 268
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Suki Points"
        Me.ColumnHeader3.Width = 115
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Separator1.FillColor = System.Drawing.Color.Gray
        Me.Guna2Separator1.Location = New System.Drawing.Point(6, 22)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(538, 10)
        Me.Guna2Separator1.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("HP Simplified", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(6, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Suki list"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderRadius = 10
        Me.Guna2Panel1.BorderThickness = 2
        Me.Guna2Panel1.Controls.Add(Me.Label5)
        Me.Guna2Panel1.Controls.Add(Me.Guna2TextBox3)
        Me.Guna2Panel1.Controls.Add(Me.Label4)
        Me.Guna2Panel1.Controls.Add(Me.Guna2TextBox2)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2TextBox1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Separator2)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(580, 32)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Padding = New System.Windows.Forms.Padding(6)
        Me.Guna2Panel1.Size = New System.Drawing.Size(363, 317)
        Me.Guna2Panel1.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("HP Simplified", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(29, 260)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 16)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Suki points"
        '
        'Guna2TextBox3
        '
        Me.Guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox3.DefaultText = ""
        Me.Guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox3.FillColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox3.ForeColor = System.Drawing.Color.OrangeRed
        Me.Guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox3.Location = New System.Drawing.Point(131, 249)
        Me.Guna2TextBox3.Name = "Guna2TextBox3"
        Me.Guna2TextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox3.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.Guna2TextBox3.PlaceholderText = "xxx003"
        Me.Guna2TextBox3.SelectedText = ""
        Me.Guna2TextBox3.Size = New System.Drawing.Size(200, 27)
        Me.Guna2TextBox3.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.Guna2TextBox3.TabIndex = 33
        Me.Guna2TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("HP Simplified", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(29, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 16)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "RFID Number:"
        '
        'Guna2TextBox2
        '
        Me.Guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox2.DefaultText = ""
        Me.Guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox2.ForeColor = System.Drawing.Color.OrangeRed
        Me.Guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.Location = New System.Drawing.Point(131, 168)
        Me.Guna2TextBox2.Name = "Guna2TextBox2"
        Me.Guna2TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox2.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.Guna2TextBox2.PlaceholderText = "RFID # goes here"
        Me.Guna2TextBox2.SelectedText = ""
        Me.Guna2TextBox2.Size = New System.Drawing.Size(200, 27)
        Me.Guna2TextBox2.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.Guna2TextBox2.TabIndex = 18
        Me.Guna2TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("HP Simplified", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(29, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Full name:"
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.Animated = True
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox1.ForeColor = System.Drawing.Color.OrangeRed
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Location = New System.Drawing.Point(131, 86)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.Guna2TextBox1.PlaceholderText = "Ex. Johnny Sings"
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.Size = New System.Drawing.Size(200, 27)
        Me.Guna2TextBox1.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.Guna2TextBox1.TabIndex = 16
        Me.Guna2TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Guna2Separator2
        '
        Me.Guna2Separator2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Separator2.FillColor = System.Drawing.Color.Gray
        Me.Guna2Separator2.Location = New System.Drawing.Point(6, 22)
        Me.Guna2Separator2.Name = "Guna2Separator2"
        Me.Guna2Separator2.Size = New System.Drawing.Size(351, 10)
        Me.Guna2Separator2.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("HP Simplified", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Suki Credentials"
        '
        'Guna2Button3
        '
        Me.Guna2Button3.Animated = True
        Me.Guna2Button3.AnimatedGIF = True
        Me.Guna2Button3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button3.BorderRadius = 6
        Me.Guna2Button3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Button3.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2Button3.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button3.FillColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.Guna2Button3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button3.ForeColor = System.Drawing.Color.White
        Me.Guna2Button3.Location = New System.Drawing.Point(580, 355)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.Size = New System.Drawing.Size(185, 45)
        Me.Guna2Button3.TabIndex = 34
        Me.Guna2Button3.Text = "Add"
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 12
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2Button4
        '
        Me.Guna2Button4.Animated = True
        Me.Guna2Button4.AnimatedGIF = True
        Me.Guna2Button4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button4.BorderRadius = 6
        Me.Guna2Button4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Button4.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2Button4.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.Guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button4.FillColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.Guna2Button4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button4.ForeColor = System.Drawing.Color.White
        Me.Guna2Button4.Location = New System.Drawing.Point(771, 355)
        Me.Guna2Button4.Name = "Guna2Button4"
        Me.Guna2Button4.Size = New System.Drawing.Size(172, 45)
        Me.Guna2Button4.TabIndex = 35
        Me.Guna2Button4.Text = "Remove"
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.Animated = True
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.CustomClick = True
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.Red
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(926, 4)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(25, 20)
        Me.Guna2ControlBox1.TabIndex = 36
        '
        'SukiCardUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(955, 416)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.Controls.Add(Me.Guna2Button4)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2Button3)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SukiCardUsers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SukiCardUsers"
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2TextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Separator2 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents Label5 As Label
    Friend WithEvents Guna2TextBox3 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
End Class
