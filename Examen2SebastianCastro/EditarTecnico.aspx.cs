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
    public partial class EditarTecnico : System.Web.UI.Page
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

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int tecnicoID;
                int.TryParse(editTecnicoID.Value, out tecnicoID);

                string nombre = editNombre.Value;
                string especialidad = editEspecialidad.Value;

                UpdateDataInDatabase(tecnicoID, nombre, especialidad);

                BindGridView();
            }
            catch (Exception ex)
            {
                Response.Write($"An error occurred: {ex.Message}");
            }
        }

        private void UpdateDataInDatabase(int tecnicoID, string nombre, string especialidad)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Connect"].ConnectionString))
            {
                string query = "UPDATE Tecnicos SET Nombre = @Nombre, Especialidad = @Especialidad WHERE TecnicoID = @TecnicoID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TecnicoID", tecnicoID);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Especialidad", especialidad);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        protected void GridViewTecnicos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewTecnicos.EditIndex = e.NewEditIndex;
            BindGridView();
        }

        protected void GridViewTecnicos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
        }

        protected void GridViewTecnicos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridViewTecnicos.EditIndex = -1;
            BindGridView();
        }
    }
}