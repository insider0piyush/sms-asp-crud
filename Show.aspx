<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Show.aspx.vb" Inherits="sms.Show" EnableEventValidation="false"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>
        Show Users Data
    </title>
</head>
<body>
     <asp:Label runat="server" style="background-color:dodgerblue;color:white;font-size:32px;font-weight:bold;display:flex;justify-content:center;width:100%;
         font-family:'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif">
   List Of Users Record
 </asp:Label>
    <form id="form1" runat="server">
        <asp:GridView runat="server" ID="aspGridView" Style="margin-top: 12px"
            HeaderStyle-BackColor="DodgerBlue" RowStyle-ForeColor="Black" RowStyle-Font-Bold="false" CellSpacing="3" CellPadding="7"
            ForeColor="White" Font-Names="monospace" Font-Bold="true" Font-Size="Larger" >
            <Columns>
                <asp:HyperLinkField DataNavigateUrlFields="sid" DataNavigateUrlFormatString="update.aspx?sid={0}" NavigateUrl="sid" Text="Update"></asp:HyperLinkField>
                 <asp:HyperLinkField DataNavigateUrlFields="sid" DataNavigateUrlFormatString="Delete.aspx?sid={0}" NavigateUrl="sid" Text="Delete"></asp:HyperLinkField>
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
