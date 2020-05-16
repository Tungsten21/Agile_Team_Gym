<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ATrainer.aspx.cs" Inherits="ATrainer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="lblTrainerID">
            TrainerID
            <asp:TextBox ID="txtTrainerID" runat="server" Height="16px" OnTextChanged="txtTrainerID_TextChanged" TextMode="Number"></asp:TextBox>
&nbsp;<asp:Button ID="btnFind" runat="server" Height="20px" OnClick="btnFind_Click" Text="Find" Width="78px" />
            <br />
        <div id="lblFullName">
            Fullname&nbsp;
            <asp:TextBox ID="txtFullname" runat="server" Height="16px"></asp:TextBox>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Gender"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtGender" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:Label ID="lblDateOfBirth" runat="server" Text="D.O.B"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtDateOfBirth" runat="server"></asp:TextBox>
        </div>
            <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br />
            <asp:CheckBox ID="chkRetrained" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged1" Text="Retrained in the last 3 years?" TextAlign="Left" />
            <br />
            <br />
            <asp:Button ID="btnView" runat="server" OnClick="btnView_Click" Text="OK" Width="103px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" Width="103px" OnClick="btnCancel_Click" />
            <br />
            <asp:Label ID="lblError" runat="server" BackColor="#CC0000" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px" Text="No errors!"></asp:Label>
        </div>
    </form>
</body>
</html>
