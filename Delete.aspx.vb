Imports MySqlConnector

Public Class Delete
    Inherits System.Web.UI.Page

    Dim ad As MySqlDataAdapter
    Dim con As MySqlConnection
    Dim cmd As MySqlCommand
    Dim ds As DataSet
    Dim sid As Integer

    Protected Sub Connection()
        con = New MySqlConnection("server = localhost ; user id = root ; password = Piyush@123 ; database = users")
        Try
            con.Open()
        Catch e As Exception
            MsgBox(e.Message)
        End Try
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Connection()
        sid = Convert.ToInt32(Request.QueryString("sid"))
        ad = New MySqlDataAdapter("SELECT * FROM USERS WHERE SID = " & sid & " ", con)
        Try
            ds = New DataSet
            ad.Fill(ds)
            If IsPostBack = False Then
                If MsgBox("" & ds.Tables(0).Rows(0).Item(1).ToString & " want to deleted ?  ", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, "Information") = MsgBoxResult.Ok Then
                    cmd = New MySqlCommand("DELETE FROM USERS WHERE SID=" & sid & "", con)
                    Try
                        cmd.ExecuteNonQuery()
                        MsgBox("Deleted")
                        lbl.Text = "UserName : " & ds.Tables(0).Rows(0).Item(1).ToString & " , is deleted successfully ! "
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Else
                    Response.Redirect("http:\\localhost:51803\Show.aspx")
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

End Class