<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="JQueryDemo._Default" ClientIDMode="Static" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
 <script type="text/javascript" src="Scripts/jquery-1.10.2.min.js"></script>
 <script src="Scripts/JQueryDemo.js" type="text/javascript"></script>
    <link href="Styles/JQueryDemo.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <table class="style1">
        <tr>
            <td >
                <asp:Label ID="leftlabel" runat="server" Text="Label"></asp:Label>
            </td>
            <td >
                <asp:Label ID="rightLabel" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Label" CssClass="MainLabel"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Label" CssClass="MainLabel"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnChangeToGreen" runat="server" Text="Change To Green By ID" />
            </td>
            <td>
                <asp:Button ID="btnChangeToRed" runat="server" Text="Change To Red" />
            </td>
        </tr>
        <tr>
            <td>
                <input id="txtBox1" type="text" /><input id="btnMoveText" type="button" 
                    value="Move Text" /><input id="txtBox2" type="text" /><input 
                    id="btnAddToList" type="button" value="Add To List" /></td>
            <td>
                <div id="ListOfStuff">
                <ul class="entries">
                
                </ul>
                </div></td>
        </tr>
    </table>
</asp:Content>
