using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class EstrategiaAscendente : ISubastaStrategy
    {
        public bool ValidarOferta(decimal monto, decimal ofertaActual, decimal precioInicial) =>
        monto > ofertaActual && monto >= precioInicial;

        public Usuario DeterminarGanador(List<Oferta> ofertas) =>
            ofertas.OrderByDescending(o => o.Monto).FirstOrDefault()?.Postulante;

        public bool DebeCerrarPorTiempo(int segundosRestantes, int cantidadOfertas) =>
            segundosRestantes <= 0 && cantidadOfertas > 0;
    }
}
