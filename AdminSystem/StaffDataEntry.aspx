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
            <asp:TextBox ID="txtStaffID" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; left: 177px; top: 39px; position: absolute"></asp:TextBox>
        </p>
        <asp:Label ID="lblStaffFirstName" runat="server" style="z-index: 1; left: 40px; position: absolute; top: 80px; height: 1px" Text="Staff First Name"></asp:Label>
        <asp:TextBox ID="txtStaffFirstName" runat="server" style="z-index: 1; left: 176px; top: 77px; position: absolute"></asp:TextBox>
        <p>
            <asp:Label ID="lblStaffLastName" runat="server" style="z-index: 1; left: 39px; top: 119px; position: absolute; height: 22px" Text="Staff Last Name"></asp:Label>
        </p>
        <asp:TextBox ID="txtLastName" runat="server" OnTextChanged="txtLastName_TextChanged" style="z-index: 1; left: 175px; position: absolute; top: 114px"></asp:TextBox>
        <asp:Label ID="lblStaffDateofBirth" runat="server" style="z-index: 1; left: 41px; top: 153px; position: absolute" Text="Date of Birth"></asp:Label>
        <p>
            <asp:TextBox ID="txtStaffDateofBirth" runat="server" style="z-index: 1; left: 171px; top: 150px; position: absolute"></asp:TextBox>
        </p>
        <asp:Label ID="lblStaffNumber" runat="server" style="z-index: 1; left: 39px; top: 186px; position: absolute" Text="Number"></asp:Label>
        <asp:TextBox ID="txtSatffNumber" runat="server" style="z-index: 1; left: 164px; top: 188px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblStaffAddress" runat="server" style="z-index: 1; left: 39px; top: 218px; position: absolute" Text="Address"></asp:Label>
        <asp:TextBox ID="txtSatffAddress" runat="server" style="z-index: 1; left: 163px; top: 222px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblStaffEmail" runat="server" style="z-index: 1; left: 44px; top: 255px; position: absolute" Text="Email"></asp:Label>
        <p>
            <asp:TextBox ID="txtStaffEmail" runat="server" style="z-index: 1; left: 152px; top: 265px; position: absolute"></asp:TextBox>
        </p>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 169px; top: 319px; position: absolute" Text="Active" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 34px; top: 357px; position: absolute"></asp:Label>
        <p>
            <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 51px; top: 408px; position: absolute" Text="OK" />
        </p>
        <p>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 161px; top: 412px; position: absolute" Text="Cancel" />
        </p>
    </form>
</body>
</html>
