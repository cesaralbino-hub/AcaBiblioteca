namespace AcaBiblioteca
{
    partial class FrmReportes
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
            pnlFiltros = new Panel();
            cmbTipoReporte = new ComboBox();
            lblTipoReporte = new Label();
            pnlBotones = new Panel();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            btnGenerar = new FontAwesome.Sharp.IconButton();
            dgvReportes = new DataGridView();
            pnlEncabezado.SuspendLayout();
            pnlFiltros.SuspendLayout();
            pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).BeginInit();
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
            pnlEncabezado.Size = new Size(784, 55);
            pnlEncabezado.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(25, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(279, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GESTIÓN DE REPORTES";
            // 
            // pnlFiltros
            // 
            pnlFiltros.BorderStyle = BorderStyle.FixedSingle;
            pnlFiltros.Controls.Add(cmbTipoReporte);
            pnlFiltros.Controls.Add(lblTipoReporte);
            pnlFiltros.Dock = DockStyle.Top;
            pnlFiltros.Location = new Point(0, 55);
            pnlFiltros.Name = "pnlFiltros";
            pnlFiltros.Size = new Size(784, 90);
            pnlFiltros.TabIndex = 1;
            // 
            // cmbTipoReporte
            // 
            cmbTipoReporte.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoReporte.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTipoReporte.FormattingEnabled = true;
            cmbTipoReporte.Location = new Point(25, 38);
            cmbTipoReporte.Name = "cmbTipoReporte";
            cmbTipoReporte.Size = new Size(350, 25);
            cmbTipoReporte.TabIndex = 0;
            // 
            // lblTipoReporte
            // 
            lblTipoReporte.AutoSize = true;
            lblTipoReporte.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipoReporte.Location = new Point(25, 12);
            lblTipoReporte.Name = "lblTipoReporte";
            lblTipoReporte.Size = new Size(111, 17);
            lblTipoReporte.TabIndex = 0;
            lblTipoReporte.Text = "Tipo de Reporte:";
            // 
            // pnlBotones
            // 
            pnlBotones.BorderStyle = BorderStyle.FixedSingle;
            pnlBotones.Controls.Add(btnLimpiar);
            pnlBotones.Controls.Add(btnGenerar);
            pnlBotones.Dock = DockStyle.Top;
            pnlBotones.Location = new Point(0, 145);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Size = new Size(784, 65);
            pnlBotones.TabIndex = 2;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            btnLimpiar.IconColor = Color.Black;
            btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiar.IconSize = 25;
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(162, 15);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(110, 35);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGenerar
            // 
            btnGenerar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerar.IconChar = FontAwesome.Sharp.IconChar.Eject;
            btnGenerar.IconColor = Color.Black;
            btnGenerar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGenerar.IconSize = 25;
            btnGenerar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGenerar.Location = new Point(20, 15);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(110, 35);
            btnGenerar.TabIndex = 3;
            btnGenerar.Text = "Generar";
            btnGenerar.TextAlign = ContentAlignment.MiddleRight;
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // dgvReportes
            // 
            dgvReportes.AllowUserToAddRows = false;
            dgvReportes.AllowUserToDeleteRows = false;
            dgvReportes.AllowUserToResizeColumns = false;
            dgvReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReportes.BackgroundColor = Color.White;
            dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportes.Dock = DockStyle.Fill;
            dgvReportes.Location = new Point(0, 210);
            dgvReportes.MultiSelect = false;
            dgvReportes.Name = "dgvReportes";
            dgvReportes.ReadOnly = true;
            dgvReportes.RowHeadersVisible = false;
            dgvReportes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReportes.Size = new Size(784, 201);
            dgvReportes.TabIndex = 3;
            // 
            // FrmReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
            Controls.Add(dgvReportes);
            Controls.Add(pnlBotones);
            Controls.Add(pnlFiltros);
            Controls.Add(pnlEncabezado);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmReportes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion de Reportes";
            Load += FrmReportes_Load;
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            pnlFiltros.ResumeLayout(false);
            pnlFiltros.PerformLayout();
            pnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReportes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlEncabezado;
        private Label lblTitulo;
        private Panel pnlFiltros;
        private ComboBox cmbTipoReporte;
        private Label lblTipoReporte;
        private Panel pnlBotones;
        private DataGridView dgvReportes;
        private FontAwesome.Sharp.IconButton btnGenerar;
        private FontAwesome.Sharp.IconButton btnLimpiar;
    }
}