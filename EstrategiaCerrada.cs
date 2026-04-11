using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class EstrategiaCerrada : ISubastaStrategy
    {
        public bool ValidarOferta(decimal monto, decimal ofertaActual, decimal precioInicial) => true;

        public Usuario DeterminarGanador(List<Oferta> ofertas) => ofertas.OrderByDescending(o => o.Monto).FirstOrDefault()?.Postulante;

        public bool DebeCerrarPorTiempo(int segundosRestantes, int cantidadOfertas) => segundosRestantes <= 0;
    }
}
