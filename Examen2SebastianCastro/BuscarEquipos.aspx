<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="BuscarEquipos.aspx.cs" Inherits="Examen2SebastianCastro.BuscarEquipos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="form-floating mb-3">
        <input type="text" class="form-control" id="txtEquiposID" placeholder="Equipo ID" runat="server">
        <label for="txtUsuarioID">ID del Equipo</label>
    </div>

    <div>
        <asp:Button ID="btnSearchByID" runat="server" Text="Buscar" class="btn" OnClick="btnSearchByID_Click" />
    </div>

    <div class="text-light container text-center">
        <asp:GridView ID="GridViewEquipos" runat="server" AutoGenerateColumns="True" Width="361px">
            <EditRowStyle BorderColor="White" />
        </asp:GridView>
    </div>


</asp:Content>
