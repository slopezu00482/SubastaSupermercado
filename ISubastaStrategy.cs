using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public interface ISubastaStrategy
    {
        bool ValidarOferta(decimal monto, decimal ofertaActual, decimal precioInicial);
        Usuario DeterminarGanador(List<Oferta> ofertas);
        // Agregamos esto para que las estrategias puedan avisar al Timer cuándo cerrar
        bool DebeCerrarPorTiempo(int segundosRestantes, int cantidadOfertas);
    }
}
