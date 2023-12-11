<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="Equipos.aspx.cs" Inherits="Examen2SebastianCastro.Equipos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
    <div class="text-light container text-center">
        <asp:GridView ID="GridView1" runat="server" Height="136px" Width="361px">
            <EditRowStyle BorderColor="White" BorderStyle="Solid" />
        </asp:GridView>

    </div>
    <div class=" container text-center">

        <a href="AnadirEquipos.aspx" class="btn">Agregar Equipo</a>

    </div>

    <div class=" container text-center">

        <a href="EliminarEquipo.aspx" class="btn">Eliminar Equipo</a>

    </div>

    <div class=" container text-center">

        <a href="BuscarEquipos.aspx" class="btn">Buscar</a>

    </div>

    <div class=" container text-center">

        <a href="EditarEquipo.aspx" class="btn">Editar</a>

    </div>



</asp:Content>
