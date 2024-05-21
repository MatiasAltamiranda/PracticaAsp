<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="PrimerPagina.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row mt-5">
        <div class="col-7 mx-auto">
            <asp:GridView CssClass="table table-dark table-striped table-bordered" runat="server" ID="dgvArticulo" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField HeaderText="Codigo" DataField="codigo" />
                    <asp:BoundField HeaderText="Titulo" DataField="nombre" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
