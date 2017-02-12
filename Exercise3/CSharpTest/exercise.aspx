<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="exercise.aspx.cs" Inherits="CSharpTest.exercise" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title></title>
    </head>
    <body>
        <form id="form1" runat="server">
            <div>
                <asp:TextBox ID="TextBoxText" runat="server" EnableViewState="False"></asp:TextBox>
                <asp:Button ID="ButtonChangeText" runat="server" Text="Change Text" OnClick="ButtonChangeText_Click" />
                <asp:Button ID="ButtonSendData" runat="server" Text="Send Data" OnClick="ButtonSendData_Click" />
            </div>
        </form>
    </body>
</html>
