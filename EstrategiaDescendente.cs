using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class EstrategiaDescendente : ISubastaStrategy
    {
        public bool ValidarOferta(decimal monto, decimal ofertaActual, decimal precioInicial) => true; // El primero que acepta gana

        public Usuario DeterminarGanador(List<Oferta> ofertas) =>
            ofertas.FirstOrDefault()?.Postulante; // El primero de la lista

        public bool DebeCerrarPorTiempo(int segundosRestantes, int cantidadOfertas) => false;
    }
}
