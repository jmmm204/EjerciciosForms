namespace RegistroDeAutos
{
    partial class Form1
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
            this.lblmarca = new System.Windows.Forms.Label();
            this.lblmodelo = new System.Windows.Forms.Label();
            this.lblaño = new System.Windows.Forms.Label();
            this.lblmatricula = new System.Windows.Forms.Label();
            this.lblreparacion = new System.Windows.Forms.Label();
            this.lblseguro = new System.Windows.Forms.Label();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.txtmodelo = new System.Windows.Forms.TextBox();
            this.txtaño = new System.Windows.Forms.TextBox();
            this.txtmatricula = new System.Windows.Forms.TextBox();
            this.cmbreparacion = new System.Windows.Forms.ComboBox();
            this.chksi = new System.Windows.Forms.CheckBox();
            this.chkno = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblmarca
            // 
            this.lblmarca.AutoSize = true;
            this.lblmarca.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmarca.Location = new System.Drawing.Point(29, 46);
            this.lblmarca.Name = "lblmarca";
            this.lblmarca.Size = new System.Drawing.Size(62, 18);
            this.lblmarca.TabIndex = 0;
            this.lblmarca.Text = "Marca:";
            this.lblmarca.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblmodelo
            // 
            this.lblmodelo.AutoSize = true;
            this.lblmodelo.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmodelo.Location = new System.Drawing.Point(29, 91);
            this.lblmodelo.Name = "lblmodelo";
            this.lblmodelo.Size = new System.Drawing.Size(71, 18);
            this.lblmodelo.TabIndex = 1;
            this.lblmodelo.Text = "Modelo:";
            this.lblmodelo.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblaño
            // 
            this.lblaño.AutoSize = true;
            this.lblaño.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaño.Location = new System.Drawing.Point(29, 137);
            this.lblaño.Name = "lblaño";
            this.lblaño.Size = new System.Drawing.Size(44, 18);
            this.lblaño.TabIndex = 2;
            this.lblaño.Text = "Año:";
            this.lblaño.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblmatricula
            // 
            this.lblmatricula.AutoSize = true;
            this.lblmatricula.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmatricula.Location = new System.Drawing.Point(29, 182);
            this.lblmatricula.Name = "lblmatricula";
            this.lblmatricula.Size = new System.Drawing.Size(91, 18);
            this.lblmatricula.TabIndex = 3;
            this.lblmatricula.Text = "Matricula:";
            this.lblmatricula.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblreparacion
            // 
            this.lblreparacion.AutoSize = true;
            this.lblreparacion.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreparacion.Location = new System.Drawing.Point(29, 232);
            this.lblreparacion.Name = "lblreparacion";
            this.lblreparacion.Size = new System.Drawing.Size(168, 18);
            this.lblreparacion.TabIndex = 4;
            this.lblreparacion.Text = "Tipo de Reparacion:";
            this.lblreparacion.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblseguro
            // 
            this.lblseguro.AutoSize = true;
            this.lblseguro.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblseguro.Location = new System.Drawing.Point(29, 282);
            this.lblseguro.Name = "lblseguro";
            this.lblseguro.Size = new System.Drawing.Size(127, 18);
            this.lblseguro.TabIndex = 5;
            this.lblseguro.Text = "¿Tiene seguro?";
            // 
            // btnregistrar
            // 
            this.btnregistrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnregistrar.Location = new System.Drawing.Point(32, 354);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(109, 34);
            this.btnregistrar.TabIndex = 6;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.UseVisualStyleBackColor = true;
            // 
            // btncancelar
            // 
            this.btncancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncancelar.Location = new System.Drawing.Point(185, 354);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(109, 34);
            this.btncancelar.TabIndex = 7;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(148, 47);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(112, 20);
            this.txtmarca.TabIndex = 8;
            // 
            // txtmodelo
            // 
            this.txtmodelo.Location = new System.Drawing.Point(148, 91);
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.Size = new System.Drawing.Size(112, 20);
            this.txtmodelo.TabIndex = 9;
            // 
            // txtaño
            // 
            this.txtaño.Location = new System.Drawing.Point(148, 137);
            this.txtaño.Name = "txtaño";
            this.txtaño.Size = new System.Drawing.Size(112, 20);
            this.txtaño.TabIndex = 10;
            // 
            // txtmatricula
            // 
            this.txtmatricula.Location = new System.Drawing.Point(148, 182);
            this.txtmatricula.Name = "txtmatricula";
            this.txtmatricula.Size = new System.Drawing.Size(112, 20);
            this.txtmatricula.TabIndex = 11;
            // 
            // cmbreparacion
            // 
            this.cmbreparacion.FormattingEnabled = true;
            this.cmbreparacion.Items.AddRange(new object[] {
            "Motor",
            "Transmision",
            "Frenos",
            "Carroceria",
            "Escape",
            "Suspension",
            "Aceite",
            "Neumaticos"});
            this.cmbreparacion.Location = new System.Drawing.Point(230, 229);
            this.cmbreparacion.Name = "cmbreparacion";
            this.cmbreparacion.Size = new System.Drawing.Size(121, 21);
            this.cmbreparacion.TabIndex = 12;
            // 
            // chksi
            // 
            this.chksi.AutoSize = true;
            this.chksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chksi.Location = new System.Drawing.Point(185, 282);
            this.chksi.Name = "chksi";
            this.chksi.Size = new System.Drawing.Size(40, 22);
            this.chksi.TabIndex = 13;
            this.chksi.Text = "Si";
            this.chksi.UseVisualStyleBackColor = true;
            // 
            // chkno
            // 
            this.chkno.AutoSize = true;
            this.chkno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkno.Location = new System.Drawing.Point(257, 282);
            this.chkno.Name = "chkno";
            this.chkno.Size = new System.Drawing.Size(47, 22);
            this.chkno.TabIndex = 14;
            this.chkno.Text = "No";
            this.chkno.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(572, 450);
            this.Controls.Add(this.chkno);
            this.Controls.Add(this.chksi);
            this.Controls.Add(this.cmbreparacion);
            this.Controls.Add(this.txtmatricula);
            this.Controls.Add(this.txtaño);
            this.Controls.Add(this.txtmodelo);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.lblseguro);
            this.Controls.Add(this.lblreparacion);
            this.Controls.Add(this.lblmatricula);
            this.Controls.Add(this.lblaño);
            this.Controls.Add(this.lblmodelo);
            this.Controls.Add(this.lblmarca);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "Form1";
            this.Text = "Registro de Autos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmarca;
        private System.Windows.Forms.Label lblmodelo;
        private System.Windows.Forms.Label lblaño;
        private System.Windows.Forms.Label lblmatricula;
        private System.Windows.Forms.Label lblreparacion;
        private System.Windows.Forms.Label lblseguro;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.TextBox txtmodelo;
        private System.Windows.Forms.TextBox txtaño;
        private System.Windows.Forms.TextBox txtmatricula;
        private System.Windows.Forms.ComboBox cmbreparacion;
        private System.Windows.Forms.CheckBox chksi;
        private System.Windows.Forms.CheckBox chkno;
    }
}

