namespace SueldoEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbltitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpingresardatos = new System.Windows.Forms.GroupBox();
            this.grphacerclick = new System.Windows.Forms.GroupBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblcargo = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtsueldocorrespondiente = new System.Windows.Forms.TextBox();
            this.cmbcargo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpingresardatos.SuspendLayout();
            this.grphacerclick.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(275, 25);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(238, 20);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Determinar sueldo del empleado";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(485, 212);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // grpingresardatos
            // 
            this.grpingresardatos.Controls.Add(this.cmbcargo);
            this.grpingresardatos.Controls.Add(this.txtnombre);
            this.grpingresardatos.Controls.Add(this.lblcargo);
            this.grpingresardatos.Controls.Add(this.lblnombre);
            this.grpingresardatos.Location = new System.Drawing.Point(50, 72);
            this.grpingresardatos.Name = "grpingresardatos";
            this.grpingresardatos.Size = new System.Drawing.Size(522, 96);
            this.grpingresardatos.TabIndex = 2;
            this.grpingresardatos.TabStop = false;
            this.grpingresardatos.Text = "Ingrese datos";
            // 
            // grphacerclick
            // 
            this.grphacerclick.Controls.Add(this.btnsalir);
            this.grphacerclick.Controls.Add(this.btnnuevo);
            this.grphacerclick.Controls.Add(this.btncalcular);
            this.grphacerclick.Location = new System.Drawing.Point(50, 193);
            this.grphacerclick.Name = "grphacerclick";
            this.grphacerclick.Size = new System.Drawing.Size(323, 160);
            this.grphacerclick.TabIndex = 3;
            this.grphacerclick.TabStop = false;
            this.grphacerclick.Text = "Hacer click";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(98, 20);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(59, 16);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = "Nombre:";
            // 
            // lblcargo
            // 
            this.lblcargo.AutoSize = true;
            this.lblcargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcargo.Location = new System.Drawing.Point(101, 59);
            this.lblcargo.Name = "lblcargo";
            this.lblcargo.Size = new System.Drawing.Size(47, 16);
            this.lblcargo.TabIndex = 1;
            this.lblcargo.Text = "Cargo:";
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(104, 19);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(103, 28);
            this.btncalcular.TabIndex = 0;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(104, 68);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(103, 28);
            this.btnnuevo.TabIndex = 1;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(104, 115);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(103, 29);
            this.btnsalir.TabIndex = 2;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sueldo correspondiente:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(181, 17);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(210, 20);
            this.txtnombre.TabIndex = 2;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            // 
            // txtsueldocorrespondiente
            // 
            this.txtsueldocorrespondiente.Location = new System.Drawing.Point(231, 386);
            this.txtsueldocorrespondiente.Name = "txtsueldocorrespondiente";
            this.txtsueldocorrespondiente.Size = new System.Drawing.Size(162, 20);
            this.txtsueldocorrespondiente.TabIndex = 5;
            // 
            // cmbcargo
            // 
            this.cmbcargo.FormattingEnabled = true;
            this.cmbcargo.Items.AddRange(new object[] {
            "Gerente",
            "Administrador",
            "Secretaria",
            "Contador"});
            this.cmbcargo.Location = new System.Drawing.Point(181, 59);
            this.cmbcargo.Name = "cmbcargo";
            this.cmbcargo.Size = new System.Drawing.Size(121, 21);
            this.cmbcargo.TabIndex = 3;
            this.cmbcargo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtsueldocorrespondiente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grphacerclick);
            this.Controls.Add(this.grpingresardatos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbltitulo);
            this.Name = "Form1";
            this.Text = "Ejemplo Condicional";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpingresardatos.ResumeLayout(false);
            this.grpingresardatos.PerformLayout();
            this.grphacerclick.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpingresardatos;
        private System.Windows.Forms.Label lblcargo;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.GroupBox grphacerclick;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsueldocorrespondiente;
        private System.Windows.Forms.ComboBox cmbcargo;
    }
}

