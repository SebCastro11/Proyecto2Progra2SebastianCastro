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
    public partial class AsignacionesTec : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string reparacionID = AddReparacionID.Value;
            string tecnicoID = AddTecnicoID.Value;
            string fechaAsignacion = AddFecha.Value;

            string connectionString = ConfigurationManager.ConnectionStrings["Connect"].ConnectionString;

            string query = "INSERT INTO Asignaciones (ReparacionID, TecnicoID, FechaAsignacion) VALUES (@Value1, @Value2, @Value3)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Value1", reparacionID);
                    command.Parameters.AddWithValue("@Value2", tecnicoID);
                    command.Parameters.AddWithValue("@Value3", fechaAsignacion);

                    connection.Open();

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}