<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="SubirImagen.aspx.cs" Inherits="PokedexWebDesdeCero.SubirImagen" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col">
                <div class="form-group">
                    <label for="fileImagen">Seleccionar imagen a subir</label>
                    <input type="file" class="form-control-file" id="fileImagen" runat="server">
                </div>
                <asp:Button Text="Guardar" ID="btnGuardar" runat="server" cssclass="btn btn-primary" OnClick="btnGuardar_Click"/>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <div class="form-group">
                <asp:Label Text="" runat="server" id="lblMensaje"/>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
