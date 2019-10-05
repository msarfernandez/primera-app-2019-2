<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="PokemonForm.aspx.cs" Inherits="PokedexWebDesdeCero.PokemonForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script>

        function validar() {
            var descripcion = document.getElementById("txtDescripcion").value;
            console.log(descripcion);
            var nombre = document.getElementById("<% = txtNombre.ClientID %>").value;
            var evoluciona = $("#<%= chkEvolucion.ClientID %>").is(":checked");
            console.log(evoluciona);

            if (descripcion === "" || nombre === "") {
                alert("Debes completar los campos");
                return false;
            }
            if (evoluciona) {
                alert("El pokemon evoluciona");
            }
            return true;
        }

    </script>

    <h1>Formulario Pokemon</h1>
    
        <div class="form-group">
            <label>Nombre</label>
            <asp:TextBox ID="txtNombre" CssClass="form-control" runat="server" />
        </div>
        <div class="form-group">
            <label>Descripcion</label>
            <asp:TextBox ID="txtDescripcion" MaxLength="20" ClientIDMode="Static" CssClass="form-control" runat="server" />
            <asp:RangeValidator ErrorMessage="El valor es incorrecto" MaximumValue="20" MinimumValue="0" ControlToValidate="txtDescripcion" runat="server" />
        </div>
        <div class="form-group form-check">
            <asp:CheckBox ID="chkEvolucion" Text="Tiene Evolución" runat="server" />
            <%--<label class="form-check-label" for="exampleCheck1">Check me out</label>--%>
        </div>
    <asp:Button Text="Aceptar" ID="btnAceptar" autopostback="false" OnClientClick="return validar()" OnClick="btnAceptar_Click" CssClass="btn btn-primary" runat="server" />


</asp:Content>
