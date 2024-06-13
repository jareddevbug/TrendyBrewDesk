Public Class loadingscr
    Private loadingAnimationCounter As Integer = 0
    Private soundPlayer As New System.Media.SoundPlayer("C:\Users\mvgui\OneDrive\Desktop\ZYFILES\Visual Basic Files\Capstone - Trendy Brew Files\mixkit-intro-transition-1146.wav")

    Private Sub loadingscr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ' Expand the Panel's width until it reaches 765
        If LoadingPanel.Width < 765 Then
            LoadingPanel.Width += 10 ' Adjust the increment as needed

            If LoadingPanel.Width <= 200 Then
                Label1.Text = "Loading resources.."
            End If
            If LoadingPanel.Width > 200 And LoadingPanel.Width < 500 Then
                Label1.Text = "Unpacking services.."

            End If
            If LoadingPanel.Width > 500 And LoadingPanel.Width < 765 Then
                Label1.Text = "System is ready.."

            End If
        Else
            '' If the width reaches 765, stop the Timer
            'Timer1.Stop()
            'soundPlayer.Play()
            heropage.Show()

            Me.Hide()

        End If
    End Sub
End Class