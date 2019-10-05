<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="PokemonForm.aspx.cs" Inherits="PokedexWebDesdeCero.PokemonForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script>

        function validar() {
            return;
            var descripcion = document.getElementById("txtDescripcion").value;
            console.log(descripcion);
            var nombre = document.getElementById("<% = txtNombre.ClientID %>").value;
            var evoluciona = $("# <% = chkEvolucion.ClientID %>").value;

            if (descripcion === "" || nombre === "") {
                alert("Debes completar los campos");
            }
            if (evoluciona) {
                alert("El pokemon evoluciona");
            }
            return;
        }

    </script>

    <h1>Formulario Pokemon</h1>
    
        <div class="form-group">
            <label>Nombre</label>
            <asp:TextBox ID="txtNombre" CssClass="form-control" runat="server" />
        </div>
        <div class="form-group">
            <label>Descripcion</label>
            <asp:TextBox ID="txtDescripcion" ClientIDMode="Static" CssClass="form-control" runat="server" />
        </div>
        <div class="form-group form-check">
            <asp:CheckBox ID="chkEvolucion" Text="Tiene Evolución" runat="server" />
            <%--<label class="form-check-label" for="exampleCheck1">Check me out</label>--%>
        </div>
    <%--<asp:Button Text="Aceptar" ID="btnAceptar" autopostback="false" OnClientClick="validar();" CssClass="btn btn-primary" runat="server" />--%>
    <button onclick="validar();">Validar</button>

</asp:Content>
