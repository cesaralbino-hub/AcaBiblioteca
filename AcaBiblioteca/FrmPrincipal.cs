using AcaBiblioteca.Datos;
using System.Drawing.Text;

namespace AcaBiblioteca
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            //  Conexion conexion = new Conexion(); 
            //    try 
            //{
            //using (var conn = conexion.obtenerConexion())
            //{
            //    conn.Open();
            //        MessageBox.Show("Conexión establecida con exito.", "AcaBiblioteca",
            //            MessageBoxButtons.OK, 
            //            MessageBoxIcon.Information); 
            //    } 

            //} 
            //catch (Exception ex) { MessageBox.Show("Error de conexión:\n" + ex.Message, "AcaBiblioteca",
            //    MessageBoxButtons.OK, 
            //    MessageBoxIcon.Error); }


            abrir_formulario(new FrmInicio());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void PicLogo_Click(object sender, EventArgs e)
        {

        }
        private void abrir_formulario(Form formulario)
        {
            PnlContenido.Controls.Clear();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            PnlContenido.Controls.Add(formulario);
            formulario.Show();

            //    MessageBox.Show(
            //     "PnlContenido: " + PnlContenido.Width + " x " + PnlContenido.Height +
            //     "\nPnlEstado: " + PnlEstado.Width + " x " + PnlEstado.Height +
            //     "\nFrmLibros: " + formulario.Width + " x " + formulario.Height,
            //     "Diagnóstico de tamaños");
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            abrir_formulario(new FrmInicio());
        }

        private void BtnLibros_Click(object sender, EventArgs e)
        {
            abrir_formulario(new FrmLibros());
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            abrir_formulario(new FrmUsuarios());
        }

        private void BtnAutores_Click(object sender, EventArgs e)
        {
            abrir_formulario(new FrmAutores());
        }

        private void BtnEditoriales_Click(object sender, EventArgs e)
        {
            abrir_formulario(new FrmEditoriales());
        }

        private void BtnPrestamos_Click(object sender, EventArgs e)
        {
            abrir_formulario(new FrmPrestamos());
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            abrir_formulario(new FrmReportes());
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        

        }
    }
}
