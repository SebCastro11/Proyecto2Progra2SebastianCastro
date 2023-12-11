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
    public partial class ReparacionesTec : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string equipoID = AddEquipoID.Value;
            string fechaSolicitud = AddFecha.Value;
            string estado = AddEstado.Value;

            string connectionString = ConfigurationManager.ConnectionStrings["Connect"].ConnectionString;

            string query = "INSERT INTO Reparaciones (EquipoID, Fecha_Solicitud, Estado) VALUES (@Value1, @Value2, @Value3)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Value1", equipoID);
                    command.Parameters.AddWithValue("@Value2", fechaSolicitud);
                    command.Parameters.AddWithValue("@Value3", estado);

                    connection.Open();

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}