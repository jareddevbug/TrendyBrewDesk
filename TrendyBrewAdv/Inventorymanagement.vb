Imports System.Drawing.Printing
Imports MongoDB.Bson
Imports MongoDB.Driver
Public Class Inventorymanagement

    'print variable'
    Private InfoToPrint As String
    Private dataToPrint As String
    Private analysis As String
    '--GLOBAL VARIABLES--'
    Dim CoffeeFromDb As Integer
    Dim SnacksFromDb As Integer
    Dim SpecialsFromDb As Integer

    Dim TotalProdSales As Integer

    Dim CoffeeTotalExpenses As String
    Dim SnacksTotalExpenses As String
    Dim SpecialsTotalExpenses As String

    Dim TargetEarningsTotal As Integer

    Dim cGrowth As String
    Dim snGrowth As String
    Dim spGrowth As String
    'Retrieve ko ng Total Sales by month'

    Dim CoffeeFromDbPercent As Integer
    Dim SnacksFromDbPercent As Integer
    Dim SpecialsFromDbPercent As Integer


    Private client As MongoClient
    Private database As IMongoDatabase

    Public Sub New()
        InitializeComponent()

        Dim constring As String = "mongodb+srv://TrendyBrewSys:UfAGLEfLrRT01CMZ@trendycluster1.9ohrmbf.mongodb.net/?retryWrites=true&w=majority"
        Dim client As MongoClient = New MongoClient(constring)
        Dim database As IMongoDatabase = client.GetDatabase("TrendyShop")
        Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)("ProductsDb")
    End Sub
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged, NumericUpDown3.ValueChanged, NumericUpDown2.ValueChanged
        Dim numericValue1 As Integer = CInt(NumericUpDown1.Value)
        Dim numericValue2 As Integer = CInt(NumericUpDown2.Value)
        Dim numericValue3 As Integer = CInt(NumericUpDown3.Value)

        ' Set the value of the circular progress bar
        Guna2CircleProgressBar1.Value = numericValue1
        Guna2CircleProgressBar2.Value = numericValue2
        Guna2CircleProgressBar3.Value = numericValue3

    End Sub
    Private Sub Inventorymanagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "mongodb+srv://TrendyBrewSys:UfAGLEfLrRT01CMZ@trendycluster1.9ohrmbf.mongodb.net/?retryWrites=true&w=majority"
        Dim dbName As String = "TrendyShop"

        Dim client As New MongoClient(connectionString)

        ' Access the MongoDB database
        Dim database As IMongoDatabase = client.GetDatabase(dbName)

        ' Access the collection you want to update documents in
        Dim collectionName As String = "ProductsDb"
        Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionName)

        ' Define the filter to find the document by a specific field, e.g., "UID"
        Dim find As String = "09664081067"
        Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of String)("UID", find)

        ' Retrieve the document from the database using the defined filter
        Dim document = collection.Find(filter).FirstOrDefault()

        If document IsNot Nothing Then
            Dim coffeeValue As Integer = document("Coffee").ToInt32()
            Dim Snacks As Integer = document("Snacks").ToInt32()
            Dim Specials As Integer = document("Specials").ToInt32()

            NumericUpDown1.Value = coffeeValue
            NumericUpDown2.Value = Snacks
            NumericUpDown3.Value = Specials
        Else
            ' Handle the case where no data is found in the database.
        End If
        'ProgressBars'
        Call RetrieveCoffeeSnacksSpecials()
        Call RetrieveProducts()
    End Sub

    Private Sub Guna2Button10_Click(sender As Object, e As EventArgs) Handles Guna2Button10.Click
        Try
            Dim connectionString As String = "mongodb+srv://TrendyBrewSys:UfAGLEfLrRT01CMZ@trendycluster1.9ohrmbf.mongodb.net/?retryWrites=true&w=majority"
            Dim dbName As String = "TrendyShop"

            Dim client As New MongoClient(connectionString)

            ' Access the MongoDB database
            Dim database As IMongoDatabase = client.GetDatabase(dbName)

            ' Access the collection you want to update documents in
            Dim collectionName As String = "ProductsDb"
            Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionName)

            ' Parse the ObjectId from the input TextBox
            Dim find As String = "09664081067"
            Dim coffeeValue As Integer = CInt(NumericUpDown1.Text)
            Dim SnackValue As Integer = CInt(NumericUpDown2.Text) ' Assuming you have another NumericUpDown for Tea
            Dim SpecialValue As Integer = CInt(NumericUpDown3.Text) ' Assuming you have another NumericUpDown for Sugar

            ' Define the filter to find the document by ObjectId
            Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of String)("UID", find)

            ' Define the update operation to set the values of fields
            Dim update As UpdateDefinition(Of BsonDocument) = Builders(Of BsonDocument).Update.
                Set(Function(doc) doc("Coffee"), coffeeValue).
                Set(Function(doc) doc("Snacks"), SnackValue).
                Set(Function(doc) doc("Specials"), SpecialValue)

            ' Perform the update operation
            collection.UpdateOne(filter, update)


        Catch ex As Exception
            ' Handle exceptions
        End Try
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        dataToPrint = "Total Coffee Sales: -------------------------------" & CoffeeFromDb & vbCrLf &
                      "Total Snacks Sales: -------------------------------" & SnacksFromDb & vbCrLf &
                      "Total Specials Sales: -----------------------------" & SpecialsFromDb & vbCrLf &
                      "---------------------------------------------------" & vbCrLf &
                      "Total Sales: --------------------------------------" & TotalProdSales

        InfoToPrint = "Target Earnings: ----------------------------------" & TargetEarnings.Text & vbCrLf &
                      "Coffee Expenses: ----------------------------------" & CoffeeExpenses.Text & vbCrLf &
                      "Snacks Expenses: ----------------------------------" & SnacksExpenses.Text & vbCrLf &
                      "Specials Expenses: --------------------------------" & SpecialsExpenses.Text

        analysis = "The growth for coffee this month is: ----------- " & cGrowth & vbCrLf &
                        "The growth for snacks this month is: ----------- " & snGrowth & vbCrLf &
                        "The growth for specials this month is: --------- " & spGrowth & vbCrLf

        Dim printDialog As New PrintDialog()

        ' Set the paper size to A4
        Dim paperSize As New PaperSize("A4", 827, 1169) ' A4 size in hundredths of an inch (8.27 x 11.69 inches)
        printDialog.PrinterSettings.DefaultPageSettings.PaperSize = paperSize

        If printDialog.ShowDialog() = DialogResult.OK Then
            PrintDocument1.PrinterSettings = printDialog.PrinterSettings
            PrintDocument1.Print()
        End If

    End Sub

    Private Sub RetrieveCoffeeSnacksSpecials()
        Try
            ' MongoDB connection string and database name
            Dim connectionString As String = "mongodb+srv://TrendyBrewSys:UfAGLEfLrRT01CMZ@trendycluster1.9ohrmbf.mongodb.net/?retryWrites=true&w=majority" ' Replace with your MongoDB connection string
            Dim client As New MongoClient(connectionString)
            Dim database As IMongoDatabase = client.GetDatabase("TrendyBrewMonthlySales") ' Replace with your database name

            ' Determine the current month
            Dim currentMonth As String = DateTime.Now.ToString("MMMM")

            ' Construct the collection name
            Dim collectionName As String = "MonthlySales" & DateTime.Now.Year

            ' Get a reference to the collection
            Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionName)

            ' Define the filter to find the document for the current month
            Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("Sales", currentMonth)

            ' Projection to retrieve only the fields you are interested in (Coffee, Snacks, Specials)
            Dim projection = Builders(Of BsonDocument).Projection.Include("Coffee").Include("Snacks").Include("Specials").Include("Durian Capuccino").Include("Bangsilog").Include("Chicken Pastil").Include("Chocnut Latte").Include("Cornsilog").Include("Enseymada").Include("Longsilog").Include("Malunggay Latte").Include("Pandesal").Include("Pinoy Lumpia").Include("Rainnbow Latte").Include("Rice Coffee").Include("Rose Latte").Include("Tapsilog").Include("Tocolog").Include("Turon")

            ' Find the document and project the specific fields
            Dim document = collection.Find(filter).Project(projection).FirstOrDefault()

            If document IsNot Nothing Then

                Dim coffeeTotal As Integer = document("Coffee").AsInt32
                Dim snacksTotal As Integer = document("Snacks").AsInt32
                Dim specialsTotal As Integer = document("Specials").AsInt32

                ' Do something with the retrieved values (e.g., display them in labels or textboxes)
                CoffeeFromDb = CInt(coffeeTotal.ToString())
                SnacksFromDb = CInt(snacksTotal.ToString())
                SpecialsFromDb = CInt(specialsTotal.ToString())

            Else
                MessageBox.Show("Document not found for the current month.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RetrieveProducts()
        Try

            ' MongoDB connection string and database name
            Dim connectionString As String = "mongodb+srv://TrendyBrewSys:UfAGLEfLrRT01CMZ@trendycluster1.9ohrmbf.mongodb.net/?retryWrites=true&w=majority" ' Replace with your MongoDB connection string
            Dim client As New MongoClient(connectionString)
            Dim database As IMongoDatabase = client.GetDatabase("TrendyBrewMonthlySales") ' Replace with your database name

            ' Determine the current month
            Dim currentMonth As String = DateTime.Now.ToString("MMMM")

            ' Construct the collection name
            Dim collectionName As String = "MonthlySales" & DateTime.Now.Year

            ' Get a reference to the collection
            Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionName)

            ' Define the filter to find the document for the current month
            Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("Sales", currentMonth)

            ' Projection to retrieve only the fields you are interested in (Coffee, Snacks, Specials)
            Dim projection = Builders(Of BsonDocument).Projection.Include("Coffee").Include("Snacks").Include("Specials").Include("Durian Capuccino").Include("Bangsilog").Include("Chicken Pastil").Include("Chocnut Latte").Include("Cornsilog").Include("Enseymada").Include("Longsilog").Include("Malunggay Latte").Include("Pandesal").Include("Pinoy Lumpia").Include("Rainbow Latte").Include("Rice Coffee").Include("Rose Latte").Include("Tapsilog").Include("Tocolog").Include("Turon")

            ' Find the document and project the specific fields
            Dim document = collection.Find(filter).Project(projection).FirstOrDefault()
            ' Your existing MongoDB connection code here...

            ' Define the list of product names you want to retrieve
            Dim productNamesToRetrieve As New List(Of String) From {
            "Durian Capuccino",
            "Bangsilog",
            "Chicken Pastil",
            "Chocnut Latte",
            "Cornsilog",
            "Enseymada",
            "Longsilog",
            "Malunggay Latte",
            "Pandesal",
            "Pinoy Lumpia",
            "Rainbow Latte",
            "Rice Coffee",
            "Rose Latte",
            "Tapsilog",
            "Tocolog",
            "Turon"
        }

            ' Create a dictionary with variable prices for each product
            Dim productPrices As New Dictionary(Of String, Decimal)
            productPrices.Add("Durian Capuccino", 35)
            productPrices.Add("Bangsilog", 65)
            productPrices.Add("Chicken Pastil", 65)
            productPrices.Add("Chocnut Latte", 35)
            productPrices.Add("Cornsilog", 65)
            productPrices.Add("Enseymada", 6)
            productPrices.Add("Longsilog", 65)
            productPrices.Add("Malunggay Latte", 30)
            productPrices.Add("Pandesal", 3)
            productPrices.Add("Pinoy Lumpia", 15)
            productPrices.Add("Rainbow Latte", 50)
            productPrices.Add("Rice Coffee", 25)
            productPrices.Add("Rose Latte", 40)
            productPrices.Add("Tapsilog", 65)
            productPrices.Add("Tocolog", 65)
            productPrices.Add("Turon", 15)

            ' Add prices for the other products as needed

            ' Retrieve product sales data from MongoDB
            ' ... (your existing code to retrieve sales data)

            If document IsNot Nothing Then
                ' Create a list to store the product names and their corresponding sales data
                Dim productDataList As New List(Of KeyValuePair(Of String, Integer))

                ' Iterate through the product names and retrieve their sales data
                For Each productName As String In productNamesToRetrieve
                    Dim productTotal As Integer = document(productName).AsInt32
                    productDataList.Add(New KeyValuePair(Of String, Integer)(productName, productTotal))
                Next

                ' Iterate through the product data and add it to the ListView
                For Each productData In productDataList
                    Dim item As New ListViewItem(productData.Key) ' Product Name
                    item.SubItems.Add(productData.Value.ToString()) ' Sold Count

                    ' Retrieve the price for the product from the dictionary
                    Dim price As Decimal
                    If productPrices.TryGetValue(productData.Key, price) Then
                        item.SubItems.Add(price.ToString("C")) ' Add Price as a sub-item (formatted as currency)
                    Else
                        ' Handle the case where the price is not found (you can display a default value or handle it as needed)
                        item.SubItems.Add("N/A")
                    End If

                    ListView1.Items.Add(item)

                Next
            Else
                MessageBox.Show("Document not found for the current month.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox1.SelectedIndexChanged
        Dim selectedItem As String = Guna2ComboBox1.SelectedItem.ToString()
        Dim currentMonth As String = DateTime.Now.ToString("MMMM")

        ' Determine the ProgressBar to update based on the current month
        Dim progressBarToUse As Guna.UI2.WinForms.Guna2VProgressBar = GetMonthProgressBar(currentMonth)

        If progressBarToUse IsNot Nothing Then
            ' Retrieve and display the value in the selected ProgressBar
            Dim value As Integer = GetValueForSelectedItem(selectedItem) ' Replace with your logic

            progressBarToUse.Value = value
        End If

        If selectedItem = "Coffee" Then
            Guna2HtmlToolTip1.SetToolTip(progressBarToUse, "Total: " & CoffeeFromDb)
            Label25.Text = "Coffee Sales"
        ElseIf selectedItem = "Snacks" Then
            Guna2HtmlToolTip1.SetToolTip(progressBarToUse, "Total: " & SnacksFromDb)
            Label25.Text = "Snacks Sales"
        Else
            Guna2HtmlToolTip1.SetToolTip(progressBarToUse, "Total: " & SpecialsFromDb)
            Label25.Text = "Specials Sales"
        End If

        Label24.Text = "Target Earnings: " & TargetEarnings.Text
        TotalProdSales = CoffeeFromDb + SnacksFromDb + SpecialsFromDb
        If CoffeeFromDb < CInt(CoffeeExpenses.Text) Then
            cGrowth = "Bad"
        ElseIf CoffeeFromDb > CInt(CoffeeExpenses.Text) Then
            cGrowth = "Good"

        ElseIf CoffeeFromDb = CInt(CoffeeExpenses.Text) Then
            cGrowth = "No growth"
        End If

        If SnacksFromDb < CInt(SnacksExpenses.Text) Then
            snGrowth = "Bad"
        ElseIf SnacksFromDb > CInt(SnacksExpenses.Text) Then
            snGrowth = "Good"

        ElseIf SnacksFromDb = CInt(SnacksExpenses.Text) Then
            snGrowth = "No growth"
        End If

        If SpecialsFromDb < CInt(SpecialsExpenses.Text) Then
            spGrowth = "Bad"
        ElseIf SpecialsFromDb > CInt(SpecialsExpenses.Text) Then
            spGrowth = "Good"

        ElseIf SpecialsFromDb = CInt(SpecialsExpenses.Text) Then
            spGrowth = "No growth"
        End If
    End Sub
    Private Function GetMonthProgressBar(currentMonth As String) As Guna.UI2.WinForms.Guna2VProgressBar
        ' Based on the current month, return the corresponding Guna2 ProgressBar
        Select Case currentMonth
            Case "January"
                Return Janbar
            Case "February"
                Return FebBar
            Case "March"
                Return MarBar
            Case "April"
                Return AprBar
            Case "May"
                Return MayBar
            Case "June"
                Return JunBar
            Case "July"
                Return JulBar
            Case "August"
                Return AugBar
            Case "September"
                Return SepBar
            Case "October"
                Return OctBar
            Case "November"
                Return NovBar
            Case "December"
                Return DecBar
            Case Else
                Return Nothing ' Handle this case as needed
        End Select
    End Function
    Private Function GetValueForSelectedItem(selectedItem As String) As Integer
        ' Replace this function with your logic to retrieve the value for the selected item
        ' You may retrieve the value from a variable, database, or elsewhere
        ' Here's an example for illustration:

        Select Case selectedItem
            Case "Coffee"
                Return CInt(CoffeeFromDb / CInt(CoffeeExpenses.Text) * 100)

            Case "Snacks"
                Return CInt(SnacksFromDb / CInt(SnacksExpenses.Text) * 100)
            Case "Specials"
                Return CInt(SpecialsFromDb / CInt(SpecialsExpenses.Text) * 100)
            Case Else
                Return 0 ' Handle this case as needed
        End Select
    End Function
    '---------------PRINTING-----------------'
    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim currentMonth As String = DateTime.Now.ToString("MMMM")
        ' Create a Font for the printed text
        Dim printFont As New Font("Arial", 12)
        ' Calculate a 1-inch left margin (1 inch * 96 DPI)
        Dim leftMargin As Single = 96  ' 1 inch in hundredths of an inch
        ' Create a RectangleF to define the printable area with the custom left margin
        Dim rect As New RectangleF(leftMargin, e.MarginBounds.Top, e.MarginBounds.Width - leftMargin, e.MarginBounds.Height)
        Dim headerText As String = "Trendy Brew - Analytics of Sales of:" & currentMonth ' Header text
        e.Graphics.DrawString(headerText, printFont, Brushes.Black, rect)
        rect.Y += printFont.GetHeight(e.Graphics) * 6  ' Add space after header
        ' Adjust the text alignment to be left within the centered content
        Dim format As New StringFormat()
        format.Alignment = StringAlignment.Near
        ' Print the data
        e.Graphics.DrawString(dataToPrint, printFont, Brushes.Black, rect, format)
        rect.Y += printFont.GetHeight(e.Graphics) * 10
        e.Graphics.DrawString(InfoToPrint, printFont, Brushes.Black, rect, format)
        rect.Y += printFont.GetHeight(e.Graphics) * 8
        e.Graphics.DrawString(analysis, printFont, Brushes.Black, rect, format)
        ' Check if there are more pages to print
        e.HasMorePages = False
    End Sub
End Class

