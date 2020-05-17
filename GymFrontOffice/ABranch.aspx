<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ABranch.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 378px;
        }
    </style>
</head>
<body style="height: 409px; width: 1241px">
    <form id="form1" runat="server">
        GymID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtbxGymID" runat="server" Height="16px" TextMode="Number"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            GymCity &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; <asp:TextBox ID="txtbxGymCity" runat="server" Height="16px"></asp:TextBox>
            <br />
            GymAddress&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtbxGymAddress" runat="server" Height="16px"></asp:TextBox>
            <br />
            DateOpened &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            <asp:TextBox ID="txtbxDateOpened" runat="server" Height="16px"></asp:TextBox>
            <br />
            Session Count&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtbxSessionCount" runat="server" Height="16px"></asp:TextBox>
            <br />
            <asp:CheckBox ID="chkbxAmmenities" runat="server" Text="Ammenities Provided?                                     " TextAlign="Left" />
            <br />
            <br />
            <asp:Button ID="bttnOK" runat="server" Height="30px" OnClick="bttnOK_Click" Text="OK" Width="100px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="bttnCancel" runat="server" Height="30px" Text="Cancel" Width="100px" OnClick="bttnCancel_Click" />
            <br />
            <asp:Button ID="bttnFind" runat="server" Height="26px" OnClick="bttnFind_Click" Text="Find" Width="292px" />
            <br />
            <p>
            <asp:Label ID="lblErrorMessage" runat="server" BorderWidth="1px" Text="No Errors"></asp:Label>
        </p>
    </form>
</body>
</html>
