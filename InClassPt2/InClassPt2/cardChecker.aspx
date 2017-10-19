<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cardChecker.aspx.cs" Inherits="InClassPt2.cardChecker" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Credit Card Checker<br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Check" />
    
    </div>
        <asp:TextBox ID="CCResult" runat="server" Height="117px" Width="238px"></asp:TextBox>

        <asp:Label ID="Label1" runat="server" Text="Number To Check"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Dictionary"></asp:Label>
        </p>
        <asp:Label ID="Label3" runat="server" Text="Word"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" style="margin-bottom: 0px"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Find Definition" />
        <br />
        <br />
        <asp:ListBox ID="ListBox1" runat="server" Height="190px" Width="631px"></asp:ListBox>
    </form>
</body>
</html>
