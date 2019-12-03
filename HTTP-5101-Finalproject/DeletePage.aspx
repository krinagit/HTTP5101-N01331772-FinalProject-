<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DeletePage.aspx.cs" Inherits="HTTP_5101_Finalproject.DeletePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <h3>Are you sure you want to delete <span runat="server" id="pagetitle"></span> </h3>
     <div class="viewnav thin">
        <a class="left" href="ListOfPages.aspx?pageid=<%= Request.QueryString["pageid"] %>">No</a>
        <ASP:Button OnClick="Delete_Page" CssClass="right" Text="Yes" runat="server"/>   
         
     </div>
   
  </asp:Content>
