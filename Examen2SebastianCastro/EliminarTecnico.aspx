<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="EliminarTecnico.aspx.cs" Inherits="Examen2SebastianCastro.ElimnarTecnico" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="form-floating mb-3">

        <input type="text" class="form-control" id="deleteTecnico" placeholder="name" runat="server">
        <label for="floatingInput">ID del Tecnico</label>
    </div>

    <div>

        <asp:Button ID="Button1" runat="server" Text="Eliminar" class="btn" OnClick="Button1_Click" />

    </div>


</asp:Content>
