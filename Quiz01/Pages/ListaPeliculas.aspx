<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaPeliculas.aspx.cs" Inherits="Quiz01.Pages.ListaPeliculas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <h1>
            Lista de películas
        </h1>
    </div>

    <div>
        <a href="CrearPelícula.aspx" class="btn btn-primary">Nuevo registro</a>
    </div>

    <div class="primary-container">

        <asp:GridView ID="GvListarPeliculas" runat="server" AutoGenerateColumns="true" CssClass="table table-striped">
        </asp:GridView>

    </div>
</asp:Content>
