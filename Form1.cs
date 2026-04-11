using WindowsFormsApp1;

namespace SubastaSupermercado
{
    public partial class Form1 : Form
    {
        private List<Subasta> subastasActivas = new List<Subasta>();
        private Usuario usuarioActual;
        public Form1()
        {
            InitializeComponent();
            ConfigurarFormulario();
            CargarDatos();
        }


        private void ConfigurarFormulario()
        {
            cmbRol.Items.AddRange(new string[] { "Comprador", "Espectador" });
            cmbRol.SelectedIndex = 0;
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void CargarDatos()
        {
            var fabE = new ElectronicoFactory();
            var fabA = new AlimentoFactory();
            var fabR = new RopaFactory();

            subastasActivas.Add(new Subasta { ProductoSubastado = fabE.CrearProducto("Laptop ROG", 1200), Estrategia = new EstrategiaAscendente() });
            subastasActivas.Add(new Subasta { ProductoSubastado = fabA.CrearProducto("Vino Reserva", 150), Estrategia = new EstrategiaDescendente(), PrecioDescendente = 300, SegundosParaCierre = 60 });
            subastasActivas.Add(new Subasta { ProductoSubastado = fabR.CrearProducto("Reloj Lujo", 500), Estrategia = new EstrategiaCerrada(), SegundosParaCierre = 20 });
            ActualizarLista();
        }
        private void cmbRol_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Esta lógica ayuda a que la interfaz se bloquee si eliges "Espectador"
            if (cmbRol.SelectedItem != null)
            {
                bool esComprador = cmbRol.SelectedItem.ToString() == "Comprador";
                txtOferta.Enabled = esComprador;
                btnOfertar.Enabled = esComprador;

                // Si es descendente, el cuadro de texto siempre debe estar apagado
                if (lstSubastas.SelectedItem is Subasta s && s.Estrategia is EstrategiaDescendente)
                {
                    txtOferta.Enabled = false;
                }
            }

        }
        private void btnOfertar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstSubastas.SelectedItem is Subasta seleccionada)
                {
                    string nombre = string.IsNullOrWhiteSpace(txtNombreUsuario.Text) ? "Anónimo" : txtNombreUsuario.Text;

                    // REGLA 3: Creación polimórfica de usuario
                    usuarioActual = (cmbRol.SelectedItem.ToString() == "Espectador")
                                    ? (Usuario)new Espectador { Nombre = nombre }
                                    : new Comprador { Nombre = nombre };

                    decimal monto = (seleccionada.Estrategia is EstrategiaDescendente)
                                    ? seleccionada.PrecioDescendente
                                    : decimal.Parse(txtOferta.Text);

                    if (usuarioActual.RealizarOferta(monto, seleccionada))
                        ActualizarLista();
                    else
                        throw new Exception("Monto insuficiente para las reglas de esta subasta.");
                }
            }
            catch (Exception ex)
            {
                // REGLA 7: Manejo de excepciones
                MessageBox.Show(ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int idx = lstSubastas.SelectedIndex;
            foreach (var s in subastasActivas)
            {
                if (!s.Abierta) continue;

                if (s.Estrategia is EstrategiaAscendente && s.Ofertas.Count > 0) s.SegundosParaCierre--;
                else if (s.Estrategia is EstrategiaDescendente)
                {
                    s.SegundosParaCierre--;
                    s.PrecioDescendente -= 1.5m; // Descenso gradual
                    if (s.PrecioDescendente <= s.ProductoSubastado.PrecioInicial) s.FinalizarSubasta();
                }
                else if (s.Estrategia is EstrategiaCerrada) s.SegundosParaCierre--;

                if (s.Estrategia.DebeCerrarPorTiempo(s.SegundosParaCierre, s.Ofertas.Count)) s.FinalizarSubasta();
            }

            ActualizarLista();
            if (idx != -1) lstSubastas.SelectedIndex = idx;

            // Update UI del precio bajando en tiempo real
            if (lstSubastas.SelectedItem is Subasta sel && sel.Estrategia is EstrategiaDescendente && sel.Abierta && !txtOferta.Focused)
                txtOferta.Text = sel.PrecioDescendente.ToString("F0");
        }
        private void ActualizarLista()
        {
            lstSubastas.DataSource = null;
            lstSubastas.DataSource = subastasActivas;
            lstSubastas.DisplayMember = "InformacionVisual";
        }

        private void lstSubastas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSubastas.SelectedItem is Subasta s)
            {
                decimal actual = s.ObtenerMontoActual();
                decimal proyectado = s.ProductoSubastado.CalcularPrecioFinal(actual);

                lblInfo.Text = $"Producto: {s.ProductoSubastado.Nombre}\n" +
                               $"Descripción: {s.ProductoSubastado.Descripcion}\n" +
                               $"Monto Subasta: {actual:C}\n" +
                               $"PRECIO FINAL (+Cargos/Desc): {proyectado:C}";

                // Configuración dinámica de controles
                bool esDesc = s.Estrategia is EstrategiaDescendente;
                txtOferta.Enabled = !esDesc && s.Abierta && cmbRol.Text == "Comprador";
                btnOfertar.Text = esDesc ? "Aceptar Precio" : "Realizar Oferta";
                btnOfertar.Enabled = s.Abierta && cmbRol.Text == "Comprador";
            }
        }
    }
}
