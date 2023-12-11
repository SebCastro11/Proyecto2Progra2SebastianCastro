<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="EditarEquipo.aspx.cs" Inherits="Examen2SebastianCastro.EditarEquipo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="form-floating mb-3">
        <input type="text" class="form-control" id="editEquiposID" placeholder="Equipo ID" runat="server">
        <label for="editUsuarioID">ID del Equipo</label>
    </div>

    <div class="form-floating mb-3">
        <input type="text" class="form-control" id="editTipoEquipo" placeholder="Tipo Equipo" runat="server">
        <label for="editNombre">Tipo de Equipo</label>
    </div>

    <div class="form-floating mb-3">
        <input type="text" class="form-control" id="editModelo" placeholder="Model" runat="server">
        <label for="editCorreoElectronico">Modelo</label>
    </div>

    <div class="form-floating mb-3">
        <input type="text" class="form-control" id="editUsuarioID" placeholder="id" runat="server">
        <label for="editTelefono">UsuarioID</label>
    </div>

    <div>
        <asp:Button ID="btnUpdate" runat="server" Text="Actualizar" class="btn" OnClick="btnUpdate_Click" />
    </div>

    <div class="text-light container text-center">
        <asp:GridView ID="GridViewEquipos" runat="server" AutoGenerateColumns="True" Width="361px">
            <EditRowStyle BorderColor="White" />
        </asp:GridView>
    </div>

</asp:Content>
