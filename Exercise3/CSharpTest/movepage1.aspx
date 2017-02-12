<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="movepage1.aspx.cs" Inherits="CSharpTest.movepage1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title></title>
    </head>
    <body>
        <form id="form1" runat="server">
            <div>
                <asp:Button ID="ButtonMove" runat="server" Text="Go to Next Page" onclick="ButtonMove_Click" />
                <a href="movepage2.aspx">Next Page</a>
            </div>
        </form>
    </body>
</html>
