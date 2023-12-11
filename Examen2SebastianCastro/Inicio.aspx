<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Examen2SebastianCastro.Inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <br />
    <h1>Bienvenido al sistema con acceso Admin</h1>
    <br />
    <br />
    <div class="card container text-center" style="width: 18rem;">
        <img src="Images/Query.PNG" class="card-img-top" alt="...">
        <div class="card-body">
            <h5 class="card-title">Query</h5>
            <p class="card-text">Query realizado para la base de datos que se utiliza en este proyecto. Base de datos llamada Examen1</p>
        </div>
    </div>

    <br />
    <br />

    <div class="card container text-center" style="width: 18rem;">
        <img src="Images/Query2.PNG" class="card-img-top" alt="...">
        <div class="card-body">
            <h5 class="card-title">Quey 2</h5>
            <p class="card-text">Query de la base de datos de usuarios para el Log In. Base de datos llamada UsuariosLOGIN</p>
        </div>
    </div>

    <br />
    <br />

    <div class="card container text-center" style="width: 18rem;">
        <img src="Images/View.PNG" class="card-img-top" alt="...">
        <div class="card-body">
            <h5 class="card-title">View</h5>
            <p class="card-text">Snip del view realizado a base del query. Base de datos llamada Examen1</p>
        </div>
    </div>

    <br />
    <br />

    <div class="card container text-center" style="width: 18rem;">
        <img src="Images/Goku.jpg" class="card-img-top" alt="...">
        <div class="card-body">
            <h5 class="card-title">Firma</h5>
            <p class="card-text">Proyecto realizado por Sebastian Castro Nuñez.</p>
        </div>
    </div>

    <div class=" container text-center">

        <a href="Login.aspx" class="btn">Log Out</a>

    </div>

</asp:Content>
