namespace AcaBiblioteca
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            pnlBienvenida = new Panel();
            picBiblioteca = new PictureBox();
            lblDescripcion = new Label();
            lblBienvenida = new Label();
            pnlBienvenida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBiblioteca).BeginInit();
            SuspendLayout();
            // 
            // pnlBienvenida
            // 
            pnlBienvenida.BackColor = Color.White;
            pnlBienvenida.Controls.Add(picBiblioteca);
            pnlBienvenida.Controls.Add(lblDescripcion);
            pnlBienvenida.Controls.Add(lblBienvenida);
            pnlBienvenida.Dock = DockStyle.Fill;
            pnlBienvenida.Location = new Point(0, 0);
            pnlBienvenida.Name = "pnlBienvenida";
            pnlBienvenida.Size = new Size(900, 600);
            pnlBienvenida.TabIndex = 0;
            // 
            // picBiblioteca
            // 
            picBiblioteca.Anchor = AnchorStyles.Top;
            picBiblioteca.BackColor = Color.Transparent;
            picBiblioteca.Image = (Image)resources.GetObject("picBiblioteca.Image");
            picBiblioteca.Location = new Point(216, 234);
            picBiblioteca.Name = "picBiblioteca";
            picBiblioteca.Size = new Size(360, 220);
            picBiblioteca.SizeMode = PictureBoxSizeMode.Zoom;
            picBiblioteca.TabIndex = 2;
            picBiblioteca.TabStop = false;
            // 
            // lblDescripcion
            // 
            lblDescripcion.BackColor = Color.Transparent;
            lblDescripcion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescripcion.ForeColor = Color.DimGray;
            lblDescripcion.Location = new Point(225, 115);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(650, 85);
            lblDescripcion.TabIndex = 1;
            lblDescripcion.Text = resources.GetString("lblDescripcion.Text");
            lblDescripcion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.BackColor = Color.Transparent;
            lblBienvenida.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBienvenida.ForeColor = Color.DarkOliveGreen;
            lblBienvenida.Location = new Point(320, 45);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(434, 40);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "BIENVENIDO A ACA BIBLIOTECA";
            lblBienvenida.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 600);
            Controls.Add(pnlBienvenida);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmInicio";
            Text = "FrmInicio";
            pnlBienvenida.ResumeLayout(false);
            pnlBienvenida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBiblioteca).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBienvenida;
        private Label lblBienvenida;
        private Label lblDescripcion;
        private PictureBox picBiblioteca;
    }
}