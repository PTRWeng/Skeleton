<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 11px;
        }
    </style>
</head>
<body style="height: 27px">
    <form id="form1" runat="server">
        <asp:Label ID="lblorderId" runat="server" style="z-index: 1; left: 64px; top: 105px; position: absolute" Text="OrderId"></asp:Label>
        <asp:Label ID="lblorderDate" runat="server" height="19px" style="z-index: 1; left: 64px; top: 138px; position: absolute" Text="Order Date"></asp:Label>
        <asp:Label ID="lblshippingAddress" runat="server" height="19px" style="z-index: 1; left: 64px; top: 169px; position: absolute" Text="Shipping Address"></asp:Label>
        <asp:Label ID="lblorderAmount" runat="server" height="19px" style="z-index: 1; left: 64px; top: 203px; position: absolute" Text="Price"></asp:Label>
        <asp:Label ID="lblorderQuantity" runat="server" height="19px" style="z-index: 1; left: 64px; top: 243px; position: absolute" Text="No. of Items"></asp:Label>
        <asp:Label ID="lblorderDescription" runat="server" height="19px" style="z-index: 1; left: 64px; top: 277px; position: absolute" Text="Description"></asp:Label>
        <asp:Button ID="btnOk" runat="server" style="z-index: 1; left: 79px; top: 375px; position: absolute; height: 26px;" Text="Ok" OnClick="btnOk_Click" />
        <p>
            <asp:CheckBox ID="chkStatus" runat="server" Style="z-index: 1; left: 134px; top: 311px; position: absolute; bottom: 123px" Text="Available" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 146px; top: 340px; position: absolute"></asp:Label>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 159px; top: 373px; position: absolute" Text="Cancel" />
        </p>
        <asp:Button ID="btnFind" runat="server" style="z-index: 1; left: 259px; top: 372px; position: absolute" Text="Find" />
        <asp:TextBox ID="txtorderId" runat="server" style="z-index: 1; left: 224px; top: 102px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtorderDate" runat="server" style="z-index: 1; left: 224px; top: 136px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtshippingAddress" runat="server" style="z-index: 1; left: 224px; top: 169px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtorderAmount" runat="server" style="z-index: 1; left: 226px; top: 204px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtorderQuantity" runat="server" style="z-index: 1; left: 226px; top: 241px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtorderDescription" runat="server" style="z-index: 1; left: 229px; top: 276px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>
