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
    public partial class AnadirTecnico : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            string nombre = addNombre.Value;
            string especialidad = addEspecialidad.Value;

            string connectionString = ConfigurationManager.ConnectionStrings["Connect"].ConnectionString;

            string query = "INSERT INTO Tecnicos (Nombre, Especialidad ) VALUES (@Value1, @Value2)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Value1", nombre);
                    command.Parameters.AddWithValue("@Value2", especialidad);

                    connection.Open();

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}