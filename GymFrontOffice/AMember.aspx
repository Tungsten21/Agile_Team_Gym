<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AMember.aspx.cs" Inherits="AMember" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            MemberID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtbxMemberID" runat="server" Height="16px" TextMode="Number"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="bttnFind" runat="server" Height="26px" OnClick="bttnFind_Click" Text="Find" Width="80px" />
            <br />
            Fullname&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtbxFullName" runat="server" Height="16px"></asp:TextBox>
            <br />
            Address&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtbxAddress" runat="server" Height="16px"></asp:TextBox>
            <br />
            DOB&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtbxDOB" runat="server" Height="16px"></asp:TextBox>
            <br />
            Phone number&nbsp;
            <asp:TextBox ID="txtbxPhoneNumber" runat="server" Height="16px"></asp:TextBox>
            <br />
            <asp:CheckBox ID="chkbxMedicalConditions" runat="server" Text="Medical conditions                                        " TextAlign="Left" />
            <br />
            <br />
            <asp:Button ID="bttnOK" runat="server" Height="30px" OnClick="bttnOK_Click" Text="OK" Width="100px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="bttnCancel" runat="server" Height="30px" Text="Cancel" Width="100px" />
            <br />
            <br />
            <asp:Label ID="lblErrorMessage" runat="server" BorderWidth="1px" Text="No errors"></asp:Label>
        </div>
    </form>
</body>
</html>
