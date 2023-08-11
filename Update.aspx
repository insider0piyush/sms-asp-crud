<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Update.aspx.vb" Inherits="sms.Update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
         <asp:Label runat="server" style="background-color:dodgerblue;color:white;font-size:32px;font-weight:bold;display:flex;justify-content:center;width:100%;
                font-family:'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif">
            Student Managment System
        </asp:Label>
    <form runat="server" id="form1" >
        <table border="0" cellpadding="7px" style="margin-top:32px;">
            <tr >
                <td style="font-size:19px;padding-right:17px;padding-left:12px">
                    First Name
                </td>
                <td>
                    <asp:TextBox ID="Fname" name="Fname" runat="server" Style="padding-inline: 12px; padding-top: 9px; padding-bottom: 9px; width: 256px;" ></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="font-size:19px;padding-right:17px;padding-left:12px;">
                    Last Name
                </td>
                <td>
                    <asp:TextBox ID="Lname" name= "Lname" runat="server" style="padding-inline:12px;padding-top:9px;padding-bottom:9px;width:256px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="font-size:19px;padding-right:17px;padding-left:12px;">
                   Sid
                </td>
                <td>
                    <asp:TextBox ID="Sid" name= "Sid"  ReadOnly="true" runat="server" style="padding-inline:12px;padding-top:9px;padding-bottom:9px;width:256px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="font-size:19px;padding-right:17px;padding-left:12px;">
                   Email
                </td>
                <td>
                    <asp:TextBox ID="Email" name= "Email" runat="server" style="padding-inline:12px;padding-top:9px;padding-bottom:9px;width:256px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="font-size:19px;padding-right:17px;padding-left:12px;">
                   Mobile No
                </td>
                <td>
                    <asp:TextBox ID="Mno" name= "Mno" runat="server" style="padding-inline:12px;padding-top:9px;padding-bottom:9px;width:256px"></asp:TextBox>
                </td>
            </tr>
        </table>
        <asp:Button ID="btnAdd" name="btnAdd" runat="server" text="Update Student"
            style="padding-left:17px;padding-right:17px;padding-top:7px;padding-bottom:7px;background-color:dodgerblue;color:white;
               font-family:'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
                   font-size:17px;outline-color:dodgerblue;border-color:dodgerblue;border-radius:12px;margin-inline-start:128px;margin-top:32px;" OnClick="StudentUpdate"></asp:Button>
    </form>
</body>
</html>
