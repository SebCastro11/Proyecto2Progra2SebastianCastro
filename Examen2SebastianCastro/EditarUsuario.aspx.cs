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
    public partial class EditarUsuario : System.Web.UI.Page
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

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int usuarioID;
                int.TryParse(editUsuarioID.Value, out usuarioID);

                string nombre = editNombre.Value;
                string correoElectronico = editCorreoElectronico.Value;
                string telefono = editTelefono.Value;

                UpdateDataInDatabase(usuarioID, nombre, correoElectronico, telefono);

                BindGridView();
            }
            catch (Exception ex)
            {
                Response.Write($"An error occurred: {ex.Message}");
            }
        }

        private void UpdateDataInDatabase(int usuarioID, string nombre, string correoElectronico, string telefono)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Connect"].ConnectionString))
            {
                string query = "UPDATE Usuarios SET Nombre = @Nombre, CorreoElectronico = @CorreoElectronico, Telefono = @Telefono WHERE UsuarioID = @UsuarioID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UsuarioID", usuarioID);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@CorreoElectronico", correoElectronico);
                    command.Parameters.AddWithValue("@Telefono", telefono);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        protected void GridViewUsuarios_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewUsuarios.EditIndex = e.NewEditIndex;
            BindGridView();
        }

        protected void GridViewUsuarios_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
        }

        protected void GridViewUsuarios_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridViewUsuarios.EditIndex = -1;
            BindGridView();
        }
    }
}