namespace ControlDePacientes
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
            this.lblnombre = new System.Windows.Forms.Label();
            this.mtxtfecha = new System.Windows.Forms.MaskedTextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblfecha = new System.Windows.Forms.Label();
            this.cmbdepartamento = new System.Windows.Forms.ComboBox();
            this.chksi = new System.Windows.Forms.CheckBox();
            this.chkno = new System.Windows.Forms.CheckBox();
            this.lbldepartamento = new System.Windows.Forms.Label();
            this.lblgenero = new System.Windows.Forms.Label();
            this.cmbgenero = new System.Windows.Forms.ComboBox();
            this.lblconsulta = new System.Windows.Forms.Label();
            this.txtconsulta = new System.Windows.Forms.TextBox();
            this.lblalergias = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(106, 43);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(66, 18);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = "Nombre:";
            this.lblnombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // mtxtfecha
            // 
            this.mtxtfecha.Location = new System.Drawing.Point(204, 81);
            this.mtxtfecha.Mask = "00/00/0000";
            this.mtxtfecha.Name = "mtxtfecha";
            this.mtxtfecha.Size = new System.Drawing.Size(100, 20);
            this.mtxtfecha.TabIndex = 1;
            this.mtxtfecha.ValidatingType = typeof(System.DateTime);
            this.mtxtfecha.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(204, 41);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(121, 20);
            this.txtnombre.TabIndex = 2;
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(20, 83);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(152, 18);
            this.lblfecha.TabIndex = 3;
            this.lblfecha.Text = "Fecha de Nacimiento:";
            // 
            // cmbdepartamento
            // 
            this.cmbdepartamento.FormattingEnabled = true;
            this.cmbdepartamento.Items.AddRange(new object[] {
            "Cardiologia",
            "Pediatria",
            "Emergencias",
            "Neurologia",
            "Dermatologia",
            "Ginecologia",
            "Oncologia"});
            this.cmbdepartamento.Location = new System.Drawing.Point(204, 170);
            this.cmbdepartamento.Name = "cmbdepartamento";
            this.cmbdepartamento.Size = new System.Drawing.Size(121, 21);
            this.cmbdepartamento.TabIndex = 4;
            // 
            // chksi
            // 
            this.chksi.AutoSize = true;
            this.chksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chksi.Location = new System.Drawing.Point(204, 262);
            this.chksi.Name = "chksi";
            this.chksi.Size = new System.Drawing.Size(40, 22);
            this.chksi.TabIndex = 5;
            this.chksi.Text = "Si";
            this.chksi.UseVisualStyleBackColor = true;
            this.chksi.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chkno
            // 
            this.chkno.AutoSize = true;
            this.chkno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkno.Location = new System.Drawing.Point(278, 262);
            this.chkno.Name = "chkno";
            this.chkno.Size = new System.Drawing.Size(47, 22);
            this.chkno.TabIndex = 6;
            this.chkno.Text = "No";
            this.chkno.UseVisualStyleBackColor = true;
            // 
            // lbldepartamento
            // 
            this.lbldepartamento.AutoSize = true;
            this.lbldepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldepartamento.Location = new System.Drawing.Point(12, 173);
            this.lbldepartamento.Name = "lbldepartamento";
            this.lbldepartamento.Size = new System.Drawing.Size(159, 18);
            this.lbldepartamento.TabIndex = 7;
            this.lbldepartamento.Text = "Departamento Medico:";
            this.lbldepartamento.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblgenero
            // 
            this.lblgenero.AutoSize = true;
            this.lblgenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgenero.Location = new System.Drawing.Point(110, 130);
            this.lblgenero.Name = "lblgenero";
            this.lblgenero.Size = new System.Drawing.Size(62, 18);
            this.lblgenero.TabIndex = 8;
            this.lblgenero.Text = "Genero:";
            this.lblgenero.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cmbgenero
            // 
            this.cmbgenero.FormattingEnabled = true;
            this.cmbgenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbgenero.Location = new System.Drawing.Point(204, 127);
            this.cmbgenero.Name = "cmbgenero";
            this.cmbgenero.Size = new System.Drawing.Size(121, 21);
            this.cmbgenero.TabIndex = 9;
            // 
            // lblconsulta
            // 
            this.lblconsulta.AutoSize = true;
            this.lblconsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconsulta.Location = new System.Drawing.Point(31, 220);
            this.lblconsulta.Name = "lblconsulta";
            this.lblconsulta.Size = new System.Drawing.Size(140, 18);
            this.lblconsulta.TabIndex = 10;
            this.lblconsulta.Text = "Motivo de Consulta:";
            // 
            // txtconsulta
            // 
            this.txtconsulta.Location = new System.Drawing.Point(204, 218);
            this.txtconsulta.Name = "txtconsulta";
            this.txtconsulta.Size = new System.Drawing.Size(121, 20);
            this.txtconsulta.TabIndex = 11;
            // 
            // lblalergias
            // 
            this.lblalergias.AutoSize = true;
            this.lblalergias.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblalergias.Location = new System.Drawing.Point(56, 262);
            this.lblalergias.Name = "lblalergias";
            this.lblalergias.Size = new System.Drawing.Size(115, 18);
            this.lblalergias.TabIndex = 12;
            this.lblalergias.Text = "¿Tiene alergias?";
            // 
            // btnguardar
            // 
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Location = new System.Drawing.Point(34, 336);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 13;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.Location = new System.Drawing.Point(169, 336);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 14;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(295, 336);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 15;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(422, 384);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.lblalergias);
            this.Controls.Add(this.txtconsulta);
            this.Controls.Add(this.lblconsulta);
            this.Controls.Add(this.cmbgenero);
            this.Controls.Add(this.lblgenero);
            this.Controls.Add(this.lbldepartamento);
            this.Controls.Add(this.chkno);
            this.Controls.Add(this.chksi);
            this.Controls.Add(this.cmbdepartamento);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.mtxtfecha);
            this.Controls.Add(this.lblnombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Control de Pacientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.MaskedTextBox mtxtfecha;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.ComboBox cmbdepartamento;
        private System.Windows.Forms.CheckBox chksi;
        private System.Windows.Forms.CheckBox chkno;
        private System.Windows.Forms.Label lbldepartamento;
        private System.Windows.Forms.Label lblgenero;
        private System.Windows.Forms.ComboBox cmbgenero;
        private System.Windows.Forms.Label lblconsulta;
        private System.Windows.Forms.TextBox txtconsulta;
        private System.Windows.Forms.Label lblalergias;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnsalir;
    }
}

