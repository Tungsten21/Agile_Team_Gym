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
          <asp:TextBox ID="txtSessionID" runat="server" Height="16px" Width="150px" TextMode="Number"></asp:TextBox>
            <br />
            <br />
            Trainer ID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtTrainerID" runat="server" Height="16px" Width="150px" TextMode="Number"></asp:TextBox>
            <br />
            <br />
            Branch ID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtBranchID" runat="server" Height="16px" Width="150px" TextMode="Number"></asp:TextBox>
            <br />
            <br />
            Type:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:TextBox ID="txtType" runat="server" Height="16px" Width="150px"></asp:TextBox>
            <br />
            <br />
             <asp:Label ID="lblDateTime" runat="server" Text="DateTime"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtDateTime" runat="server"></asp:TextBox>
            <br />
            <br />
            Cost:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCost" runat="server" Height="16px" Width="150px" ></asp:TextBox>
            <br />
            <br />
             <asp:CheckBox ID="chkEquipmentRequired" runat="server" Text="Equipment Required" TextAlign="Left" />
              <br />
              <br />
            <asp:Button ID="Ok" runat="server"  OnClick="Button1_Click" Text="OK" Width="103px" />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Cancel" runat="server" Text="Cancel" Width="103px" OnClick="Cancel_Click" />
        &nbsp;&nbsp;&nbsp;
           
            <asp:Button ID="Find" runat="server" Text="Find"  OnClick="Find_Click" Width="103px" />
            <br />
            <asp:Label ID="lblError" runat="server" Text="No Errors"></asp:Label>
        </div>
    </form>
</body>
</html>
