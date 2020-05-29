<%@ Page Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="ListaPokemon.aspx.cs" Inherits="PokedexWebDesdeCero.ListaPokemon" %>

<asp:Content runat="server" ID="ListaPokemon" ContentPlaceHolderID="ContentPlaceHolder1">

    <h1>Lista Pokemons</h1>

    <asp:TextBox runat="server" AutoPostBack="true" ID="txtNumeroPokemon" OnTextChanged="txtNumeroPokemon_TextChanged" />
    <asp:DropDownList runat="server" ID="cboPokemons" />

    <div class="card-columns" style="margin-left: 10px; margin-right: 10px;">

        <%-- ESTO funciona perfecto, pero lo cambiamos por el repeater para poder usar el 
            pasaje de parámetros con el CommandArgument de un botón (el PRUEBA), ya que de ESTE modo, 
            no toma el valor. --%>
        <% foreach (var item in listaPokemons)
            { %>
        <div class="card" style="width: 18rem;">
            <img src="<% = item.UrlImagen %>" class="card-img-top" alt="...">
            <div class="card-body">
                <h5 class="card-title"><% = item.Nombre %></h5>
                <p class="card-text"><% = item.Descripcion %></p>
                <a href="PokemonDetail.aspx?idpkm=<% = item.Id.ToString() %>" class="btn btn-primary">Seleccionar</a>
                <a href="Favoritos.aspx?idpkm=<% = item.Id.ToString() %>" class="btn btn-primary">Fav</a>
            </div>
        </div>
        <% } %>




        <%-- Esto reemplaza el foreach. Vean que cambia la forma de pasar el argumento a cada tag.
            En este caso se usa el numeral (#) y la función Eval que recibe por parámetro como string
            el nombre de la property de tu objeto. El repeater va a iterar lo que esté dentro de la colección
             que le asignamos en el LOAD. Se lo asignamos directamente por ID, en este caso, repetidor.--%>
        <%--        <asp:Repeater runat="server" ID="repetidor">
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
        </asp:Repeater>--%>
    </div>

    <%--<asp:TextBox runat="server" ID="txtTextbox" />--%>


    <%-- MSF-20200522: para poder hacer funcionar el Seleccionar del grid hay varias cosas..
        Por un lado la cuestion era agregar el OnSelectedIndexChange a nivel GridView y alli agregar el evento.
        Luegon un ButtonField como tenia con el commandName Select (esto no seria del todo necesario, es un identificador).
        Luego, vean en el evento que lo que hago es levantar el argumento que llega, esa parte es sencilla.
        PERO PERO PERO, cual argumento? Bueno, tenemos que elegir o el index de la grilla (no me servia para nada)
        o algun dato disponible en la grilla... tampoco me servia ninguno. Lo que hice fue agregar el ID a la grilla.
        Pero no queremos mostrar el id en la grilla... entonces visible false... pero si hacemos eso no va a estar diponible el 
        dato ya que ni siquiera se dibuja en html si ASP dice que va en visible false... entonces? ocultarlo por css, 
        pero no se le puede mandar style inline, asi que hice la siguiente class css, pero tampoco se le puede agregar UNA clase de una...
        entonces hay que usar las properties HeaderStyle-CssClass e ItemStyle-CssClass como ven a continuacion...
        Un par de vueltas? Si... asi es la vida... jaja. Mas adelante cuando usen cosas mas sofisticadas QUIZAS, QUIZASSS estos temas
        sean mas sencillos de resolver... pero seguro habran otros.--%>
    <style>
        .oculto {
            display: none;
        }
    </style>

    <asp:GridView CssClass="table" ID="dgvPokemons" runat="server" AutoGenerateColumns="false" OnSelectedIndexChanged="dgvPokemones_SelectedIndexChanged" OnRowCommand="dgvPokemons_RowCommand">
        <Columns>
            <asp:ButtonField HeaderText="Opcion" ButtonType="Link" Text="Seleccionar" CommandName="Select" />
            <asp:BoundField HeaderText="Id" DataField="Id" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />
            <asp:BoundField HeaderText="PokeNombre" DataField="Nombre" />
            <asp:BoundField HeaderText="Caracteristicas" DataField="Descripcion" />
        </Columns>
    </asp:GridView>

    <asp:Button ID="txtNavegar" Text="Navegar" runat="server" OnClick="txtNavegar_Click" />


    <%--<input type="type" runat="server" id="txtInput" name="name" value="" />--%>
    <%-- Esto es un ejemplo para que vean que no se ve desde el server --%>
    <%--    <table id="miTabla">
        <tr>
            <td></td>
        </tr>
    </table>--%>
</asp:Content>
