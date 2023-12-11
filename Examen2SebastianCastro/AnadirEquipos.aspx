<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="AnadirEquipos.aspx.cs" Inherits="Examen2SebastianCastro.AnadirEquipos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="form-floating mb-3">

        <input type="text" class="form-control" id="addTipo" placeholder="name@example.com" runat="server">
        <label for="floatingInput">Tipo de Equipo</label>
    </div>

    <div class="form-floating mb-3">

        <input type="text" class="form-control" id="addModelo" placeholder="84753695" runat="server">
        <label for="floatingInput">Modelo</label>
    </div>

    <div class="form-floating mb-3">

        <input type="text" class="form-control" id="addUsuarioID" placeholder="name" runat="server">
        <label for="floatingInput">ID del Usuario</label>
    </div>


    <div>

        <asp:Button ID="Button1" runat="server" Text="Agregar" class="btn" OnClick="Button1_Click" />

    </div>

</asp:Content>
