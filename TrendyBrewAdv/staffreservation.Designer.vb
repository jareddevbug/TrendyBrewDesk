<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class staffreservation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(staffreservation))
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2DateTimePicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button5 = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel5.BackgroundImage = CType(resources.GetObject("Panel5.BackgroundImage"), System.Drawing.Image)
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.TextBox1)
        Me.Panel5.Controls.Add(Me.PictureBox1)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.Location = New System.Drawing.Point(887, 103)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(331, 427)
        Me.Panel5.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(10, 332)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(308, 84)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Text = "Additional Details...."
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(10, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(308, 280)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(81, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Reservation's QR code"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(887, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(331, 85)
        Me.Panel1.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(88, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Reservation details"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("HP Simplified", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(89, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 16)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "As of August 08, 2023"
        '
        'Timer1
        '
        Me.Timer1.Interval = 10000
        '
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND
        Me.Guna2AnimateWindow1.TargetForm = Me
        '
        'Guna2Button2
        '
        Me.Guna2Button2.Animated = True
        Me.Guna2Button2.AnimatedGIF = True
        Me.Guna2Button2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.BorderRadius = 6
        Me.Guna2Button2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Button2.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.Location = New System.Drawing.Point(980, 536)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(116, 65)
        Me.Guna2Button2.TabIndex = 24
        Me.Guna2Button2.Text = "Reject"
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
        Me.Guna2Button3.Image = CType(resources.GetObject("Guna2Button3.Image"), System.Drawing.Image)
        Me.Guna2Button3.Location = New System.Drawing.Point(1045, 607)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.Size = New System.Drawing.Size(173, 85)
        Me.Guna2Button3.TabIndex = 25
        Me.Guna2Button3.Text = "Scan QR"
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Guna2TextBox1.BorderColor = System.Drawing.Color.Silver
        Me.Guna2TextBox1.BorderRadius = 6
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = "abcd12@gmail.com"
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.IconRight = CType(resources.GetObject("Guna2TextBox1.IconRight"), System.Drawing.Image)
        Me.Guna2TextBox1.Location = New System.Drawing.Point(12, 10)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = ""
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.Size = New System.Drawing.Size(642, 22)
        Me.Guna2TextBox1.TabIndex = 37
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.ListView1.Font = New System.Drawing.Font("HP Simplified", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.ForeColor = System.Drawing.Color.White
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(12, 38)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(869, 654)
        Me.ListView1.TabIndex = 39
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 45
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "name"
        Me.ColumnHeader2.Width = 120
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "email"
        Me.ColumnHeader3.Width = 120
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "phone"
        Me.ColumnHeader4.Width = 120
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "date"
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "time"
        Me.ColumnHeader6.Width = 100
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "tableNum"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "guest"
        Me.ColumnHeader8.Width = 55
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "details"
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "status"
        Me.ColumnHeader10.Width = 100
        '
        'Guna2DateTimePicker1
        '
        Me.Guna2DateTimePicker1.BorderRadius = 6
        Me.Guna2DateTimePicker1.Checked = True
        Me.Guna2DateTimePicker1.FillColor = System.Drawing.Color.OrangeRed
        Me.Guna2DateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2DateTimePicker1.ForeColor = System.Drawing.Color.White
        Me.Guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Guna2DateTimePicker1.Location = New System.Drawing.Point(660, 10)
        Me.Guna2DateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Guna2DateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Guna2DateTimePicker1.Name = "Guna2DateTimePicker1"
        Me.Guna2DateTimePicker1.Size = New System.Drawing.Size(221, 22)
        Me.Guna2DateTimePicker1.TabIndex = 40
        Me.Guna2DateTimePicker1.Value = New Date(2023, 12, 1, 20, 44, 31, 474)
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.AnimatedGIF = True
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderRadius = 6
        Me.Guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.Guna2Button1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Button1.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(887, 536)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(85, 65)
        Me.Guna2Button1.TabIndex = 23
        Me.Guna2Button1.Text = "Email"
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
        Me.Guna2Button4.Location = New System.Drawing.Point(1102, 536)
        Me.Guna2Button4.Name = "Guna2Button4"
        Me.Guna2Button4.Size = New System.Drawing.Size(116, 65)
        Me.Guna2Button4.TabIndex = 41
        Me.Guna2Button4.Text = "Approve"
        '
        'Guna2Button5
        '
        Me.Guna2Button5.Animated = True
        Me.Guna2Button5.AnimatedGIF = True
        Me.Guna2Button5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button5.BorderRadius = 6
        Me.Guna2Button5.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Button5.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2Button5.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.Guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button5.FillColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.Guna2Button5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button5.ForeColor = System.Drawing.Color.White
        Me.Guna2Button5.Image = CType(resources.GetObject("Guna2Button5.Image"), System.Drawing.Image)
        Me.Guna2Button5.Location = New System.Drawing.Point(887, 607)
        Me.Guna2Button5.Name = "Guna2Button5"
        Me.Guna2Button5.Size = New System.Drawing.Size(152, 85)
        Me.Guna2Button5.TabIndex = 42
        Me.Guna2Button5.Text = "DONE"
        '
        'staffreservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1230, 704)
        Me.ControlBox = False
        Me.Controls.Add(Me.Guna2Button5)
        Me.Controls.Add(Me.Guna2Button4)
        Me.Controls.Add(Me.Guna2DateTimePicker1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Guna2TextBox1)
        Me.Controls.Add(Me.Guna2Button3)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "staffreservation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents Guna2DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button5 As Guna.UI2.WinForms.Guna2Button
End Class
