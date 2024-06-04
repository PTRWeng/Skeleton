<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 112px; top: 47px; position: absolute" Text="You sure to Delete this record?"></asp:Label>
        <asp:Button ID="btnNo" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 267px; top: 112px; position: absolute" Text="No" />
        <asp:Button ID="Yes" runat="server" OnClick="Yes_Click" style="z-index: 1; left: 118px; top: 112px; position: absolute;" Text="Yes" />
    </form>
</body>
</html>
