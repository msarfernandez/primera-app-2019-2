<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="DropDowns.aspx.cs" Inherits="PokedexWebDesdeCero.DropDowns" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

    <div class="container">
        <div class="row">
            <div class="col">
                <h1>Despleglables (DropDownList)</h1>
                <h3>Estatico</h3>
                <div class="form-group">
                    <asp:Label Text="Colores" runat="server" />
                    <asp:DropDownList runat="server" CssClass="form-control" ID="ddlColores">
                        <asp:ListItem Text="Verde" />
                        <asp:ListItem Text="Amarillo" />
                        <asp:ListItem Text="Azul" />
                    </asp:DropDownList>
                </div>

                <h3>Desplegable desde DB</h3>
                <div class="form-group">
                    <asp:Label Text="Pokemons" runat="server" />
                    <asp:DropDownList runat="server" ID="ddlPokemons" CssClass="form-control">
                    </asp:DropDownList>
                </div>

                <h3>Update panel</h3>
                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                        <div class="form-group">
                            <div class="row">
                                <div class="col">
                                    <asp:Label Text="text" runat="server" ID="lblNombre" />
                                </div>
                                <div class="col">
                                    <asp:TextBox AutoPostBack="true" runat="server" ID="txtNombre" OnTextChanged="txtNombre_TextChanged" CssClass="form-control" />
                                </div>
                                <div class="col">
                                    <asp:Button Text="Aceptar" CssClass="form-control" runat="server" ID="btnAceptar" OnClick="btnAceptar_Click" />
                                </div>
                            </div>
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>

                <h3>Desplegable desde DB Agrupados</h3>
                <div class="form-group">
                    <asp:UpdatePanel runat="server">
                        <ContentTemplate>
                            <div class="row">
                                <div class="col">
                                    <asp:Label Text="Tipos" runat="server" />
                                    <asp:DropDownList runat="server" ID="ddlTipos" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="ddlTipos_SelectedIndexChanged">
                                    </asp:DropDownList>
                                </div>
                                <div class="col">
                                    <asp:Label Text="Pokemons" runat="server" />
                                    <asp:DropDownList runat="server" ID="ddlPokemonsFiltrados" CssClass="form-control">
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    <hr />
                    <h3>Desplegable pre seleccionado</h3>
                    <div class="form-group">
                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <asp:Label Text="ID" runat="server" />
                                    <asp:TextBox runat="server" ID="txtIdTipo" CssClass="form-control" />
                                </div>
                                <asp:Button Text="Aceptar" runat="server" CssClass="btn btn-primary" ID="btnSeleccionar" OnClick="btnSeleccionar_Click" />
                            </div>
                            <div class="col">
                                <div class="form-group">
                                    <asp:Label Text="Tipo Preseleccionado" runat="server" />
                                    <asp:DropDownList runat="server" ID="ddlTipoPreseleccionado" CssClass="form-control">
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </div>
                    </div>
                    <h3>Imagen Rapido</h3>
                    <div class="row">
                        <div class="col">
                            <asp:UpdatePanel runat="server">
                                <ContentTemplate>
                                    <div class="form-group">
                                        <asp:TextBox runat="server" ID="txtUrlImagen" CssClass="form-control" />
                                        <asp:Button Text="Cargar" runat="server" ID="btnCargar" CssClass="btn btn-primary" OnClick="Cargar_Click" />
                                        <img src="<% = urlImagen %>" alt="Alternate Text" />
                                    </div>

                                </ContentTemplate>
                            </asp:UpdatePanel>

                        </div>
                    </div>
                </div>
            </div>
        </div>
</asp:Content>
