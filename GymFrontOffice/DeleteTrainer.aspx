<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteTrainer.aspx.cs" Inherits="DeleteTrainer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Are you sure you want to delete this trainer?</div>
        <p>
            <asp:Button ID="btnYes" runat="server" Height="30px" OnClick="btnYes_Click" Text="Yes" Width="70px" />
&nbsp;
            <asp:Button ID="btnNo" runat="server" Height="30px" OnClick="btnNo_Click" Text="No" Width="70px" />
        </p>
    </form>
</body>
</html>
