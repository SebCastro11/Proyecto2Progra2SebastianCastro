<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="Asignaciones.aspx.cs" Inherits="Examen2SebastianCastro.Asignaciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div class="form-floating mb-3">
        <input type="text" class="form-control" id="AddReparacionID" placeholder="Reparacion ID" runat="server">
        <label for="AddReparacionID">ID de la reparacion</label>
    </div>

    <div class="form-floating mb-3">
        <input type="text" class="form-control" id="AddTecnicoID" placeholder="Tecnico ID" runat="server">
        <label for="AddTecnicoID">ID del Tecnico</label>
    </div>

    <div class="form-floating mb-3">
        <input type="text" class="form-control" id="AddFecha" placeholder="Fecha Asignacion" runat="server">
        <label for="AddFecha">Fecha de asignacion (mm-dd-yyyy)</label>
    </div>

    <div>
        <asp:Button ID="btnAdd" runat="server" Text="Añadir Asignacion" class="btn" OnClick="btnAdd_Click" />
    </div>

</asp:Content>
