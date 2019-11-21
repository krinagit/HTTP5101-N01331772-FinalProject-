<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListOfPages.aspx.cs" Inherits="HTTP_5101_Finalproject.ListOfPages" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1></h1>
   
  
    <div class="animallovers" runat="server">
        <div class="listitem">
            <div class="col4">ANIMAL ID</div>
            <div class="col4">ANIMAL NAME</div>
            <div class="col4">ABOUT ANIMAL</div>
            
        </div>
        <div id="animal_result" runat="server">

        </div>
    </div>
</asp:Content>
