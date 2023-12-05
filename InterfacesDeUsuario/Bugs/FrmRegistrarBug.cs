using BTS_3k2_PAV.Entidades;
using BTS_3k2_PAV.Servicios;
using BTS_3k2_PAV.Utils;
using System;
using System.Windows.Forms;

namespace BTS_3k2_PAV.InterfacesDeUsuario.Bugs
{
    public partial class FrmRegistrarBug : Form
    {
        private readonly PrioridadesServicio prioridadesServicio;
        private readonly ProductosServicio productosServicio;
        private readonly CriticidadesServicio criticidadServicio;
        private readonly BugsServicio bugsServicio;

        public FrmRegistrarBug()
        {
            prioridadesServicio = new PrioridadesServicio();
            productosServicio = new ProductosServicio();
            criticidadServicio = new CriticidadesServicio();
            bugsServicio = new BugsServicio();
            InitializeComponent();
        }

        private void FrmRegistrarBug_Load(object sender, EventArgs e)
        {
            CargarCombos();
        }

        private void CargarCombos()
        {
            var prioridades = prioridadesServicio.Obtener();
            var productos = productosServicio.Obtener();
            var criticidades = criticidadServicio.Obtener();

            var prioridadXDefecto = new Prioridad()
            {
                Nombre = "Seleccionar"
            };
            prioridades.Add(prioridadXDefecto);

            var criticidadXDefecto = new Criticidad()
            {
                Nombre = "Seleccionar"
            };

            criticidades.Add(criticidadXDefecto);


            var conectorPrioridades = new BindingSource();                        
            conectorPrioridades.DataSource = prioridades;


            var conectorProductos = new BindingSource();
            conectorProductos.DataSource = productos;

            var conectorCriticidades = new BindingSource();
            conectorCriticidades.DataSource = criticidades;

            CombosUtils.CargarCombo(ref CbPrioridad, conectorPrioridades);
            CbPrioridad.SelectedItem = prioridadXDefecto;
            
            CombosUtils.CargarCombo(ref CbProducto, conectorProductos); 
            
            CombosUtils.CargarCombo(ref CBCriticidad, conectorCriticidades);
            CBCriticidad.SelectedItem = criticidadXDefecto;


        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (UsuarioConfirma())
                {
                    RegistrarUsuario();
                    Dispose();
                }
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error. Intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool UsuarioConfirma()
        {
            var opcion = MessageBox.Show("¿Confirma crear un bug?",
                "Confirmación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            return opcion == DialogResult.Yes;
        }

        public void RegistrarUsuario()
        {
            var bug = new Bug();
            bug.Titulo = TxtTitulo.Text.Trim();
            bug.Descripcion = TxtDecripcion.Text.Trim();
            bug.Producto = (Producto)CbProducto.SelectedItem;
            bug.Prioridad = (Prioridad)CbPrioridad.SelectedItem;
            bug.Criticidad = (Criticidad)CBCriticidad.SelectedItem;
            bugsServicio.Validar(bug);
            bugsServicio.RegistrarBug(bug);
            MessageBox.Show("El bug se registró con éxito.",
                "Información", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
