<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MemberList.aspx.cs" Inherits="MemberList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter a DOB(yyyy/mm/dd):
            <asp:TextBox ID="txtbxDOB" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="bttnApply" runat="server" Height="30px" OnClick="bttnApply_Click" Text="Apply" Width="85px" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="bttnClear" runat="server" Height="30px" OnClick="bttnClear_Click" style="margin-bottom: 0px" Text="Clear" Width="85px" />
            <br />
            <br />
            <asp:ListBox ID="lstMemberList" runat="server" Height="320px" Width="450px"></asp:ListBox>
            <br />
            <br />
            <br />
            <asp:Button ID="bttnAdd" runat="server" Height="30px" OnClick="bttnAdd_Click" Text="Add" Width="85px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="bttnEdit" runat="server" Height="30px" OnClick="bttnEdit_Click" style="height: 29px" Text="Edit" Width="85px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="bttnDelete" runat="server" Height="30px" OnClick="bttnDelete_Click" Text="Delete" Width="85px" />
            <br />
            <br />
            <asp:Label ID="Errorlbl" runat="server" Text="ErrorLabel"></asp:Label>
        </div>
    </form>
</body>
</html>
