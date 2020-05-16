<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteMember.aspx.cs" Inherits="DeleteMember" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <div>
            Are you sure you want to delete this Member?</div>
        <p>
            <asp:Button ID="bttnYes" runat="server" Height="30px" OnClick="btnYes_Click" Text="Yes" Width="70px" />
&nbsp;
            <asp:Button ID="bttnNo" runat="server" Height="30px" OnClick="btnNo_Click" Text="No" Width="70px" />
        </p>
        </div>
    </form>
</body>
</html>
