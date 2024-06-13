Imports MongoDB.Bson
Imports MongoDB.Driver
Public Class adminreg

    Dim constring As String = "mongodb+srv://TrendyBrewSys:UfAGLEfLrRT01CMZ@trendycluster1.9ohrmbf.mongodb.net/?retryWrites=true&w=majority"
    Dim client As MongoClient = New MongoClient(constring)
    Dim database As IMongoDatabase = client.GetDatabase("SystemUsers")
    Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)("AdminAccounts")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Email As String = TextBox2.Text
        Dim Rfid As String = TextBox3.Text
        Dim Fullname As String = TextBox1.Text

        Dim filter = MongoDB.Driver.Builders(Of BsonDocument).Filter.Eq(Of String)("Email", Email)
        Dim result As BsonDocument = collection.Find(filter).FirstOrDefault()

        If result IsNot Nothing Then
            MessageBox.Show("Email already exists!")
        ElseIf String.IsNullOrEmpty(Email) OrElse String.IsNullOrEmpty(Fullname) Then
            MessageBox.Show("Please input credentials first.")
        Else
            Dim document As BsonDocument = New BsonDocument()
            document.Add("Email", Email)
            document.Add("Rfid", rfid)
            document.Add("Fullname", Fullname)
            collection.InsertOne(document)
            MessageBox.Show("Account created successfully!")

            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click


    End Sub
End Class