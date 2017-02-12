<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="passdata1.aspx.cs" Inherits="CSharpTest.passdata1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title></title>
    </head>
    <body>
        <form id="form1" runat="server">
            <div>
                <asp:TextBox ID="TextBoxText" runat="server">Some text</asp:TextBox>
                <asp:Button ID="ButtonSend" runat="server" OnClick="ButtonSend_Click" Text="Send to Next Page" />
            </div>
        </form>
    </body>
</html>
