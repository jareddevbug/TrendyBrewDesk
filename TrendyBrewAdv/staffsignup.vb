Imports System.Text.RegularExpressions
Imports MongoDB.Bson
Imports MongoDB.Driver
Public Class staffsignup

    Dim constring As String = "mongodb+srv://TrendyBrewSys:UfAGLEfLrRT01CMZ@trendycluster1.9ohrmbf.mongodb.net/?retryWrites=true&w=majority"
    Dim client As MongoClient = New MongoClient(constring)
    Dim database As IMongoDatabase = client.GetDatabase("SystemUsers")
    Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)("ShopSideAccounts")

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Staffsignin.Show()
        Me.Hide()
    End Sub

    Private Sub staffsignup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub

    Function PasswordMeetsRequirements(password As String) As Boolean
        Dim pattern As String = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).+$"
        Dim isMatch As Boolean = Regex.IsMatch(password, pattern)
        Return isMatch
    End Function

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim Email As String = TextBox1.Text
        Dim Password As String = TextBox3.Text
        Dim Fullname As String = TextBox2.Text

        Dim filter = MongoDB.Driver.Builders(Of BsonDocument).Filter.Eq(Of String)("Email", Email)
        Dim result As BsonDocument = collection.Find(filter).FirstOrDefault()

        If result IsNot Nothing Then
            MessageBox.Show("Email already exists!")
        ElseIf String.IsNullOrEmpty(Email) OrElse String.IsNullOrEmpty(Password) Then
            MessageBox.Show("Please input credentials first.")
        ElseIf Not PasswordMeetsRequirements(Password) Then
            MessageBox.Show("Password should contain at least one uppercase letter, one lowercase letter, and one number.")
        Else
            Dim document As BsonDocument = New BsonDocument()
            document.Add("Email", Email)
            document.Add("Password", Password)
            document.Add("Fullname", Fullname)
            document.Add("Status", "")
            document.Add("Reputation", "")
            collection.InsertOne(document)
            MessageBox.Show("Account created successfully!")
        End If

        Staffsignin.Show()
        Me.Hide()

    End Sub
End Class