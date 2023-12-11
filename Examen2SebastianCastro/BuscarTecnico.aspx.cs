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
    public partial class BuscarTecnico : System.Web.UI.Page
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
            DataTable tecnicosDataTable = GetDataFromDatabase();
            GridViewTecnicos.DataSource = tecnicosDataTable;
            GridViewTecnicos.DataBind();
        }

        private DataTable GetDataFromDatabase()
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Connect"].ConnectionString))
            {
                string query = "SELECT * FROM Tecnicos";

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
                int tecnicoID;
                if (int.TryParse(txtTecnicoID.Value, out tecnicoID))
                {
                    DataTable resultDataTable = GetDataForTecnicoID(tecnicoID);

                    if (resultDataTable.Rows.Count > 0)
                    {
                        GridViewTecnicos.DataSource = resultDataTable;
                        GridViewTecnicos.DataBind();
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write($"Error: {ex.Message}");
            }
        }

        private DataTable GetDataForTecnicoID(int tecnicoID)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Connect"].ConnectionString))
            {
                string query = $"SELECT * FROM Tecnicos WHERE TecnicoID = @TecnicoID";

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