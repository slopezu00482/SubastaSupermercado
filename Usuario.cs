using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public abstract class Usuario
    {
        public string Nombre { get; set; }
        public abstract bool RealizarOferta(decimal monto, Subasta subasta);
    }

    public class Comprador : Usuario
    {
        public override bool RealizarOferta(decimal monto, Subasta subasta)
        {
            return subasta.ProcesarOferta(this, monto);
        }
    }

    public class Espectador : Usuario
    {
        public override bool RealizarOferta(decimal monto, Subasta subasta)
        {
            return false;
        }
    }
}
