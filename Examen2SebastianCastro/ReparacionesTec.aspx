<%@ Page Title="" Language="C#" MasterPageFile="~/MenuTecnico.Master" AutoEventWireup="true" CodeBehind="ReparacionesTec.aspx.cs" Inherits="Examen2SebastianCastro.ReparacionesTec" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="form-floating mb-3">
        <input type="text" class="form-control" id="AddEquipoID" placeholder="Equipo ID" runat="server">
        <label for="AddEquipoID">ID del Equipo</label>
    </div>

    <div class="form-floating mb-3">
        <input type="text" class="form-control" id="AddFecha" placeholder="Fecha de solicitud" runat="server">
        <label for="AddFecha">Fecha de solicitud (mm-dd-yyyy)</label>
    </div>

    <div class="form-floating mb-3">
        <input type="text" class="form-control" id="AddEstado" placeholder="Estado" runat="server">
        <label for="AddEstado">Estado (0= Sin terminar 1= Terminado)</label>
    </div>

    <div>
        <asp:Button ID="btnAdd" runat="server" Text="Añadir Reparacion" class="btn" OnClick="btnAdd_Click" />
    </div>

</asp:Content>
