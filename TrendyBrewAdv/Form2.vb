Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        ContactDevs.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim staffmanagement As New staffmanagement()
        staffmanagement.TopLevel = False
        MainPanel.Controls.Clear()
        MainPanel.Controls.Add(staffmanagement)
        staffmanagement.Show()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim inventorymanagement As New Inventorymanagement()
        inventorymanagement.TopLevel = False
        MainPanel.Controls.Clear()
        MainPanel.Controls.Add(inventorymanagement)
        inventorymanagement.Show()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        adminreg.Show()

    End Sub

    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs) Handles Guna2Button8.Click
        MessageBox.Show("Account logged out!")
        heropage.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button10_Click(sender As Object, e As EventArgs) Handles Guna2Button10.Click
        Dim staffordering As New staffordering()
        staffordering.TopLevel = False
        MainPanel.Controls.Clear()
        MainPanel.Controls.Add(staffordering)
        staffordering.Show()
    End Sub

    Private Sub Guna2Button9_Click(sender As Object, e As EventArgs) Handles Guna2Button9.Click
        Dim staffreservation As New staffreservation()
        staffreservation.TopLevel = False
        MainPanel.Controls.Clear()
        MainPanel.Controls.Add(staffreservation)
        staffreservation.Show()
    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
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

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        ScanRFID.Show()
        MessageBox.Show("Please scan the RIFD (Suki Card).", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Label2.Text = DateTime.Now.ToString()
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Me.Close()

    End Sub
End Class