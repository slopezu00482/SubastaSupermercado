using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public abstract class ProductoFactory
    {
        public abstract Producto CrearProducto(string nombre, decimal precio);
    }
}
