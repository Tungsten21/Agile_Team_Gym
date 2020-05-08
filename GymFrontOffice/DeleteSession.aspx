<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteSession.aspx.cs" Inherits="DeleteSession" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Are you sure you want to delete this record?<br />
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes" />
            &nbsp;&nbsp;
            <asp:Button ID="btnNo" runat="server" OnClick="Button2_Click" Text="No" />
        </div>
    </form>
</body>
</html>
