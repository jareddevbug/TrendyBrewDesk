Public Class Form1
    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles MainPanel.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = DateTime.Now.ToString()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Label5.Text = Staffsignin.TextBox2.Text

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim staffordering As New staffordering()
        staffordering.TopLevel = False
        MainPanel.Controls.Clear()
        MainPanel.Controls.Add(staffordering)
        staffordering.Show()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim staffreservation As New staffreservation()
        staffreservation.TopLevel = False
        MainPanel.Controls.Clear()
        MainPanel.Controls.Add(staffreservation)
        staffreservation.Show()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dim staffhomeform As New staffhomeform()
        staffhomeform.TopLevel = False
        MainPanel.Controls.Clear()
        MainPanel.Controls.Add(staffhomeform)
        staffhomeform.Show()
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs)
        Dim Stocks As New Stocks()
        Stocks.TopLevel = False
        MainPanel.Controls.Clear()
        MainPanel.Controls.Add(Stocks)
        Stocks.Show()
    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs)
        Dim result As DialogResult
        result = MessageBox.Show("If you exit now, your account will automatically logout, do you still want to continue?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' User clicked "Yes" - place your code here for the "Yes" case
            MessageBox.Show("Account Logged out successfully!")
            heropage.Show()
            Me.Hide()

        Else
            ' User clicked "No" or closed the message box - place your code here for the "No" or other cases
            MessageBox.Show("It seems like you accidentally pressed the exit button.")
        End If

    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Dim sukicardUsers As New SukiCardUsers()
        sukicardUsers.TopLevel = False
        MainPanel.Controls.Clear()
        MainPanel.Controls.Add(sukicardUsers)
        sukicardUsers.Show()
    End Sub

    Private Sub Guna2Separator1_Click(sender As Object, e As EventArgs) Handles Guna2Separator1.Click

    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        Dim inventorymanagement As New Inventorymanagement()
        inventorymanagement.TopLevel = False
        MainPanel.Controls.Clear()
        MainPanel.Controls.Add(inventorymanagement)
        inventorymanagement.Show()
    End Sub
End Class
