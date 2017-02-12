<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="postbacktest.aspx.cs" Inherits="CSharpTest.postbacktest" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title></title>
    </head>
    <body>
        <form id="form1" runat="server">
            <div>
                <asp:Label ID="LabelIsPostBack" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
            </div>
            <div>
                <asp:DropDownList ID="DropDownListPostBack" runat="server" AutoPostBack="True">
                    <asp:ListItem>Yes</asp:ListItem>
                    <asp:ListItem>No</asp:ListItem>
                    <asp:ListItem>Maybe</asp:ListItem>
                </asp:DropDownList>
                <asp:CheckBox ID="CheckBoxPostBack" runat="server" />
                <asp:Button ID="ButtonPostBack" runat="server" Text="Click Me" />
            </div>
            <div>
                <asp:Label ID="LabelResult" runat="server"></asp:Label>
            </div>
        </form>
    </body>
</html>
