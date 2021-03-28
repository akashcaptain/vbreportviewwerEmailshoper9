Imports System.IO
Imports System.Net.Mail

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Shoper9MM0DataSet.StkTrnDtls' table. You can move, or remove it, as needed.
        Me.StkTrnDtlsTableAdapter.Fill(Me.Shoper9MM0DataSet.StkTrnDtls)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub BTN1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN1.Click
        Dim byteViewer As Byte() = ReportViewer1.LocalReport.Render("PDF")
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "*PDF files (*.pdf)|*.pdf"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True
        Dim newFile As New FileStream("D:\" & "Reports" & ".pdf", FileMode.Create)
        newFile.Write(byteViewer, 0, byteViewer.Length)
        newFile.Close()
        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("", "")
            Smtp_Server.Port = 25
            Smtp_Server.EnableSsl = False
            Smtp_Server.Host = "mail.rupa.co.in"
            Dim attachment As System.Net.Mail.Attachment = New System.Net.Mail.Attachment("D:\Reports.pdf")

            e_mail = New MailMessage()
            e_mail.From = New MailAddress("")
            e_mail.To.Add("akash@tagcomputers.co.in")
            e_mail.To.Add("akash.online98@gmail.com")
            e_mail.Subject = "Email Sending"
            e_mail.IsBodyHtml = False
            e_mail.Body = "Report Send"
            e_mail.Attachments.Add(attachment)

            Smtp_Server.Send(e_mail)
            MsgBox("Mail Sent")

        Catch error_t As Exception
            MsgBox(error_t.ToString)
        End Try
    End Sub
End Class
