namespace AcaBiblioteca
{
    partial class FrmLibros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PnlTitulo = new Panel();
            LblTitulo = new Label();
            PnlBusqueda = new Panel();
            btnBuscar = new Button();
            txtBuscarISBN = new TextBox();
            LblBuscar = new Label();
            LblIsbn = new Label();
            PnlDatos = new Panel();
            cmbEditorial = new ComboBox();
            cmbAutor = new ComboBox();
            txtExistencias = new TextBox();
            txtAnio = new TextBox();
            txtCategoria = new TextBox();
            txtTitulo = new TextBox();
            txtISBN = new TextBox();
            LblExistencias = new Label();
            lblAnio = new Label();
            LblCategoria = new Label();
            LblEditorial = new Label();
            LblAutor = new Label();
            LblTutuloLib = new Label();
            PnlBotones = new Panel();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnNuevo = new FontAwesome.Sharp.IconButton();
            dgvLibros = new DataGridView();
            PnlTitulo.SuspendLayout();
            PnlBusqueda.SuspendLayout();
            PnlDatos.SuspendLayout();
            PnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            SuspendLayout();
            // 
            // PnlTitulo
            // 
            PnlTitulo.BackColor = Color.OliveDrab;
            PnlTitulo.Controls.Add(LblTitulo);
            PnlTitulo.Dock = DockStyle.Top;
            PnlTitulo.Location = new Point(0, 0);
            PnlTitulo.Name = "PnlTitulo";
            PnlTitulo.Size = new Size(1350, 81);
            PnlTitulo.TabIndex = 0;
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.BackColor = Color.Transparent;
            LblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTitulo.Location = new Point(277, 21);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(243, 32);
            LblTitulo.TabIndex = 0;
            LblTitulo.Text = "GESTION DE LIBROS";
            // 
            // PnlBusqueda
            // 
            PnlBusqueda.BackColor = Color.WhiteSmoke;
            PnlBusqueda.Controls.Add(btnBuscar);
            PnlBusqueda.Controls.Add(txtBuscarISBN);
            PnlBusqueda.Controls.Add(LblBuscar);
            PnlBusqueda.Dock = DockStyle.Top;
            PnlBusqueda.Location = new Point(0, 81);
            PnlBusqueda.Name = "PnlBusqueda";
            PnlBusqueda.Size = new Size(1350, 55);
            PnlBusqueda.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(458, 15);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(108, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscarISBN
            // 
            txtBuscarISBN.Location = new Point(243, 15);
            txtBuscarISBN.Name = "txtBuscarISBN";
            txtBuscarISBN.Size = new Size(200, 23);
            txtBuscarISBN.TabIndex = 1;
            // 
            // LblBuscar
            // 
            LblBuscar.AutoSize = true;
            LblBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblBuscar.Location = new Point(202, 15);
            LblBuscar.Name = "LblBuscar";
            LblBuscar.Size = new Size(35, 15);
            LblBuscar.TabIndex = 0;
            LblBuscar.Text = "ISBN";
            // 
            // LblIsbn
            // 
            LblIsbn.AutoSize = true;
            LblIsbn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblIsbn.Location = new Point(290, 15);
            LblIsbn.Name = "LblIsbn";
            LblIsbn.Size = new Size(38, 15);
            LblIsbn.TabIndex = 6;
            LblIsbn.Text = "ISBN:";
            // 
            // PnlDatos
            // 
            PnlDatos.Controls.Add(cmbEditorial);
            PnlDatos.Controls.Add(cmbAutor);
            PnlDatos.Controls.Add(txtExistencias);
            PnlDatos.Controls.Add(txtAnio);
            PnlDatos.Controls.Add(txtCategoria);
            PnlDatos.Controls.Add(txtTitulo);
            PnlDatos.Controls.Add(txtISBN);
            PnlDatos.Controls.Add(LblExistencias);
            PnlDatos.Controls.Add(lblAnio);
            PnlDatos.Controls.Add(LblCategoria);
            PnlDatos.Controls.Add(LblEditorial);
            PnlDatos.Controls.Add(LblAutor);
            PnlDatos.Controls.Add(LblIsbn);
            PnlDatos.Controls.Add(LblTutuloLib);
            PnlDatos.Dock = DockStyle.Top;
            PnlDatos.Location = new Point(0, 136);
            PnlDatos.Name = "PnlDatos";
            PnlDatos.Size = new Size(1350, 229);
            PnlDatos.TabIndex = 2;
            // 
            // cmbEditorial
            // 
            cmbEditorial.FormattingEnabled = true;
            cmbEditorial.Location = new Point(369, 97);
            cmbEditorial.Name = "cmbEditorial";
            cmbEditorial.Size = new Size(223, 23);
            cmbEditorial.TabIndex = 15;
            // 
            // cmbAutor
            // 
            cmbAutor.FormattingEnabled = true;
            cmbAutor.Location = new Point(369, 70);
            cmbAutor.Name = "cmbAutor";
            cmbAutor.Size = new Size(223, 23);
            cmbAutor.TabIndex = 14;
            // 
            // txtExistencias
            // 
            txtExistencias.Location = new Point(369, 186);
            txtExistencias.Name = "txtExistencias";
            txtExistencias.Size = new Size(223, 23);
            txtExistencias.TabIndex = 13;
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(369, 156);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(223, 23);
            txtAnio.TabIndex = 12;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(369, 123);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(223, 23);
            txtCategoria.TabIndex = 11;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(369, 41);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(223, 23);
            txtTitulo.TabIndex = 10;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(369, 12);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(223, 23);
            txtISBN.TabIndex = 3;
            // 
            // LblExistencias
            // 
            LblExistencias.AutoSize = true;
            LblExistencias.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblExistencias.Location = new Point(290, 186);
            LblExistencias.Name = "LblExistencias";
            LblExistencias.Size = new Size(70, 15);
            LblExistencias.TabIndex = 9;
            LblExistencias.Text = "Existencias:";
            // 
            // lblAnio
            // 
            lblAnio.AutoSize = true;
            lblAnio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAnio.Location = new Point(290, 156);
            lblAnio.Name = "lblAnio";
            lblAnio.Size = new Size(32, 15);
            lblAnio.TabIndex = 16;
            lblAnio.Text = "Año:";
            // 
            // LblCategoria
            // 
            LblCategoria.AutoSize = true;
            LblCategoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblCategoria.Location = new Point(290, 126);
            LblCategoria.Name = "LblCategoria";
            LblCategoria.Size = new Size(63, 15);
            LblCategoria.TabIndex = 7;
            LblCategoria.Text = "Categoria:";
            // 
            // LblEditorial
            // 
            LblEditorial.AutoSize = true;
            LblEditorial.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblEditorial.Location = new Point(290, 97);
            LblEditorial.Name = "LblEditorial";
            LblEditorial.Size = new Size(55, 15);
            LblEditorial.TabIndex = 5;
            LblEditorial.Text = "Editorial:";
            // 
            // LblAutor
            // 
            LblAutor.AutoSize = true;
            LblAutor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblAutor.Location = new Point(290, 69);
            LblAutor.Name = "LblAutor";
            LblAutor.Size = new Size(42, 15);
            LblAutor.TabIndex = 4;
            LblAutor.Text = "Autor:";
            // 
            // LblTutuloLib
            // 
            LblTutuloLib.AutoSize = true;
            LblTutuloLib.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTutuloLib.Location = new Point(290, 44);
            LblTutuloLib.Name = "LblTutuloLib";
            LblTutuloLib.Size = new Size(42, 15);
            LblTutuloLib.TabIndex = 1;
            LblTutuloLib.Text = "Titulo:";
            // 
            // PnlBotones
            // 
            PnlBotones.Controls.Add(btnCancelar);
            PnlBotones.Controls.Add(btnEliminar);
            PnlBotones.Controls.Add(btnEditar);
            PnlBotones.Controls.Add(btnGuardar);
            PnlBotones.Controls.Add(btnNuevo);
            PnlBotones.Dock = DockStyle.Top;
            PnlBotones.Location = new Point(0, 365);
            PnlBotones.Name = "PnlBotones";
            PnlBotones.Size = new Size(1350, 53);
            PnlBotones.TabIndex = 3;
            // 
            // btnCancelar
            // 
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.X;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.IconSize = 25;
            btnCancelar.Location = new Point(622, 11);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(125, 29);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.IconSize = 25;
            btnEliminar.Location = new Point(491, 11);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(125, 29);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            btnEditar.IconColor = Color.Black;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.IconSize = 25;
            btnEditar.Location = new Point(360, 11);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(125, 29);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 25;
            btnGuardar.Location = new Point(229, 11);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(125, 29);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.IconChar = FontAwesome.Sharp.IconChar.Palette;
            btnNuevo.IconColor = Color.Black;
            btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevo.IconSize = 25;
            btnNuevo.Location = new Point(100, 11);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(124, 29);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextAlign = ContentAlignment.MiddleRight;
            btnNuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // dgvLibros
            // 
            dgvLibros.AllowUserToAddRows = false;
            dgvLibros.AllowUserToDeleteRows = false;
            dgvLibros.AllowUserToResizeColumns = false;
            dgvLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLibros.BackgroundColor = Color.White;
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Dock = DockStyle.Fill;
            dgvLibros.EnableHeadersVisualStyles = false;
            dgvLibros.Location = new Point(0, 418);
            dgvLibros.MultiSelect = false;
            dgvLibros.Name = "dgvLibros";
            dgvLibros.ReadOnly = true;
            dgvLibros.RowHeadersVisible = false;
            dgvLibros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLibros.Size = new Size(1350, 324);
            dgvLibros.TabIndex = 4;
            dgvLibros.CellClick += dgvLibros_CellClick;
            // 
            // FrmLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 742);
            Controls.Add(dgvLibros);
            Controls.Add(PnlBotones);
            Controls.Add(PnlDatos);
            Controls.Add(PnlBusqueda);
            Controls.Add(PnlTitulo);
            Name = "FrmLibros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLibros";
            WindowState = FormWindowState.Maximized;
            Load += FrmLibros_Load;
            PnlTitulo.ResumeLayout(false);
            PnlTitulo.PerformLayout();
            PnlBusqueda.ResumeLayout(false);
            PnlBusqueda.PerformLayout();
            PnlDatos.ResumeLayout(false);
            PnlDatos.PerformLayout();
            PnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlTitulo;
        private Label LblTitulo;
        private Panel PnlBusqueda;
        private Button btnBuscar;
        private TextBox txtBuscarISBN;
        private Label LblBuscar;
        private Panel PnlDatos;
        private Label LblTutuloLib;
        private Label LblIsbn;
        private Label LblEditorial;
        private Label LblAutor;
        private Label LblCategoria;       
        private TextBox txtISBN;
        private Label LblExistencias;
        private Label lblAnio;
        private ComboBox cmbAutor;
        private TextBox txtExistencias;
        private TextBox txtAnio;
        private TextBox txtCategoria;
        private TextBox txtTitulo;
        private ComboBox cmbEditorial;
        private Panel PnlBotones;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private DataGridView dgvLibros;
    }
}