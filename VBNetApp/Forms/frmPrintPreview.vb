
Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmPrintPreview

    Private Sub frmPrintPreview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Sub ShowPrintUser()
        Dim con As New MySqlConnection(DB_CONNECTION_STRING)
        con.Open()
        Dim com As New MySqlCommand("SELECT u_fname,u_lname,u_mname,u_username,u_password FROM desk_app.users;", con)
        Dim dA As New MySqlDataAdapter()
        Dim dS As New DataSet()
        dA.SelectCommand = com
        dA.Fill(dS)

        Dim rpt As New ReportDocument()
        rpt.Load(Application.StartupPath & "\\Reports\\rptUserAccount.rpt")
        rpt.SetDataSource(dS)

        CRViewer.ReportSource = rpt
        CRViewer.RefreshReport()
        con.Close()

        Me.Show()
    End Sub
End Class