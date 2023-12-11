using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Examen2SebastianCastro
{
    public partial class ConsultaGeneralAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSearchByID_Click(object sender, EventArgs e)
        {
            int tecnicoID;
            if (int.TryParse(txtUsuarioID.Value, out tecnicoID))
            {
                DataTable resultDataTable = GetTecnicoDetails(tecnicoID);

                if (resultDataTable.Rows.Count > 0)
                {
                    GridViewResult.Visible = true;
                    GridViewResult.DataSource = resultDataTable;
                    GridViewResult.DataBind();
                }
                else
                {
                    GridViewResult.Visible = false;
                }
            }
        }

        private DataTable GetTecnicoDetails(int tecnicoID)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Connect"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT t.TecnicoID, t.Nombre, a.AsignacionID, a.FechaAsignacion, a.ReparacionID,
                                    r.Fecha_Solicitud, r.Estado, d.Descripcion, q.TipoEquipo, q.Modelo,
                                    s.Nombre AS UsuarioNombre, s.CorreoElectronico
                             FROM Tecnicos t
                             INNER JOIN Asignaciones a ON t.TecnicoID = a.TecnicoID
                             INNER JOIN Reparaciones r ON r.ReparacionID = a.ReparacionID
                             INNER JOIN DetallesReparacion d ON d.ReparacionID = r.ReparacionID
                             INNER JOIN Equipos q ON q.EquiposID = r.EquipoID
                             INNER JOIN Usuarios s ON s.UsuarioID = q.UsuarioID
                             WHERE t.TecnicoID = @TecnicoID";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@TecnicoID", tecnicoID);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }
    }
}