<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="exercise.aspx.cs" Inherits="Exercise2.exercise" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Exercise 2</title>
    <script src="Scripts/exercises.js"></script>
    <link href="Content/Layout.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="header">
        <h1 class="header__title">Genert</h1>
    </div>

    <table style="width:100%;">
        <tr>
            <td>Site</td>
            <td><a href="http://genert.org">GENERT.ORG Website</a></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/pattern.jpg" />
            </td>
        </tr>
    </table>

    </form>
    </body>
</html>
