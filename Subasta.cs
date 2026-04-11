using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Subasta
    {
        public Producto ProductoSubastado { get; set; }
        public ISubastaStrategy Estrategia { get; set; }
        public List<Oferta> Ofertas { get; set; } = new List<Oferta>();
        public bool Abierta { get; private set; } = true;
        public int SegundosParaCierre { get; set; } = 10;
        public decimal PrecioDescendente { get; set; }

        public decimal ObtenerMontoActual()
        {
            if (Estrategia is EstrategiaDescendente) return PrecioDescendente;
            return Ofertas.Count > 0 ? Ofertas.Max(o => o.Monto) : ProductoSubastado.PrecioInicial;
        }

        public bool ProcesarOferta(Usuario u, decimal monto)
        {
            if (!Abierta) throw new Exception("Subasta cerrada.");

            // Regla de un solo intento para subasta cerrada
            if (Estrategia is EstrategiaCerrada && Ofertas.Any(o => o.Postulante.Nombre == u.Nombre))
                throw new Exception("Solo se permite una oferta por usuario en esta modalidad.");

            if (Estrategia.ValidarOferta(monto, ObtenerMontoActual(), ProductoSubastado.PrecioInicial))
            {
                Ofertas.Add(new Oferta { Postulante = u, Monto = monto });

                if (Estrategia is EstrategiaAscendente) SegundosParaCierre = 10; // Reinicio de timer
                if (Estrategia is EstrategiaDescendente) FinalizarSubasta(); // Cierre inmediato

                return true;
            }
            return false;
        }

        public void FinalizarSubasta()
        {
            if (!Abierta) return;
            Abierta = false;

            Usuario ganador = Estrategia.DeterminarGanador(Ofertas);
            if (ganador != null)
            {
                // Buscamos el monto base (oferta ganadora o precio descendente aceptado)
                decimal montoBase = (Estrategia is EstrategiaDescendente) ? PrecioDescendente : Ofertas.Where(o => o.Postulante == ganador).Max(o => o.Monto);
                decimal precioFinal = ProductoSubastado.CalcularPrecioFinal(montoBase);

                MessageBox.Show($"¡SUBASTA FINALIZADA!\nGanador: {ganador.Nombre}\nPrecio Final: {precioFinal:C}");
            }
            else
            {
                MessageBox.Show($"La subasta de {ProductoSubastado.Nombre} terminó sin comprador.");
            }
        }

        // Propiedad para el ListBox (Regla 7)
        public string InformacionVisual
        {
            get
            {
                string tipo = Estrategia.GetType().Name.Replace("Estrategia", "");
                string estado = Abierta ? $"{SegundosParaCierre}s" : "[CERRADA]";
                var mejor = Ofertas.OrderByDescending(o => o.Monto).FirstOrDefault();

                if (Estrategia is EstrategiaAscendente && Abierta)
                    return $"[{tipo}] {ProductoSubastado.Nombre} | Líder: {(mejor?.Postulante.Nombre ?? "Nadie")} ({ObtenerMontoActual():C}) | {estado}";

                if (Estrategia is EstrategiaDescendente && Abierta)
                    return $"[{tipo}] {ProductoSubastado.Nombre} | Precio: {PrecioDescendente:C} | {estado}";

                if (!Abierta)
                    return $"[{tipo}] {ProductoSubastado.Nombre} | GANADOR: {(mejor?.Postulante.Nombre ?? "Nadie")} | {estado}";

                return $"[{tipo}] {ProductoSubastado.Nombre} | Ofertas Ocultas | {estado}";
            }
        }
    }
}
