<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddPage.aspx.cs" Inherits="HTTP_5101_Finalproject.AddPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>New Page</h2>
    <div class="formrow">
        <label>Page Title</label>
        <asp:TextBox runat="server" ID="page_title"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="page_title" ErrorMessage="Please enter a page title"></asp:RequiredFieldValidator>
   
    </div>
    <div class="formrow">
        <label>Page Body</label>
        <asp:TextBox runat="server" ID="page_body"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="page_body" ErrorMessage="Please Enter a page content"></asp:RequiredFieldValidator>

    </div>

        <div class="Add">
            <asp:Button OnClick="Add_Page" Text="Add Page" runat="server" />
        </div>
</asp:Content>
