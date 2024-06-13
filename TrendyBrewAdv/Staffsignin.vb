Imports System.Net
Imports System.Net.Mail
Imports MongoDB.Bson
Imports MongoDB.Driver


Public Class Staffsignin
    Private countdown As Integer = 30 ' Initial countdown value
    Private isCountingDown As Boolean = False

    Dim randomCode As String


    'db conn'
    Dim constring As String = "mongodb+srv://TrendyBrewSys:UfAGLEfLrRT01CMZ@trendycluster1.9ohrmbf.mongodb.net/?retryWrites=true&w=majority"
    Dim client As MongoClient = New MongoClient(constring)
    Dim database As IMongoDatabase = client.GetDatabase("SystemUsers")
    Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)("ShopSideAccounts")

    Public Sub New()
        InitializeComponent()
        ' Disable the Timer and set the button text
        Timer1.Enabled = False
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub generatecode()
        Dim random As New Random()

        ' Generate a random 6-digit number
        Dim randomNumber As Integer = random.Next(100000, 999999)
        randomCode = CStr(randomNumber)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim emailvalue = TextBox2.Text

        If Not isCountingDown Then
            isCountingDown = True
            Button3.Enabled = False ' Disable the button during countdown
            Timer1.Start()

            generatecode()

        End If

        Dim senderEmail As String = "trendybrewsys@gmail.com"
        Dim senderPassword As String = "qmbv jcoj gves kvhn"
        ' Recipient's email address
        Dim recipientEmail As String = emailValue

        ' Create a new MailMessage object
        Dim mail As New MailMessage()

        ' Set the sender and recipient addresses
        mail.From = New MailAddress(senderEmail)
        mail.To.Add(emailValue)

        ' Set the subject and body of the email
        mail.Subject = "TrendyBrew - Signin security"
        mail.Body = "Good Day, your signin code is " + randomCode


        ' Set the SMTP client details
        Dim smtp As New SmtpClient("smtp.gmail.com")
        smtp.Port = 587
        smtp.EnableSsl = True
        smtp.Credentials = New NetworkCredential(senderEmail, senderPassword)

        Try
            ' Send the email
            smtp.Send(mail)
            MessageBox.Show("Email sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error sending email: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Dispose of the attachment to release resources

        End Try




    End Sub

    Private Sub Staffsignin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        countdown -= 1

        If countdown >= 0 Then
            Button3.Text = countdown.ToString()
        Else
            Timer1.Stop()
            Button3.Text = "Resend"
            Button3.Enabled = True ' Re-enable the button when countdown is complete
            isCountingDown = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        Dim Email As String = TextBox2.Text
        Dim Password As String = TextBox3.Text

        Debug.WriteLine($"Email: {Email}, Password: {Password}")

        Dim filter = Builders(Of BsonDocument).Filter.And(
Builders(Of BsonDocument).Filter.Eq(Of String)("Email", Email.Trim()),
Builders(Of BsonDocument).Filter.Eq(Of String)("Password", Password.Trim())
)


        ' Print the filter as a JSON string
        Debug.WriteLine($"MongoDB Query: {filter.ToJson()}")

        Try
            Dim result As BsonDocument = collection.Find(filter).FirstOrDefault()

            If result IsNot Nothing Then

                If TextBox1.Text = randomCode Then
                    MessageBox.Show("Login Success!")
                    Form1.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Invalid Code. Please Try again. " + randomCode)
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                    TextBox3.Text = ""

                End If
            Else
                MessageBox.Show("Invalid Username or Password." + Email + Password)
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show($"Error executing MongoDB query: {ex.Message}")
        End Try



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2HtmlLabel1_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel1.Click
        staffsignup.Show()
        Me.Hide()

    End Sub
End Class