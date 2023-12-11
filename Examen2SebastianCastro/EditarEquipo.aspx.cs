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
    public partial class EditarEquipo : System.Web.UI.Page
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

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int equiposID;
                int.TryParse(editEquiposID.Value, out equiposID);

                string tipoEquipo = editTipoEquipo.Value;
                string modelo = editModelo.Value;
                int usuarioID;
                int.TryParse(editUsuarioID.Value, out usuarioID);

                UpdateDataInDatabase(equiposID, tipoEquipo, modelo, usuarioID);

                BindGridView();
            }
            catch (Exception ex)
            {
                Response.Write($"An error occurred: {ex.Message}");
            }
        }

        private void UpdateDataInDatabase(int equiposID, string tipoEquipo, string modelo, int usuarioID)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Connect"].ConnectionString))
            {
                string query = "UPDATE Equipos SET TipoEquipo = @TipoEquipo, Modelo = @Modelo, UsuarioID = @UsuarioID WHERE EquiposID = @EquiposID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EquiposID", equiposID);
                    command.Parameters.AddWithValue("@TipoEquipo", tipoEquipo);
                    command.Parameters.AddWithValue("@Modelo", modelo);
                    command.Parameters.AddWithValue("@UsuarioID", usuarioID);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        protected void GridViewEquipos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewEquipos.EditIndex = e.NewEditIndex;
            BindGridView();
        }

        protected void GridViewEquipos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
        }

        protected void GridViewEquipos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridViewEquipos.EditIndex = -1;
            BindGridView();
        }
    }
}