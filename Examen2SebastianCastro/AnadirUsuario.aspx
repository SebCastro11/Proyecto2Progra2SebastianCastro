<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="AnadirUsuario.aspx.cs" Inherits="Examen2SebastianCastro.AnadirUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="form-floating mb-3">

        <input type="text" class="form-control" id="addUsuario" placeholder="name" runat="server">
        <label for="floatingInput">Nombre del usuario</label>
    </div>

    <div class="form-floating mb-3">

        <input type="text" class="form-control" id="addMail" placeholder="name@example.com" runat="server">
        <label for="floatingInput">Correo</label>
    </div>

    <div class="form-floating mb-3">

        <input type="text" class="form-control" id="addTelefono" placeholder="84753695" runat="server">
        <label for="floatingInput">Telefono</label>
    </div>


    <div>

        <asp:Button ID="Button1" runat="server" Text="Agregar" class="btn" OnClick="Button1_Click" />

    </div>
</asp:Content>
