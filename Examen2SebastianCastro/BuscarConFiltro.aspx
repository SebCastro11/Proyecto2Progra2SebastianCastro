<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="BuscarConFiltro.aspx.cs" Inherits="Examen2SebastianCastro.BuscarConFiltro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="form-floating mb-3">
        <input type="text" class="form-control" id="txtUsuarioID" placeholder="User ID" runat="server">
        <label for="txtUsuarioID">ID del Usuario</label>
    </div>

    <div>
        <asp:Button ID="btnSearchByID" runat="server" Text="Search by ID" class="btn" OnClick="btnSearchByID_Click" />
    </div>

    <div class="text-light container text-center">
        <asp:GridView ID="GridViewUsuarios" runat="server" AutoGenerateColumns="True" Width="361px">
            <EditRowStyle BorderColor="White" />
        </asp:GridView>
    </div>

</asp:Content>
