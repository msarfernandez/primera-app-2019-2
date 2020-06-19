<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PokedexWeb.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Pokedex</title>
    <!-- CSS only -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" integrity="sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk" crossorigin="anonymous">
</head>
<body>

    <div class="container">
        <div class="row">
            <div class="col">
                <form id="form1" runat="server">
                    <div>
                        <img class="mb-4" src="/docs/4.5/assets/brand/bootstrap-solid.svg" alt="" width="72" height="72">
                        <h1 class="h3 mb-3 font-weight-normal">Login</h1>
                        <div class="forn-group">
                            <asp:TextBox runat="server" ID="txtUsuario" CssClass="form-control" placeholder="Usuario" required="" />
                            <%--<asp:RegularExpressionValidator ErrorMessage="Ingrese un mail valido" ControlToValidate="txtUsuario" runat="server" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"/>--%>
                        </div>
                        <div class="form-group">
                            <asp:TextBox runat="server" ID="txtPass" CssClass="form-control" placeholder="Password" required="" />
                        </div>
                        <asp:Button Text="Ingresar" runat="server" CssClass="btn btn-lg btn-primary" ID="btnIngresar" OnClick="btnIngresar_Click" />
                    </div>

                    <%-- esto es para probar si queremos dibujar algo o no en base a una condicion --%>
                    <% if (false)
                        { %>

                    <div>
                        <asp:Button Text="HOLA" runat="server" />
                    </div>

                    <% 
                        } %>
                </form>
            </div>
        </div>
    </div>
</body>
</html>
