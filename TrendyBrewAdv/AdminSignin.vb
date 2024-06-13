Imports System.Net
Imports System.Net.Mail
Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class AdminSignin
    Private countdown As Integer = 30 ' Initial countdown value
    Private isCountingDown As Boolean = False

    Dim adminrandomCode As String


    'db conn'
    Dim constring As String = "mongodb+srv://TrendyBrewSys:UfAGLEfLrRT01CMZ@trendycluster1.9ohrmbf.mongodb.net/?retryWrites=true&w=majority"
    Dim client As MongoClient = New MongoClient(constring)
    Dim database As IMongoDatabase = client.GetDatabase("SystemUsers")
    Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)("AdminAccounts")


    Public Sub New()
        InitializeComponent()
        ' Disable the Timer and set the button text
        Timer1.Enabled = False
    End Sub

    Private Sub generatecode()
        Dim random As New Random()

        ' Generate a random 6-digit number
        Dim randomNumber As Integer = random.Next(100000, 999999)
        adminrandomCode = CStr(randomNumber)
    End Sub

    Private Sub verifyAdminuser()

        Dim senderEmail As String = "trendybrewsys@gmail.com"
        Dim senderPassword As String = "qmbv jcoj gves kvhn"
        ' Recipient's email address
        Dim recipientEmail As String = TextBox2.Text

        ' Create a new MailMessage object
        Dim mail As New MailMessage()

        ' Set the sender and recipient addresses
        mail.From = New MailAddress(senderEmail)
        mail.To.Add(TextBox2.Text)

        ' Set the subject and body of the email
        mail.Subject = "TrendyBrew - Signin security"
        mail.Body = "Good Day, your signin code is " + adminrandomCode


        ' Set the SMTP client details
        Dim smtp As New SmtpClient("smtp.gmail.com")
        smtp.Port = 587
        smtp.EnableSsl = True
        smtp.Credentials = New NetworkCredential(senderEmail, senderPassword)

        Try
            ' Send the email
            smtp.Send(mail)
            MessageBox.Show("An email was send to your email acccount, please verify that it was your account.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error sending email: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Dispose of the attachment to release resources

        End Try
    End Sub


    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        'ADMIN SIGNIN HERE'
        generatecode()


        Dim Email As String = TextBox2.Text
        Dim fullName As String = TextBox1.Text
        Dim RFID As String = TextBox3.Text

        Debug.WriteLine($"Email: {Email}, Password: {fullName}")

        Dim filter = Builders(Of BsonDocument).Filter.And(
Builders(Of BsonDocument).Filter.Eq(Of String)("Email", Email.Trim()),
Builders(Of BsonDocument).Filter.Eq(Of String)("Fullname", fullName.Trim()),
Builders(Of BsonDocument).Filter.Eq(Of String)("Rfid", RFID.Trim())
)


        ' Print the filter as a JSON string
        Debug.WriteLine($"MongoDB Query: {filter.ToJson()}")

        Try
            Dim result As BsonDocument = collection.Find(filter).FirstOrDefault()

            If result IsNot Nothing Then

                verifyAdminuser()

                'vbYesNo here'


                ' Display an input box and get user input
                Dim userInput As String = InputBox("Please enter the secret code:", "User Input", "Default Value")

                If userInput = adminrandomCode Then
                    MessageBox.Show("Login Success!")
                    Form2.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Invalid Code. Please Try again.")
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                    TextBox3.Text = ""

                End If
            Else
                MessageBox.Show("Login failed. Please make sure you are accessing the right account or you are entering the right email.")
            End If
        Catch ex As Exception
            MessageBox.Show($"Error executing MongoDB query: {ex.Message}")
        End Try




    End Sub

    Private Sub AdminSignin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class