Imports System.IO
Imports System.Net
Imports System.Net.Mail
Imports System.Net.Mime
Imports MongoDB.Bson
Imports MongoDB.Driver
Imports ZXing
Public Class staffreservation
    Dim connectionString As String = "mongodb+srv://TrendyBrewSys:UfAGLEfLrRT01CMZ@trendycluster1.9ohrmbf.mongodb.net/?retryWrites=true&w=majority"
    Dim client As MongoClient = New MongoClient(connectionString)
    Dim database As IMongoDatabase = client.GetDatabase("MainReservationDb")
    Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)("reservations")

    Dim updateTimer As New Timer()
    Dim emailValue As String

    Public Property qrCheck As String

    Private Sub staffreservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize and start the timer
        updateTimer.Interval = 20000 ' 15 seconds
        AddHandler updateTimer.Tick, AddressOf UpdateListView
        updateTimer.Start()
    End Sub
    Private Sub UpdateListView(sender As Object, e As EventArgs)
        ' Clear existing items in the ListView
        ListView1.Items.Clear()

        ' Query MongoDB and populate ListView
        Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Empty
        Dim cursor As IAsyncCursor(Of BsonDocument) = collection.Find(filter).ToCursor()

        While cursor.MoveNext()
            For Each document As BsonDocument In cursor.Current
                ' Extract data from MongoDB document
                Dim id As String = document.GetValue("_id").ToString()
                Dim name As String = document.GetValue("name").ToString()
                Dim email As String = document.GetValue("email").ToString()
                Dim phone As String = document.GetValue("phone").ToString()
                Dim [date] As String = document.GetValue("date").ToString()
                Dim time As String = document.GetValue("time").ToString()
                Dim tableNumber As String = document.GetValue("tableNumber").ToString()
                Dim numberOfGuest As String = document.GetValue("numberOfGuest").ToString()
                Dim details As String = document.GetValue("details").ToString()
                Dim status As String = document.GetValue("status").ToString()

                ' Create a ListViewItem and add subitems
                Dim listItem As New ListViewItem(id)
                listItem.SubItems.Add(name)
                listItem.SubItems.Add(email)
                listItem.SubItems.Add(phone)
                listItem.SubItems.Add([date])
                listItem.SubItems.Add(time)
                listItem.SubItems.Add(tableNumber)
                listItem.SubItems.Add(numberOfGuest)
                listItem.SubItems.Add(details)
                listItem.SubItems.Add(status)

                ' Add the ListViewItem to the ListView
                ListView1.Items.Add(listItem)
            Next
        End While
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

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
        mail.Subject = "TrendyBrew - Table booking"
        mail.Body = "Good Day, ka TrendyBrew!"

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

        If ListView1.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)
            Dim email As String = selectedItem.SubItems(2).Text ' Replace with the actual column index

            ' Define the filter to find the document by email
            Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("email", email)

            ' Define the update to set the new value for the "status" field
            Dim update = Builders(Of BsonDocument).Update.Set(Function(doc) doc("status"), "Pending")

            ' Perform the update operation
            collection.UpdateOne(filter, update)

            ' Refresh the ListView or update the "status" column locally if needed
            ' YourListView.Items(selectedItem.Index).SubItems("status_column_index").Text = "new_status_value"
        Else
            MessageBox.Show("Please select a row in the ListView.")
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            ' Get the selected item
            Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)

            Dim detailsValue As String = selectedItem.SubItems(8).Text

            TextBox1.Text = detailsValue
            ' Get the value of the "email" column (assuming "name" is the second column, index 1)
            emailValue = selectedItem.SubItems(2).Text

            ' Now, you can use the 'nameValue' as needed
            MessageBox.Show($"Selected user's email: {emailValue}")
        Else

        End If
    End Sub


    Private Sub ListView1_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles ListView1.ItemSelectionChanged
        If e.IsSelected Then
            GenerateAndDisplayQRCode(e.Item)
        End If
    End Sub
    Private Sub GenerateAndDisplayQRCode(selectedItem As ListViewItem)
        Dim id As String = selectedItem.SubItems(0).Text ' Replace with the actual column index

        ' Generate QR code with larger size
        Dim qrCodeWriter As New BarcodeWriter()
        qrCodeWriter.Format = BarcodeFormat.QR_CODE

        ' Set width and height for a larger QR code
        qrCodeWriter.Options = New ZXing.QrCode.QrCodeEncodingOptions With {
            .Width = 280, ' Set the desired width
            .Height = 280, ' Set the desired height
            .Margin = 0 ' Adjust margin if needed
        }

        Dim qrCodeBitmap As Bitmap = qrCodeWriter.Write(id)

        ' Display QR code in PictureBox
        PictureBox1.Image = qrCodeBitmap
        PictureBox1.Size = New Size(qrCodeBitmap.Width, qrCodeBitmap.Height) ' Adjust PictureBox size to match the QR code size
    End Sub
    Private Sub DeleteSelectedRow()
        If ListView1.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)
            Dim id As String = selectedItem.SubItems(0).Text ' Replace with the actual column index

            ' Delete item from ListView
            ListView1.Items.Remove(selectedItem)

            ' Delete item from MongoDB
            DeleteDocumentFromDatabase(id)
        Else
            MessageBox.Show("Please select a row in the ListView.")
        End If
    End Sub
    Private Sub DeleteDocumentFromDatabase(id As String)
        ' Connect to your MongoDB database
        Dim connectionString As String = "mongodb+srv://TrendyBrewSys:UfAGLEfLrRT01CMZ@trendycluster1.9ohrmbf.mongodb.net/?retryWrites=true&w=majority"
        Dim client As MongoClient = New MongoClient(connectionString)
        Dim database As IMongoDatabase = client.GetDatabase("MainReservationDb")
        Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)("reservations")

        ' Create a BsonDocument for the filter
        Dim filter = New BsonDocument("_id", New ObjectId(id))

        ' Perform the delete operation
        collection.DeleteOne(filter)
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        DeleteSelectedRow()

    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click

        If ListView1.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)
            Dim email As String = selectedItem.SubItems(2).Text ' Replace with the actual column index

            ' Define the filter to find the document by email
            Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("email", email)

            ' Define the update to set the new value for the "status" field
            Dim update = Builders(Of BsonDocument).Update.Set(Function(doc) doc("status"), "Validated")

            ' Perform the update operation
            collection.UpdateOne(filter, update)

            ' Refresh the ListView or update the "status" column locally if needed
            ' YourListView.Items(selectedItem.Index).SubItems("status_column_index").Text = "new_status_value"
        Else
            MessageBox.Show("Please select a row in the ListView.")
        End If

        If PictureBox1.Image IsNot Nothing Then
            ' Set the image data from PictureBox1
            Dim imageData As Byte()
            Using ms As New MemoryStream()
                ' Specify the image format when saving
                PictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                imageData = ms.ToArray()
            End Using

            ' Create a new MailMessage object
            Dim mail As New MailMessage()

            ' Set the sender and recipient addresses
            mail.From = New MailAddress("trendybrewsys@gmail.com")
            mail.To.Add(emailValue)

            ' Set the subject and body of the email
            mail.Subject = "TrendyBrew - Booking success!"

            ' Get data from the selected row in the ListView
            Dim customerName As String = ListView1.SelectedItems(0).SubItems(1).Text ' Replace with the actual column index for customer name
            Dim reservationDate As String = ListView1.SelectedItems(0).SubItems(4).Text ' Replace with the actual column index for reservation date
            Dim reservationTime As String = ListView1.SelectedItems(0).SubItems(5).Text ' Replace with the actual column index for reservation time
            Dim numberOfGuests As String = ListView1.SelectedItems(0).SubItems(7).Text ' Replace with the actual column index for number of guests
            Dim tableNumber As String = ListView1.SelectedItems(0).SubItems(6).Text ' Replace with the actual column index for table number

            ' Compose the email body with specific details
            mail.Body = $"Dear {customerName},

Great news! Your reservation at TrendyBrew has been approved:

Date: {reservationDate}
Time: {reservationTime}
Guests: {numberOfGuests}
Table: {tableNumber}

We can't wait to welcome you. If you have any special requests or questions, feel free to reach out.

See you soon!
Note: Save your QR and be there on time.

Best,
TrendyBrew Team"

            ' Attach the image data
            Dim attachment As New Attachment(New MemoryStream(imageData), "QRCode.jpg", MediaTypeNames.Image.Jpeg)
            mail.Attachments.Add(attachment)

            ' Set the SMTP client details
            Dim smtp As New SmtpClient("smtp.gmail.com")
            smtp.Port = 587
            smtp.EnableSsl = True
            smtp.Credentials = New NetworkCredential("trendybrewsys@gmail.com", "qmbv jcoj gves kvhn")

            Try
                ' Send the email
                smtp.Send(mail)
                MessageBox.Show("Email sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error sending email: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Dispose of the attachment to release resources
                If attachment IsNot Nothing Then
                    attachment.Dispose()
                End If
            End Try
        Else
            MessageBox.Show("Please generate a QR code first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        DeleteSelectedRow()
    End Sub
    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        ScanDialog.Show()

        If ListView1.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)
            qrCheck = selectedItem.SubItems(0).Text ' Replace with the actual column index
        Else
        End If
    End Sub
End Class