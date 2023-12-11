<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Examen2SebastianCastro.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous" />
    <link href="MenuCSS.css" rel="stylesheet" />
</head>
<body>

    <h1>Sistema De Reparaciones</h1>
    <br />
    <form id="Login" runat="server">
        <div class="container">
            <div class="form-floating mb-3">
                <input type="text" class="form-control" id="txtUsuario" placeholder="Usuario" runat="server" />
                <label for="txtUsuario">Usuario</label>
            </div>

            <div class="form-floating mb-3">
                <input type="password" class="form-control" id="txtPassword" placeholder="Contraseña" runat="server" />
                <label for="txtPassword">Contraseña</label>
            </div>

            <div class="mb-3">
                <asp:Button ID="Loginbtn" runat="server" Text="Log In" class="btn" OnClick="Loginbtn_Click" />
            </div>
        </div>
    </form>
</body>
</html>
