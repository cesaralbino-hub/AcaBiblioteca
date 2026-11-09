namespace AcaBiblioteca
{
    partial class FrmEditoriales
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
            txtNombre = new TextBox();
            lblNombre = new Label();
            pnlBotones = new Panel();
            dgvEditoriales = new DataGridView();
            btnNuevo = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            pnlEncabezado.SuspendLayout();
            pnlDatos.SuspendLayout();
            pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEditoriales).BeginInit();
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
            pnlEncabezado.Size = new Size(800, 36);
            pnlEncabezado.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(20, 9);
            lblTitulo.Margin = new Padding(2, 0, 2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(282, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GESTION DE EDITORIALES";
            // 
            // pnlDatos
            // 
            pnlDatos.BorderStyle = BorderStyle.FixedSingle;
            pnlDatos.Controls.Add(txtNombre);
            pnlDatos.Controls.Add(lblNombre);
            pnlDatos.Dock = DockStyle.Top;
            pnlDatos.Location = new Point(0, 36);
            pnlDatos.Margin = new Padding(2);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(800, 52);
            pnlDatos.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(18, 23);
            txtNombre.Margin = new Padding(2);
            txtNombre.MaxLength = 100;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(351, 27);
            txtNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(18, 5);
            lblNombre.Margin = new Padding(2, 0, 2, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(125, 19);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre Editorial";
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
            pnlBotones.Location = new Point(0, 88);
            pnlBotones.Margin = new Padding(2);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Size = new Size(800, 65);
            pnlBotones.TabIndex = 2;
            // 
            // dgvEditoriales
            // 
            dgvEditoriales.AllowUserToAddRows = false;
            dgvEditoriales.AllowUserToDeleteRows = false;
            dgvEditoriales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEditoriales.BackgroundColor = Color.White;
            dgvEditoriales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEditoriales.Dock = DockStyle.Fill;
            dgvEditoriales.EnableHeadersVisualStyles = false;
            dgvEditoriales.Location = new Point(0, 153);
            dgvEditoriales.Margin = new Padding(2);
            dgvEditoriales.MultiSelect = false;
            dgvEditoriales.Name = "dgvEditoriales";
            dgvEditoriales.ReadOnly = true;
            dgvEditoriales.RowHeadersVisible = false;
            dgvEditoriales.RowHeadersWidth = 62;
            dgvEditoriales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEditoriales.Size = new Size(800, 297);
            dgvEditoriales.TabIndex = 6;
            dgvEditoriales.CellDoubleClick += dgvEditoriales_CellDoubleClick;
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.IconChar = FontAwesome.Sharp.IconChar.Palette;
            btnNuevo.IconColor = Color.Black;
            btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevo.IconSize = 25;
            btnNuevo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevo.Location = new Point(53, 15);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(110, 35);
            btnNuevo.TabIndex = 6;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextAlign = ContentAlignment.MiddleRight;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 25;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(187, 15);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(110, 35);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.Pen;
            btnEditar.IconColor = Color.Black;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.IconSize = 25;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(314, 15);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(110, 35);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += this.btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.IconSize = 25;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(443, 15);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(110, 35);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += this.btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.IconSize = 25;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(570, 15);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(110, 35);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += this.btnCancelar_Click;
            // 
            // FrmEditoriales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvEditoriales);
            Controls.Add(pnlBotones);
            Controls.Add(pnlDatos);
            Controls.Add(pnlEncabezado);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FrmEditoriales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmEditoriales";
            Load += FrmEditoriales_Load;
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            pnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEditoriales).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlEncabezado;
        private Label lblTitulo;
        private Panel pnlDatos;
        private TextBox txtNombre;
        private Label lblNombre;
        private Panel pnlBotones;
        private DataGridView dgvEditoriales;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
    }
}