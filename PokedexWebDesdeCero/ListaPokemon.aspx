<%@ Page Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="ListaPokemon.aspx.cs" Inherits="PokedexWebDesdeCero.ListaPokemon" %>

<asp:Content runat="server" ID="ListaPokemon" ContentPlaceHolderID="ContentPlaceHolder1">

    <h1>Lista Pokemons</h1>

    <asp:TextBox runat="server" AutoPostBack="true" Id="txtNumeroPokemon" OnTextChanged="txtNumeroPokemon_TextChanged" />
    <asp:DropDownList runat="server" ID="cboPokemons" />

    <div class="card-columns" style="margin-left: 10px; margin-right: 10px;">

        <% foreach (var item in listaPokemons)
            { %>
        <div class="card">
            <img src="<% = item.UrlImagen %>" class="card-img-top" alt="...">
            <div class="card-body">
                <h5 class="card-title"><% = item.Nombre %></h5>
                <p class="card-text"><% = item.Descripcion %></p>
            </div>
        </div>
        <% } %>
    </div>

    <%--<asp:TextBox runat="server" ID="txtTextbox" />--%>

    <%--    <asp:GridView CssClass="table" ID="dgvPokemones" runat="server" AutoGenerateColumns="false" OnSelectedIndexChanged="dgvPokemones_SelectedIndexChanged">
        <Columns>
            <asp:BoundField HeaderText="PokeNombre" DataField="Nombre" />
            <asp:BoundField HeaderText="Caracteristicas" DataField="Descripcion" />
            <asp:ButtonField HeaderText="Opcion" ButtonType="Link" CommandName="dgvPokemones_SelectedIndexChanged" />
        </Columns>            
    </asp:GridView>

    <asp:Button ID="txtNavegar" Text="Navegar" runat="server" OnClick="txtNavegar_Click" />--%>


    <%--<input type="type" runat="server" id="txtInput" name="name" value="" />--%>
    <%-- Esto es un ejemplo para que vean que no se ve desde el server --%>
    <%--    <table id="miTabla">
        <tr>
            <td></td>
        </tr>
    </table>--%>
</asp:Content>
