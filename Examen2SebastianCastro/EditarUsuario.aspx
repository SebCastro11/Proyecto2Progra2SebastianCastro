<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="EditarUsuario.aspx.cs" Inherits="Examen2SebastianCastro.EditarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="form-floating mb-3">
        <input type="text" class="form-control" id="editUsuarioID" placeholder="User ID" runat="server" >
        <label for="editUsuarioID">ID del Usuario</label>
    </div>

    <div class="form-floating mb-3">
        <input type="text" class="form-control" id="editNombre" placeholder="Name" runat="server">
        <label for="editNombre">Nombre</label>
    </div>

    <div class="form-floating mb-3">
        <input type="text" class="form-control" id="editCorreoElectronico" placeholder="Email" runat="server">
        <label for="editCorreoElectronico">Correo Electronico</label>
    </div>

    <div class="form-floating mb-3">
        <input type="text" class="form-control" id="editTelefono" placeholder="Phone" runat="server">
        <label for="editTelefono">Telefono</label>
    </div>

    <div>
        <asp:Button ID="btnUpdate" runat="server" Text="Actualizar" class="btn" OnClick="btnUpdate_Click" />
    </div>

   <div class="text-light container text-center">
    <asp:GridView ID="GridViewUsuarios" runat="server" AutoGenerateColumns="True" Width="361px">
        <EditRowStyle BorderColor="White" />
    </asp:GridView>
</div>

</asp:Content>
