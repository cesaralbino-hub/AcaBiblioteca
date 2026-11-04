
using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using AcaBiblioteca.Datos;

namespace AcaBiblioteca
{
    public partial class FrmUsuarios : Form
    {
        private int? idUsuarioSeleccionado = null;

        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            LimpiarCampos();
        }

        private void CargarUsuarios()
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.obtenerConexion())
                {
                    cn.Open();

                    string consulta =
                    "SELECT Id_Usuario, Nombre, Apellido, " +
                    "Documento, Telefono1 AS Telefono, Correo " +
                 "FROM Usuarios ORDER BY Nombre, Apellido";

                    using (SqlDataAdapter adaptador =
                           new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);
                        dgvUsuarios.DataSource = tabla;
                    }
                }

                dgvUsuarios.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los usuarios:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDocumento.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();

            idUsuarioSeleccionado = null;
            dgvUsuarios.ClearSelection();
            txtNombre.Focus();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtDocumento.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show(
                    "Complete todos los campos.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            if (!txtCorreo.Text.Contains("@") ||
                !txtCorreo.Text.Contains("."))
            {
                MessageBox.Show(
                    "Ingrese un correo electrónico válido.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return false;
            }

            return true;
        }

        private void AgregarParametros(SqlCommand comando)
        {
            comando.Parameters.AddWithValue(
                "@Nombre", txtNombre.Text.Trim());
            comando.Parameters.AddWithValue(
                "@Apellido", txtApellido.Text.Trim());
            comando.Parameters.AddWithValue(
                "@Documento", txtDocumento.Text.Trim());
            comando.Parameters.AddWithValue(
                "@Telefono", txtTelefono.Text.Trim());
            comando.Parameters.AddWithValue(
                "@Correo", txtCorreo.Text.Trim());
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.obtenerConexion())
                {
                    cn.Open();

                    string consulta =
                        "INSERT INTO Usuarios " +
                        "(Nombre, Apellido, Documento, Telefono1, Correo) " +
                        "VALUES (@Nombre, @Apellido, @Documento, " +
                        "@Telefono, @Correo)";

                    using (SqlCommand comando =
                           new SqlCommand(consulta, cn))
                    {
                        AgregarParametros(comando);
                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Usuario guardado correctamente.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarUsuarios();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar el usuario:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void dgvUsuarios_CellDoubleClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];

            idUsuarioSeleccionado = Convert.ToInt32(
                fila.Cells["Id_Usuario"].Value);

            txtNombre.Text =
                fila.Cells["Nombre"].Value?.ToString() ?? "";
            txtApellido.Text =
                fila.Cells["Apellido"].Value?.ToString() ?? "";
            txtDocumento.Text =
                fila.Cells["Documento"].Value?.ToString() ?? "";
            txtTelefono.Text =
                fila.Cells["Telefono"].Value?.ToString() ?? "";
            txtCorreo.Text =
                fila.Cells["Correo"].Value?.ToString() ?? "";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idUsuarioSeleccionado == null)
            {
                MessageBox.Show(
                    "Seleccione un usuario haciendo doble clic en la tabla.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarCampos())
                return;

            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.obtenerConexion())
                {
                    cn.Open();

                    string consulta =
                        "UPDATE Usuarios SET " +
                        "Nombre = @Nombre, " +
                        "Apellido = @Apellido, " +
                        "Documento = @Documento, " +
                        "Telefono1 = @Telefono, " +
                        "Correo = @Correo " +
                        "WHERE Id_Usuario = @IdUsuario";

                    using (SqlCommand comando =
                           new SqlCommand(consulta, cn))
                    {
                        AgregarParametros(comando);

                        comando.Parameters.AddWithValue(
                            "@IdUsuario", idUsuarioSeleccionado.Value);

                        int filas = comando.ExecuteNonQuery();

                        if (filas == 0)
                        {
                            MessageBox.Show(
                                "No se encontró el usuario para actualizar.",
                                "Biblioteca",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }

                MessageBox.Show(
                    "Usuario actualizado correctamente.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarUsuarios();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al actualizar el usuario:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idUsuarioSeleccionado == null)
            {
                MessageBox.Show(
                    "Seleccione un usuario haciendo doble clic en la tabla.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de eliminar al usuario " +
                txtNombre.Text + " " + txtApellido.Text + "?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
                return;

            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.obtenerConexion())
                {
                    cn.Open();

                    string consulta =
                        "DELETE FROM Usuarios WHERE Id_Usuario = @IdUsuario";

                    using (SqlCommand comando =
                           new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue(
                            "@IdUsuario", idUsuarioSeleccionado.Value);

                        int filas = comando.ExecuteNonQuery();

                        if (filas == 0)
                        {
                            MessageBox.Show(
                                "No se encontró el usuario para eliminar.",
                                "Biblioteca",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }

                MessageBox.Show(
                    "Usuario eliminado correctamente.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarUsuarios();
                LimpiarCampos();
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                MessageBox.Show(
                    "No se puede eliminar este usuario porque " +
                    "tiene préstamos relacionados.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al eliminar el usuario:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
