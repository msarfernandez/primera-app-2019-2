<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Favoritos.aspx.cs" Inherits="PokedexWebDesdeCero.Favoritos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="row">
            <div class="col">
                <table class="table">
                    <tr>
                        <td>Nombre</td>
                        <td>Tipo</td>
                        <td>Accion</td>
                    </tr>
                    <%foreach (var poke in listaFavoritos)
                        {
                    %>

                    <tr>
                        <td><% = poke.Nombre %></td>
                        <td><% = poke.Tipo %></td>
                        <td><a href="Favoritos.aspx?idQuitar=<% = poke.Id.ToString() %>" class="btn btn-primary">Quitar</a></td>
                    </tr>


                    <% } %>
                </table>

            </div>

        </div>
    </div>



</asp:Content>
