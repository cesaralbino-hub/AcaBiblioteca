namespace AcaBiblioteca
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlMenu = new Panel();
            pnlInformacion = new FlowLayoutPanel();
            lblInfoTitulo = new Label();
            lblInfoAcademica = new Label();
            lblInfoAsignatura = new Label();
            lblInfoPrograma = new Label();
            lblInfoAutor = new Label();
            lblInfoAnio = new Label();
            picBirrete = new FontAwesome.Sharp.IconPictureBox();
            BtnSalir = new FontAwesome.Sharp.IconButton();
            BtnReportes = new FontAwesome.Sharp.IconButton();
            BtnPrestamos = new FontAwesome.Sharp.IconButton();
            BtnEditoriales = new FontAwesome.Sharp.IconButton();
            BtnAutores = new FontAwesome.Sharp.IconButton();
            BtnUsuarios = new FontAwesome.Sharp.IconButton();
            BtnLibros = new FontAwesome.Sharp.IconButton();
            BtnInicio = new FontAwesome.Sharp.IconButton();
            PnlLogo = new Panel();
            PicLogo = new PictureBox();
            LblSubtitulo = new Label();
            lblTitulo = new Label();
            PnlSuperior = new Panel();
            lblTituloPrincipal = new Label();
            PnlEstado = new Panel();
            PnlContenido = new Panel();
            pnlMenu.SuspendLayout();
            pnlInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBirrete).BeginInit();
            PnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicLogo).BeginInit();
            PnlSuperior.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = SystemColors.ButtonFace;
            pnlMenu.Controls.Add(pnlInformacion);
            pnlMenu.Controls.Add(BtnSalir);
            pnlMenu.Controls.Add(BtnReportes);
            pnlMenu.Controls.Add(BtnPrestamos);
            pnlMenu.Controls.Add(BtnEditoriales);
            pnlMenu.Controls.Add(BtnAutores);
            pnlMenu.Controls.Add(BtnUsuarios);
            pnlMenu.Controls.Add(BtnLibros);
            pnlMenu.Controls.Add(BtnInicio);
            pnlMenu.Controls.Add(PnlLogo);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(260, 611);
            pnlMenu.TabIndex = 0;
            // 
            // pnlInformacion
            // 
            pnlInformacion.BackColor = Color.WhiteSmoke;
            pnlInformacion.BorderStyle = BorderStyle.FixedSingle;
            pnlInformacion.Controls.Add(lblInfoTitulo);
            pnlInformacion.Controls.Add(lblInfoAcademica);
            pnlInformacion.Controls.Add(lblInfoAsignatura);
            pnlInformacion.Controls.Add(lblInfoPrograma);
            pnlInformacion.Controls.Add(picBirrete);
            pnlInformacion.Controls.Add(lblInfoAutor);
            pnlInformacion.Controls.Add(lblInfoAnio);
            pnlInformacion.FlowDirection = FlowDirection.TopDown;
            pnlInformacion.Location = new Point(12, 341);
            pnlInformacion.Name = "pnlInformacion";
            pnlInformacion.Size = new Size(240, 240);
            pnlInformacion.TabIndex = 9;
            pnlInformacion.WrapContents = false;
            // 
            // lblInfoTitulo
            // 
            lblInfoTitulo.AutoSize = true;
            lblInfoTitulo.BackColor = Color.Transparent;
            lblInfoTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInfoTitulo.ForeColor = Color.OliveDrab;
            lblInfoTitulo.Location = new Point(30, 3);
            lblInfoTitulo.Margin = new Padding(30, 3, 3, 3);
            lblInfoTitulo.Name = "lblInfoTitulo";
            lblInfoTitulo.Size = new Size(125, 21);
            lblInfoTitulo.TabIndex = 0;
            lblInfoTitulo.Text = "ACA BIBLIOTECA";
            lblInfoTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblInfoAcademica
            // 
            lblInfoAcademica.AutoSize = true;
            lblInfoAcademica.BackColor = Color.Transparent;
            lblInfoAcademica.ForeColor = Color.DimGray;
            lblInfoAcademica.Location = new Point(30, 30);
            lblInfoAcademica.Margin = new Padding(30, 3, 3, 3);
            lblInfoAcademica.Name = "lblInfoAcademica";
            lblInfoAcademica.Size = new Size(143, 15);
            lblInfoAcademica.TabIndex = 1;
            lblInfoAcademica.Text = "Proyecto académico CUN";
            lblInfoAcademica.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblInfoAsignatura
            // 
            lblInfoAsignatura.AutoSize = true;
            lblInfoAsignatura.BackColor = Color.Transparent;
            lblInfoAsignatura.ForeColor = Color.DimGray;
            lblInfoAsignatura.Location = new Point(30, 56);
            lblInfoAsignatura.Margin = new Padding(30, 8, 3, 3);
            lblInfoAsignatura.Name = "lblInfoAsignatura";
            lblInfoAsignatura.Size = new Size(136, 15);
            lblInfoAsignatura.TabIndex = 2;
            lblInfoAsignatura.Text = "Programación Avanzada";
            // 
            // lblInfoPrograma
            // 
            lblInfoPrograma.AutoSize = true;
            lblInfoPrograma.BackColor = Color.Transparent;
            lblInfoPrograma.ForeColor = Color.DimGray;
            lblInfoPrograma.Location = new Point(30, 77);
            lblInfoPrograma.Margin = new Padding(30, 3, 3, 3);
            lblInfoPrograma.Name = "lblInfoPrograma";
            lblInfoPrograma.Size = new Size(124, 15);
            lblInfoPrograma.TabIndex = 3;
            lblInfoPrograma.Text = "Ingeniería de Sistemas";
            // 
            // lblInfoAutor
            // 
            lblInfoAutor.AutoSize = true;
            lblInfoAutor.BackColor = Color.Transparent;
            lblInfoAutor.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInfoAutor.ForeColor = Color.DimGray;
            lblInfoAutor.Location = new Point(15, 181);
            lblInfoAutor.Margin = new Padding(15, 18, 3, 3);
            lblInfoAutor.Name = "lblInfoAutor";
            lblInfoAutor.Size = new Size(202, 13);
            lblInfoAutor.TabIndex = 4;
            lblInfoAutor.Text = "Desarrollado por: César Albino Vargas";
            // 
            // lblInfoAnio
            // 
            lblInfoAnio.AutoSize = true;
            lblInfoAnio.BackColor = Color.Transparent;
            lblInfoAnio.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInfoAnio.ForeColor = Color.DimGray;
            lblInfoAnio.Location = new Point(100, 200);
            lblInfoAnio.Margin = new Padding(100, 3, 3, 3);
            lblInfoAnio.Name = "lblInfoAnio";
            lblInfoAnio.Size = new Size(31, 13);
            lblInfoAnio.TabIndex = 5;
            lblInfoAnio.Text = "2026";
            // 
            // picBirrete
            // 
            picBirrete.BackColor = Color.WhiteSmoke;
            picBirrete.ForeColor = Color.OliveDrab;
            picBirrete.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
            picBirrete.IconColor = Color.OliveDrab;
            picBirrete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picBirrete.IconSize = 55;
            picBirrete.Location = new Point(90, 105);
            picBirrete.Margin = new Padding(90, 10, 3, 3);
            picBirrete.Name = "picBirrete";
            picBirrete.Size = new Size(60, 55);
            picBirrete.SizeMode = PictureBoxSizeMode.CenterImage;
            picBirrete.TabIndex = 6;
            picBirrete.TabStop = false;
            // 
            // BtnSalir
            // 
            BtnSalir.BackColor = Color.Transparent;
            BtnSalir.Cursor = Cursors.Hand;
            BtnSalir.Dock = DockStyle.Top;
            BtnSalir.FlatStyle = FlatStyle.Flat;
            BtnSalir.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            BtnSalir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSalir.IconChar = FontAwesome.Sharp.IconChar.Close;
            BtnSalir.IconColor = Color.Black;
            BtnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnSalir.IconSize = 19;
            BtnSalir.Location = new Point(0, 296);
            BtnSalir.Margin = new Padding(10, 0, 10, 0);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(260, 31);
            BtnSalir.TabIndex = 8;
            BtnSalir.Text = "SALIR";
            BtnSalir.TextAlign = ContentAlignment.MiddleLeft;
            BtnSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnSalir.UseVisualStyleBackColor = false;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // BtnReportes
            // 
            BtnReportes.BackColor = Color.Transparent;
            BtnReportes.Dock = DockStyle.Top;
            BtnReportes.FlatStyle = FlatStyle.Flat;
            BtnReportes.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            BtnReportes.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnReportes.IconChar = FontAwesome.Sharp.IconChar.BookAtlas;
            BtnReportes.IconColor = Color.Black;
            BtnReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnReportes.IconSize = 19;
            BtnReportes.Location = new Point(0, 268);
            BtnReportes.Margin = new Padding(10, 0, 10, 0);
            BtnReportes.Name = "BtnReportes";
            BtnReportes.Size = new Size(260, 28);
            BtnReportes.TabIndex = 7;
            BtnReportes.Text = "REPORTES";
            BtnReportes.TextAlign = ContentAlignment.MiddleLeft;
            BtnReportes.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnReportes.UseVisualStyleBackColor = false;
            BtnReportes.Click += BtnReportes_Click;
            // 
            // BtnPrestamos
            // 
            BtnPrestamos.BackColor = Color.Transparent;
            BtnPrestamos.Dock = DockStyle.Top;
            BtnPrestamos.FlatStyle = FlatStyle.Flat;
            BtnPrestamos.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            BtnPrestamos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPrestamos.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            BtnPrestamos.IconColor = Color.Black;
            BtnPrestamos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnPrestamos.IconSize = 19;
            BtnPrestamos.Location = new Point(0, 240);
            BtnPrestamos.Margin = new Padding(10, 0, 10, 0);
            BtnPrestamos.Name = "BtnPrestamos";
            BtnPrestamos.Size = new Size(260, 28);
            BtnPrestamos.TabIndex = 6;
            BtnPrestamos.Text = "PRESTAMOS";
            BtnPrestamos.TextAlign = ContentAlignment.MiddleLeft;
            BtnPrestamos.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnPrestamos.UseVisualStyleBackColor = false;
            BtnPrestamos.Click += BtnPrestamos_Click;
            // 
            // BtnEditoriales
            // 
            BtnEditoriales.BackColor = Color.Transparent;
            BtnEditoriales.Dock = DockStyle.Top;
            BtnEditoriales.FlatStyle = FlatStyle.Flat;
            BtnEditoriales.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            BtnEditoriales.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEditoriales.IconChar = FontAwesome.Sharp.IconChar.Bookmark;
            BtnEditoriales.IconColor = Color.Black;
            BtnEditoriales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnEditoriales.IconSize = 19;
            BtnEditoriales.Location = new Point(0, 212);
            BtnEditoriales.Margin = new Padding(10, 0, 10, 0);
            BtnEditoriales.Name = "BtnEditoriales";
            BtnEditoriales.Size = new Size(260, 28);
            BtnEditoriales.TabIndex = 5;
            BtnEditoriales.Text = "EDITORIALES";
            BtnEditoriales.TextAlign = ContentAlignment.MiddleLeft;
            BtnEditoriales.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnEditoriales.UseVisualStyleBackColor = false;
            BtnEditoriales.Click += BtnEditoriales_Click;
            // 
            // BtnAutores
            // 
            BtnAutores.BackColor = Color.Transparent;
            BtnAutores.Dock = DockStyle.Top;
            BtnAutores.FlatStyle = FlatStyle.Flat;
            BtnAutores.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            BtnAutores.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAutores.IconChar = FontAwesome.Sharp.IconChar.BookReader;
            BtnAutores.IconColor = Color.Black;
            BtnAutores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnAutores.IconSize = 19;
            BtnAutores.Location = new Point(0, 184);
            BtnAutores.Margin = new Padding(10, 0, 10, 0);
            BtnAutores.Name = "BtnAutores";
            BtnAutores.Size = new Size(260, 28);
            BtnAutores.TabIndex = 4;
            BtnAutores.Text = "AUTORES";
            BtnAutores.TextAlign = ContentAlignment.MiddleLeft;
            BtnAutores.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnAutores.UseVisualStyleBackColor = false;
            BtnAutores.Click += BtnAutores_Click;
            // 
            // BtnUsuarios
            // 
            BtnUsuarios.BackColor = Color.Transparent;
            BtnUsuarios.Dock = DockStyle.Top;
            BtnUsuarios.FlatStyle = FlatStyle.Flat;
            BtnUsuarios.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            BtnUsuarios.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnUsuarios.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            BtnUsuarios.IconColor = Color.Black;
            BtnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnUsuarios.IconSize = 19;
            BtnUsuarios.Location = new Point(0, 156);
            BtnUsuarios.Margin = new Padding(10, 0, 10, 0);
            BtnUsuarios.Name = "BtnUsuarios";
            BtnUsuarios.Size = new Size(260, 28);
            BtnUsuarios.TabIndex = 3;
            BtnUsuarios.Text = "USUARIOS";
            BtnUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            BtnUsuarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnUsuarios.UseVisualStyleBackColor = false;
            BtnUsuarios.Click += BtnUsuarios_Click;
            // 
            // BtnLibros
            // 
            BtnLibros.BackColor = Color.Transparent;
            BtnLibros.Dock = DockStyle.Top;
            BtnLibros.FlatStyle = FlatStyle.Flat;
            BtnLibros.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            BtnLibros.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLibros.IconChar = FontAwesome.Sharp.IconChar.Book;
            BtnLibros.IconColor = Color.Black;
            BtnLibros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnLibros.IconSize = 19;
            BtnLibros.Location = new Point(0, 128);
            BtnLibros.Margin = new Padding(10, 0, 10, 0);
            BtnLibros.Name = "BtnLibros";
            BtnLibros.Size = new Size(260, 28);
            BtnLibros.TabIndex = 2;
            BtnLibros.Text = "LIBROS";
            BtnLibros.TextAlign = ContentAlignment.MiddleLeft;
            BtnLibros.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnLibros.UseVisualStyleBackColor = false;
            BtnLibros.Click += BtnLibros_Click;
            // 
            // BtnInicio
            // 
            BtnInicio.BackColor = Color.Transparent;
            BtnInicio.Dock = DockStyle.Top;
            BtnInicio.FlatStyle = FlatStyle.Flat;
            BtnInicio.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            BtnInicio.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnInicio.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            BtnInicio.IconColor = Color.Black;
            BtnInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnInicio.IconSize = 19;
            BtnInicio.Location = new Point(0, 100);
            BtnInicio.Margin = new Padding(10, 0, 10, 0);
            BtnInicio.Name = "BtnInicio";
            BtnInicio.Size = new Size(260, 28);
            BtnInicio.TabIndex = 1;
            BtnInicio.Text = "INICIO";
            BtnInicio.TextAlign = ContentAlignment.MiddleLeft;
            BtnInicio.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnInicio.UseVisualStyleBackColor = false;
            BtnInicio.Click += BtnInicio_Click;
            // 
            // PnlLogo
            // 
            PnlLogo.BackColor = Color.YellowGreen;
            PnlLogo.Controls.Add(PicLogo);
            PnlLogo.Controls.Add(LblSubtitulo);
            PnlLogo.Controls.Add(lblTitulo);
            PnlLogo.Dock = DockStyle.Top;
            PnlLogo.Location = new Point(0, 0);
            PnlLogo.Name = "PnlLogo";
            PnlLogo.Size = new Size(260, 100);
            PnlLogo.TabIndex = 0;
            PnlLogo.Paint += panel1_Paint;
            // 
            // PicLogo
            // 
            PicLogo.BackColor = Color.Transparent;
            PicLogo.Image = Properties.Resources.Gemini_Generated_Image_1r69mk1r69mk1r69;
            PicLogo.Location = new Point(3, 21);
            PicLogo.Name = "PicLogo";
            PicLogo.Size = new Size(71, 50);
            PicLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            PicLogo.TabIndex = 2;
            PicLogo.TabStop = false;
            PicLogo.Click += PicLogo_Click;
            // 
            // LblSubtitulo
            // 
            LblSubtitulo.AutoSize = true;
            LblSubtitulo.BackColor = Color.Transparent;
            LblSubtitulo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblSubtitulo.ForeColor = SystemColors.ActiveCaptionText;
            LblSubtitulo.Location = new Point(80, 51);
            LblSubtitulo.Name = "LblSubtitulo";
            LblSubtitulo.Size = new Size(143, 20);
            LblSubtitulo.TabIndex = 1;
            LblSubtitulo.Text = "Sistema de Gestión";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Corbel", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.Desktop;
            lblTitulo.Location = new Point(69, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(170, 42);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Biblioteca";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // PnlSuperior
            // 
            PnlSuperior.BackColor = Color.OliveDrab;
            PnlSuperior.Controls.Add(lblTituloPrincipal);
            PnlSuperior.Dock = DockStyle.Top;
            PnlSuperior.Location = new Point(260, 0);
            PnlSuperior.Name = "PnlSuperior";
            PnlSuperior.Size = new Size(1024, 100);
            PnlSuperior.TabIndex = 1;
            // 
            // lblTituloPrincipal
            // 
            lblTituloPrincipal.AutoSize = true;
            lblTituloPrincipal.BackColor = Color.Transparent;
            lblTituloPrincipal.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloPrincipal.ForeColor = Color.White;
            lblTituloPrincipal.Location = new Point(60, 34);
            lblTituloPrincipal.Name = "lblTituloPrincipal";
            lblTituloPrincipal.Size = new Size(590, 45);
            lblTituloPrincipal.TabIndex = 0;
            lblTituloPrincipal.Text = "SISTEMA DE GESTIÓN DE BIBLIOTECA";
            lblTituloPrincipal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PnlEstado
            // 
            PnlEstado.BackColor = Color.OliveDrab;
            PnlEstado.Dock = DockStyle.Bottom;
            PnlEstado.Location = new Point(260, 581);
            PnlEstado.Name = "PnlEstado";
            PnlEstado.Size = new Size(1024, 30);
            PnlEstado.TabIndex = 2;
            // 
            // PnlContenido
            // 
            PnlContenido.Dock = DockStyle.Fill;
            PnlContenido.ForeColor = Color.Black;
            PnlContenido.Location = new Point(260, 100);
            PnlContenido.Name = "PnlContenido";
            PnlContenido.Size = new Size(1024, 481);
            PnlContenido.TabIndex = 3;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 611);
            Controls.Add(PnlContenido);
            Controls.Add(PnlEstado);
            Controls.Add(PnlSuperior);
            Controls.Add(pnlMenu);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Gestion de Biblioteca";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            pnlMenu.ResumeLayout(false);
            pnlInformacion.ResumeLayout(false);
            pnlInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBirrete).EndInit();
            PnlLogo.ResumeLayout(false);
            PnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicLogo).EndInit();
            PnlSuperior.ResumeLayout(false);
            PnlSuperior.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Panel PnlSuperior;
        private Panel PnlEstado;
        private Panel PnlContenido;
        private Panel PnlLogo;
        private Label lblTitulo;
        private PictureBox PicLogo;
        private Label LblSubtitulo;
        private FontAwesome.Sharp.IconButton BtnInicio;
        private FontAwesome.Sharp.IconButton BtnUsuarios;
        private FontAwesome.Sharp.IconButton BtnLibros;
        private FontAwesome.Sharp.IconButton BtnPrestamos;
        private FontAwesome.Sharp.IconButton BtnEditoriales;
        private FontAwesome.Sharp.IconButton BtnAutores;
        private FontAwesome.Sharp.IconButton BtnSalir;
        private FontAwesome.Sharp.IconButton BtnReportes;
        private Label lblTituloPrincipal;
        private FlowLayoutPanel pnlInformacion;
        private Label lblInfoTitulo;
        private Label lblInfoAcademica;
        private Label lblInfoAsignatura;
        private Label lblInfoPrograma;
        private Label lblInfoAutor;
        private Label lblInfoAnio;
        private FontAwesome.Sharp.IconPictureBox picBirrete;
    }
}
