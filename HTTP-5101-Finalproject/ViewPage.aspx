<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewPage.aspx.cs" Inherits="HTTP_5101_Finalproject.ViewPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div id="updatepage" runat="server"></div>
     <div><a href="DeletePage.aspx"></a></div>
    <div id="http_page" runat="server">
        <h2><span id="page_title" runat="server"></span></h2>
        <p><span id="page_body" runat="server"></span></p>
    </div>
    <a class="btn" href="ListOfPages.aspx">Back to List</a>
</asp:Content>
