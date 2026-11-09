namespace AcaBiblioteca
{
    partial class FrmUsuarios
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
            txtCorreo = new TextBox();
            lblCorreo = new Label();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtDocumento = new TextBox();
            lblDocumento = new Label();
            txtApellido = new TextBox();
            lblApellido = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            pnlBotones = new Panel();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnNuevo = new FontAwesome.Sharp.IconButton();
            dgvUsuarios = new DataGridView();
            pnlEncabezado.SuspendLayout();
            pnlDatos.SuspendLayout();
            pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.BackColor = Color.OliveDrab;
            pnlEncabezado.Controls.Add(lblTitulo);
            pnlEncabezado.Dock = DockStyle.Top;
            pnlEncabezado.Location = new Point(0, 0);
            pnlEncabezado.Margin = new Padding(2);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new Size(800, 39);
            pnlEncabezado.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(55, 5);
            lblTitulo.Margin = new Padding(2, 0, 2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(256, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GESTION DE USUARIOS";
            // 
            // pnlDatos
            // 
            pnlDatos.BorderStyle = BorderStyle.FixedSingle;
            pnlDatos.Controls.Add(txtCorreo);
            pnlDatos.Controls.Add(lblCorreo);
            pnlDatos.Controls.Add(txtTelefono);
            pnlDatos.Controls.Add(lblTelefono);
            pnlDatos.Controls.Add(txtDocumento);
            pnlDatos.Controls.Add(lblDocumento);
            pnlDatos.Controls.Add(txtApellido);
            pnlDatos.Controls.Add(lblApellido);
            pnlDatos.Controls.Add(txtNombre);
            pnlDatos.Controls.Add(lblNombre);
            pnlDatos.Dock = DockStyle.Top;
            pnlDatos.Location = new Point(0, 39);
            pnlDatos.Margin = new Padding(2);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(800, 88);
            pnlDatos.TabIndex = 1;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(189, 61);
            txtCorreo.Margin = new Padding(2);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(344, 23);
            txtCorreo.TabIndex = 9;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCorreo.Location = new Point(189, 46);
            lblCorreo.Margin = new Padding(2, 0, 2, 0);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(50, 19);
            lblCorreo.TabIndex = 8;
            lblCorreo.Text = "EMAIL";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(18, 61);
            txtTelefono.Margin = new Padding(2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(155, 23);
            txtTelefono.TabIndex = 7;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefono.Location = new Point(18, 46);
            lblTelefono.Margin = new Padding(2, 0, 2, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(78, 19);
            lblTelefono.TabIndex = 6;
            lblTelefono.Text = "TELEFONO";
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(360, 22);
            txtDocumento.Margin = new Padding(2);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(173, 23);
            txtDocumento.TabIndex = 5;
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDocumento.Location = new Point(360, 4);
            lblDocumento.Margin = new Padding(2, 0, 2, 0);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(98, 19);
            lblDocumento.TabIndex = 4;
            lblDocumento.Text = "DOCUMENTO";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(189, 23);
            txtApellido.Margin = new Padding(2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(155, 23);
            txtApellido.TabIndex = 3;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApellido.Location = new Point(189, 4);
            lblApellido.Margin = new Padding(2, 0, 2, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(82, 19);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "APELLIDOS";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(18, 23);
            txtNombre.Margin = new Padding(2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(155, 23);
            txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(18, 4);
            lblNombre.Margin = new Padding(2, 0, 2, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(69, 19);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "NOMBRE";
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
            pnlBotones.Location = new Point(0, 127);
            pnlBotones.Margin = new Padding(2);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Size = new Size(800, 65);
            pnlBotones.TabIndex = 2;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.IconSize = 25;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(539, 15);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(110, 35);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.IconSize = 25;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(423, 15);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(110, 35);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.Pen;
            btnEditar.IconColor = Color.Black;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.IconSize = 25;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(288, 15);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(110, 35);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "EDITAR";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 25;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(172, 15);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(110, 35);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.IconChar = FontAwesome.Sharp.IconChar.Palette;
            btnNuevo.IconColor = Color.Black;
            btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevo.IconSize = 25;
            btnNuevo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevo.Location = new Point(44, 15);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(110, 35);
            btnNuevo.TabIndex = 5;
            btnNuevo.Text = "NUEVO";
            btnNuevo.TextAlign = ContentAlignment.MiddleRight;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.BackgroundColor = Color.White;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Dock = DockStyle.Fill;
            dgvUsuarios.Location = new Point(0, 192);
            dgvUsuarios.Margin = new Padding(2);
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.RowHeadersWidth = 62;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(800, 258);
            dgvUsuarios.TabIndex = 3;
            dgvUsuarios.CellDoubleClick += dgvUsuarios_CellDoubleClick;
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvUsuarios);
            Controls.Add(pnlBotones);
            Controls.Add(pnlDatos);
            Controls.Add(pnlEncabezado);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FrmUsuarios";
            Text = "Gestion de Usuarios";
            Load += FrmUsuarios_Load;
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            pnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlEncabezado;
        private Label lblTitulo;
        private Panel pnlDatos;
        private TextBox txtApellido;
        private Label lblApellido;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtDocumento;
        private Label lblDocumento;
        private TextBox txtCorreo;
        private Label lblCorreo;
        private Panel pnlBotones;
        private DataGridView dgvUsuarios;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnEliminar;
    }
}