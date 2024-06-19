namespace discosApp
{
    partial class frmAltaDisco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAltaDisco));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.nudCanciones = new System.Windows.Forms.NumericUpDown();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEstilo = new System.Windows.Forms.Label();
            this.lblEdicion = new System.Windows.Forms.Label();
            this.cbEstilo = new System.Windows.Forms.ComboBox();
            this.cbEdicion = new System.Windows.Forms.ComboBox();
            this.pbImagenAlta = new System.Windows.Forms.PictureBox();
            this.btnAgregarAlta = new System.Windows.Forms.Button();
            this.btnCancelarAlta = new System.Windows.Forms.Button();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCanciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenAlta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(29, 39);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(40, 16);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo";
            // 
            // txtTitulo
            // 
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(110, 35);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(145, 24);
            this.txtTitulo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Canciones";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(29, 117);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(45, 16);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha";
            // 
            // nudCanciones
            // 
            this.nudCanciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCanciones.Location = new System.Drawing.Point(110, 150);
            this.nudCanciones.Name = "nudCanciones";
            this.nudCanciones.Size = new System.Drawing.Size(65, 24);
            this.nudCanciones.TabIndex = 6;
            this.nudCanciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "dd/MM/yy";
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(110, 110);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(145, 24);
            this.dtpFecha.TabIndex = 7;
            // 
            // txtImagen
            // 
            this.txtImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImagen.Location = new System.Drawing.Point(110, 189);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(145, 24);
            this.txtImagen.TabIndex = 9;
            this.txtImagen.Leave += new System.EventHandler(this.txtImagen_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Imagen";
            // 
            // lblEstilo
            // 
            this.lblEstilo.AutoSize = true;
            this.lblEstilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstilo.Location = new System.Drawing.Point(29, 230);
            this.lblEstilo.Name = "lblEstilo";
            this.lblEstilo.Size = new System.Drawing.Size(40, 16);
            this.lblEstilo.TabIndex = 10;
            this.lblEstilo.Text = "Estilo";
            // 
            // lblEdicion
            // 
            this.lblEdicion.AutoSize = true;
            this.lblEdicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdicion.Location = new System.Drawing.Point(29, 269);
            this.lblEdicion.Name = "lblEdicion";
            this.lblEdicion.Size = new System.Drawing.Size(52, 16);
            this.lblEdicion.TabIndex = 11;
            this.lblEdicion.Text = "Edicion";
            // 
            // cbEstilo
            // 
            this.cbEstilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstilo.FormattingEnabled = true;
            this.cbEstilo.Location = new System.Drawing.Point(110, 225);
            this.cbEstilo.Name = "cbEstilo";
            this.cbEstilo.Size = new System.Drawing.Size(145, 26);
            this.cbEstilo.TabIndex = 12;
            // 
            // cbEdicion
            // 
            this.cbEdicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEdicion.FormattingEnabled = true;
            this.cbEdicion.Location = new System.Drawing.Point(110, 264);
            this.cbEdicion.Name = "cbEdicion";
            this.cbEdicion.Size = new System.Drawing.Size(145, 26);
            this.cbEdicion.TabIndex = 13;
            // 
            // pbImagenAlta
            // 
            this.pbImagenAlta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagenAlta.Location = new System.Drawing.Point(318, 52);
            this.pbImagenAlta.Name = "pbImagenAlta";
            this.pbImagenAlta.Size = new System.Drawing.Size(223, 223);
            this.pbImagenAlta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagenAlta.TabIndex = 14;
            this.pbImagenAlta.TabStop = false;
            // 
            // btnAgregarAlta
            // 
            this.btnAgregarAlta.Location = new System.Drawing.Point(34, 317);
            this.btnAgregarAlta.Name = "btnAgregarAlta";
            this.btnAgregarAlta.Size = new System.Drawing.Size(92, 37);
            this.btnAgregarAlta.TabIndex = 15;
            this.btnAgregarAlta.Text = "Agregar";
            this.btnAgregarAlta.UseVisualStyleBackColor = true;
            this.btnAgregarAlta.Click += new System.EventHandler(this.btnAgregarAlta_Click);
            // 
            // btnCancelarAlta
            // 
            this.btnCancelarAlta.Location = new System.Drawing.Point(163, 317);
            this.btnCancelarAlta.Name = "btnCancelarAlta";
            this.btnCancelarAlta.Size = new System.Drawing.Size(92, 37);
            this.btnCancelarAlta.TabIndex = 16;
            this.btnCancelarAlta.Text = "Cancelar";
            this.btnCancelarAlta.UseVisualStyleBackColor = true;
            this.btnCancelarAlta.Click += new System.EventHandler(this.btnCancelarAlta_Click);
            // 
            // txtAutor
            // 
            this.txtAutor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutor.Location = new System.Drawing.Point(110, 74);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(145, 24);
            this.txtAutor.TabIndex = 18;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(29, 78);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(38, 16);
            this.lblAutor.TabIndex = 17;
            this.lblAutor.Text = "Autor";
            // 
            // frmAltaDisco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 369);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.btnCancelarAlta);
            this.Controls.Add(this.btnAgregarAlta);
            this.Controls.Add(this.pbImagenAlta);
            this.Controls.Add(this.cbEdicion);
            this.Controls.Add(this.cbEstilo);
            this.Controls.Add(this.lblEdicion);
            this.Controls.Add(this.lblEstilo);
            this.Controls.Add(this.txtImagen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.nudCanciones);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAltaDisco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Disco";
            this.Load += new System.EventHandler(this.frmAltaDisco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCanciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenAlta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.NumericUpDown nudCanciones;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtImagen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEstilo;
        private System.Windows.Forms.Label lblEdicion;
        private System.Windows.Forms.ComboBox cbEstilo;
        private System.Windows.Forms.ComboBox cbEdicion;
        private System.Windows.Forms.PictureBox pbImagenAlta;
        private System.Windows.Forms.Button btnAgregarAlta;
        private System.Windows.Forms.Button btnCancelarAlta;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label lblAutor;
    }
}