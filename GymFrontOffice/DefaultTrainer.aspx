<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DefaultTrainer.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstTrainerList" runat="server" Height="254px" Width="335px"></asp:ListBox>
        </div>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="AddClick" Text="Add" Width="85px" Height="30px" />
        &nbsp;
            <asp:Button ID="btnEdit" runat="server" Height="30px" OnClick="btnEdit_Click" Text="Edit" Width="85px" />
&nbsp;
            <asp:Button ID="btnDelete" runat="server" Height="30px" OnClick="btnDelete_Click" Text="Delete" Width="85px" />
        </p>
        <asp:Label ID="lblError" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
