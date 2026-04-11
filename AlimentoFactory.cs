using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class AlimentoFactory : ProductoFactory
    {
        public override Producto CrearProducto(string nombre, decimal precio) =>
            new Alimento { Nombre = nombre, PrecioInicial = precio, EsPerecedero = true, CercaDeCaducidad = true };
    }
}