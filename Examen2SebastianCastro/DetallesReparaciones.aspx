<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="DetallesReparaciones.aspx.cs" Inherits="Examen2SebastianCastro.DetallesReparaciones" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   <div class="form-floating mb-3">
        <input type="text" class="form-control" id="addRepID" placeholder="Reparacion ID" runat="server">
        <label for="addRepID">ID de la Reparacion</label>
    </div>

    <div class="form-floating mb-3">
        <input type="text" class="form-control" id="Descripcion" placeholder="Descripcion" runat="server">
        <label for="Descripcion">Descripcion</label>
    </div>

    <div class="form-floating mb-3">
        <input type="text" class="form-control" id="addDate" placeholder="Fecha de inicio" runat="server">
        <label for="addDate">Fecha de Solicitud (mm-dd-yyyy)</label>
    </div>

        <div class="form-floating mb-3">
        <input type="text" class="form-control" id="addFechaFin" placeholder="Fecha Fin" runat="server">
        <label for="addIDTec">Fecha Fin (mm-dd-yyyy)</label>
    </div>

    <div>
        <asp:Button ID="btnUpdate" runat="server" Text="Añadir Detalles" class="btn" OnClick="btnUpdate_Click" />
    </div>

</asp:Content>
