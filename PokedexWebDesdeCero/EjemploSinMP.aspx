<%@ Page Language="C#" MasterPageFile="~/Principal.Master"  AutoEventWireup="true" CodeBehind="EjemploSinMP.aspx.cs" Inherits="PokedexWebDesdeCero.EjemploSinMP" %>

<%--<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>No tiene nada</h1>
        </div>
    </form>
</body>
</html>--%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="#" rel="stylesheet" />
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>esta es la pagina SIN MP ahora con MP</h1>
</asp:Content>