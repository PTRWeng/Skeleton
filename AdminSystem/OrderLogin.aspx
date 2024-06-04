<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderLogin.aspx.cs" Inherits="OrderLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 13px; top: 47px; position: absolute" Text="Order Login Page"></asp:Label>
            <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 75px; top: 107px; position: absolute" Text="UserName:"></asp:Label>
            <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 74px; top: 159px; position: absolute" Text="Password:"></asp:Label>
        </div>
        <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 167px; top: 106px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 166px; top: 158px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 86px; top: 225px; position: absolute" Text="Login" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 197px; top: 226px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Label ID="lblError" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 369px; top: 134px; position: absolute"></asp:Label>
    </form>
</body>
</html>
