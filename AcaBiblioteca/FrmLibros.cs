using AcaBiblioteca.Datos;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AcaBiblioteca
{
    public partial class FrmLibros : Form
    {
        public FrmLibros()
        {
            InitializeComponent();
        }

        private void FrmLibros_Load(object sender, EventArgs e)
        {
            CargarLibros();
            CargarAutores();
            CargarEditoriales();
        }

        private void CargarLibros()
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.obtenerConexion())
                {
                    cn.Open();

                    string consulta = "SELECT * FROM Libros";

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();

                        adaptador.Fill(tabla);

                        dgvLibros.DataSource = tabla;
                        //MessageBox.Show(
                        // "Libros cargados: " + tabla.Rows.Count,
                        // "Verificación de registros",
                        //    MessageBoxButtons.OK,
                        //    MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los libros:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CargarAutores()
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.obtenerConexion())
                {
                    cn.Open();

                    string consulta = "SELECT Id_Autor, Nombre, Apellido FROM Autores ORDER BY Nombre, Apellido";

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();

                        adaptador.Fill(tabla);

                        tabla.Columns.Add("NombreCompleto", typeof(string));

                        foreach (DataRow fila in tabla.Rows)
                        {
                            fila["NombreCompleto"] =
                                fila["Nombre"].ToString() + " " +
                                fila["Apellido"].ToString();
                        }

                        cmbAutor.DataSource = tabla;
                        cmbAutor.DisplayMember = "NombreCompleto";
                        cmbAutor.ValueMember = "Id_Autor";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los autores:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CargarEditoriales()
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.obtenerConexion())
                {
                    cn.Open();

                    string consulta = "SELECT Id_Editorial, Nombre FROM Editoriales ORDER BY Nombre";

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();

                        adaptador.Fill(tabla);

                        cmbEditorial.DataSource = tabla;
                        cmbEditorial.DisplayMember = "Nombre";
                        cmbEditorial.ValueMember = "Id_Editorial";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar las editoriales:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBuscarISBN.Text))
                {
                    MessageBox.Show(
                        "Ingrese un ISBN para realizar la búsqueda.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.obtenerConexion())
                {
                    cn.Open();

                    string consulta = "SELECT * FROM Libros WHERE ISBN = @ISBN";

                    using (SqlCommand comando = new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue(
                            "@ISBN", txtBuscarISBN.Text.Trim());

                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                txtISBN.Text = lector["ISBN"].ToString();
                                txtTitulo.Text = lector["Titulo"].ToString();

                                cmbAutor.SelectedValue =
                                    Convert.ToInt32(lector["Id_Autor"]);

                                cmbEditorial.SelectedValue =
                                    Convert.ToInt32(lector["Id_Editorial"]);

                                txtCategoria.Text = lector["Categoria"].ToString();
                                txtAnio.Text = lector["Anio"].ToString();
                                txtExistencias.Text = lector["Existencias"].ToString();

                                MessageBox.Show(
                                    "Libro encontrado.",
                                    "Biblioteca",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(
                                    "No se encontró un libro con ese ISBN.",
                                    "Biblioteca",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al buscar el libro:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtBuscarISBN.Clear();
            txtISBN.Clear();
            txtTitulo.Clear();
            txtCategoria.Clear();
            txtAnio.Clear();
            txtExistencias.Clear();

            cmbAutor.SelectedIndex = -1;
            cmbEditorial.SelectedIndex = -1;

            txtISBN.Enabled = true;
            txtISBN.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar campos obligatorios
                if (string.IsNullOrWhiteSpace(txtISBN.Text) ||
                    string.IsNullOrWhiteSpace(txtTitulo.Text) ||
                    cmbAutor.SelectedIndex == -1 ||
                    cmbEditorial.SelectedIndex == -1 ||
                    string.IsNullOrWhiteSpace(txtCategoria.Text))
                {
                    MessageBox.Show(
                        "Complete todos los campos obligatorios.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                // Validar año
                if (!int.TryParse(txtAnio.Text, out int anio))
                {
                    MessageBox.Show(
                        "Ingrese un año válido.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                // Validar existencias
                if (!int.TryParse(txtExistencias.Text, out int existencias)
                    || existencias < 0)
                {
                    MessageBox.Show(
                        "Ingrese una cantidad válida de existencias.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.obtenerConexion())
                {
                    cn.Open();

                    string consulta = @"
                INSERT INTO Libros
                (ISBN, Titulo, Id_Autor, Id_Editorial,
                 Categoria, Anio, Existencias)
                VALUES
                (@ISBN, @Titulo, @Id_Autor, @Id_Editorial,
                 @Categoria, @Anio, @Existencias)";

                    using (SqlCommand comando = new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue(
                            "@ISBN", txtISBN.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@Titulo", txtTitulo.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@Id_Autor", cmbAutor.SelectedValue);

                        comando.Parameters.AddWithValue(
                            "@Id_Editorial", cmbEditorial.SelectedValue);

                        comando.Parameters.AddWithValue(
                            "@Categoria", txtCategoria.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@Anio", anio);

                        comando.Parameters.AddWithValue(
                            "@Existencias", existencias);

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Libro guardado correctamente.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarLibros();

                btnNuevo_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar el libro:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar campos obligatorios
                if (string.IsNullOrWhiteSpace(txtISBN.Text) ||
                    string.IsNullOrWhiteSpace(txtTitulo.Text) ||
                    cmbAutor.SelectedIndex == -1 ||
                    cmbEditorial.SelectedIndex == -1 ||
                    string.IsNullOrWhiteSpace(txtCategoria.Text))
                {
                    MessageBox.Show(
                        "Complete todos los campos obligatorios.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                // Validar año
                if (!int.TryParse(txtAnio.Text, out int anio))
                {
                    MessageBox.Show(
                        "Ingrese un año válido.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                // Validar existencias
                if (!int.TryParse(txtExistencias.Text, out int existencias)
                    || existencias < 0)
                {
                    MessageBox.Show(
                        "Ingrese una cantidad válida de existencias.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.obtenerConexion())
                {
                    cn.Open();

                    string consulta = @"
                UPDATE Libros
                SET Titulo = @Titulo,
                    Id_Autor = @Id_Autor,
                    Id_Editorial = @Id_Editorial,
                    Categoria = @Categoria,
                    Anio = @Anio,
                    Existencias = @Existencias
                WHERE ISBN = @ISBN";

                    using (SqlCommand comando = new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue(
                            "@ISBN", txtISBN.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@Titulo", txtTitulo.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@Id_Autor", cmbAutor.SelectedValue);

                        comando.Parameters.AddWithValue(
                            "@Id_Editorial", cmbEditorial.SelectedValue);

                        comando.Parameters.AddWithValue(
                            "@Categoria", txtCategoria.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@Anio", anio);

                        comando.Parameters.AddWithValue(
                            "@Existencias", existencias);

                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas == 0)
                        {
                            MessageBox.Show(
                                "No se encontró un libro con ese ISBN.",
                                "Biblioteca",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }

                MessageBox.Show(
                    "Libro actualizado correctamente.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarLibros();

                btnNuevo_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al actualizar el libro:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void dgvLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Evitar seleccionar encabezados o filas vacías
                if (e.RowIndex < 0)
                    return;

                DataGridViewRow fila = dgvLibros.Rows[e.RowIndex];

                if (fila.IsNewRow)
                    return;

                // Cargar los datos del libro seleccionado
                txtISBN.Text = fila.Cells["ISBN"].Value?.ToString();
                txtTitulo.Text = fila.Cells["Titulo"].Value?.ToString();

                cmbAutor.SelectedValue =
                    Convert.ToInt32(fila.Cells["Id_Autor"].Value);

                cmbEditorial.SelectedValue =
                    Convert.ToInt32(fila.Cells["Id_Editorial"].Value);

                txtCategoria.Text = fila.Cells["Categoria"].Value?.ToString();
                txtAnio.Text = fila.Cells["Anio"].Value?.ToString();
                txtExistencias.Text = fila.Cells["Existencias"].Value?.ToString();

                // Evitar modificar la llave primaria durante la edición
                txtISBN.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al seleccionar el libro:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Validar que exista un ISBN seleccionado
            if (string.IsNullOrWhiteSpace(txtISBN.Text))
            {
                MessageBox.Show(
                    "Seleccione un libro para eliminar.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Solicitar confirmación
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de eliminar el libro:\n" +
                txtTitulo.Text + "?",
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
                        "DELETE FROM Libros WHERE ISBN = @ISBN";

                    using (SqlCommand comando = new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue(
                            "@ISBN", txtISBN.Text.Trim());

                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas == 0)
                        {
                            MessageBox.Show(
                                "No se encontró el libro para eliminar.",
                                "Biblioteca",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }

                MessageBox.Show(
                    "Libro eliminado correctamente.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarLibros();

                btnNuevo_Click(sender, e);
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                MessageBox.Show(
                    "No se puede eliminar este libro porque tiene " +
                    "registros relacionados, como préstamos.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al eliminar el libro:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Limpiar los campos del formulario
            txtBuscarISBN.Clear();
            txtISBN.Clear();
            txtTitulo.Clear();
            txtCategoria.Clear();
            txtAnio.Clear();
            txtExistencias.Clear();

            // Limpiar las selecciones
            cmbAutor.SelectedIndex = -1;
            cmbEditorial.SelectedIndex = -1;

            // Habilitar nuevamente el ISBN
            txtISBN.Enabled = true;

            // Quitar la selección de la tabla
            dgvLibros.ClearSelection();

            // Ubicar el cursor en el campo ISBN
            txtISBN.Focus();
        }
    }
}
