<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="nuevoArticulo.aspx.cs" Inherits="PrimerPagina.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Nuevo Articulo</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Agregar articulo</h2>

    <div class="mt-5 mb-3">
        <label>Id: </label>
        <asp:TextBox runat="server" ID="tbID" CssClass="form-control w-50"> </asp:TextBox>
    </div>
    <div class="mt-5 mb-3">
    <label>Codigo: </label>
    <asp:TextBox runat="server" ID="tbCodigo" CssClass="form-control w-50"> </asp:TextBox>
</div>
    <div class="mt-5 mb-3">
    <label>Nombre: </label>
    <asp:TextBox runat="server" ID="tbNombre" CssClass="form-control w-50"> </asp:TextBox>
</div>
    <div class="mt-5 mb-3">
    <label>Direccion : </label>
    <asp:TextBox runat="server" ID="tbDireccion" CssClass="form-control w-50"> </asp:TextBox>
</div>
  <div class="mt-5 mb-3">
    <label>Altura : </label>
    <asp:TextBox runat="server" ID="tbAltura" CssClass="form-control w-50"> </asp:TextBox>
</div>

    <asp:Button CssClass="btn btn-primary" Text="Enviar" runat="server" ID="enviarArticulo" OnClick="enviarArticulo_Click"/>

    <label runat="server" id="mostrarInfo"></label>
</asp:Content>
