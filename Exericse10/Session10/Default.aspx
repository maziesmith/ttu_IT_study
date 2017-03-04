<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Session10._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <asp:Panel ID="PanelAddCustomer" runat="server">
        <h1>
            New Customer
        </h1>
        <table>
            <tr>
                <td>
                    Customer Name
                </td>
                <td>
                    <asp:TextBox ID="TextBoxNewCustomerName" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        <br />
        <asp:Button ID="ButtonAddCustomer" runat="server" Text="Add Customer" OnClick="ButtonAddCustomer_Click" />
    </asp:Panel>
    <asp:Panel ID="PanelEditCustomer" runat="server">
        <h1>
            Edit Customer
        </h1>
        <table>
            <tr>
                <td>
                    Customer Name
                </td>
                <td>
                    <asp:TextBox ID="TextBoxEditCustomerName" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        <asp:Button ID="ButtonSaveCustomer" runat="server" Text="Save Customer" OnClick="ButtonSaveCustomer_Click" />
    </asp:Panel>
    <asp:Label ID="LabelError" runat="server"></asp:Label>
</asp:Content>
