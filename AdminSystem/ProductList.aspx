<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 136px; top: 358px; position: absolute" Text="Edit" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 56px; top: 411px; position: absolute"></asp:Label>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 54px; top: 357px; position: absolute" Text="Add" />
            <asp:ListBox ID="lstGameList" runat="server" style="z-index: 1; left: 26px; top: 23px; position: absolute; height: 313px; width: 699px"></asp:ListBox>
        </div>
    </form>
</body>
</html>
