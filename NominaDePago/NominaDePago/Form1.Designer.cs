namespace NominaDePago
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
            this.lblNominaDePago = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDiasTrabajados = new System.Windows.Forms.Label();
            this.lblPagosPorDia = new System.Windows.Forms.Label();
            this.btnGuardarRegistro = new System.Windows.Forms.Button();
            this.btnCalcularSalario = new System.Windows.Forms.Button();
            this.lblTotalDevengado = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDiasTrabajados = new System.Windows.Forms.TextBox();
            this.txtPagosPorDia = new System.Windows.Forms.TextBox();
            this.txtTotalDevengado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNominaDePago
            // 
            this.lblNominaDePago.AutoSize = true;
            this.lblNominaDePago.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNominaDePago.Location = new System.Drawing.Point(192, 9);
            this.lblNominaDePago.Name = "lblNominaDePago";
            this.lblNominaDePago.Size = new System.Drawing.Size(212, 20);
            this.lblNominaDePago.TabIndex = 0;
            this.lblNominaDePago.Text = "Calculo Nomina de Pago";
            this.lblNominaDePago.Click += new System.EventHandler(this.lblNominaDePago_Click);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(93, 67);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "Numero:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(93, 104);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDiasTrabajados
            // 
            this.lblDiasTrabajados.AutoSize = true;
            this.lblDiasTrabajados.Location = new System.Drawing.Point(93, 140);
            this.lblDiasTrabajados.Name = "lblDiasTrabajados";
            this.lblDiasTrabajados.Size = new System.Drawing.Size(83, 13);
            this.lblDiasTrabajados.TabIndex = 3;
            this.lblDiasTrabajados.Text = "Dias trabajados:";
            // 
            // lblPagosPorDia
            // 
            this.lblPagosPorDia.AutoSize = true;
            this.lblPagosPorDia.Location = new System.Drawing.Point(93, 174);
            this.lblPagosPorDia.Name = "lblPagosPorDia";
            this.lblPagosPorDia.Size = new System.Drawing.Size(75, 13);
            this.lblPagosPorDia.TabIndex = 4;
            this.lblPagosPorDia.Text = "Pagos por dia:";
            // 
            // btnGuardarRegistro
            // 
            this.btnGuardarRegistro.Location = new System.Drawing.Point(240, 220);
            this.btnGuardarRegistro.Name = "btnGuardarRegistro";
            this.btnGuardarRegistro.Size = new System.Drawing.Size(133, 41);
            this.btnGuardarRegistro.TabIndex = 5;
            this.btnGuardarRegistro.Text = "Guardar Registro";
            this.btnGuardarRegistro.UseVisualStyleBackColor = true;
            this.btnGuardarRegistro.Click += new System.EventHandler(this.btnGuardarRegistro_Click);
            // 
            // btnCalcularSalario
            // 
            this.btnCalcularSalario.Location = new System.Drawing.Point(260, 278);
            this.btnCalcularSalario.Name = "btnCalcularSalario";
            this.btnCalcularSalario.Size = new System.Drawing.Size(93, 30);
            this.btnCalcularSalario.TabIndex = 6;
            this.btnCalcularSalario.Text = "Calcular Salario";
            this.btnCalcularSalario.UseVisualStyleBackColor = true;
            this.btnCalcularSalario.Click += new System.EventHandler(this.btnCalcularSalario_Click);
            // 
            // lblTotalDevengado
            // 
            this.lblTotalDevengado.AutoSize = true;
            this.lblTotalDevengado.Location = new System.Drawing.Point(134, 359);
            this.lblTotalDevengado.Name = "lblTotalDevengado";
            this.lblTotalDevengado.Size = new System.Drawing.Size(91, 13);
            this.lblTotalDevengado.TabIndex = 7;
            this.lblTotalDevengado.Text = "Total devengado:";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(137, 422);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(102, 33);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(358, 422);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(102, 32);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(196, 67);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(140, 20);
            this.txtNumero.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(196, 101);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(140, 20);
            this.txtNombre.TabIndex = 11;
            // 
            // txtDiasTrabajados
            // 
            this.txtDiasTrabajados.Location = new System.Drawing.Point(196, 137);
            this.txtDiasTrabajados.Name = "txtDiasTrabajados";
            this.txtDiasTrabajados.Size = new System.Drawing.Size(140, 20);
            this.txtDiasTrabajados.TabIndex = 12;
            // 
            // txtPagosPorDia
            // 
            this.txtPagosPorDia.Location = new System.Drawing.Point(196, 171);
            this.txtPagosPorDia.Name = "txtPagosPorDia";
            this.txtPagosPorDia.Size = new System.Drawing.Size(140, 20);
            this.txtPagosPorDia.TabIndex = 13;
            // 
            // txtTotalDevengado
            // 
            this.txtTotalDevengado.Location = new System.Drawing.Point(253, 356);
            this.txtTotalDevengado.Name = "txtTotalDevengado";
            this.txtTotalDevengado.Size = new System.Drawing.Size(100, 20);
            this.txtTotalDevengado.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 478);
            this.Controls.Add(this.txtTotalDevengado);
            this.Controls.Add(this.txtPagosPorDia);
            this.Controls.Add(this.txtDiasTrabajados);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.lblTotalDevengado);
            this.Controls.Add(this.btnCalcularSalario);
            this.Controls.Add(this.btnGuardarRegistro);
            this.Controls.Add(this.lblPagosPorDia);
            this.Controls.Add(this.lblDiasTrabajados);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblNominaDePago);
            this.Name = "Form1";
            this.Text = "Formulario Nomina";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNominaDePago;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDiasTrabajados;
        private System.Windows.Forms.Label lblPagosPorDia;
        private System.Windows.Forms.Button btnGuardarRegistro;
        private System.Windows.Forms.Button btnCalcularSalario;
        private System.Windows.Forms.Label lblTotalDevengado;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDiasTrabajados;
        private System.Windows.Forms.TextBox txtPagosPorDia;
        private System.Windows.Forms.TextBox txtTotalDevengado;
    }
}

