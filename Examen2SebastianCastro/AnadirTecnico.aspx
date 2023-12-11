<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="AnadirTecnico.aspx.cs" Inherits="Examen2SebastianCastro.AnadirTecnico" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="form-floating mb-3">

        <input type="text" class="form-control" id="addNombre" placeholder="name@example.com" runat="server">
        <label for="floatingInput">Nombre de Tecnico</label>
    </div>

    <div class="form-floating mb-3">

        <input type="text" class="form-control" id="addEspecialidad" placeholder="84753695" runat="server">
        <label for="floatingInput">Especialidad</label>
    </div>

    <div>

        <asp:Button ID="Button1" runat="server" Text="Agregar" class="btn" OnClick="Button1_Click" />

    </div>

</asp:Content>
