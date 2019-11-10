<%@ Page Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="ListaPokemon.aspx.cs" Inherits="PokedexWebDesdeCero.ListaPokemon" %>

<asp:Content runat="server" ID="ListaPokemon" ContentPlaceHolderID="ContentPlaceHolder1">

    <h1>Lista Pokemons</h1>

    <asp:TextBox runat="server" AutoPostBack="true" ID="txtNumeroPokemon" OnTextChanged="txtNumeroPokemon_TextChanged" />
    <asp:DropDownList runat="server" ID="cboPokemons" />

    <div class="card-columns" style="margin-left: 10px; margin-right: 10px;">

        <%-- ESTO funciona perfecto, pero lo cambiamos por el repeater para poder usar el 
            pasaje de parámetros con el CommandArgument de un botón (el PRUEBA), ya que de ESTE modo, 
            no toma el valor. --%>
        <%--        <% foreach (var item in listaPokemons)
            { %>
        <div class="card">
            <img src="<% = item.UrlImagen %>" class="card-img-top" alt="...">
            <div class="card-body">
                <h5 class="card-title"><% = item.Nombre %></h5>
                <p class="card-text"><% = item.Descripcion %></p>
            </div>
            <a class="btn btn-primary" href="PokemonDetail.aspx?idpkm=<% = item.Id.ToString() %>">Seleccionar</a>
            <asp:Button Text="Prueba" CommandArgument='<%#"item.Id"%>' CommandName="idPokemon" runat="server" OnClick="Unnamed1_Click" />
        </div>
        <% } %>--%>

        <%-- Esto reemplaza el foreach. Vean que cambia la forma de pasar el argumento a cada tag.
            En este caso se usa el numeral (#) y la función Eval que recibe por parámetro como string
            el nombre de la property de tu objeto. El repeater va a iterar lo que esté dentro de la colección
             que le asignamos en el LOAD. Se lo asignamos directamente por ID, en este caso, repetidor.--%>
        <asp:Repeater runat="server" ID="repetidor">
            <ItemTemplate>
                <div class="card">
                    <img src="<%#Eval("UrlImagen") %>" class="card-img-top" alt="...">
                    <div class="card-body">
                        <h5 class="card-title"><%#Eval("Nombre")%></h5>
                        <p class="card-text"><%#Eval("Descripcion")%></p>
                    </div>
                    <a class="btn btn-primary" href="PokemonDetail.aspx?idpkm=<%#Eval("Id")%>">Seleccionar</a>
                    <asp:Button ID="btnArgumento" CssClass="btn btn-primary" Text="Argumento to Back" CommandArgument='<%#Eval("Id")%>' CommandName="idPokemon" runat="server" OnClick="btnArgumento_Click" />
                </div>
            </ItemTemplate>
        </asp:Repeater>

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
