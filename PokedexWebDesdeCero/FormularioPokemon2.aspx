<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormularioPokemon2.aspx.cs" Inherits="PokedexWebDesdeCero.FormularioPokemon2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
            <asp:ValidationSummary runat="server" />
    <form id="form1" runat="server">
        <h1>Formulario Pokemon</h1>

        <div class="form-group">
            <label>Nombre</label>
            <asp:TextBox ID="txtNombre" CssClass="form-control" runat="server" />
        </div>
        <div class="form-group">
            <label>Descripcion</label>
            <asp:TextBox ID="txtDescripcion" ClientIDMode="Static" CssClass="form-control" runat="server" />
            <asp:RequiredFieldValidator ErrorMessage="Tenes que cargar la descropcion" ControlToValidate="txtDescripcion" runat="server" />
        </div>
        <div class="form-group form-check">
            <asp:CheckBox ID="chkEvolucion" Text="Tiene Evolución" runat="server" />
            <%--<label class="form-check-label" for="exampleCheck1">Check me out</label>--%>
        </div>
        <%--<asp:Button Text="Aceptar" ID="btnAceptar" autopostback="false" OnClientClick="validar();" CssClass="btn btn-primary" runat="server" />--%>
        <button onclick="validar();">Validar</button>
    </form>
</body>
</html>
