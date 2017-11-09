<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Banking.aspx.cs" Inherits="Problem1.Banking" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Owner:
        <asp:Label ID="lblOwner" runat="server" Text="lblOwner"></asp:Label>
    
    </div>
        AccountID:
        <asp:Label ID="lblAcntID" runat="server" Text="lblAcntID"></asp:Label>
        <br />
        TotalAmount:
        <asp:Label ID="lblTotal" runat="server" Text="lblTotal"></asp:Label>
        <p>
            <asp:Button ID="Button1" runat="server" Height="36px" OnClick="Button1_Click" Text="Button" />
        </p>
    </form>
</body>
</html>
