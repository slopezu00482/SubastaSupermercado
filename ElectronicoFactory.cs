using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class ElectronicoFactory : ProductoFactory
    {
        public override Producto CrearProducto(string nombre, decimal precio) =>
            new Electronico
            {
                Nombre = nombre,
                PrecioInicial = precio,
                Descripcion = "Dispositivo de alta tecnología con garantía extendida."
            };
    }
}
