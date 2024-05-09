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
        <p>
            <asp:Label ID="tblorderId" runat="server" style="z-index: 1; left: 23px; top: 212px; position: absolute; height: 13px" Text="Order ID" width="107px"></asp:Label>
            <asp:TextBox ID="txtOrderId" runat="server" style="z-index: 1; left: 146px; top: 211px; position: absolute; right: 377px;" height="13px" width="107px"></asp:TextBox>
            <asp:Label ID="tblorderDate" runat="server" style="z-index: 1; left: 22px; top: 252px; position: absolute" Text="Order Date" height="13px" width="107px"></asp:Label>
            <asp:Label ID="tblshippingAddress" runat="server" style="z-index: 1; left: 22px; top: 293px; position: absolute; height: 13px" Text="Shipping Address" width="107px"></asp:Label>
            <asp:Label ID="tblorderAmount" runat="server" style="z-index: 1; left: 24px; top: 339px; position: absolute; bottom: 239px; width: 107px; margin-bottom: 22px;" Text="Price"></asp:Label>
        </p>
        <p>
            <asp:Label ID="tblQuantity" runat="server" style="z-index: 1; left: 22px; top: 377px; position: absolute" Text="No. of Items" height="13px" width="107px"></asp:Label>
            <asp:Label ID="tblDescription" runat="server" style="z-index: 1; left: 23px; top: 413px; position: absolute" Text="Description" height="13px" width="107px"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <asp:Label ID="tblError" runat="server" style="z-index: 1; left: 99px; top: 497px; position: absolute; height: 13px" width="107px"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 19px; top: 546px; position: absolute; height: 26px" Text="OK" width="107px" />
        <asp:Button ID="BTNCancel" runat="server" style="z-index: 1; left: 152px; top: 546px; position: absolute; height: 26px;" Text="Cancel" width="107px" />
        <p>
            &nbsp;</p>
        <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 146px; top: 252px; position: absolute" height="13px" width="107px"></asp:TextBox>
        <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 146px; top: 297px; position: absolute" height="13px" width="107px"></asp:TextBox>
        <asp:TextBox ID="TextBox5" runat="server" style="z-index: 1; left: 147px; top: 337px; position: absolute" height="13px" width="107px"></asp:TextBox>
        <asp:TextBox ID="TextBox6" runat="server" style="z-index: 1; left: 145px; top: 377px; position: absolute" height="13px" width="107px"></asp:TextBox>
        <asp:TextBox ID="TextBox7" runat="server" style="z-index: 1; left: 145px; top: 415px; position: absolute" height="13px" width="107px"></asp:TextBox>
        <p>
            <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 82px; top: 461px; position: absolute; margin-bottom: 3px;" Text="Available" height="13px" width="107px" />
        </p>
    </form>
</body>
</html>
