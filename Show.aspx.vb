Imports MySqlConnector
Public Class Show
    Inherits System.Web.UI.Page

    Dim cmd As MySqlCommand
    Dim con As MySqlConnection
    Dim ad As MySqlDataAdapter
    Dim ds As DataSet

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Connection()
        loadData()
    End Sub

    Protected Sub Connection()
        con = New MySqlConnection("server = localhost ; user id = root ; password = Piyush@123 ; database = users")
        Try
            con.Open()
        Catch e As Exception
            MsgBox(e.Message)
        End Try
    End Sub
    Protected Sub loadData()
        ad = New MySqlDataAdapter("SELECT * FROM USERS", con)
        ds = New DataSet()
        ad.Fill(ds, "USERS")
        aspGridView.DataSource = ds.Tables(0).DefaultView
        aspGridView.DataBind()
    End Sub
End Class