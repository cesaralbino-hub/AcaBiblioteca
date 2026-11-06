
using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using AcaBiblioteca.Datos;

namespace AcaBiblioteca
{
    public partial class FrmPrestamos : Form
    {
        private int? idPrestamoSeleccionado = null;
        private bool cargandoDatos = false;

        public FrmPrestamos()
        {
            InitializeComponent();

            // Asociamos los eventos desde el código.
            // No deben estar duplicados en el diseñador.
            Load += FrmPrestamos_Load;
            btnNuevo.Click += btnNuevo_Click;
            btnGuardar.Click += btnGuardar_Click;
            btnEditar.Click += btnEditar_Click;
            btnEliminar.Click += btnEliminar_Click;
            btnCancelar.Click += btnCancelar_Click;
            dgvPrestamos.CellDoubleClick += dgvPrestamos_CellDoubleClick;
        }

        private void FrmPrestamos_Load(object? sender, EventArgs e)
        {
            CargarUsuarios();
            CargarLibros();
            CargarPrestamos();
            LimpiarCampos();
        }

        private SqlConnection CrearConexion()
        {
            Conexion conexion = new Conexion();
            return conexion.obtenerConexion();
        }

        // =========================================
        // CARGAR USUARIOS
        // =========================================

        private void CargarUsuarios()
        {
            try
            {
                using (SqlConnection cn = CrearConexion())
                {
                    cn.Open();

                    string consulta =
                        "SELECT Id_Usuario, " +
                        "Nombre + ' ' + Apellido AS NombreCompleto " +
                        "FROM Usuarios ORDER BY Nombre, Apellido";

                    using (SqlDataAdapter adaptador =
                        new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);

                        cmbUsuario.DataSource = tabla;
                        cmbUsuario.DisplayMember = "NombreCompleto";
                        cmbUsuario.ValueMember = "Id_Usuario";
                        cmbUsuario.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MostrarError("Error al cargar usuarios", ex);
            }
        }

        // =========================================
        // CARGAR LIBROS
        // =========================================

        private void CargarLibros()
        {
            try
            {
                using (SqlConnection cn = CrearConexion())
                {
                    cn.Open();

                    string consulta =
                        "SELECT ISBN, Titulo " +
                        "FROM Libros ORDER BY Titulo";

                    using (SqlDataAdapter adaptador =
                        new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);

                        cmbLibro.DataSource = tabla;
                        cmbLibro.DisplayMember = "Titulo";
                        cmbLibro.ValueMember = "ISBN";
                        cmbLibro.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MostrarError("Error al cargar libros", ex);
            }
        }

        // =========================================
        // CARGAR PRÉSTAMOS
        // =========================================

        private void CargarPrestamos()
        {
            try
            {
                using (SqlConnection cn = CrearConexion())
                {
                    cn.Open();

                    string consulta =
                        "SELECT Id_Prestamo, Id_Usuario, ISBN, " +
                        "Fecha_Prestamo, Fecha_Devolucion, Estado " +
                        "FROM Prestamos ORDER BY Id_Prestamo DESC";

                    using (SqlDataAdapter adaptador =
                        new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);
                        dgvPrestamos.DataSource = tabla;
                    }
                }

                dgvPrestamos.ClearSelection();
            }
            catch (Exception ex)
            {
                MostrarError("Error al cargar préstamos", ex);
            }
        }

        // =========================================
        // LIMPIAR CAMPOS
        // =========================================

        private void LimpiarCampos()
        {
            idPrestamoSeleccionado = null;

            cmbUsuario.SelectedIndex = -1;
            cmbLibro.SelectedIndex = -1;

            dtpFechaPrestamo.Value = DateTime.Today;

            dtpFechaDevolucion.Value = DateTime.Today;
            dtpFechaDevolucion.Checked = false;

            dgvPrestamos.ClearSelection();

            cmbUsuario.Focus();
        }

        private void btnNuevo_Click(object? sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnCancelar_Click(object? sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // =========================================
        // VALIDACIONES
        // =========================================

        private bool ValidarCampos()
        {
            if (cmbUsuario.SelectedIndex < 0 ||
                cmbLibro.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Seleccione un usuario y un libro.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            if (dtpFechaPrestamo.Value.Date > DateTime.Today)
            {
                MessageBox.Show(
                    "La fecha del préstamo no puede ser futura.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            if (dtpFechaDevolucion.Checked &&
                dtpFechaDevolucion.Value.Date <
                dtpFechaPrestamo.Value.Date)
            {
                MessageBox.Show(
                    "La devolución no puede ser anterior al préstamo.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            return true;
        }

        // =========================================
        // CONSULTAR EXISTENCIAS
        // =========================================

        private int ObtenerExistencias(
            SqlConnection cn,
            SqlTransaction transaccion,
            string isbn)
        {
            string consulta =
                "SELECT Existencias FROM Libros WITH (UPDLOCK, HOLDLOCK) " +
                "WHERE ISBN = @ISBN";

            using (SqlCommand comando =
                new SqlCommand(consulta, cn, transaccion))
            {
                comando.Parameters.AddWithValue("@ISBN", isbn);

                object? resultado = comando.ExecuteScalar();

                if (resultado == null || resultado == DBNull.Value)
                    throw new Exception("El libro no existe.");

                return Convert.ToInt32(resultado);
            }
        }

        // =========================================
        // ACTUALIZAR EXISTENCIAS
        // =========================================

        private void CambiarExistencias(
            SqlConnection cn,
            SqlTransaction transaccion,
            string isbn,
            int cantidad)
        {
            string consulta =
                "UPDATE Libros SET Existencias = Existencias + @Cantidad " +
                "WHERE ISBN = @ISBN";

            using (SqlCommand comando =
                new SqlCommand(consulta, cn, transaccion))
            {
                comando.Parameters.AddWithValue("@Cantidad", cantidad);
                comando.Parameters.AddWithValue("@ISBN", isbn);

                int filas = comando.ExecuteNonQuery();

                if (filas != 1)
                    throw new Exception(
                        "No fue posible actualizar las existencias.");
            }
        }

        // =========================================
        // GUARDAR PRÉSTAMO
        // =========================================

        private void btnGuardar_Click(object? sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            if (dtpFechaDevolucion.Checked)
            {
                MessageBox.Show(
                    "Un préstamo nuevo debe registrarse sin devolución.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int idUsuario = Convert.ToInt32(cmbUsuario.SelectedValue);
            string isbn = cmbLibro.SelectedValue!.ToString()!;

            try
            {
                using (SqlConnection cn = CrearConexion())
                {
                    cn.Open();

                    using (SqlTransaction transaccion =
                        cn.BeginTransaction(IsolationLevel.Serializable))
                    {
                        try
                        {
                            int existencias =
                                ObtenerExistencias(cn, transaccion, isbn);

                            if (existencias <= 0)
                            {
                                throw new Exception(
                                    "El libro no tiene existencias disponibles.");
                            }

                            string consulta =
                                "INSERT INTO Prestamos " +
                                "(Id_Usuario, ISBN, Fecha_Prestamo, " +
                                "Fecha_Devolucion, Estado) " +
                                "VALUES (@Usuario, @ISBN, @Fecha, NULL, 'Prestado')";

                            using (SqlCommand comando =
                                new SqlCommand(consulta, cn, transaccion))
                            {
                                comando.Parameters.AddWithValue(
                                    "@Usuario", idUsuario);
                                comando.Parameters.AddWithValue(
                                    "@ISBN", isbn);
                                comando.Parameters.AddWithValue(
                                    "@Fecha", dtpFechaPrestamo.Value.Date);

                                comando.ExecuteNonQuery();
                            }

                            CambiarExistencias(
                                cn, transaccion, isbn, -1);

                            transaccion.Commit();
                        }
                        catch
                        {
                            transaccion.Rollback();
                            throw;
                        }
                    }
                }

                MessageBox.Show(
                    "Préstamo registrado correctamente.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarPrestamos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MostrarError("Error al guardar préstamo", ex);
            }
        }

        // =========================================
        // SELECCIONAR PRÉSTAMO
        // =========================================

        private void dgvPrestamos_CellDoubleClick(
            object? sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila = dgvPrestamos.Rows[e.RowIndex];

            idPrestamoSeleccionado =
                Convert.ToInt32(fila.Cells["Id_Prestamo"].Value);

            cmbUsuario.SelectedValue =
                fila.Cells["Id_Usuario"].Value;

            cmbLibro.SelectedValue =
                fila.Cells["ISBN"].Value?.ToString();

            dtpFechaPrestamo.Value =
                Convert.ToDateTime(
                    fila.Cells["Fecha_Prestamo"].Value);

            object? fecha =
                fila.Cells["Fecha_Devolucion"].Value;

            if (fecha == null || fecha == DBNull.Value)
            {
                dtpFechaDevolucion.Value = DateTime.Today;
                dtpFechaDevolucion.Checked = false;
            }
            else
            {
                dtpFechaDevolucion.Value =
                    Convert.ToDateTime(fecha);

                dtpFechaDevolucion.Checked = true;
            }
        }

        // =========================================
        // EDITAR / REGISTRAR DEVOLUCIÓN
        // =========================================

        private void btnEditar_Click(object? sender, EventArgs e)
        {
            if (idPrestamoSeleccionado == null)
            {
                MessageBox.Show(
                    "Haga doble clic sobre un préstamo para editarlo.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarCampos())
                return;

            int idUsuario = Convert.ToInt32(cmbUsuario.SelectedValue);
            string isbnNuevo = cmbLibro.SelectedValue!.ToString()!;

            try
            {
                using (SqlConnection cn = CrearConexion())
                {
                    cn.Open();

                    using (SqlTransaction transaccion =
                        cn.BeginTransaction(IsolationLevel.Serializable))
                    {
                        try
                        {
                            string isbnAnterior;
                            string estadoAnterior;

                            string consultaActual =
                                "SELECT ISBN, Estado FROM Prestamos " +
                                "WITH (UPDLOCK, HOLDLOCK) " +
                                "WHERE Id_Prestamo = @Id";

                            using (SqlCommand comando =
                                new SqlCommand(
                                    consultaActual, cn, transaccion))
                            {
                                comando.Parameters.AddWithValue(
                                    "@Id", idPrestamoSeleccionado.Value);

                                using (SqlDataReader lector =
                                    comando.ExecuteReader())
                                {
                                    if (!lector.Read())
                                        throw new Exception(
                                            "El préstamo ya no existe.");

                                    isbnAnterior = lector.GetString(0);
                                    estadoAnterior = lector.GetString(1);
                                }
                            }

                            bool estabaDevuelto =
                                estadoAnterior.Equals(
                                    "Devuelto",
                                    StringComparison.OrdinalIgnoreCase);

                            bool devolverAhora =
                                dtpFechaDevolucion.Checked;

                            if (estabaDevuelto && !devolverAhora)
                                throw new Exception(
                                    "No se puede reactivar un préstamo devuelto.");

                            if (estabaDevuelto &&
                                isbnNuevo != isbnAnterior)
                                throw new Exception(
                                    "No se puede cambiar el libro de un préstamo devuelto.");

                            if (!estabaDevuelto &&
                                isbnNuevo != isbnAnterior)
                            {
                                int disponibles =
                                    ObtenerExistencias(
                                        cn, transaccion, isbnNuevo);

                                if (disponibles <= 0)
                                    throw new Exception(
                                        "El nuevo libro no tiene existencias.");

                                CambiarExistencias(
                                    cn, transaccion, isbnAnterior, 1);

                                CambiarExistencias(
                                    cn, transaccion, isbnNuevo, -1);
                            }

                            if (!estabaDevuelto && devolverAhora)
                            {
                                CambiarExistencias(
                                    cn, transaccion, isbnNuevo, 1);
                            }

                            string estadoNuevo =
                                devolverAhora ? "Devuelto" : "Prestado";

                            string consulta =
                                "UPDATE Prestamos SET " +
                                "Id_Usuario = @Usuario, " +
                                "ISBN = @ISBN, " +
                                "Fecha_Prestamo = @FechaPrestamo, " +
                                "Fecha_Devolucion = @FechaDevolucion, " +
                                "Estado = @Estado " +
                                "WHERE Id_Prestamo = @Id";

                            using (SqlCommand comando =
                                new SqlCommand(consulta, cn, transaccion))
                            {
                                comando.Parameters.AddWithValue(
                                    "@Usuario", idUsuario);

                                comando.Parameters.AddWithValue(
                                    "@ISBN", isbnNuevo);

                                comando.Parameters.AddWithValue(
                                    "@FechaPrestamo",
                                    dtpFechaPrestamo.Value.Date);

                                comando.Parameters.Add(
                                    "@FechaDevolucion",
                                    SqlDbType.Date).Value =
                                    devolverAhora
                                        ? dtpFechaDevolucion.Value.Date
                                        : DBNull.Value;

                                comando.Parameters.AddWithValue(
                                    "@Estado", estadoNuevo);

                                comando.Parameters.AddWithValue(
                                    "@Id", idPrestamoSeleccionado.Value);

                                if (comando.ExecuteNonQuery() != 1)
                                    throw new Exception(
                                        "No fue posible actualizar el préstamo.");
                            }

                            transaccion.Commit();
                        }
                        catch
                        {
                            transaccion.Rollback();
                            throw;
                        }
                    }
                }

                MessageBox.Show(
                    "Préstamo actualizado correctamente.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarPrestamos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MostrarError("Error al editar préstamo", ex);
            }
        }

        // =========================================
        // ELIMINAR PRÉSTAMO
        // =========================================

        private void btnEliminar_Click(object? sender, EventArgs e)
        {
            if (idPrestamoSeleccionado == null)
            {
                MessageBox.Show(
                    "Haga doble clic sobre el préstamo que desea eliminar.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de eliminar este préstamo?",
                "Biblioteca",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection cn = CrearConexion())
                {
                    cn.Open();

                    using (SqlTransaction transaccion =
                        cn.BeginTransaction(IsolationLevel.Serializable))
                    {
                        try
                        {
                            string isbn;
                            string estado;

                            string consultaActual =
                                "SELECT ISBN, Estado FROM Prestamos " +
                                "WITH (UPDLOCK, HOLDLOCK) " +
                                "WHERE Id_Prestamo = @Id";

                            using (SqlCommand comando =
                                new SqlCommand(
                                    consultaActual, cn, transaccion))
                            {
                                comando.Parameters.AddWithValue(
                                    "@Id", idPrestamoSeleccionado.Value);

                                using (SqlDataReader lector =
                                    comando.ExecuteReader())
                                {
                                    if (!lector.Read())
                                        throw new Exception(
                                            "El préstamo ya no existe.");

                                    isbn = lector.GetString(0);
                                    estado = lector.GetString(1);
                                }
                            }

                            string consulta =
                                "DELETE FROM Prestamos " +
                                "WHERE Id_Prestamo = @Id";

                            using (SqlCommand comando =
                                new SqlCommand(consulta, cn, transaccion))
                            {
                                comando.Parameters.AddWithValue(
                                    "@Id", idPrestamoSeleccionado.Value);

                                if (comando.ExecuteNonQuery() != 1)
                                    throw new Exception(
                                        "No fue posible eliminar el préstamo.");
                            }

                            if (estado.Equals(
                                "Prestado",
                                StringComparison.OrdinalIgnoreCase))
                            {
                                CambiarExistencias(
                                    cn, transaccion, isbn, 1);
                            }

                            transaccion.Commit();
                        }
                        catch
                        {
                            transaccion.Rollback();
                            throw;
                        }
                    }
                }

                MessageBox.Show(
                    "Préstamo eliminado correctamente.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarPrestamos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MostrarError("Error al eliminar préstamo", ex);
            }
        }

        // =========================================
        // MENSAJES DE ERROR
        // =========================================

        private void MostrarError(string mensaje, Exception ex)
        {
            MessageBox.Show(
                mensaje + ":\n" + ex.Message,
                "Biblioteca",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
