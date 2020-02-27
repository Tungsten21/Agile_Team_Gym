<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ASession.aspx.cs" Inherits="ASession" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <div style="height: 397px">
            Session ID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      //      <asp:TextBox ID="sessionID" runat="server" Height="16px" Width="150px" TextMode="Number" OnTextChanged="sessionID_TextChanged"></asp:TextBox> &nbsp;&nbsp;&nbsp;
            <br />
            Trainer ID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="trainerID0" runat="server" Height="16px" Width="150px" TextMode="Number"></asp:TextBox>
            <br />
            Branch ID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="trainerID1" runat="server" Height="16px" Width="150px" TextMode="Number"></asp:TextBox>
            <br />
            Type:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="trainerID2" runat="server" Height="16px" Width="150px" TextMode="Number"></asp:TextBox>
            <br />
            DateTime:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="trainerID3" runat="server" Height="16px" Width="150px" TextMode="Number"></asp:TextBox>
            <br />
            Cost:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="trainerID4" runat="server" Height="16px" Width="150px" TextMode="Number"></asp:TextBox>
            <br />
             <asp:CheckBox ID="EquipmentRequired" runat="server" Text="Equipment Required" TextAlign="Left" OnCheckedChanged="EquipmentRequired_CheckedChanged" />
              <br />
            <asp:Button ID="ok" runat="server" Height="20px" OnClick="Button1_Click" Text="OK" Width="60px" />
            <asp:Button ID="cancel" runat="server" Height="20px" OnClick="Button1_Click" Text="Cancel" Width="60px" />
        </div>
    </form>
</body>
</html>
