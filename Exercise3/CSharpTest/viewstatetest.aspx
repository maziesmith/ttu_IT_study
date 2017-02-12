<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewstatetest.aspx.cs" Inherits="CSharpTest.viewstatetest" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title></title>
    </head>
    <body>
        <form id="form1" runat="server">
            <div>
                <asp:Label ID="LabelText" runat="server" 
                    Text="Unchanged Text" EnableViewState="False"></asp:Label>
            </div>
            <div>
                <asp:Button ID="ButtonChangeText" runat="server" Text="Change Text" 
                    onclick="ButtonChangeText_Click" />
                <asp:Button ID="ButtonPostBack" runat="server" Text="Just Post Back" 
                    onclick="ButtonPostBack_Click" />
            </div>
            <asp:TextBox ID="TextBoxViewState" runat="server"></asp:TextBox>
        </form>
    </body>
</html>
