namespace RecetaMedica
{
    partial class frmReceta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReceta));
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.cmbPaciente = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMedico = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtExpediente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.grbMedicamentos = new System.Windows.Forms.GroupBox();
            this.nupCantidad3 = new System.Windows.Forms.NumericUpDown();
            this.nupCantidad2 = new System.Windows.Forms.NumericUpDown();
            this.nupCantidad1 = new System.Windows.Forms.NumericUpDown();
            this.cmbMedicamento2 = new System.Windows.Forms.ComboBox();
            this.cmbMedicamento3 = new System.Windows.Forms.ComboBox();
            this.cmbMedicamento1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIndicaciones = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ttMessages = new System.Windows.Forms.ToolTip(this.components);
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.grbDatos.SuspendLayout();
            this.grbMedicamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantidad3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantidad2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantidad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDatos
            // 
            this.grbDatos.Controls.Add(this.pictureBox2);
            this.grbDatos.Controls.Add(this.pictureBox1);
            this.grbDatos.Controls.Add(this.cmbPaciente);
            this.grbDatos.Controls.Add(this.label11);
            this.grbDatos.Controls.Add(this.dtpFecha);
            this.grbDatos.Controls.Add(this.label5);
            this.grbDatos.Controls.Add(this.label2);
            this.grbDatos.Controls.Add(this.txtMedico);
            this.grbDatos.Controls.Add(this.label3);
            this.grbDatos.Controls.Add(this.txtExpediente);
            this.grbDatos.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatos.ForeColor = System.Drawing.Color.White;
            this.grbDatos.Location = new System.Drawing.Point(12, 80);
            this.grbDatos.Margin = new System.Windows.Forms.Padding(4);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Padding = new System.Windows.Forms.Padding(4);
            this.grbDatos.Size = new System.Drawing.Size(1099, 169);
            this.grbDatos.TabIndex = 14;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "DATOS";
            this.grbDatos.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbPaciente
            // 
            this.cmbPaciente.Enabled = false;
            this.cmbPaciente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaciente.FormattingEnabled = true;
            this.cmbPaciente.Location = new System.Drawing.Point(157, 92);
            this.cmbPaciente.Name = "cmbPaciente";
            this.cmbPaciente.Size = new System.Drawing.Size(521, 26);
            this.cmbPaciente.TabIndex = 12;
            this.cmbPaciente.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 100);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 18);
            this.label11.TabIndex = 11;
            this.label11.Text = "Paciente:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(157, 124);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(239, 26);
            this.dtpFecha.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 133);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Medico:";
            // 
            // txtMedico
            // 
            this.txtMedico.Enabled = false;
            this.txtMedico.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedico.Location = new System.Drawing.Point(157, 26);
            this.txtMedico.Margin = new System.Windows.Forms.Padding(4);
            this.txtMedico.Name = "txtMedico";
            this.txtMedico.Size = new System.Drawing.Size(521, 26);
            this.txtMedico.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Expediente:";
            // 
            // txtExpediente
            // 
            this.txtExpediente.Enabled = false;
            this.txtExpediente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpediente.Location = new System.Drawing.Point(157, 59);
            this.txtExpediente.Margin = new System.Windows.Forms.Padding(4);
            this.txtExpediente.Name = "txtExpediente";
            this.txtExpediente.Size = new System.Drawing.Size(313, 26);
            this.txtExpediente.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 76);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Medicamento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(368, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 27);
            this.label1.TabIndex = 12;
            this.label1.Text = "INGRESO DE RECETA MEDICA";
            // 
            // printDocument1
            // 
            this.printDocument1.DocumentName = " ";
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // grbMedicamentos
            // 
            this.grbMedicamentos.Controls.Add(this.pictureBox5);
            this.grbMedicamentos.Controls.Add(this.pictureBox4);
            this.grbMedicamentos.Controls.Add(this.pictureBox3);
            this.grbMedicamentos.Controls.Add(this.label12);
            this.grbMedicamentos.Controls.Add(this.txtIndicaciones);
            this.grbMedicamentos.Controls.Add(this.btnGuardar);
            this.grbMedicamentos.Controls.Add(this.nupCantidad3);
            this.grbMedicamentos.Controls.Add(this.nupCantidad2);
            this.grbMedicamentos.Controls.Add(this.btnNuevo);
            this.grbMedicamentos.Controls.Add(this.nupCantidad1);
            this.grbMedicamentos.Controls.Add(this.btnImprimir);
            this.grbMedicamentos.Controls.Add(this.cmbMedicamento2);
            this.grbMedicamentos.Controls.Add(this.cmbMedicamento3);
            this.grbMedicamentos.Controls.Add(this.cmbMedicamento1);
            this.grbMedicamentos.Controls.Add(this.label9);
            this.grbMedicamentos.Controls.Add(this.label10);
            this.grbMedicamentos.Controls.Add(this.label7);
            this.grbMedicamentos.Controls.Add(this.label8);
            this.grbMedicamentos.Controls.Add(this.label4);
            this.grbMedicamentos.Controls.Add(this.label6);
            this.grbMedicamentos.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbMedicamentos.ForeColor = System.Drawing.Color.White;
            this.grbMedicamentos.Location = new System.Drawing.Point(12, 256);
            this.grbMedicamentos.Name = "grbMedicamentos";
            this.grbMedicamentos.Size = new System.Drawing.Size(1099, 360);
            this.grbMedicamentos.TabIndex = 20;
            this.grbMedicamentos.TabStop = false;
            this.grbMedicamentos.Text = "MEDICAMENTOS";
            // 
            // nupCantidad3
            // 
            this.nupCantidad3.Enabled = false;
            this.nupCantidad3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupCantidad3.Location = new System.Drawing.Point(145, 200);
            this.nupCantidad3.Name = "nupCantidad3";
            this.nupCantidad3.Size = new System.Drawing.Size(120, 26);
            this.nupCantidad3.TabIndex = 21;
            // 
            // nupCantidad2
            // 
            this.nupCantidad2.Enabled = false;
            this.nupCantidad2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupCantidad2.Location = new System.Drawing.Point(145, 134);
            this.nupCantidad2.Name = "nupCantidad2";
            this.nupCantidad2.Size = new System.Drawing.Size(120, 26);
            this.nupCantidad2.TabIndex = 20;
            // 
            // nupCantidad1
            // 
            this.nupCantidad1.Enabled = false;
            this.nupCantidad1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupCantidad1.Location = new System.Drawing.Point(145, 68);
            this.nupCantidad1.Name = "nupCantidad1";
            this.nupCantidad1.Size = new System.Drawing.Size(120, 26);
            this.nupCantidad1.TabIndex = 19;
            // 
            // cmbMedicamento2
            // 
            this.cmbMedicamento2.Enabled = false;
            this.cmbMedicamento2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMedicamento2.FormattingEnabled = true;
            this.cmbMedicamento2.Location = new System.Drawing.Point(145, 101);
            this.cmbMedicamento2.Name = "cmbMedicamento2";
            this.cmbMedicamento2.Size = new System.Drawing.Size(266, 26);
            this.cmbMedicamento2.TabIndex = 18;
            this.cmbMedicamento2.SelectedIndexChanged += new System.EventHandler(this.cmbMedicamento2_SelectedIndexChanged_1);
            // 
            // cmbMedicamento3
            // 
            this.cmbMedicamento3.Enabled = false;
            this.cmbMedicamento3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMedicamento3.FormattingEnabled = true;
            this.cmbMedicamento3.Location = new System.Drawing.Point(145, 167);
            this.cmbMedicamento3.Name = "cmbMedicamento3";
            this.cmbMedicamento3.Size = new System.Drawing.Size(266, 26);
            this.cmbMedicamento3.TabIndex = 17;
            this.cmbMedicamento3.SelectedIndexChanged += new System.EventHandler(this.cmbMedicamento3_SelectedIndexChanged_1);
            // 
            // cmbMedicamento1
            // 
            this.cmbMedicamento1.Enabled = false;
            this.cmbMedicamento1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMedicamento1.FormattingEnabled = true;
            this.cmbMedicamento1.Location = new System.Drawing.Point(145, 37);
            this.cmbMedicamento1.Name = "cmbMedicamento1";
            this.cmbMedicamento1.Size = new System.Drawing.Size(266, 26);
            this.cmbMedicamento1.TabIndex = 13;
            this.cmbMedicamento1.SelectedIndexChanged += new System.EventHandler(this.cmbMedicamento1_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 175);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 18);
            this.label9.TabIndex = 13;
            this.label9.Text = "Medicamento:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 208);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 18);
            this.label10.TabIndex = 15;
            this.label10.Text = "Cantidad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 109);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "Medicamento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 142);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 18);
            this.label8.TabIndex = 11;
            this.label8.Text = "Cantidad:";
            // 
            // txtIndicaciones
            // 
            this.txtIndicaciones.Enabled = false;
            this.txtIndicaciones.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIndicaciones.Location = new System.Drawing.Point(473, 43);
            this.txtIndicaciones.Multiline = true;
            this.txtIndicaciones.Name = "txtIndicaciones";
            this.txtIndicaciones.Size = new System.Drawing.Size(612, 215);
            this.txtIndicaciones.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(470, 17);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(342, 18);
            this.label12.TabIndex = 23;
            this.label12.Text = "Indicaciones que debe de seguir el paciente";
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = global::FarmaciaDigital.Properties.Resources.Guardar;
            this.btnGuardar.Location = new System.Drawing.Point(491, 273);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(192, 76);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Image = global::FarmaciaDigital.Properties.Resources.nuevo__2_;
            this.btnNuevo.Location = new System.Drawing.Point(7, 273);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(192, 76);
            this.btnNuevo.TabIndex = 17;
            this.btnNuevo.Text = "Agregar nueva receta";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Image = global::FarmaciaDigital.Properties.Resources.imprimir;
            this.btnImprimir.Location = new System.Drawing.Point(893, 273);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(192, 76);
            this.btnImprimir.TabIndex = 16;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Image = global::FarmaciaDigital.Properties.Resources.home1;
            this.btnMenu.Location = new System.Drawing.Point(12, 13);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(123, 59);
            this.btnMenu.TabIndex = 18;
            this.btnMenu.Text = "Menu";
            this.btnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ttMessages.SetToolTip(this.btnMenu, "Regresar al menu");
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FarmaciaDigital.Properties.Resources.medico;
            this.pictureBox2.Location = new System.Drawing.Point(685, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FarmaciaDigital.Properties.Resources.paciente;
            this.pictureBox1.Location = new System.Drawing.Point(685, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::FarmaciaDigital.Properties.Resources.medical_05_icon_icons_com_73942;
            this.pictureBox3.Location = new System.Drawing.Point(417, 37);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::FarmaciaDigital.Properties.Resources.medical_05_icon_icons_com_73942;
            this.pictureBox4.Location = new System.Drawing.Point(417, 167);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(26, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::FarmaciaDigital.Properties.Resources.medical_05_icon_icons_com_73942;
            this.pictureBox5.Location = new System.Drawing.Point(417, 101);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(26, 26);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 25;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::FarmaciaDigital.Properties.Resources.logoSalud;
            this.pictureBox6.Location = new System.Drawing.Point(705, 13);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(50, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 21;
            this.pictureBox6.TabStop = false;
            // 
            // frmReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1122, 627);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.grbMedicamentos);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.grbDatos);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmReceta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FARMACIA DIGITAL - ASIGNAR RECETA";
            this.Load += new System.EventHandler(this.MostrarReceta_Load);
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            this.grbMedicamentos.ResumeLayout(false);
            this.grbMedicamentos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantidad3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantidad2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantidad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMedico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtExpediente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label5;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.GroupBox grbMedicamentos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbPaciente;
        private System.Windows.Forms.ComboBox cmbMedicamento3;
        private System.Windows.Forms.ComboBox cmbMedicamento1;
        private System.Windows.Forms.ComboBox cmbMedicamento2;
        private System.Windows.Forms.NumericUpDown nupCantidad3;
        private System.Windows.Forms.NumericUpDown nupCantidad2;
        private System.Windows.Forms.NumericUpDown nupCantidad1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtIndicaciones;
        private System.Windows.Forms.ToolTip ttMessages;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}