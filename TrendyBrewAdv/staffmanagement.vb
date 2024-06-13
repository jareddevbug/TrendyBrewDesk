Imports MongoDB.Bson
Imports MongoDB.Driver
Public Class staffmanagement
    Private client As MongoClient
    Private database As IMongoDatabase
    Private collection As IMongoCollection(Of BsonDocument)


    Public Sub New()
        InitializeComponent()

        ' Initialize MongoDB client and connect to your MongoDB server
        client = New MongoClient("mongodb+srv://TrendyBrewSys:UfAGLEfLrRT01CMZ@trendycluster1.9ohrmbf.mongodb.net/?retryWrites=true&w=majority")
        database = client.GetDatabase("SystemUsers")
        collection = database.GetCollection(Of BsonDocument)("ShopSideAccounts")

        ' Set up the Timer control to periodically update the ListView
        Timer1.Start()
    End Sub

    Private Sub RefreshListView()
        ' Create a filter (you can adjust this based on your criteria)
        Dim filter = Builders(Of BsonDocument).Filter.Empty

        ' Query MongoDB and retrieve data
        Dim cursor = collection.Find(filter).ToCursor()

        ' Clear existing items in the ListView
        ListView1.Items.Clear()

        ' Iterate through the cursor and add data to the ListView
        For Each document As BsonDocument In cursor.ToEnumerable()
            Dim item As New ListViewItem(document("_id").ToString()) ' Assuming "_id" is the key for your primary identifier
            item.SubItems.Add(document("Email").ToString())
            item.SubItems.Add(document("Password").ToString())
            item.SubItems.Add(document("Fullname").ToString())
            item.SubItems.Add(document("Status").ToString())
            item.SubItems.Add(document("Reputation").ToString())


            ListView1.Items.Add(item)
        Next
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        RefreshListView()

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Guna2MessageDialog1.Show()

    End Sub
End Class