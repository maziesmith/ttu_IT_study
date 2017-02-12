<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="CSharpTest._default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>Exercise 3</title>
    </head>
    <body>
        <form id="form1" runat="server">
            <div>
                <asp:Label ID="LabelOutput" runat="server" Text="Label"></asp:Label>
                <asp:Button ID="ButtonChangeText" runat="server" OnClick="ButtonChangeText_Click" Text="Button" />
            </div>
            <asp:Calendar ID="CalendarSelect" runat="server" OnSelectionChanged="CalendarSelect_SelectionChanged"></asp:Calendar>
        </form>
    </body>
</html>
