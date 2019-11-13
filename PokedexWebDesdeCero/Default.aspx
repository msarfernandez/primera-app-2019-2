<%@ Page Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PokedexWebDesdeCero.Default" %>

<asp:Content runat="server" ID="Default" ContentPlaceHolderID="ContentPlaceHolder1">

    <h1>DEFAULT</h1>
    <asp:Label Text="Desplegable de Pokemon" runat="server" />
    <asp:DropDownList runat="server" ID="ddlPokemon"></asp:DropDownList>
    <asp:Button Text="Seleccionar Pokemon" ID="btnSeleccionar" runat="server" OnClick="btnSeleccionar_Click" />
    <asp:Label Text="nada seleccionado" ID="lblSeleccion" runat="server" />

</asp:Content>