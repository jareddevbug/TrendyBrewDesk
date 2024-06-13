<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class staffmanagement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(staffmanagement))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2ComboBox1 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Separator9 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2Separator2 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Guna2TextBox4 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Guna2TextBox5 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2TextBox2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2TextBox3 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse3 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse4 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2MessageDialog1 = New Guna.UI2.WinForms.Guna2MessageDialog()
        Me.Panel1.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(728, 19)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(456, 84)
        Me.Panel1.TabIndex = 33
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Harlow Solid Italic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(28, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(400, 24)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "A good staff will spread positivity and attract people"
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ListView1.Font = New System.Drawing.Font("HP Simplified", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.ForeColor = System.Drawing.Color.White
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(9, 54)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(681, 563)
        Me.ListView1.TabIndex = 35
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 74
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Email"
        Me.ColumnHeader2.Width = 145
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Password"
        Me.ColumnHeader3.Width = 80
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Fullname"
        Me.ColumnHeader4.Width = 154
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Status"
        Me.ColumnHeader5.Width = 95
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Reputation"
        Me.ColumnHeader6.Width = 131
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10000
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Guna2TextBox1.BorderColor = System.Drawing.Color.Silver
        Me.Guna2TextBox1.BorderRadius = 6
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = "Hey"
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.IconRight = CType(resources.GetObject("Guna2TextBox1.IconRight"), System.Drawing.Image)
        Me.Guna2TextBox1.Location = New System.Drawing.Point(52, 6)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = ""
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.Size = New System.Drawing.Size(485, 22)
        Me.Guna2TextBox1.TabIndex = 36
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 8
        Me.Guna2Elipse1.TargetControl = Me.ListView1
        '
        'Guna2ComboBox1
        '
        Me.Guna2ComboBox1.AutoRoundedCorners = True
        Me.Guna2ComboBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ComboBox1.BorderRadius = 10
        Me.Guna2ComboBox1.BorderThickness = 0
        Me.Guna2ComboBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Guna2ComboBox1.FillColor = System.Drawing.Color.OrangeRed
        Me.Guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox1.Font = New System.Drawing.Font("HP Simplified", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2ComboBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2ComboBox1.ItemHeight = 16
        Me.Guna2ComboBox1.Items.AddRange(New Object() {"Coffee", "Snacks", "Specials"})
        Me.Guna2ComboBox1.Location = New System.Drawing.Point(543, 6)
        Me.Guna2ComboBox1.Name = "Guna2ComboBox1"
        Me.Guna2ComboBox1.Size = New System.Drawing.Size(151, 22)
        Me.Guna2ComboBox1.TabIndex = 37
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.BorderRadius = 10
        Me.Guna2Panel3.BorderThickness = 2
        Me.Guna2Panel3.Controls.Add(Me.ListView1)
        Me.Guna2Panel3.Controls.Add(Me.Guna2TextBox1)
        Me.Guna2Panel3.Controls.Add(Me.Guna2ComboBox1)
        Me.Guna2Panel3.Controls.Add(Me.Guna2Separator9)
        Me.Guna2Panel3.Controls.Add(Me.Guna2Separator2)
        Me.Guna2Panel3.Controls.Add(Me.Label4)
        Me.Guna2Panel3.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.FillColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Guna2Panel3.Location = New System.Drawing.Point(13, 19)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Padding = New System.Windows.Forms.Padding(6)
        Me.Guna2Panel3.Size = New System.Drawing.Size(701, 642)
        Me.Guna2Panel3.TabIndex = 38
        '
        'Guna2Separator9
        '
        Me.Guna2Separator9.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator9.FillColor = System.Drawing.Color.Gray
        Me.Guna2Separator9.Location = New System.Drawing.Point(9, 623)
        Me.Guna2Separator9.Name = "Guna2Separator9"
        Me.Guna2Separator9.Size = New System.Drawing.Size(678, 10)
        Me.Guna2Separator9.TabIndex = 39
        '
        'Guna2Separator2
        '
        Me.Guna2Separator2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Separator2.FillColor = System.Drawing.Color.Gray
        Me.Guna2Separator2.Location = New System.Drawing.Point(6, 22)
        Me.Guna2Separator2.Name = "Guna2Separator2"
        Me.Guna2Separator2.Size = New System.Drawing.Size(689, 26)
        Me.Guna2Separator2.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("HP Simplified", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(6, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Staffs"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel2)
        Me.Guna2Panel1.Controls.Add(Me.Panel1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel3)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(14, 14)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1196, 676)
        Me.Guna2Panel1.TabIndex = 40
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.BorderRadius = 10
        Me.Guna2Panel2.BorderThickness = 2
        Me.Guna2Panel2.Controls.Add(Me.Guna2Button3)
        Me.Guna2Panel2.Controls.Add(Me.Label5)
        Me.Guna2Panel2.Controls.Add(Me.Guna2TextBox4)
        Me.Guna2Panel2.Controls.Add(Me.Label6)
        Me.Guna2Panel2.Controls.Add(Me.Guna2TextBox5)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Button2)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Button1)
        Me.Guna2Panel2.Controls.Add(Me.Label1)
        Me.Guna2Panel2.Controls.Add(Me.Guna2TextBox2)
        Me.Guna2Panel2.Controls.Add(Me.Label2)
        Me.Guna2Panel2.Controls.Add(Me.Guna2TextBox3)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Separator1)
        Me.Guna2Panel2.Controls.Add(Me.Label3)
        Me.Guna2Panel2.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Guna2Panel2.Location = New System.Drawing.Point(728, 118)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Padding = New System.Windows.Forms.Padding(6)
        Me.Guna2Panel2.Size = New System.Drawing.Size(456, 332)
        Me.Guna2Panel2.TabIndex = 40
        '
        'Guna2Button3
        '
        Me.Guna2Button3.Animated = True
        Me.Guna2Button3.AnimatedGIF = True
        Me.Guna2Button3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button3.BorderRadius = 8
        Me.Guna2Button3.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Guna2Button3.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button3.FillColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.Guna2Button3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button3.ForeColor = System.Drawing.Color.White
        Me.Guna2Button3.Location = New System.Drawing.Point(313, 276)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.Size = New System.Drawing.Size(135, 45)
        Me.Guna2Button3.TabIndex = 36
        Me.Guna2Button3.Text = "Suspend"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("HP Simplified", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(292, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 16)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "RFID Number"
        '
        'Guna2TextBox4
        '
        Me.Guna2TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox4.DefaultText = ""
        Me.Guna2TextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox4.FillColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Guna2TextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox4.ForeColor = System.Drawing.Color.OrangeRed
        Me.Guna2TextBox4.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox4.Location = New System.Drawing.Point(236, 168)
        Me.Guna2TextBox4.Name = "Guna2TextBox4"
        Me.Guna2TextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox4.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Guna2TextBox4.PlaceholderText = "RFID # goes here"
        Me.Guna2TextBox4.SelectedText = ""
        Me.Guna2TextBox4.Size = New System.Drawing.Size(200, 27)
        Me.Guna2TextBox4.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.Guna2TextBox4.TabIndex = 35
        Me.Guna2TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("HP Simplified", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(91, 198)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 16)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Full name"
        '
        'Guna2TextBox5
        '
        Me.Guna2TextBox5.Animated = True
        Me.Guna2TextBox5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox5.DefaultText = ""
        Me.Guna2TextBox5.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox5.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox5.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox5.FillColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Guna2TextBox5.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox5.ForeColor = System.Drawing.Color.OrangeRed
        Me.Guna2TextBox5.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox5.Location = New System.Drawing.Point(21, 168)
        Me.Guna2TextBox5.Name = "Guna2TextBox5"
        Me.Guna2TextBox5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox5.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Guna2TextBox5.PlaceholderText = "Ex. Johnny Sings"
        Me.Guna2TextBox5.SelectedText = ""
        Me.Guna2TextBox5.Size = New System.Drawing.Size(200, 27)
        Me.Guna2TextBox5.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.Guna2TextBox5.TabIndex = 33
        Me.Guna2TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Guna2Button2
        '
        Me.Guna2Button2.Animated = True
        Me.Guna2Button2.AnimatedGIF = True
        Me.Guna2Button2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.BorderRadius = 8
        Me.Guna2Button2.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Guna2Button2.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.Location = New System.Drawing.Point(158, 276)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(149, 45)
        Me.Guna2Button2.TabIndex = 31
        Me.Guna2Button2.Text = "Remove"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.AnimatedGIF = True
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderRadius = 8
        Me.Guna2Button1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Guna2Button1.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.Guna2Button1.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(10, 276)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(142, 45)
        Me.Guna2Button1.TabIndex = 19
        Me.Guna2Button1.Text = "Add"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("HP Simplified", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(292, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 16)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "RFID Number"
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
        Me.Guna2TextBox2.Location = New System.Drawing.Point(236, 60)
        Me.Guna2TextBox2.Name = "Guna2TextBox2"
        Me.Guna2TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox2.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
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
        Me.Label2.Location = New System.Drawing.Point(91, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Full name"
        '
        'Guna2TextBox3
        '
        Me.Guna2TextBox3.Animated = True
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
        Me.Guna2TextBox3.Location = New System.Drawing.Point(21, 60)
        Me.Guna2TextBox3.Name = "Guna2TextBox3"
        Me.Guna2TextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox3.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2TextBox3.PlaceholderText = "Ex. Johnny Sings"
        Me.Guna2TextBox3.SelectedText = ""
        Me.Guna2TextBox3.Size = New System.Drawing.Size(200, 27)
        Me.Guna2TextBox3.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.Guna2TextBox3.TabIndex = 16
        Me.Guna2TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Separator1.FillColor = System.Drawing.Color.Gray
        Me.Guna2Separator1.Location = New System.Drawing.Point(6, 22)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(444, 10)
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
        Me.Label3.Size = New System.Drawing.Size(98, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Staff Credentials"
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.BorderRadius = 8
        Me.Guna2Elipse2.TargetControl = Me.Guna2Panel3
        '
        'Guna2Elipse3
        '
        Me.Guna2Elipse3.BorderRadius = 8
        Me.Guna2Elipse3.TargetControl = Me.Panel1
        '
        'Guna2Elipse4
        '
        Me.Guna2Elipse4.BorderRadius = 8
        Me.Guna2Elipse4.TargetControl = Me.Guna2Panel2
        '
        'Guna2MessageDialog1
        '
        Me.Guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK
        Me.Guna2MessageDialog1.Caption = "Trendy Brew"
        Me.Guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.None
        Me.Guna2MessageDialog1.Parent = Nothing
        Me.Guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark
        Me.Guna2MessageDialog1.Text = "This is a sample message"
        '
        'staffmanagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1224, 704)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "staffmanagement"
        Me.Padding = New System.Windows.Forms.Padding(14)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "staffmanagement"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ComboBox1 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Separator2 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2Separator9 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse3 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse4 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2TextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2TextBox3 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Guna2TextBox4 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Guna2TextBox5 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Private WithEvents Guna2MessageDialog1 As Guna.UI2.WinForms.Guna2MessageDialog
End Class
