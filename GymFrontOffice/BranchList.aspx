<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BranchList.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <div>
            <asp:Button ID="btnEdit" runat="server" Height="30px" OnClick="btnEdit_Click" Text="Edit" Width="85px" />
            <asp:Button ID="btnAdd" runat="server" OnClick="AddClick" Text="Add" Width="85px" Height="30px" />
            <asp:Button ID="btnDelete" runat="server" Height="30px" OnClick="btnDelete_Click" Text="Delete" Width="85px" />
        </div>
        <p>
        &nbsp;
            &nbsp;
            <asp:ListBox ID="lstBranchList" runat="server" Height="254px" Width="426px" OnSelectedIndexChanged="lstTrainerList_SelectedIndexChanged" style="margin-top: 61px"></asp:ListBox>
        </p>
        <p>
            Enter a Opening Date:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtFilter" runat="server" Height="16px" Width="169px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnApply" runat="server" Height="30px" OnClick="btnApply_Click" Text="Apply" Width="85px" />
&nbsp;
            <asp:Button ID="btnClear" runat="server" Height="30px" Text="Clear" Width="85px" OnClick="btnClear_Click" />
        </p>
        <asp:Label ID="lablError" runat="server" Text="No Errors"></asp:Label>
        </div>
    </form>
</body>
</html>
