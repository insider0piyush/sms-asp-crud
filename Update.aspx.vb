Imports MySqlConnector

Public Class Update
    Inherits System.Web.UI.Page

    Dim cmd As MySqlCommand
    Dim con As MySqlConnection
    Dim ad As MySqlDataAdapter
    Dim ds As DataSet
    Dim getId As Integer

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
        getId = Convert.ToInt32(Request.QueryString("sid"))
        ad = New MySqlDataAdapter("SELECT * FROM USERS WHERE SID = " & getId & " ", con)
        Try
            ds = New DataSet()
            ad.Fill(ds)
            If IsPostBack = False Then
                Sid.Text = ds.Tables(0).Rows(0).Item(0).ToString
                Fname.Text = ds.Tables(0).Rows(0).Item(1).ToString
                Lname.Text = ds.Tables(0).Rows(0).Item(2).ToString
                Email.Text = ds.Tables(0).Rows(0).Item(3).ToString
                Mno.Text = ds.Tables(0).Rows(0).Item(4).ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Protected Sub UpdateData()
        getId = Convert.ToInt32(Request.QueryString("sid"))
        cmd = New MySqlCommand("UPDATE USERS SET FNAME=@FNAME,LNAME=@LNAME,EMAIL=@EMAIL,MNO=@MNO WHERE SID= " & getId & " ", con)
        Try
            cmd.Parameters.AddWithValue("@FNAME", Fname.Text.Trim)
            cmd.Parameters.AddWithValue("@LNAME", Lname.Text.Trim)
            cmd.Parameters.AddWithValue("@EMAIL", Email.Text.Trim)
            cmd.Parameters.AddWithValue("@MNO", Convert.ToInt64(Mno.Text.Trim))
            cmd.ExecuteNonQuery()
            MsgBox("UPDATED" + " " + Fname.Text.Trim.ToUpper + " " + Lname.Text.Trim.ToUpper + " >> ")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Protected Sub StudentUpdate(sender As Object, e As EventArgs)
        Connection()
        UpdateData()
        Response.Redirect("http://localhost:51803/Show.aspx")
    End Sub
End Class