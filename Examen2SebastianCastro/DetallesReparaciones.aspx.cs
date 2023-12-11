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
    public partial class DetallesReparaciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string reparacionID = addRepID.Value;
            string FechaFin = addFechaFin.Value;
            string descripcion = Descripcion.Value;
            string fechaInicio = addDate.Value;

            string connectionString = ConfigurationManager.ConnectionStrings["Connect"].ConnectionString;

            string query = "INSERT INTO DetallesReparacion (ReparacionID, Descripcion, FechaInicio, FechaFin) VALUES (@Value1, @Value2, @Value3, @Value4)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Value1", reparacionID);
                    command.Parameters.AddWithValue("@Value2", descripcion);
                    command.Parameters.AddWithValue("@Value3", fechaInicio);
                    command.Parameters.AddWithValue("@Value4", FechaFin);

                    connection.Open();

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}