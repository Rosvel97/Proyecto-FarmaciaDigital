namespace FarmaciaDigital
{
    partial class CuadroDialogo
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
            this.components = new System.ComponentModel.Container();
            this.lblTituloAlerta = new System.Windows.Forms.Label();
            this.lblDescripcionAlerta = new System.Windows.Forms.Label();
            this.LinAnimacion = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picAlerta = new System.Windows.Forms.PictureBox();
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.btnExepcion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlerta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloAlerta
            // 
            this.lblTituloAlerta.AutoSize = true;
            this.lblTituloAlerta.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAlerta.Location = new System.Drawing.Point(105, 49);
            this.lblTituloAlerta.Name = "lblTituloAlerta";
            this.lblTituloAlerta.Size = new System.Drawing.Size(113, 23);
            this.lblTituloAlerta.TabIndex = 1;
            this.lblTituloAlerta.Text = "TituloAlerta";
            // 
            // lblDescripcionAlerta
            // 
            this.lblDescripcionAlerta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescripcionAlerta.AutoEllipsis = true;
            this.lblDescripcionAlerta.AutoSize = true;
            this.lblDescripcionAlerta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionAlerta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDescripcionAlerta.Location = new System.Drawing.Point(105, 81);
            this.lblDescripcionAlerta.Name = "lblDescripcionAlerta";
            this.lblDescripcionAlerta.Size = new System.Drawing.Size(121, 17);
            this.lblDescripcionAlerta.TabIndex = 2;
            this.lblDescripcionAlerta.Text = "DescripcionAlerta";
            // 
            // LinAnimacion
            // 
            this.LinAnimacion.BackColor = System.Drawing.Color.Black;
            this.LinAnimacion.Location = new System.Drawing.Point(-4, 150);
            this.LinAnimacion.Name = "LinAnimacion";
            this.LinAnimacion.Size = new System.Drawing.Size(0, 15);
            this.LinAnimacion.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FarmaciaDigital.Properties.Resources.Cerrar;
            this.pictureBox1.Location = new System.Drawing.Point(378, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picAlerta
            // 
            this.picAlerta.Location = new System.Drawing.Point(12, 35);
            this.picAlerta.Name = "picAlerta";
            this.picAlerta.Size = new System.Drawing.Size(90, 78);
            this.picAlerta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAlerta.TabIndex = 0;
            this.picAlerta.TabStop = false;
            // 
            // Temporizador
            // 
            this.Temporizador.Interval = 10;
            this.Temporizador.Tick += new System.EventHandler(this.Temporizador_Tick_1);
            // 
            // btnExepcion
            // 
            this.btnExepcion.BackColor = System.Drawing.Color.LightPink;
            this.btnExepcion.FlatAppearance.BorderSize = 0;
            this.btnExepcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExepcion.ForeColor = System.Drawing.Color.Maroon;
            this.btnExepcion.Location = new System.Drawing.Point(316, 134);
            this.btnExepcion.Margin = new System.Windows.Forms.Padding(0);
            this.btnExepcion.Name = "btnExepcion";
            this.btnExepcion.Size = new System.Drawing.Size(85, 22);
            this.btnExepcion.TabIndex = 6;
            this.btnExepcion.Text = "Mas detalles";
            this.btnExepcion.UseVisualStyleBackColor = false;
            this.btnExepcion.Visible = false;
            // 
            // CuadroDialogo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(402, 158);
            this.Controls.Add(this.btnExepcion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LinAnimacion);
            this.Controls.Add(this.lblDescripcionAlerta);
            this.Controls.Add(this.lblTituloAlerta);
            this.Controls.Add(this.picAlerta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CuadroDialogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CuadroDialogo";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CuadroDialogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlerta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picAlerta;
        private System.Windows.Forms.Label lblTituloAlerta;
        private System.Windows.Forms.Label lblDescripcionAlerta;
        private System.Windows.Forms.Panel LinAnimacion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer Temporizador;
        public System.Windows.Forms.Button btnExepcion;
    }
}