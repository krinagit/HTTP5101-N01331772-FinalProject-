<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListOfPages.aspx.cs" Inherits="HTTP_5101_Finalproject.ListOfPages" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="page_list" runat="server"></div> 
  
    <div><a href="AddPage.aspx">Add Page</a></div>
   
    <div class="page" runat="server">   
        <div class="listitem">
            <%--<div class="col4">PAGE ID</div>--%>
            <div class="col4">PAGE TITLE</div>
            <div class="col4">PAGE BODY</div>
            
        </div>
        <div id="page_result" runat="server">

        </div>
    </div>
</asp:Content>

   