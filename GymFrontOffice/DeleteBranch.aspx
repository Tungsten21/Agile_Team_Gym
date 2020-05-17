<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteBranch.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 142px; width: 407px">
    <form id="form1" runat="server">
        Are you sure you want to delete this Branch?<p>
            <asp:Button ID="yesbtn" runat="server" OnClick="nobtn_Click" Text="Yes" />
            <asp:Button ID="nobtn" runat="server" OnClick="nobtn_Click" Text="No " />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
