<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="Examen2SebastianCastro.Usuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="text-light container text-center">
        <asp:GridView ID="GridView1" runat="server" Height="136px" Width="361px">
            <EditRowStyle BorderColor="White" BorderStyle="Solid" />
        </asp:GridView>

    </div>
    <div class=" container text-center">

        <a href="AnadirUsuario.aspx" class="btn">Agregar Usuario</a>

    </div>

    <div class=" container text-center">

        <a href="EliminarUsuario.aspx" class="btn">Eliminar Usuario</a>

    </div>

    <div class=" container text-center">

        <a href="BuscarConFiltro.aspx" class="btn">Buscar</a>

    </div>

    <div class=" container text-center">

        <a href="EditarUsuario.aspx" class="btn">Editar</a>

    </div>




</asp:Content>
