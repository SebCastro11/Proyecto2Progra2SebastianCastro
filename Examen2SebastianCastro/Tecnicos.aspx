<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="Tecnicos.aspx.cs" Inherits="Examen2SebastianCastro.Tecnicos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="text-light container text-center">
    <asp:GridView ID="GridView1" runat="server" Height="136px" Width="361px">
        <EditRowStyle BorderColor="White" BorderStyle="Solid" />
    </asp:GridView>

</div>
<div class=" container text-center">

    <a href="AnadirTecnico.aspx" class="btn">Agregar Tecnico</a>

</div>

<div class=" container text-center">

    <a href="EliminarTecnico.aspx" class="btn">Eliminar Tecnico</a>

</div>

<div class=" container text-center">

    <a href="BuscarTecnico.aspx" class="btn">Buscar</a>

</div>

<div class=" container text-center">

    <a href="EditarTecnico.aspx" class="btn">Editar</a>

</div>

</asp:Content>
