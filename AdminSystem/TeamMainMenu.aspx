<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Size="Larger" style="z-index: 1; left: 358px; top: 50px; position: absolute; margin-bottom: 0px" Text="Gaming Zen Main Menu"></asp:Label>
            <asp:Button ID="btnGames" runat="server" OnClick="btnGames_Click" style="z-index: 1; left: 233px; top: 132px; position: absolute" Text="Games" />
            <asp:Button ID="btnOrders" runat="server" style="z-index: 1; left: 425px; top: 131px; position: absolute" Text="Orders" />
            <asp:Button ID="btnCustomers" runat="server"  OnClick="btnCustomers_Click" style="z-index: 1; left: 608px; top: 133px; position: absolute" Text="Customers" />

        </div>
    </form>
</body>
</html>
