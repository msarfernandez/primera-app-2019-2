<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="PokemonDetail.aspx.cs" Inherits="PokedexWebDesdeCero.PokemonDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card" style="width: 25%">
            <img src="<% = pokemon.UrlImagen %>" class="card-img-top" alt="...">
            <div class="card-body">
                <h5 class="card-title"><% = pokemon.Nombre %></h5>
                <p class="card-text"><% = pokemon.Descripcion %></p>
            </div>
        </div>
</asp:Content>
