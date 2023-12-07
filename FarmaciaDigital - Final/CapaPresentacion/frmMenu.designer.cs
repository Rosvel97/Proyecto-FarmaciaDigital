namespace FarmaciaDigital
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ttMessages = new System.Windows.Forms.ToolTip(this.components);
            this.fechaHora = new System.Windows.Forms.Timer(this.components);
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbHora = new System.Windows.Forms.Label();
            this.grbxFechaHora = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnSalirSesion = new System.Windows.Forms.Button();
            this.btnRecetaMedica = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnIngresoMedicamentos = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnIngresoDatosPacientes = new System.Windows.Forms.Button();
            this.btnMostrarPacientes = new System.Windows.Forms.Button();
            this.btnQuienesSomos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.grbxFechaHora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRecetaMedica);
            this.groupBox1.Controls.Add(this.btnAyuda);
            this.groupBox1.Controls.Add(this.btnIngresoMedicamentos);
            this.groupBox1.Controls.Add(this.btnInventario);
            this.groupBox1.Controls.Add(this.btnIngresoDatosPacientes);
            this.groupBox1.Controls.Add(this.btnMostrarPacientes);
            this.groupBox1.Controls.Add(this.btnQuienesSomos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 485);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MENU";
            // 
            // fechaHora
            // 
            this.fechaHora.Enabled = true;
            this.fechaHora.Tick += new System.EventHandler(this.fechaHora_Tick);
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.ForeColor = System.Drawing.Color.White;
            this.lbFecha.Location = new System.Drawing.Point(6, 39);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(55, 20);
            this.lbFecha.TabIndex = 38;
            this.lbFecha.Text = "Fecha";
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.ForeColor = System.Drawing.Color.White;
            this.lbHora.Location = new System.Drawing.Point(6, 19);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(46, 20);
            this.lbHora.TabIndex = 39;
            this.lbHora.Text = "Hora";
            // 
            // grbxFechaHora
            // 
            this.grbxFechaHora.Controls.Add(this.lbFecha);
            this.grbxFechaHora.Controls.Add(this.lbHora);
            this.grbxFechaHora.Location = new System.Drawing.Point(626, 570);
            this.grbxFechaHora.Name = "grbxFechaHora";
            this.grbxFechaHora.Size = new System.Drawing.Size(83, 61);
            this.grbxFechaHora.TabIndex = 8;
            this.grbxFechaHora.TabStop = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // btnSalirSesion
            // 
            this.btnSalirSesion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalirSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSalirSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnSalirSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirSesion.ForeColor = System.Drawing.Color.White;
            this.btnSalirSesion.Image = global::FarmaciaDigital.Properties.Resources.cierre;
            this.btnSalirSesion.Location = new System.Drawing.Point(12, 573);
            this.btnSalirSesion.Name = "btnSalirSesion";
            this.btnSalirSesion.Size = new System.Drawing.Size(155, 56);
            this.btnSalirSesion.TabIndex = 37;
            this.btnSalirSesion.Text = "Cerrar Sesion";
            this.btnSalirSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalirSesion.UseVisualStyleBackColor = true;
            this.btnSalirSesion.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnRecetaMedica
            // 
            this.btnRecetaMedica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRecetaMedica.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRecetaMedica.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRecetaMedica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRecetaMedica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnRecetaMedica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecetaMedica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecetaMedica.ForeColor = System.Drawing.Color.White;
            this.btnRecetaMedica.Image = global::FarmaciaDigital.Properties.Resources.receta;
            this.btnRecetaMedica.Location = new System.Drawing.Point(465, 283);
            this.btnRecetaMedica.Name = "btnRecetaMedica";
            this.btnRecetaMedica.Size = new System.Drawing.Size(210, 81);
            this.btnRecetaMedica.TabIndex = 8;
            this.btnRecetaMedica.Text = "Receta médica";
            this.btnRecetaMedica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecetaMedica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRecetaMedica.UseVisualStyleBackColor = false;
            this.btnRecetaMedica.Click += new System.EventHandler(this.btnRecetaMedica_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAyuda.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAyuda.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAyuda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAyuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda.ForeColor = System.Drawing.Color.White;
            this.btnAyuda.Image = global::FarmaciaDigital.Properties.Resources.ayuda;
            this.btnAyuda.Location = new System.Drawing.Point(21, 283);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(210, 81);
            this.btnAyuda.TabIndex = 5;
            this.btnAyuda.Text = "Sugerencias";
            this.btnAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnIngresoMedicamentos
            // 
            this.btnIngresoMedicamentos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIngresoMedicamentos.BackColor = System.Drawing.Color.SteelBlue;
            this.btnIngresoMedicamentos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnIngresoMedicamentos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnIngresoMedicamentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnIngresoMedicamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresoMedicamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresoMedicamentos.ForeColor = System.Drawing.Color.White;
            this.btnIngresoMedicamentos.Image = global::FarmaciaDigital.Properties.Resources.medicamentos;
            this.btnIngresoMedicamentos.Location = new System.Drawing.Point(21, 53);
            this.btnIngresoMedicamentos.Name = "btnIngresoMedicamentos";
            this.btnIngresoMedicamentos.Size = new System.Drawing.Size(210, 81);
            this.btnIngresoMedicamentos.TabIndex = 2;
            this.btnIngresoMedicamentos.Text = "Ingreso de medicamentos";
            this.btnIngresoMedicamentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresoMedicamentos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIngresoMedicamentos.UseVisualStyleBackColor = false;
            this.btnIngresoMedicamentos.Click += new System.EventHandler(this.btnIngresoMedicamentos_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInventario.BackColor = System.Drawing.Color.SteelBlue;
            this.btnInventario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInventario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.Color.White;
            this.btnInventario.Image = global::FarmaciaDigital.Properties.Resources.Inventario;
            this.btnInventario.Location = new System.Drawing.Point(465, 53);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(210, 81);
            this.btnInventario.TabIndex = 4;
            this.btnInventario.Text = "Inventario de medicamentos";
            this.btnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInventario.UseVisualStyleBackColor = false;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnIngresoDatosPacientes
            // 
            this.btnIngresoDatosPacientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIngresoDatosPacientes.BackColor = System.Drawing.Color.SteelBlue;
            this.btnIngresoDatosPacientes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnIngresoDatosPacientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnIngresoDatosPacientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnIngresoDatosPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresoDatosPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresoDatosPacientes.ForeColor = System.Drawing.Color.White;
            this.btnIngresoDatosPacientes.Image = global::FarmaciaDigital.Properties.Resources.Ingreso;
            this.btnIngresoDatosPacientes.Location = new System.Drawing.Point(21, 171);
            this.btnIngresoDatosPacientes.Name = "btnIngresoDatosPacientes";
            this.btnIngresoDatosPacientes.Size = new System.Drawing.Size(210, 81);
            this.btnIngresoDatosPacientes.TabIndex = 3;
            this.btnIngresoDatosPacientes.Text = "Ingreso Datos Pacientes";
            this.btnIngresoDatosPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresoDatosPacientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIngresoDatosPacientes.UseVisualStyleBackColor = false;
            this.btnIngresoDatosPacientes.Click += new System.EventHandler(this.btnIngresoDatosPacientes_Click);
            // 
            // btnMostrarPacientes
            // 
            this.btnMostrarPacientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMostrarPacientes.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMostrarPacientes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMostrarPacientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnMostrarPacientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnMostrarPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarPacientes.ForeColor = System.Drawing.Color.White;
            this.btnMostrarPacientes.Image = global::FarmaciaDigital.Properties.Resources.Registro;
            this.btnMostrarPacientes.Location = new System.Drawing.Point(465, 171);
            this.btnMostrarPacientes.Name = "btnMostrarPacientes";
            this.btnMostrarPacientes.Size = new System.Drawing.Size(210, 79);
            this.btnMostrarPacientes.TabIndex = 6;
            this.btnMostrarPacientes.Text = "Registro de Pacientes";
            this.btnMostrarPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostrarPacientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMostrarPacientes.UseVisualStyleBackColor = false;
            this.btnMostrarPacientes.Click += new System.EventHandler(this.btnMostrarPacientes_Click);
            // 
            // btnQuienesSomos
            // 
            this.btnQuienesSomos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQuienesSomos.BackColor = System.Drawing.Color.SteelBlue;
            this.btnQuienesSomos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnQuienesSomos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnQuienesSomos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnQuienesSomos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuienesSomos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuienesSomos.ForeColor = System.Drawing.Color.White;
            this.btnQuienesSomos.Image = global::FarmaciaDigital.Properties.Resources.QuienesSomos;
            this.btnQuienesSomos.Location = new System.Drawing.Point(243, 384);
            this.btnQuienesSomos.Name = "btnQuienesSomos";
            this.btnQuienesSomos.Size = new System.Drawing.Size(210, 81);
            this.btnQuienesSomos.TabIndex = 7;
            this.btnQuienesSomos.Text = "Quienes somos";
            this.btnQuienesSomos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuienesSomos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuienesSomos.UseVisualStyleBackColor = false;
            this.btnQuienesSomos.Click += new System.EventHandler(this.btnQuienesSomos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(722, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(721, 643);
            this.Controls.Add(this.grbxFechaHora);
            this.Controls.Add(this.btnSalirSesion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FARMACIA DIGITAL";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.grbxFechaHora.ResumeLayout(false);
            this.grbxFechaHora.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnIngresoMedicamentos;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnMostrarPacientes;
        private System.Windows.Forms.Button btnIngresoDatosPacientes;
        private System.Windows.Forms.Button btnQuienesSomos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalirSesion;
        private System.Windows.Forms.ToolTip ttMessages;
        private System.Windows.Forms.Timer fechaHora;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.GroupBox grbxFechaHora;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnRecetaMedica;
    }
}