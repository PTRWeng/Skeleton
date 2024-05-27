<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 209px; top: 358px; position: absolute" Text="Delete" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 136px; top: 358px; position: absolute" Text="Edit" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 44px; top: 520px; position: absolute"></asp:Label>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 54px; top: 357px; position: absolute" Text="Add" />
            <asp:ListBox ID="lstGameList" runat="server" style="z-index: 1; left: 26px; top: 23px; position: absolute; height: 313px; width: 699px"></asp:ListBox>
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 48px; top: 419px; position: absolute" Text="Enter a Game Title"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 178px; top: 417px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 64px; top: 462px; position: absolute" Text="Apply Filter" />
        <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; top: 462px; position: absolute; left: 210px" Text="Clear Filter" />
    </form>
</body>
</html>
