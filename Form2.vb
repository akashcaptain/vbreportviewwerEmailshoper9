Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Shoper9MM0DataSet.StkTrnDtls' table. You can move, or remove it, as needed.
        Me.StkTrnDtlsTableAdapter.Fill(Me.Shoper9MM0DataSet.StkTrnDtls)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportViewer1.Load

    End Sub

    Private Sub ReportViewer1_ReportExport(ByVal sender As Object, ByVal e As Microsoft.Reporting.WinForms.ReportExportEventArgs) Handles ReportViewer1.ReportExport

    End Sub
End Class
