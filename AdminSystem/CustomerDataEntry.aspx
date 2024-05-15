<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 19px; top: 178px; position: absolute; height: 19px" Text="Customer Id"></asp:Label>
        <asp:Label ID="lblCustomerFirtName" runat="server" style="z-index: 1; left: 15px; top: 204px; position: absolute" Text="Customer First Name"></asp:Label>
        <asp:Label ID="lblCustomerLastName" runat="server" style="z-index: 1; left: 20px; top: 231px; position: absolute" Text="Customer Last Name"></asp:Label>
        <asp:Label ID="lblCustomerEmailAdress" runat="server" style="z-index: 1; left: 13px; top: 265px; position: absolute; width: 155px" Text="Customer Email Address"></asp:Label>
        <asp:Label ID="lblCustomerAddress" runat="server" style="z-index: 1; left: 14px; top: 337px; position: absolute" Text="Customer Address"></asp:Label>
        <asp:TextBox ID="txtCustomerId" runat="server" style="z-index: 1; left: 182px; top: 173px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCustomerFirstName" runat="server" style="z-index: 1; left: 188px; top: 202px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCustomerLastName" runat="server" style="z-index: 1; left: 195px; top: 232px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCustomerEmailAdress" runat="server" style="z-index: 1; left: 193px; top: 263px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCustomerDateOfBirth" runat="server" style="z-index: 1; left: 201px; top: 294px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCustomerAddress" runat="server" style="z-index: 1; left: 206px; top: 333px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnCancle" runat="server" style="z-index: 1; left: 140px; top: 440px; position: absolute" Text="Cancle" />
        <asp:Button ID="btnFind" runat="server" style="z-index: 1; left: 270px; top: 438px; position: absolute" Text="Find" />
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 148px; top: 400px; position: absolute"></asp:Label>
            <asp:CheckBox ID="chkOrderPlaced" runat="server" style="z-index: 1; left: 116px; top: 370px; position: absolute" Text="Order Placed" />
        </p>
        <p>
            &nbsp;</p>
        <p>
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 44px; top: 443px; position: absolute" Text="OK" />
        </p>
        <asp:Label ID="lblCustomerDateOfBirth" runat="server" style="z-index: 1; left: 11px; top: 298px; position: absolute" Text="Customer Date Of Birth"></asp:Label>
    </form>
</body>
</html>
