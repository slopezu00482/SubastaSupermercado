using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Ropa : Producto
    {
        public bool EsLiquidacion { get; set; }

        public override decimal CalcularPrecioFinal(decimal precioSubasta)
        {
            return EsLiquidacion ? precioSubasta * 0.80m : precioSubasta;
        }
    }
}
