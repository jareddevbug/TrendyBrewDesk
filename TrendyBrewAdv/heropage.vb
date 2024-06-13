Public Class heropage
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        staffsignup.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AdminSignin.Show()
        Me.Hide()

    End Sub
End Class