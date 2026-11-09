
using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using AcaBiblioteca.Datos;

namespace AcaBiblioteca
{
    public partial class FrmReportes : Form
    {
        public FrmReportes()
        {
            InitializeComponent();
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {
            CargarTiposReporte();
            LimpiarReporte();
        }

        private void CargarTiposReporte()
        {
            cmbTipoReporte.Items.Clear();

            cmbTipoReporte.Items.Add("Préstamos activos");
            cmbTipoReporte.Items.Add("Préstamos devueltos");
            cmbTipoReporte.Items.Add("Inventario de libros");

            cmbTipoReporte.SelectedIndex = -1;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
           if (cmbTipoReporte.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione un tipo de reporte.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cmbTipoReporte.Focus();
                return;
            }

            string consulta = "";

            switch (cmbTipoReporte.SelectedIndex)
            {
                case 0:
                    consulta = @"
                        SELECT
                            p.Id_Prestamo,
                            u.Nombre + ' ' + u.Apellido AS Usuario,
                            l.Titulo AS Libro,
                            p.Fecha_Prestamo,
                            p.Fecha_Devolucion,
                            p.Estado
                        FROM Prestamos p
                        INNER JOIN Usuarios u
                            ON p.Id_Usuario = u.Id_Usuario
                        INNER JOIN Libros l
                            ON p.ISBN = l.ISBN
                        WHERE p.Estado = 'Prestado'
                        ORDER BY p.Fecha_Prestamo DESC,
                                 p.Id_Prestamo DESC";
                    break;

                case 1:
                    consulta = @"
                        SELECT
                            p.Id_Prestamo,
                            u.Nombre + ' ' + u.Apellido AS Usuario,
                            l.Titulo AS Libro,
                            p.Fecha_Prestamo,
                            p.Fecha_Devolucion,
                            p.Estado
                        FROM Prestamos p
                        INNER JOIN Usuarios u
                            ON p.Id_Usuario = u.Id_Usuario
                        INNER JOIN Libros l
                            ON p.ISBN = l.ISBN
                        WHERE p.Estado = 'Devuelto'
                        ORDER BY p.Fecha_Devolucion DESC,
                                 p.Id_Prestamo DESC";
                    break;

                case 2:
                    consulta = @"
                        SELECT
                            l.ISBN,
                            l.Titulo,
                            a.Nombre + ' ' + a.Apellido AS Autor,
                            e.Nombre AS Editorial,
                            l.Categoria,
                            l.Anio,
                            l.Existencias
                        FROM Libros l
                        INNER JOIN Autores a
                            ON l.Id_Autor = a.Id_Autor
                        INNER JOIN Editoriales e
                            ON l.Id_Editorial = e.Id_Editorial
                        ORDER BY l.Titulo";
                    break;
            }

            GenerarReporte(consulta);
        }

        private void GenerarReporte(string consulta)
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.obtenerConexion())
                {
                    cn.Open();

                    using (SqlDataAdapter adaptador =
                        new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);

                        dgvReportes.DataSource = tabla;

                        if (tabla.Rows.Count == 0)
                        {
                            MessageBox.Show(
                                "No se encontraron registros para este reporte.",
                                "Biblioteca",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Error al consultar la base de datos:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al generar el reporte:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarReporte();
        }

        private void LimpiarReporte()
        {
            cmbTipoReporte.SelectedIndex = -1;
            dgvReportes.DataSource = null;
            dgvReportes.Columns.Clear();
        }
    }
}
