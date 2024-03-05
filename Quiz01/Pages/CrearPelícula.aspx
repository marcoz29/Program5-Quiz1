<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CrearPelícula.aspx.cs" Inherits="Quiz01.Pages.CrearPelícula" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <h1>Formulario de creación
        </h1>
    </div>

    <div>
        <div>
            <span>Pelicula</span>
            <asp:TextBox ID="TxtNombre" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div>
            <span>Estreno</span>
            <asp:TextBox ID="TxtAnhoEstreno" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div>
            <span>Género</span>
            <asp:TextBox ID="TxtGenero" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="BtnGuardar" runat="server"
                Text="Guardar" BackColor="#33CC33"
                ForeColor="White" CssClass="btn btn-primary"
                OnClick="BtnGuardar_Click" />
        </div>

        <div>
            <a href="ListaPeliculas.aspx" class="btn btn-light">Cancelar</a>
        </div>
    </div>
</asp:Content>
