<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="PrimerPagina.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Inicio</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row mt-5">
        <div class="col-7 mx-auto">
            <asp:GridView CssClass="table table-dark table-striped table-bordered" DataKeyNames="Id" OnSelectedIndexChanged="dgvArticulo_SelectedIndexChanged" runat="server" ID="dgvArticulo" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField HeaderText="Codigo" DataField="codigo" />
                    <asp:BoundField HeaderText="Titulo" DataField="nombre" />
                    <asp:BoundField HeaderText="Direccion" DataField="direccion" />
                    <asp:CheckBoxField  HeaderText="Importado" DataField="importado" />
                    <asp:CommandField ShowSelectButton="true" SelectText="Seleccionar" HeaderText="Acción" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
        <a href="nuevoArticulo.aspx" class="btn btn-primary">Agregar</a>
</asp:Content>
