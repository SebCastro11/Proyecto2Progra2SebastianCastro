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
    public partial class BuscarEquipos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGridView();
            }
        }

        private void BindGridView()
        {
            DataTable equiposDataTable = GetDataFromDatabase();
            GridViewEquipos.DataSource = equiposDataTable;
            GridViewEquipos.DataBind();
        }

        private DataTable GetDataFromDatabase()
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Connect"].ConnectionString))
            {
                string query = "SELECT * FROM Equipos";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        protected void btnSearchByID_Click(object sender, EventArgs e)
        {
            try
            {
                int equiposID;
                if (int.TryParse(txtEquiposID.Value, out equiposID))
                {
                    DataTable resultDataTable = GetDataForEquiposID(equiposID);

                    if (resultDataTable.Rows.Count > 0)
                    {
                        GridViewEquipos.DataSource = resultDataTable;
                        GridViewEquipos.DataBind();
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write($"Error: {ex.Message}");
            }
        }

        private DataTable GetDataForEquiposID(int equiposID)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Connect"].ConnectionString))
            {
                string query = $"SELECT * FROM Equipos WHERE EquiposID = @EquiposID";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@EquiposID", equiposID);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }
    }
}