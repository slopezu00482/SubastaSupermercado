using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Electronico : Producto
    {
        public override decimal CalcularPrecioFinal(decimal precioSubasta)
        {
            return precioSubasta * 1.10m;
        }
    }
}
