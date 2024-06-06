<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblStaffID" runat="server" style="z-index: 1; left: 43px; top: 43px; position: absolute; height: 2px; bottom: 630px" Text="Staff ID"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="txtStaffID" runat="server"  style="z-index: 1; left: 177px; top: 39px; position: absolute"></asp:TextBox>
        </p>
        <asp:Label ID="lblStaffFirstName" runat="server" style="z-index: 1; left: 40px; position: absolute; top: 80px; height: 1px" Text="Staff First Name"></asp:Label>
        <asp:TextBox ID="txtStaffFirstName" runat="server" style="z-index: 1; left: 176px; top: 77px; position: absolute"></asp:TextBox>
        <p>
            <asp:Label ID="lblStaffLastName" runat="server" style="z-index: 1; left: 39px; top: 119px; position: absolute; height: 22px" Text="Staff Last Name"></asp:Label>
        </p>
        <asp:TextBox ID="txtStaffLastName" runat="server" style="z-index: 1; left: 175px; position: absolute; top: 114px"></asp:TextBox>
        <asp:Label ID="lblStaffDateofBirth" runat="server" style="z-index: 1; left: 41px; top: 153px; position: absolute" Text="Date of Birth"></asp:Label>
        <p>
            <asp:TextBox ID="txtStaffDateofBirth" runat="server" style="z-index: 1; left: 171px; top: 150px; position: absolute"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 385px; top: 35px; position: absolute" Text="Find" />
        </p>
        <asp:Label ID="lblStaffNumber" runat="server" style="z-index: 1; left: 39px; top: 186px; position: absolute" Text="Number"></asp:Label>
        <asp:TextBox ID="txtStaffNumber" runat="server" style="z-index: 1; left: 164px; top: 188px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblStaffAddress" runat="server" style="z-index: 1; left: 39px; top: 218px; position: absolute" Text="Address"></asp:Label>
        <asp:TextBox ID="txtStaffAddress" runat="server" style="z-index: 1; left: 163px; top: 222px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblStaffEmail" runat="server" style="z-index: 1; left: 44px; top: 255px; position: absolute" Text="Email"></asp:Label>
        <p>
            <asp:TextBox ID="txtStaffEmail" runat="server" style="z-index: 1; left: 152px; top: 265px; position: absolute"></asp:TextBox>
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 32px; top: 323px; position: absolute"></asp:Label>
        <p>
            <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 45px; top: 377px; position: absolute" Text="OK" OnClick="btnOK_Click" />
        </p>
        <p>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 161px; top: 380px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        </p>
    </form>
</body>
</html>
