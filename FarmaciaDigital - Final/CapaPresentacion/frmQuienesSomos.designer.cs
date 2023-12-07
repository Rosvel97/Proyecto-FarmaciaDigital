
namespace QuienesSomos
{
    partial class frmQuienesSomos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuienesSomos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMasInfo = new System.Windows.Forms.Button();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMenu);
            this.groupBox1.Controls.Add(this.lbDescripcion);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnMasInfo);
            this.groupBox1.Font = new System.Drawing.Font("Museo Sans 500", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 476);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Museo Sans 500", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Image = global::FarmaciaDigital.Properties.Resources.home1;
            this.btnMenu.Location = new System.Drawing.Point(6, 17);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(130, 74);
            this.btnMenu.TabIndex = 37;
            this.btnMenu.Text = "Menú";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FarmaciaDigital.Properties.Resources.LOGOUTEC;
            this.pictureBox1.Location = new System.Drawing.Point(492, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnMasInfo
            // 
            this.btnMasInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btnMasInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMasInfo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMasInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnMasInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnMasInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasInfo.Font = new System.Drawing.Font("Museo Sans 500", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMasInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMasInfo.Image = global::FarmaciaDigital.Properties.Resources.info;
            this.btnMasInfo.Location = new System.Drawing.Point(8, 392);
            this.btnMasInfo.Margin = new System.Windows.Forms.Padding(0);
            this.btnMasInfo.Name = "btnMasInfo";
            this.btnMasInfo.Size = new System.Drawing.Size(681, 70);
            this.btnMasInfo.TabIndex = 4;
            this.btnMasInfo.Text = "Más información...";
            this.btnMasInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMasInfo.UseVisualStyleBackColor = false;
            this.btnMasInfo.Click += new System.EventHandler(this.btnMasInfo_Click);
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lbDescripcion.CausesValidation = false;
            this.lbDescripcion.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescripcion.ForeColor = System.Drawing.Color.Transparent;
            this.lbDescripcion.Location = new System.Drawing.Point(7, 78);
            this.lbDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(500, 314);
            this.lbDescripcion.TabIndex = 3;
            this.lbDescripcion.Text = resources.GetString("lbDescripcion.Text");
            this.lbDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmQuienesSomos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(721, 500);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmQuienesSomos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FARMACIA DIGITAL - ¿QUIENES SOMOS?";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMasInfo;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

