using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Alimento : Producto
    {
        public bool EsPerecedero { get; set; }
        public bool CercaDeCaducidad { get; set; }

        public override decimal CalcularPrecioFinal(decimal precioSubasta)
        {
            if (EsPerecedero && CercaDeCaducidad)
                return precioSubasta * 0.85m;

            return precioSubasta;
        }
    }
}
