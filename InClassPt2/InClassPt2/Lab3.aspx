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
    </form>
</body>
</html>
