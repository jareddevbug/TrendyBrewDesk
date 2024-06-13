Imports System.Drawing.Printing
Imports MongoDB.Bson
Imports MongoDB.Driver
Public Class staffordering
    Dim printDocument As New PrintDocument()
    '--GLOBAL VARIABLES--'
    Dim CoffeeFromDb As Integer
    Dim SnacksFromDb As Integer
    Dim SpecialsFromDb As Integer
    'Retrieve ko ng Total Sales by month'

    Private Sub ScrollToPictureBox(picBox As PictureBox)
        If picBox IsNot Nothing Then
            ProductsPanel.ScrollControlIntoView(picBox)
        End If
    End Sub

    Private Sub Panel1_Scroll(sender As Object, e As ScrollEventArgs) Handles ProductsPanel.Scroll
        If e.ScrollOrientation = ScrollOrientation.VerticalScroll Then
            ProductsPanel.VerticalScroll.Value = e.NewValue
        End If
    End Sub

    '------------------------------------------------'
    Private productQuantityControls As New Dictionary(Of String, NumericUpDown)()
    Private MaxRowsAllowed As Integer = 10 ' Change this to your desired maximum number of rows

    Private Sub CalculateSubtotal()
        Dim Subtotal As Decimal = 0

        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(2).Value IsNot Nothing Then
                Subtotal += CDec(row.Cells(2).Value)
            End If
        Next
        Label13.Text = Subtotal.ToString
        Dim Total As String
        Dim shopevent As Int32 = 10
        Dim VAT As Int32 = 3
        If CheckBox1.Checked = True Then
            Total = CStr(Subtotal - shopevent + VAT)
            Label6.Text = Total
        ElseIf CheckBox1.Checked = False Then
            Total = CStr(Subtotal + VAT)
            Label6.Text = Total

        End If
        ' Now, you have the subtotal stored in the "Subtotal" variable.
        ' You can use it as needed in your code
    End Sub

    Dim CoffeeTotalQuantity As Integer = 0
    Dim SnacksTotalQuantity As Integer = 0
    Dim SpecialsTotalQuantity As Integer = 0

    Dim DurianCapuccino As Integer
    Dim RiceCoffee As Integer
    Dim RoseLatte As Integer
    Dim RainbowLatte As Integer
    Dim MalunggayLatte As Integer
    Dim ChocnutLatte As Integer
    Dim PinoyLumpia As Integer
    Dim Enseymada As Integer
    Dim Pandesal As Integer
    Dim Turon As Integer
    Dim Cornsilog As Integer
    Dim ChickenPastil As Integer
    Dim Tocilog As Integer
    Dim Bangsilog As Integer
    Dim Tapsilog As Integer
    Dim Longsilog As Integer

    Private Sub GetSpecificProductQuantities()
        ' Initialize all product quantities to 0
        DurianCapuccino = 0
        RiceCoffee = 0
        RoseLatte = 0
        RainbowLatte = 0
        MalunggayLatte = 0
        ChocnutLatte = 0
        PinoyLumpia = 0
        Enseymada = 0
        Pandesal = 0
        Turon = 0
        Cornsilog = 0
        ChickenPastil = 0
        Tocilog = 0
        Bangsilog = 0
        Tapsilog = 0
        Longsilog = 0

        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then ' Skip the empty row if present
                Dim productName As String = row.Cells("Description").Value.ToString()
                Dim quantity As Integer = CInt(row.Cells("Quantity").Value)

                ' Update the corresponding variable based on the product name
                Select Case productName
                    Case "Durian Capuccino"
                        DurianCapuccino += quantity
                    Case "Rice Coffee"
                        RiceCoffee += quantity
                    Case "Rose Latte"
                        RoseLatte += quantity
                    Case "Rainbow Latte"
                        RainbowLatte += quantity
                    Case "Malunggay Latte"
                        MalunggayLatte += quantity
                    Case "Chocnut Latte"
                        ChocnutLatte += quantity
                    Case "Pinoy Lumpia"
                        PinoyLumpia += quantity
                    Case "Enseymada"
                        Enseymada += quantity
                    Case "Pandesal"
                        Pandesal += quantity
                    Case "Turon"
                        Turon += quantity
                    Case "Cornsilog"
                        Cornsilog += quantity
                    Case "Chicken Pastil"
                        ChickenPastil += quantity
                    Case "Tocilog"
                        Tocilog += quantity
                    Case "Bangsilog"
                        Bangsilog += quantity
                    Case "Tapsilog"
                        Tapsilog += quantity
                    Case "Longsilog"
                        Longsilog += quantity
                End Select
            End If
        Next
    End Sub

    Private Sub CalculateTotalQuantities()

        Dim CoffeeTotalPrice As Integer = 0
        Dim SnacksTotalPrice As Integer = 0
        Dim SpecialsTotalPrice As Integer = 0

        ' Calculate the total ordered quantities for each product type
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(0).Value IsNot Nothing AndAlso row.Cells(1).Value IsNot Nothing Then
                Dim productName As String = row.Cells(0).Value.ToString()
                Dim quantity As Integer = CInt(row.Cells(1).Value)

                Dim prices As Integer = CInt(row.Cells(2).Value)

                ' Determine the type of the product and update the respective total quantity
                Select Case productName
                    Case "Durian Capuccino", "Rice Coffee", "Rose Latte", "Rainbow Latte", "Malunggay Latte", "Chocnut Latte"
                        CoffeeTotalQuantity += quantity
                        CoffeeTotalPrice += prices

                    Case "Pinoy Lumpia", "Enseymada", "Pandesal", "Turon"
                        SnacksTotalQuantity += quantity
                        SnacksTotalPrice += prices
                    Case "Cornsilog", "Chicken Pastil", "Tocilog", "Bangsilog", "Tapsilog", "Longsilog"
                        SpecialsTotalQuantity += quantity
                        SpecialsTotalPrice += prices
                        ' Add more cases for other product types if needed
                End Select
            End If
        Next

        ' Check if the ordered quantities exceed the available stock
        If CoffeeTotalQuantity > CInt(Label15.Text) Or SnacksTotalQuantity > CInt(Label17.Text) Or SpecialsTotalQuantity > CInt(Label19.Text) Then
            MessageBox.Show("Not Enough Stocks.")
        Else
            Label1.Text = CStr(CoffeeTotalPrice)
            Label23.Text = CStr(SnacksTotalPrice)
            Label25.Text = CStr(SpecialsTotalPrice)

            ' Subtract the ordered quantities from the available stock and update the labels
            Label15.Text = CStr(CInt(Label15.Text) - CoffeeTotalQuantity)
            Label17.Text = CStr(CInt(Label17.Text) - SnacksTotalQuantity)
            Label19.Text = CStr(CInt(Label19.Text) - SpecialsTotalQuantity)
            Call UpdateMongoDBDocument()
            Dim printPreviewDialog As New PrintPreviewDialog()
            printPreviewDialog.Document = printDocument
            printPreviewDialog.ShowDialog()
        End If
        '
    End Sub

    Private Sub staffordering_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeProductQuantityControls()
        DataGridView1.Columns.Add("Description", "Description")
        DataGridView1.Columns.Add("Quantity", "Quantity")
        DataGridView1.Columns.Add("Price", "Price")

        '-----------------------------------'
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

            Label15.Text = CStr(coffeeValue)
            Label17.Text = CStr(Snacks)
            Label19.Text = CStr(Specials)
        Else
            ' Handle the case where no data is found in the database.
        End If

        AddHandler printDocument.PrintPage, AddressOf PrintDocument1_PrintPage
    End Sub
    Private Sub InitializeProductQuantityControls()
        ' Coffee Products
        productQuantityControls.Add("Durian Capuccino", NumericUpDownDurianCapuccino)
        productQuantityControls.Add("Rice Coffee", NumericUpDownRiceCoffee)
        productQuantityControls.Add("Rose Latte", NumericUpDownRoseLatte)
        productQuantityControls.Add("Rainbow Latte", NumericUpDownRainbowLatte)
        productQuantityControls.Add("Malunggay Latte", NumericUpDownMalunggayLatte)
        productQuantityControls.Add("Chocnut Latte", NumericUpDownChocnutLatte)

        ' Snacks
        productQuantityControls.Add("Pinoy Lumpia", NumericUpDownPinoyLumpia)
        productQuantityControls.Add("Enseymada", NumericUpDownEnseymada)
        productQuantityControls.Add("Pandesal", NumericUpDownPandesal)
        productQuantityControls.Add("Turon", NumericUpDownTuron)

        ' Special Dishes
        productQuantityControls.Add("Cornsilog", NumericUpDownCornsilog)
        productQuantityControls.Add("Chicken Pastil", NumericUpDownChickenPastil)
        productQuantityControls.Add("Tocilog", NumericUpDownTocilog)
        productQuantityControls.Add("Bangsilog", NumericUpDownBangsilog)
        productQuantityControls.Add("Tapsilog", NumericUpDownTapsilog)
        productQuantityControls.Add("Longsilog", NumericUpDownLongsilog)
    End Sub
    ' Helper function to get the price of a product by its name
    Private Function GetPriceByProductName(productName As String) As Decimal
        ' Define the prices for each product
        Select Case productName
            Case "Durian Capuccino"
                Return 35
            Case "Rice Coffee"
                Return 25
            Case "Rose Latte"
                Return 40
            Case "Rainbow Latte"
                Return 50
            Case "Malunggay Latte"
                Return 30
            Case "Chocnut Latte"
                Return 35
            Case "Pinoy Lumpia"
                Return 15
            Case "Enseymada"
                Return 6
            Case "Pandesal"
                Return 3
            Case "Turon"
                Return 15
            Case "Cornsilog", "Chicken Pastil", "Tocilog", "Bangsilog", "Tapsilog", "Longsilog"
                Return 65
            Case Else
                Return 0 ' Handle cases where the product name is not recognized
        End Select
    End Function

    Private Sub CoffeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoffeeToolStripMenuItem.Click
        ScrollToPictureBox(PictureBox1)
    End Sub

    Private Sub SnacksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SnacksToolStripMenuItem.Click
        ScrollToPictureBox(PictureBox2)
    End Sub

    Private Sub SpecialsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpecialsToolStripMenuItem.Click
        ScrollToPictureBox(PictureBox3)
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim g As Graphics = e.Graphics
        Dim font As New Font("Arial", 8) ' Use "Arial" instead of "arial" for consistency
        Dim lineHeight As Single = font.GetHeight(g)
        Dim columnWidths As New List(Of Single)

        ' Define column headers and widths
        Dim headers As String() = {"Product", "Qty", "Total"} ' Adjust headers for brevity
        Dim widths As Single() = {100, 40, 60} ' Adjusted column widths for 58mm paper

        ' Calculate column positions and draw headers
        Dim x As Single = 6
        For i As Integer = 0 To headers.Length - 1
            g.DrawString(headers(i), font, Brushes.Black, x, 50) ' Adjust the vertical position for headers
            columnWidths.Add(widths(i))
            x += widths(i)
        Next

        ' Initialize the yOffset to the vertical position below the headers
        Dim yOffset As Single = 50 + lineHeight

        ' Loop through the DataGridView and draw the data
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then ' Skip the new row if it exists
                Dim productName As String = row.Cells(0).Value.ToString()
                Dim quantity As Integer = CInt(row.Cells(1).Value)
                Dim totalPrice As Decimal = CDec(row.Cells(2).Value)

                x = 2
                g.DrawString(productName, font, Brushes.Black, x, yOffset)
                x += columnWidths(0)

                g.DrawString(quantity.ToString(), font, Brushes.Black, x, yOffset)
                x += columnWidths(1)

                g.DrawString("$" & totalPrice.ToString(), font, Brushes.Black, x, yOffset)

                yOffset += lineHeight
            End If
        Next

        ' Calculate the total
        Dim total As Decimal = CDec(Label6.Text)

        ' Draw a line to separate data from total
        yOffset += 5 ' Adjusted spacing
        g.DrawLine(New Pen(Brushes.Black, 1), 10, yOffset, 150, yOffset) ' Adjusted line width and endpoint

        ' Draw the total
        yOffset += 5 ' Adjusted spacing
        g.DrawString("Total:", font, Brushes.Black, 10, yOffset)
        g.DrawString("$" & total.ToString(), font, Brushes.Black, 60, yOffset)

        ' Include the shop name at the top
        Dim shopName As String = " TrendyBrew.Ph" ' Change this to your shop's name
        Dim shopLoc As String = "Kasiglahan Vill. Rod. Rizal"
        g.DrawString(shopName, New Font("Verdana", 10), Brushes.Black, 7, 6)
        g.DrawString(shopLoc, New Font("Arial", 8), Brushes.Black, 7, 20)
        ' Dispose of resources
        font.Dispose()
    End Sub
    Private Sub UpdateMongoDBDocument()
        Try
            ' MongoDB connection string and database name
            Dim connectionString As String = "mongodb+srv://TrendyBrewSys:UfAGLEfLrRT01CMZ@trendycluster1.9ohrmbf.mongodb.net/?retryWrites=true&w=majority"
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

            Call GetSpecificProductQuantities()
            ' Define the update using lambda expressions
            Dim SalesTotal As Integer
            Dim VAT As Integer
            Dim CoffeeTotal As Integer = CInt(Label1.Text)
            Dim SnacksTotal As Integer = CInt(Label23.Text)
            Dim SpecialTotal As Integer = CInt(Label25.Text)
            VAT = 3
            SalesTotal += CInt(Label6.Text)

            Dim updateDoc As New BsonDocument
            updateDoc.Add("$inc", New BsonDocument From {
            {"Coffee", CoffeeTotal},
            {"Snacks", SnacksTotal},
            {"Specials", SpecialTotal},
            {"VAT", VAT},
            {"Total", SalesTotal},
            {"Durian Capuccino", DurianCapuccino},
            {"Rice Coffee", RiceCoffee},
            {"Rose Latte", RoseLatte},
            {"Rainbow Latte", RainbowLatte},
            {"Malunggay Latte", MalunggayLatte},
            {"Chocnut Latte", ChocnutLatte},
            {"Pinoy Lumpia", PinoyLumpia},
            {"Enseymada", Enseymada},
            {"Pandesal", Pandesal},
            {"Turon", Turon},
            {"Cornsilog", Cornsilog},
            {"Chicken Pastil", ChickenPastil},
            {"Tocolog", Tocilog},
            {"Bangsilog", Bangsilog},
            {"Tapsilog", Tapsilog},
            {"Longsilog", Longsilog}
            })

            Dim updateResult As UpdateResult = collection.UpdateOne(filter, updateDoc)

            If updateResult.ModifiedCount = 1 Then
                MessageBox.Show("Successfully updated the sales of: " & currentMonth, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Not found or updated the sales of: " & currentMonth, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub RetrieveCoffeeSnacksSpecials()
        Try
            ' MongoDB connection string and database name
            Dim connectionString As String = "mongodb+srv://TrendyBrewSys:UfAGLEfLrRT01CMZ@trendycluster1.9ohrmbf.mongodb.net/?retryWrites=true&w=majority"
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
            Dim projection = Builders(Of BsonDocument).Projection.Include("Coffee").Include("Snacks").Include("Specials")

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

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        ' Clear the DataGridView
        If DataGridView1.Rows.Count >= MaxRowsAllowed Then
            MessageBox.Show("Maximum number of rows reached.")
            Exit Sub
        End If
        DataGridView1.Rows.Clear()

        ' Iterate through the product names and their corresponding NumericUpDown controls
        For Each product In productQuantityControls
            Dim productName As String = product.Key
            Dim quantity As Integer = CInt(product.Value.Value)

            ' Check if quantity is greater than 0
            If quantity > 0 Then
                Dim existingRow As DataGridViewRow = Nothing

                ' Search for an existing row with the same product name
                For Each row As DataGridViewRow In DataGridView1.Rows
                    If row.Cells(0).Value IsNot Nothing AndAlso row.Cells(0).Value.ToString() = productName Then
                        existingRow = row
                        Exit For
                    End If
                Next

                ' If an existing row is found, update it; otherwise, add a new row
                If existingRow IsNot Nothing Then
                    Dim currentQuantity As Integer = CInt(existingRow.Cells(1).Value)
                    Dim newQuantity As Integer = currentQuantity + quantity
                    existingRow.Cells(1).Value = newQuantity
                    existingRow.Cells(2).Value = newQuantity * GetPriceByProductName(productName)
                Else
                    DataGridView1.Rows.Add(productName, quantity, quantity * GetPriceByProductName(productName))
                End If
            End If
        Next
        Call CalculateSubtotal()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Call CalculateTotalQuantities()

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
            Dim coffeeValue As Integer = CInt(Label15.Text)
            Dim SnackValue As Integer = CInt(Label17.Text) ' Assuming you have another NumericUpDown for Tea
            Dim SpecialValue As Integer = CInt(Label19.Text) ' Assuming you have another NumericUpDown for Sugar

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
        '-------------------------'
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        ScanRFID.Show()
    End Sub
End Class