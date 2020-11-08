Imports System.Reflection
Module PrintingAndEmail
    Public PasswordEntered As Boolean = False
    Sub PrintDeliveryLabel(ByVal Map As Graph, ByVal Customer As Customer, ByVal Order As Order, ByVal StartPoint As Vertex)
        Dim Word As Microsoft.Office.Interop.Word.Application
        Dim Document As Microsoft.Office.Interop.Word.Document
        Dim Heading As Microsoft.Office.Interop.Word.Paragraph
        Dim Content As Microsoft.Office.Interop.Word.Paragraph
        Word = CreateObject("Word.Application")
        Word.Visible = False
        Document = Word.Documents.Add
        Heading = Document.Content.Paragraphs.Add
        Heading.Range.Text = "Delivery " & Now.Date
        Heading.Range.Font.Bold = True
        Heading.Range.Font.Size = 30
        Heading.Range.InsertParagraphAfter()
        Content = Document.Content.Paragraphs.Add(Document.Bookmarks.Item("\endofdoc").Range)
        Content.Range.Font.Bold = False
        Content.Range.Text = Customer.Forename & " " & Customer.Surname & vbCr
        Content.Range.Text = Customer.HouseNumber & vbCr
        Content.Range.Text = Content.Range.Text & Customer.Street & vbCr
        Content.Range.Text = Content.Range.Text & Customer.Town & vbCr
        Content.Range.Text = Content.Range.Text & Customer.Postcode
        Content.Format.SpaceAfter = 0
        Content.Format.LineSpacing = 1
        Content.Range.InsertParagraphAfter()
        Document.PrintOut()
        Document.Saved = False
        Document.Close()
        Word.Quit()
    End Sub
    Sub PrintShoppingList(ByVal SupplyList() As String)
        Dim Word As Microsoft.Office.Interop.Word.Application
        Dim Document As Microsoft.Office.Interop.Word.Document
        Dim Heading As Microsoft.Office.Interop.Word.Paragraph
        Dim Content As Microsoft.Office.Interop.Word.Paragraph
        Word = CreateObject("Word.Application")
        Word.Visible = False
        Document = Word.Documents.Add
        Heading = Document.Content.Paragraphs.Add
        Heading.Range.Text = "Shopping List " & Now.Date
        Heading.Range.Font.Bold = True
        Heading.Format.SpaceAfter = 1
        Heading.Range.InsertParagraphAfter()
        Content = Document.Content.Paragraphs.Add(Document.Bookmarks.Item("\endofdoc").Range)
        Content.Range.Font.Bold = False
        For count = 0 To SupplyList.Length - 1
            Content.Range.Text = Content.Range.Text & vbCr & SupplyList(count)
        Next
        Content.Format.SpaceAfter = 0
        Content.Format.LineSpacing = 1
        Content.Range.InsertParagraphAfter()
        Document.PrintOut()
    End Sub
    Sub PrintInvoice(ByVal Invoice As Document, ByVal Order As Order, ByVal Customer As Customer, ByVal Print As Boolean)

   
    End Sub
    Sub SendEmail(ByVal ToAddress As String, ByVal Subject As String, ByVal Message As String, Optional ByVal AttachmentDirectory As String = Nothing)
        If PasswordEntered = False Then
            Try
                EMailPasswordForm.Show()
                SendEmail(ToAddress, Subject, Message, AttachmentDirectory)
            Catch err As Exception
            End Try
        Else

            Try
                SMTPServer.UseDefaultCredentials = False
                SMTPServer.Credentials = New Net.NetworkCredential(Variables.EMailUser, Variables.EMailPassword)
                SMTPServer.Port = EMailPort
                SMTPServer.Host = EMailServer

                EMail = New Net.Mail.MailMessage
                EMail.From = New Net.Mail.MailAddress(EMailUser)
                EMail.To.Add(ToAddress)
                EMail.Subject = Subject
                EMail.IsBodyHtml = False
                EMail.Body = Message
                SMTPServer.Send(EMail)

                MsgBox("E-Mail was successfully sent to " & ToAddress, MsgBoxStyle.Information, "E-Mail Sent")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Sub EMailInvoice(ByVal Order As Order, ByVal Customer As Customer)
        If PasswordEntered = False Then

            EMailPasswordForm.Show()
            EMailInvoice(Order, Customer)


        Else
            Try
                SMTPServer.UseDefaultCredentials = False
                SMTPServer.Credentials = New Net.NetworkCredential(Variables.EMailUser, Variables.EMailPassword)
                SMTPServer.Port = EMailPort
                SMTPServer.Host = EMailServer

                EMail = New Net.Mail.MailMessage
                EMail.From = New Net.Mail.MailAddress(EMailUser)
                EMail.To.Add(Customer.EMailAddress)
                EMail.Subject = "Invoice for your recent order"
                EMail.IsBodyHtml = False
                EMail.Body = Customer.Forename & "," & vbCr & vbCr & "Thank you for your recent order from us of: " & vbCr & Order.OrderDetails & vbCr & vbCr & "This is an invoice for £" & Order.Cost & vbCr & "A deposit should have already been received and the final full payment is required by the deadline of " & Order.Deadline & vbCr & vbCr & "Thank You for choosing Createabake"
                MsgBox("To: " & Customer.EMailAddress & vbCr & "Subject: " & EMail.Subject & vbCr & vbCr & EMail.Body)
                SMTPServer.Send(EMail)

                MsgBox("E-Mail was successfully sent to " & Customer.EMailAddress, MsgBoxStyle.Information, "E-Mail Sent")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub


    Sub PrintAllergyLabel()
        Dim Word As Microsoft.Office.Interop.Word.Application
        Dim Document As Microsoft.Office.Interop.Word.Document
        Dim Heading As Microsoft.Office.Interop.Word.Paragraph
        Dim Content As Microsoft.Office.Interop.Word.Paragraph
        Word = CreateObject("Word.Application")
        Word.Visible = False
        Document = Word.Documents.Add
        Heading = Document.Content.Paragraphs.Add
        Heading.Range.Text = "ALLERGY ADVICE"
        Heading.Range.Font.Bold = True
        Heading.Range.Font.Size = 30
        Heading.Range.InsertParagraphAfter()
        Content = Document.Content.Paragraphs.Add(Document.Bookmarks.Item("\endofdoc").Range)
        Content.Range.Font.Bold = False
        Content.Range.Text = "May contain: nuts, gluten, wheat, milk, egg" & vbCr
        Content.Format.SpaceAfter = 0
        Content.Format.LineSpacing = 1
        Content.Range.InsertParagraphAfter()
        Document.PrintOut()
        Document.Saved = False
        Document.Close()
        Word.Quit()
    End Sub
    Sub PrintVeganLabel()
        Dim Word As Microsoft.Office.Interop.Word.Application
        Dim Document As Microsoft.Office.Interop.Word.Document
        Dim Heading As Microsoft.Office.Interop.Word.Paragraph
        Dim Content As Microsoft.Office.Interop.Word.Paragraph
        Word = CreateObject("Word.Application")
        Word.Visible = False
        Document = Word.Documents.Add
        Heading = Document.Content.Paragraphs.Add
        Heading.Range.Text = "VEGAN CONTENT"
        Heading.Range.Font.Bold = True
        Heading.Range.Font.Size = 30
        Heading.Range.InsertParagraphAfter()
        Content = Document.Content.Paragraphs.Add(Document.Bookmarks.Item("\endofdoc").Range)
        Content.Range.Font.Bold = False
        Content.Range.Text = "May contain dairy products" & vbCr
        Content.Format.SpaceAfter = 0
        Content.Format.LineSpacing = 1
        Content.Range.InsertParagraphAfter()
        Document.PrintOut()
        Document.Saved = False
        Document.Close()
        Word.Quit()
    End Sub
End Module
