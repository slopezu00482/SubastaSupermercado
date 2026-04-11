using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class RopaFactory : ProductoFactory
    {
        public override Producto CrearProducto(string nombre, decimal precio) =>
        new Ropa { Nombre = nombre, PrecioInicial = precio, EsLiquidacion = true };
    }
}