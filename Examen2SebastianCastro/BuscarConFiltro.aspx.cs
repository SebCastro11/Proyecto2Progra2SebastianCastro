using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Examen2SebastianCastro
{
    public partial class BuscarConFiltro : System.Web.UI.Page
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
            DataTable usuariosDataTable = GetDataFromDatabase();
            GridViewUsuarios.DataSource = usuariosDataTable;
            GridViewUsuarios.DataBind();
        }

        private DataTable GetDataFromDatabase()
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Connect"].ConnectionString))
            {
                string query = "SELECT * FROM Usuarios";

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
                int usuarioID;
                if (int.TryParse(txtUsuarioID.Value, out usuarioID))
                {
                    DataTable resultDataTable = GetDataForUsuarioID(usuarioID);

                    if (resultDataTable.Rows.Count > 0)
                    {
                        GridViewUsuarios.DataSource = resultDataTable;
                        GridViewUsuarios.DataBind();
                    }
                    
                }
                
            }
            catch (Exception ex)
            {
                Response.Write($"Error: {ex.Message}");
            }
        }

        private DataTable GetDataForUsuarioID(int usuarioID)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Connect"].ConnectionString))
            {
                string query = $"SELECT * FROM Usuarios WHERE UsuarioID = @UsuarioID";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@UsuarioID", usuarioID);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }



    }
}
