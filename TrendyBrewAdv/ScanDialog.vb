Public Class ScanDialog
    Public Property qrValidation As Boolean
    Public Sub AccessVariable()
        Dim reserveInstance As New staffreservation()
        Dim qrValue As String = reserveInstance.qrCheck

        ' Use the value as needed...

        If Guna2TextBox1.Text = qrValue Then
            qrValidation = True
            MessageBox.Show("QR matched. You can now delete the selected row")
        Else
            qrValidation = False
            MessageBox.Show("QR didn't match. Please try again.")
        End If
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox1.TextChanged
        AccessVariable()
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Me.Close()

    End Sub
End Class
