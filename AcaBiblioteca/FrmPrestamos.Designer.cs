namespace AcaBiblioteca
{
    partial class FrmPrestamos
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
            pnlEncabezado = new Panel();
            lblTitulo = new Label();
            pnlDatos = new Panel();
            dtpFechaDevolucion = new DateTimePicker();
            dtpFechaPrestamo = new DateTimePicker();
            cmbLibro = new ComboBox();
            cmbUsuario = new ComboBox();
            lblFechaDevolucion = new Label();
            lblFechaPrestamo = new Label();
            lblLibro = new Label();
            lblUsuario = new Label();
            pnlBotones = new Panel();
            pnlContenido = new Panel();
            dgvPrestamos = new DataGridView();
            btnNuevo = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            pnlEncabezado.SuspendLayout();
            pnlDatos.SuspendLayout();
            pnlBotones.SuspendLayout();
            pnlContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).BeginInit();
            SuspendLayout();
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.BackColor = Color.OliveDrab;
            pnlEncabezado.Controls.Add(lblTitulo);
            pnlEncabezado.Dock = DockStyle.Top;
            pnlEncabezado.Location = new Point(0, 0);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new Size(784, 55);
            pnlEncabezado.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(25, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(301, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GESTION DE PRESTAMOS";
            // 
            // pnlDatos
            // 
            pnlDatos.BorderStyle = BorderStyle.FixedSingle;
            pnlDatos.Controls.Add(dtpFechaDevolucion);
            pnlDatos.Controls.Add(dtpFechaPrestamo);
            pnlDatos.Controls.Add(cmbLibro);
            pnlDatos.Controls.Add(cmbUsuario);
            pnlDatos.Controls.Add(lblFechaDevolucion);
            pnlDatos.Controls.Add(lblFechaPrestamo);
            pnlDatos.Controls.Add(lblLibro);
            pnlDatos.Controls.Add(lblUsuario);
            pnlDatos.Dock = DockStyle.Top;
            pnlDatos.Location = new Point(0, 55);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(784, 165);
            pnlDatos.TabIndex = 1;
            // 
            // dtpFechaDevolucion
            // 
            dtpFechaDevolucion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaDevolucion.Format = DateTimePickerFormat.Short;
            dtpFechaDevolucion.Location = new Point(410, 120);
            dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            dtpFechaDevolucion.ShowCheckBox = true;
            dtpFechaDevolucion.Size = new Size(340, 25);
            dtpFechaDevolucion.TabIndex = 7;
            // 
            // dtpFechaPrestamo
            // 
            dtpFechaPrestamo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaPrestamo.Format = DateTimePickerFormat.Short;
            dtpFechaPrestamo.Location = new Point(25, 120);
            dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            dtpFechaPrestamo.Size = new Size(340, 25);
            dtpFechaPrestamo.TabIndex = 6;
            // 
            // cmbLibro
            // 
            cmbLibro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLibro.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbLibro.FormattingEnabled = true;
            cmbLibro.Location = new Point(410, 45);
            cmbLibro.Name = "cmbLibro";
            cmbLibro.Size = new Size(340, 25);
            cmbLibro.TabIndex = 5;
            // 
            // cmbUsuario
            // 
            cmbUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUsuario.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbUsuario.FormattingEnabled = true;
            cmbUsuario.Location = new Point(25, 45);
            cmbUsuario.Name = "cmbUsuario";
            cmbUsuario.Size = new Size(340, 25);
            cmbUsuario.TabIndex = 4;
            // 
            // lblFechaDevolucion
            // 
            lblFechaDevolucion.AutoSize = true;
            lblFechaDevolucion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaDevolucion.Location = new Point(410, 95);
            lblFechaDevolucion.Name = "lblFechaDevolucion";
            lblFechaDevolucion.Size = new Size(121, 17);
            lblFechaDevolucion.TabIndex = 3;
            lblFechaDevolucion.Text = "Fecha Devolución:";
            // 
            // lblFechaPrestamo
            // 
            lblFechaPrestamo.AutoSize = true;
            lblFechaPrestamo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaPrestamo.Location = new Point(25, 95);
            lblFechaPrestamo.Name = "lblFechaPrestamo";
            lblFechaPrestamo.Size = new Size(109, 17);
            lblFechaPrestamo.TabIndex = 2;
            lblFechaPrestamo.Text = "Fecha Préstamo:";
            // 
            // lblLibro
            // 
            lblLibro.AutoSize = true;
            lblLibro.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLibro.Location = new Point(410, 20);
            lblLibro.Name = "lblLibro";
            lblLibro.Size = new Size(44, 17);
            lblLibro.TabIndex = 1;
            lblLibro.Text = "Libro:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(25, 20);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 17);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario:";
            // 
            // pnlBotones
            // 
            pnlBotones.BorderStyle = BorderStyle.FixedSingle;
            pnlBotones.Controls.Add(btnCancelar);
            pnlBotones.Controls.Add(btnEliminar);
            pnlBotones.Controls.Add(btnEditar);
            pnlBotones.Controls.Add(btnGuardar);
            pnlBotones.Controls.Add(btnNuevo);
            pnlBotones.Dock = DockStyle.Top;
            pnlBotones.Location = new Point(0, 220);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Size = new Size(784, 65);
            pnlBotones.TabIndex = 2;
            // 
            // pnlContenido
            // 
            pnlContenido.Controls.Add(dgvPrestamos);
            pnlContenido.Dock = DockStyle.Fill;
            pnlContenido.Location = new Point(0, 285);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(784, 126);
            pnlContenido.TabIndex = 3;
            // 
            // dgvPrestamos
            // 
            dgvPrestamos.AllowUserToAddRows = false;
            dgvPrestamos.AllowUserToDeleteRows = false;
            dgvPrestamos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrestamos.BackgroundColor = Color.White;
            dgvPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrestamos.Dock = DockStyle.Fill;
            dgvPrestamos.Location = new Point(0, 0);
            dgvPrestamos.MultiSelect = false;
            dgvPrestamos.Name = "dgvPrestamos";
            dgvPrestamos.ReadOnly = true;
            dgvPrestamos.RowHeadersVisible = false;
            dgvPrestamos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrestamos.Size = new Size(784, 126);
            dgvPrestamos.TabIndex = 0;
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.IconChar = FontAwesome.Sharp.IconChar.Palette;
            btnNuevo.IconColor = Color.Black;
            btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevo.IconSize = 25;
            btnNuevo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevo.Location = new Point(40, 15);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(110, 35);
            btnNuevo.TabIndex = 5;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextAlign = ContentAlignment.MiddleRight;
            btnNuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 25;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(167, 15);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(110, 35);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += this.btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.Pen;
            btnEditar.IconColor = Color.Black;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.IconSize = 25;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(293, 15);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(110, 35);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += this.btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.IconSize = 25;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(421, 15);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(110, 35);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.IconSize = 25;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(548, 15);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(110, 35);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmPrestamos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
            Controls.Add(pnlContenido);
            Controls.Add(pnlBotones);
            Controls.Add(pnlDatos);
            Controls.Add(pnlEncabezado);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPrestamos";
            Text = "FrmPrestamos";
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            pnlBotones.ResumeLayout(false);
            pnlContenido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlEncabezado;
        private Label lblTitulo;
        private Panel pnlDatos;
        private Panel pnlBotones;
        private Panel pnlContenido;
        private Label lblFechaPrestamo;
        private Label lblLibro;
        private Label lblUsuario;
        private DateTimePicker dtpFechaPrestamo;
        private ComboBox cmbLibro;
        private ComboBox cmbUsuario;
        private Label lblFechaDevolucion;
        private DateTimePicker dtpFechaDevolucion;
        private DataGridView dgvPrestamos;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnCancelar;
    }
}