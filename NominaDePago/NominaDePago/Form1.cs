using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NominaDePago
{
    public partial class Form1 : Form
    {
        Empleado emp = new Empleado(); //Creando objeto de la clase empleado
        public Form1()
        {
            InitializeComponent();
        }

        private void lblNominaDePago_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardarRegistro_Click(object sender, EventArgs e)
        {
            emp.NumEmpleado = Convert.ToInt32(txtNumero.Text);
            emp.NombreEmp = txtNombre.Text;
            emp.DiasLab = Convert.ToInt32(txtDiasTrabajados.Text);
            emp.SalDia = Convert.ToDecimal(txtPagosPorDia.Text);
            MessageBox.Show("Registro guardado");
        }

        private void btnCalcularSalario_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
