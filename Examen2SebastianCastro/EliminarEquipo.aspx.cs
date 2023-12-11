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
    public partial class EliminarEquipo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(deleteEquipo.Value);

            string connectionString = ConfigurationManager.ConnectionStrings["Connect"].ConnectionString;

            string query = "DELETE FROM Equipos WHERE EquiposID = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", ID);

                    connection.Open();


                    command.ExecuteNonQuery();
                }
            }
        }
    }
}