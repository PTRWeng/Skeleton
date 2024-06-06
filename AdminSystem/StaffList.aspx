<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStaffList" runat="server" style="z-index: 1; left: 10px; top: 37px; position: absolute; height: 312px; width: 329px"></asp:ListBox>
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 208px; top: 373px; position: absolute" Text="Delete" OnClick="btnDelete_Click" />
        <p>
            <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 16px; top: 374px; position: absolute"  Text="Add" OnClick="btnAdd_Click" />
            <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 107px; top: 373px; position: absolute" Text="Edit" OnClick="btnEdit_Click" />
        </p>
        <asp:Label ID="lblError" runat="server" ForeColor="Red" style="z-index: 1; left: 360px; top: 401px; position: absolute"></asp:Label>
        <asp:TextBox ID="txtStaffFirstName" runat="server" style="z-index: 1; left: 79px; top: 486px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnClearFilter" runat="server" style="z-index: 1; left: 183px; top: 527px; position: absolute" Text="Clear Filter" OnClick="btnClearFilter_Click" />
        <p>
            <asp:Button ID="btnApplyFilter" runat="server" style="z-index: 1; left: 38px; top: 529px; position: absolute; " Text="Apply Filter" OnClick="btnApplyFilter_Click" />
        </p>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 27px; top: 444px; position: absolute; right: 599px" Text="Enter Staff First Name to Filter the list"></asp:Label>
    </form>
</body>
</html>
