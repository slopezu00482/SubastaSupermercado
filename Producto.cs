using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public abstract class Producto
    {
        public string Nombre { get; set; }
        public decimal PrecioInicial { get; set; }
        public string Descripcion { get; set; }
        public abstract decimal CalcularPrecioFinal(decimal precioSubasta);
    }
}
