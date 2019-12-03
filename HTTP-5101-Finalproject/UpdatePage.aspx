<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdatePage.aspx.cs" Inherits="HTTP_5101_Finalproject.UpdatePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="page" runat="server">
        <div class="viewnav">
            <a class="left" href="ViewPage.aspx?pageid=<%=Request.QueryString["pageid"] %>">Cancel</a>
        </div>
        <h2>Updating <span id="update_page" runat="server"></span></h2>
        
        <div class="formrow">
            <label>Page Title</label>
            <asp:TextBox runat="server" ID="page_title"></asp:TextBox>
        </div>
        <div class="formrow">
            <label>Page Body</label>
            <asp:TextBox runat="server" ID="page_body"></asp:TextBox>
        </div>


        <asp:Button Text="Update Page" OnClick="Update_Page" runat="server" />

        
    </div>
</asp:Content>
