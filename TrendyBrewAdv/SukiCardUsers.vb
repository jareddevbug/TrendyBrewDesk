Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class SukiCardUsers

    Private client As IMongoClient
    Private database As IMongoDatabase

    Public Sub New()
        InitializeComponent()
        InitializeMongoDB()
    End Sub



    Private Sub InitializeMongoDB()
        Dim connectionString As String = "mongodb+srv://TrendyBrewSys:UfAGLEfLrRT01CMZ@trendycluster1.9ohrmbf.mongodb.net/?retryWrites=true&w=majority"
        client = New MongoClient(connectionString)
        database = client.GetDatabase("TrendyShop")


    End Sub

    Private Sub AddDataToListView(rfid As String, fullname As String, sukipoints As String)
        Dim item As New ListViewItem(rfid)
        item.SubItems.Add(fullname)
        ListView1.Items.Add(item)
    End Sub

    Private Sub SaveDataToMongoDB(rfid As String, fullname As String)
        Dim collection = database.GetCollection(Of BsonDocument)("SukiCardsColl")
        Dim indexKeys = Builders(Of BsonDocument).IndexKeys.Ascending("RFID").Ascending("FullName")
        Dim uniqueIndex = New CreateIndexModel(Of BsonDocument)(indexKeys, New CreateIndexOptions() With {
        .Unique = True
    })
        collection.Indexes.CreateOne(uniqueIndex)

        Dim document As New BsonDocument()
        document("RFID") = rfid
        document("FullName") = fullname

        collection.InsertOne(document)
    End Sub


    Private Sub RemoveDataFromMongoDB(rfid As String, fullname As String, sukipoints As String)
        Dim collection = database.GetCollection(Of BsonDocument)("SukiCardsColl")

        Dim filter = Builders(Of BsonDocument).Filter.And(
        Builders(Of BsonDocument).Filter.Eq(Of String)("RFID", rfid),
        Builders(Of BsonDocument).Filter.Eq(Of String)("FullName", fullname)
    )

        collection.DeleteMany(filter) ' Use DeleteMany to remove all matching documents
    End Sub




    Private Sub LoadDataFromMongoDBAndPopulateListView()
        Dim collection = database.GetCollection(Of BsonDocument)("SukiCardsColl")

        Dim filter = Builders(Of BsonDocument).Filter.Empty ' You can specify a filter if needed

        Dim documents = collection.Find(filter).ToList()

        For Each document As BsonDocument In documents
            Dim rfid As String = document("RFID").AsString
            Dim fullname As String = document("FullName").AsString
            Dim sukipoints As String = document("sukiPoints").AsString

            Dim item As New ListViewItem(rfid)
            item.SubItems.Add(fullname)
            item.SubItems.Add(sukipoints)
            ListView1.Items.Add(item)

        Next
    End Sub

    Private Sub RemoveDataFromListView()
        For Each item As ListViewItem In ListView1.SelectedItems
            Dim rfid As String = item.Text
            Dim fullname As String = item.SubItems(1).Text
            Dim sukipoints As String = item.SubItems(2).Text

            ' Remove the item from the ListView
            item.Remove()

            ' Remove the corresponding data from the database
            RemoveDataFromMongoDB(rfid, fullname, sukipoints)
        Next
    End Sub


    Private Sub SukiCardUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataFromMongoDBAndPopulateListView()
    End Sub





    Private Sub AddDataToListViewAndMongoDB(rfid As String, fullname As String, sukipoints As String)
        ' Check if the combination of RFID and Full Name already exists
        Dim collection = database.GetCollection(Of BsonDocument)("SukiCardsColl")
        Dim filter = Builders(Of BsonDocument).Filter.And(
        Builders(Of BsonDocument).Filter.Eq(Of String)("RFID", rfid),
        Builders(Of BsonDocument).Filter.Eq(Of String)("FullName", fullname),
        Builders(Of BsonDocument).Filter.Eq(Of String)("sukiPoints", sukipoints)
    )

        If collection.Find(filter).CountDocuments() = 0 Then
            ' Combination does not exist, so we can add it
            AddDataToListView(rfid, fullname, sukipoints)

            Dim document As New BsonDocument()
            document("RFID") = rfid
            document("FullName") = fullname
            document("sukiPoints") = sukipoints

            collection.InsertOne(document)


        Else
            MessageBox.Show("RFID and Full Name combination already exists.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        LoadDataFromMongoDBAndPopulateListView()
    End Sub




    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dim rfid As String = Guna2TextBox2.Text
        Dim fullname As String = Guna2TextBox1.Text
        Dim sukipoints As String = Guna2TextBox3.Text


        ' Add data to the ListView and MongoDB if it's not a duplicate
        AddDataToListViewAndMongoDB(rfid, fullname, sukipoints)
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        RemoveDataFromListView()
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Me.Close()

    End Sub
End Class