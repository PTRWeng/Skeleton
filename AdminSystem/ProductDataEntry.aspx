<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnReturnToMainMenu" runat="server" OnClick="btnReturnToMainMenu_Click" style="z-index: 1; left: 323px; top: 398px; position: absolute" Text="Return to Main Menu" />
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 381px; top: 62px; position: absolute" Text="Find" />
            <asp:Label ID="lblGameID" runat="server" style="z-index: 1; left: 66px; top: 64px; position: absolute" Text="Game ID" width="105px"></asp:Label>
            <asp:TextBox ID="txtgameID" runat="server" style="z-index: 1; left: 188px; top: 61px; position: absolute"></asp:TextBox>
        </div>
        <asp:Label ID="lblGameTitle" runat="server" style="z-index: 1; left: 69px; top: 102px; position: absolute" Text="GameTitle" width="105px"></asp:Label>
        <asp:TextBox ID="txtGameTitle" runat="server" style="z-index: 1; left: 188px; top: 102px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblGameDescription" runat="server" style="z-index: 1; left: 67px; top: 138px; position: absolute" Text="GameDescription"></asp:Label>
        <asp:TextBox ID="txtGameDescription" runat="server" style="z-index: 1; left: 187px; top: 135px; position: absolute; height: 24px; width: 619px;"></asp:TextBox>
        <asp:Label ID="lblGamePlatform" runat="server" style="z-index: 1; left: 71px; top: 187px; position: absolute; right: 986px" Text="GamePlatform" width="105px"></asp:Label>
        <asp:TextBox ID="txtGamePlatform" runat="server" style="z-index: 1; left: 189px; top: 188px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblReleaseDate" runat="server" style="z-index: 1; left: 70px; top: 228px; position: absolute" Text="DateUpdated" width="105px"></asp:Label>
        <asp:TextBox ID="txtReleaseDate" runat="server" style="z-index: 1; left: 188px; top: 228px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 76px; top: 271px; position: absolute" Text="Price" width="105px"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 188px; top: 268px; position: absolute; height: 18px"></asp:TextBox>
        <asp:CheckBox ID="chkAvailable" runat="server" style="z-index: 1; left: 140px; top: 313px; position: absolute" Text="Available" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 78px; top: 354px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 121px; top: 400px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 201px; top: 400px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
