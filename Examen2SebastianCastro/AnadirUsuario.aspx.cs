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
    public partial class AnadirUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            string nombre = addUsuario.Value;
            string mail = addMail.Value;
            string telefono = addTelefono.Value;

            string connectionString = ConfigurationManager.ConnectionStrings["Connect"].ConnectionString;

            string query = "INSERT INTO Usuarios (Nombre, CorreoElectronico, Telefono ) VALUES (@Value1, @Value2, @Value3)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Value1", nombre);
                    command.Parameters.AddWithValue("@Value2", mail);
                    command.Parameters.AddWithValue("@Value3", telefono);


                    connection.Open();

                    command.ExecuteNonQuery();
                }
            }
        }


    }



}

