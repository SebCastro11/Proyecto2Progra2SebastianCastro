<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="EditarTecnico.aspx.cs" Inherits="Examen2SebastianCastro.EditarTecnico" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div class="form-floating mb-3">
     <input type="text" class="form-control" id="editTecnicoID" placeholder="Equipo ID" runat="server">
     <label for="editUsuarioID">ID del Tecnico</label>
 </div>

 <div class="form-floating mb-3">
     <input type="text" class="form-control" id="editNombre" placeholder="Tipo Equipo" runat="server">
     <label for="editNombre">Nombre de Tecnico</label>
 </div>

 <div class="form-floating mb-3">
     <input type="text" class="form-control" id="editEspecialidad" placeholder="Model" runat="server">
     <label for="editCorreoElectronico">Especialidad</label>
 </div>

 <div>
     <asp:Button ID="btnUpdate" runat="server" Text="Actualizar" class="btn" OnClick="btnUpdate_Click" />
 </div>

 <div class="text-light container text-center">
     <asp:GridView ID="GridViewTecnicos" runat="server" AutoGenerateColumns="True" Width="361px">
         <EditRowStyle BorderColor="White" />
     </asp:GridView>
 </div>


</asp:Content>
