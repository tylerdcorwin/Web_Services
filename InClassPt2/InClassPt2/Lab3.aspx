<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lab3.aspx.cs" Inherits="InClassPt2.Lab3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Get Weather Forecast for Boston<br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Get Boston Weather" />
    
    </div>
        <asp:TextBox ID="TextBox1" runat="server" Height="241px" TextMode="MultiLine" Width="605px"></asp:TextBox>
        <br />
        <br />
        <br />
        Enter Zip Code&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Get Cities for Zip Code" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Get Cities Nearby Zip" />
        <br />
        <asp:TextBox ID="TextBox3" runat="server" Height="145px" TextMode="MultiLine" Width="374px"></asp:TextBox>
    </form>
</body>
</html>
