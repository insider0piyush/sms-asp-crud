Imports MySqlConnector

Public Class _Default
    Inherits System.Web.UI.Page

    Dim cmd As MySqlCommand
    Dim con As MySqlConnection
    Protected Sub Connection()
        con = New MySqlConnection("server = localhost ; user id = root ; password = Piyush@123 ; database = users")
        Try
            con.Open()
        Catch e As Exception
            MsgBox(e.Message)
        End Try
    End Sub


    Protected Sub CreateTable()
        cmd = New MySqlCommand("CREATE TABLE USERS(SID INT PRIMARY KEY , FNAME VARCHAR(32) , LNAME VARCHAR(32) , EMAIL VARCHAR(72) , MNO BIGINT)", con)
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
    End Sub

    Protected Sub InsertedInTable()
        cmd = New MySqlCommand("INSERT INTO USERS VALUES(@SID,@FNAME,@LNAME,@EMAIL,@MNO)", con)
        Try
            cmd.Parameters.AddWithValue("@SID", Convert.ToInt32(Sid.Text.Trim))
            cmd.Parameters.AddWithValue("@FNAME", Fname.Text.Trim)
            cmd.Parameters.AddWithValue("@LNAME", Lname.Text.Trim)
            cmd.Parameters.AddWithValue("@EMAIL", Email.Text.Trim)
            cmd.Parameters.AddWithValue("@MNO", Convert.ToInt64(Mno.Text.Trim))
            cmd.ExecuteNonQuery()
            MsgBox("INSERTED" + " " + Fname.Text.Trim.ToUpper + " " + Lname.Text.Trim.ToUpper + " >> ")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Protected Sub clearTable()
        Sid.Text = ""
        Fname.Text = ""
        Lname.Text = ""
        Email.Text = ""
        Mno.Text = ""
    End Sub

    Protected Sub StudentAdd(sender As Object, e As EventArgs)
        Connection()
        CreateTable()
        InsertedInTable()
        clearTable()
        Response.Redirect("http://localhost:51803/Show.aspx")
    End Sub

    Protected Sub StudentView(sender As Object, e As EventArgs)
        Response.Redirect("http:\\localhost:51803\Show.aspx")
    End Sub
End Class