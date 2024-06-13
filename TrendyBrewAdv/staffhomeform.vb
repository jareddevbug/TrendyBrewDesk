Imports System.Net
Imports System.Net.Mail
Imports System.Threading
Imports Google.Apis.Auth.OAuth2
Imports Google.Apis.Services
Imports Google.Apis.Sheets.v4
Imports Google.Apis.Sheets.v4.Data

Public Class staffhomeform

    Private Const CredentialsFilePath As String = "C:\Users\mvgui\Downloads\trendybrewapiko-2a6d015bc0de.json"
    Private Const SpreadsheetId As String = "1TdTK4L20bznYimkbdQNxigMkYEsD6N22gb6iLypNK9E"
    Private Const Range As String = "Sheet1!A1:G20"

    Private dataTable As New DataTable()
    Private service As SheetsService

    Private Sub staffhomeform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Initialize the Sheets API service
            Dim credential As UserCredential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                New ClientSecrets() With {
                    .ClientSecret = "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",
                    .ClientId = "295882787463-dg2lr640o585tvhhl0cocn2ho3i1ep9n.apps.googleusercontent.com"
                },
                {SheetsService.Scope.Spreadsheets, SheetsService.Scope.SpreadsheetsReadonly},
                "user",
                CancellationToken.None).Result

            ' Initialize the SheetsService at the class level
            service = New SheetsService(New BaseClientService.Initializer() With {
                .HttpClientInitializer = credential,
                .ApplicationName = "trendyBrew"
            })

            ' Retrieve data from the spreadsheet
            Dim request As SpreadsheetsResource.ValuesResource.GetRequest = service.Spreadsheets.Values.[Get](SpreadsheetId, Range)
            Dim response As ValueRange = request.Execute()

            ' Display data in the DataGridView
            If response IsNot Nothing AndAlso response.Values IsNot Nothing AndAlso response.Values.Count > 0 Then
                ' Assume the first row contains column headers
                For Each header In response.Values(0)
                    dataTable.Columns.Add(header.ToString())
                Next

                ' Populate the data table
                For rowIdx As Integer = 1 To response.Values.Count - 1
                    Dim newRow As DataRow = dataTable.NewRow()
                    For colIdx As Integer = 0 To response.Values(rowIdx).Count - 1
                        newRow(colIdx) = response.Values(rowIdx)(colIdx)
                    Next
                    dataTable.Rows.Add(newRow)
                Next

                ' Bind the data table to the DataGridView
                DataGridView1.DataSource = dataTable
            End If
        Catch ex As Exception
            ' Handle the exception here, or simply log it
            MessageBox.Show($"An error occurred during initialization: {ex.Message}")
        End Try
    End Sub
    Dim BVal As Object
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        ' Check if any row is selected
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Get the selected row index
            Dim selectedIndex As Integer = DataGridView1.SelectedRows(0).Index

            ' Get the value in the second column (index 1) of the selected row
            BVal = DataGridView1.Rows(selectedIndex).Cells(1).Value.ToString()

            ' Remove the selected row from the DataTable
            dataTable.Rows.RemoveAt(selectedIndex)

            ' Update Google Sheets with the modified data
            UpdateGoogleSheets()

            ' Display a message or use the columnBValue as needed
            MessageBox.Show($"Item with Column B value {BVal} deleted successfully.")
        Else
            MessageBox.Show("Please select a row to delete.")
        End If
    End Sub

    Private Sub UpdateGoogleSheets()
        Try
            ' Update the data in Google Sheets
            Dim updateData As New List(Of IList(Of Object))

            For Each row As DataRow In dataTable.Rows
                Dim rowData As New List(Of Object)()
                For Each col As DataColumn In dataTable.Columns
                    rowData.Add(row(col.ColumnName))
                Next
                updateData.Add(rowData)
            Next

            ' Specify the range to update in Google Sheets
            Dim updateRange As String = "Sheet1!A1:G20" ' Update with your actual range

            ' Update Google Sheets with the modified data
            Dim updateRequest As New ValueRange With {
                .Values = updateData
            }

            Dim updateResponse As UpdateValuesResponse = service.Spreadsheets.Values.Update(updateRequest, SpreadsheetId, updateRange).Execute()

            ' Optionally, handle the update response
            If updateResponse IsNot Nothing Then
                MessageBox.Show("Data updated successfully!")
            Else
                MessageBox.Show("Error updating data.")
            End If
        Catch ex As Exception
            ' Handle the exception here, or simply log it
            MessageBox.Show($"Success: {ex.Message}")
        End Try
    End Sub



    Private Sub notifyAdminuser()

        Dim senderEmail As String = "trendybrewsys@gmail.com"
        Dim senderPassword As String = "qmbv jcoj gves kvhn"
        ' Recipient's email address
        Dim recipientEmail As String = CStr(BVal)

        ' Create a new MailMessage object
        Dim mail As New MailMessage()

        ' Set the sender and recipient addresses
        mail.From = New MailAddress(senderEmail)
        mail.To.Add(CStr(BVal))

        ' Set the subject and body of the email
        mail.Subject = "TrendyBrew - Notice"
        mail.Body = "Your order is approved"


        ' Set the SMTP client details
        Dim smtp As New SmtpClient("smtp.gmail.com")
        smtp.Port = 587
        smtp.EnableSsl = True
        smtp.Credentials = New NetworkCredential(senderEmail, senderPassword)

        Try
            ' Send the email
            smtp.Send(mail)
            MessageBox.Show("An email was send to your email acccount", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error sending email: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Dispose of the attachment to release resources

        End Try
    End Sub

End Class
