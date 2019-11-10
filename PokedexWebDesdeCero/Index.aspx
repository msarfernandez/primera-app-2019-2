<%@ Page Title="Index" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="PokedexWebDesdeCero.Index" %>

<%--<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

</asp:Content>--%>

<asp:Content runat="server" ID="LoQueSea" ContentPlaceHolderID="ContentPlaceHolder1">

    <h1>INDEX</h1>

    <%--<img src="<% "https://assets.pokemon.com/assets//cms2-es-es/img/misc/_tiles/generic/pokemon-169-m.jpg" %>"" alt="Alternate Text" />--%>
    <a href="ListaPokemon.aspx">Listado de Pokemons</a>

</asp:Content>
