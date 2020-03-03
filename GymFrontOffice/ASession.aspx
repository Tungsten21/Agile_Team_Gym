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
          <asp:TextBox ID="sessionID" runat="server" Height="16px" Width="150px" TextMode="Number"></asp:TextBox>
            <br />
            <br />
            Trainer ID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TrainerID" runat="server" Height="16px" Width="150px" TextMode="Number"></asp:TextBox>
            <br />
            <br />
            Branch ID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="BranchID" runat="server" Height="16px" Width="150px" TextMode="Number"></asp:TextBox>
            <br />
            <br />
            Type:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:TextBox ID="Type" runat="server" Height="16px" Width="150px"></asp:TextBox>
            <br />
            <br />
            DateTime:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:Calendar ID="Calendar1" runat="server" Height="173px" style="margin-top: 0px" Width="299px"></asp:Calendar>
            <br />
            <br />
            Cost:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Cost" runat="server" Height="16px" Width="150px" ></asp:TextBox>
            <br />
            <br />
             <asp:CheckBox ID="EquipmentRequired" runat="server" Text="Equipment Required" TextAlign="Left" />
              <br />
              <br />
            <asp:Button ID="ok" runat="server" Height="20px" OnClick="Button1_Click" Text="OK" Width="60px" />
            <asp:Button ID="cancel" runat="server" Height="20px" OnClick="Button1_Click" Text="Cancel" Width="60px" />
        </div>
    </form>
</body>
</html>
