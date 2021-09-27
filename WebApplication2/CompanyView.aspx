<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CompanyView.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
<Columns>
    <asp:BoundField DataField="Id" HeaderText="Id" />
</Columns>
<Columns>
    <asp:BoundField DataField="Name" HeaderText="Name" />
</Columns>
</asp:GridView>
    </form>
</body>
</html>
