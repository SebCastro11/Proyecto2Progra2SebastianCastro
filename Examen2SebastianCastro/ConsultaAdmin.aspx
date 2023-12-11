<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="ConsultaGeneralAdmin.aspx.cs" Inherits="Examen2SebastianCastro.ConsultaGeneralAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="form-floating mb-3">
        <input type="text" class="form-control" id="txtUsuarioID" placeholder="User ID" runat="server" />
        <label for="txtUsuarioID">ID del Tecnico</label>
    </div>

    <div>
        <asp:Button ID="btnSearchByID" runat="server" Text="Search by ID" class="btn" OnClick="btnSearchByID_Click" />
    </div>

    <div>
        <asp:GridView ID="GridViewResult" runat="server" AutoGenerateColumns="False" CssClass="table table-bordered">
            <Columns>
                <asp:BoundField DataField="TecnicoID" HeaderText="TecnicoID" SortExpression="TecnicoID" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />

                <asp:BoundField DataField="AsignacionID" HeaderText="AsignacionID" SortExpression="AsignacionID" />
                <asp:BoundField DataField="FechaAsignacion" HeaderText="FechaAsignacion" SortExpression="FechaAsignacion" />
                <asp:BoundField DataField="ReparacionID" HeaderText="ReparacionID" SortExpression="ReparacionID" />
                <asp:BoundField DataField="Fecha_Solicitud" HeaderText="Fecha_Solicitud" SortExpression="Fecha_Solicitud" />
                <asp:BoundField DataField="Estado" HeaderText="Estado" SortExpression="Estado" />
                <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" SortExpression="Descripcion" />
                <asp:BoundField DataField="TipoEquipo" HeaderText="TipoEquipo" SortExpression="TipoEquipo" />
                <asp:BoundField DataField="Modelo" HeaderText="Modelo" SortExpression="Modelo" />
                <asp:BoundField DataField="UsuarioNombre" HeaderText="UsuarioNombre" SortExpression="UsuarioNombre" />
                <asp:BoundField DataField="CorreoElectronico" HeaderText="CorreoElectronico" SortExpression="CorreoElectronico" />
            </Columns>
        </asp:GridView>
    </div>




</asp:Content>
