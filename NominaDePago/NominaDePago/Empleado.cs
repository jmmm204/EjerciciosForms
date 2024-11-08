using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaDePago
{
    internal class Empleado
    {
        public int NumEmpleado { get; set; }
        public string NombreEmp { get; set; }
        public int DiasLab { get; set; }
        public decimal SalDia { get; set; }

        public decimal CalcularSalario (int DiasLab, decimal SalDia)
        {
            return DiasLab * SalDia;
        }
    }
}
