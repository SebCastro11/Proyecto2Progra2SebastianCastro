using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Examen2SebastianCastro
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Loginbtn_Click(object sender, EventArgs e)
        {
            string username = txtUsuario.Value.Trim();
            string password = txtPassword.Value.Trim();

            if (Autenticar(username, password, out int ID, out int userRole))
            {
                Session["UserID"] = ID;
                Session["UserRole"] = userRole;

                Response.Redirect(GetRedirectPage(userRole));
            }
            else
            {
                
            }
        }

        private bool Autenticar(string username, string password, out int userID, out int userRole)
        {
            userID = -1; 
            userRole = -1; 

            string connectionString = ConfigurationManager.ConnectionStrings["ConnectLogin"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ID, Rol FROM UsuariosLOGIN WHERE Nombre = @Username AND Contraseña = @Password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        userID = Convert.ToInt32(reader["ID"]);
                        userRole = Convert.ToInt32(reader["Rol"]);

                        return true; 
                    }
                }
            }

            return false; 
        }

        private string GetRedirectPage(int userRole)
        {
            // Adjust the redirection logic based on your roles
            switch (userRole)
            {
                case 0:
                    return "Inicio.aspx";
                case 1:
                    return "InicioTec.aspx";
                default:
                    return "Usuarios.aspx";
            }
        }


    }
}