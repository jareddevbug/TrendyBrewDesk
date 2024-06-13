Public Class ScanRFID

    Private Sub ScanRFID_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        Me.Hide()

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        SukiCardUsers.Show()
        Me.Hide()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        MessageBox.Show("Hehe")
    End Sub
End Class