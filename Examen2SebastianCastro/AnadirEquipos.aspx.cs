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
    public partial class AnadirEquipos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            string tipo = addTipo.Value;
            string modelo = addModelo.Value;
            string usuarioid = addUsuarioID.Value;

            string connectionString = ConfigurationManager.ConnectionStrings["Connect"].ConnectionString;

            string query = "INSERT INTO Equipos (TipoEquipo, Modelo, UsuarioID ) VALUES (@Value1, @Value2, @Value3)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Value1", tipo);
                    command.Parameters.AddWithValue("@Value2", modelo);
                    command.Parameters.AddWithValue("@Value3", usuarioid);


                    connection.Open();

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}