using BTS_3k2_PAV.Entidades;
using BTS_3k2_PAV.Servicios;
using BTS_3k2_PAV.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTS_3k2_PAV.InterfacesDeUsuario.Bugs
{
    public partial class FrmBugs : Form
    {
        private readonly FrmPrincipal frmPrincipal;
        private readonly BugsServicio bugsServicio;

        private readonly EstadosServicio estadosServicio;
        private readonly PrioridadesServicio prioridadesServicio;
        private readonly ProductosServicio productosServicio;
        private readonly CriticidadesServicio criticidadesServicio;
        private readonly UsuariosServicio usuariosServicio;

        public FrmBugs(FrmPrincipal frmPrincipal)
        {
            this.frmPrincipal = frmPrincipal;
            estadosServicio = new EstadosServicio();
            prioridadesServicio = new PrioridadesServicio();
            productosServicio= new ProductosServicio();
            criticidadesServicio = new CriticidadesServicio();
            usuariosServicio = new UsuariosServicio();
            bugsServicio = new BugsServicio();
            InitializeComponent();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            var frmRegistrarBug = new FrmRegistrarBug();
            frmRegistrarBug.ShowDialog();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            CerrarFormulario();
        }

        private void CerrarFormulario()
        {
            frmPrincipal.Show();
            Dispose();
        }

        private void FrmBugs_FormClosing(object sender, FormClosingEventArgs e)
        {
            CerrarFormulario();
        }

        private void BtnDarBaja_Click(object sender, EventArgs e)
        {
            if (DgvBugs.SelectedRows.Count == 1)
            {
                var id = Convert.ToInt64(DgvBugs.SelectedRows[0].Cells["Id"].Value);
                var bug = bugsServicio.GetBug(id);
                bugsServicio.BarBaja(bug);
                return;
            }
            if (DgvBugs.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un registro.", "Información", MessageBoxButtons.OK);
                return;
            }
            if (DgvBugs.SelectedRows.Count > 1)
            {
                MessageBox.Show("Debe seleccionar solo un registro, no muchos.", "Información", MessageBoxButtons.OK);
            }
        }

        private void FrmBugs_Load(object sender, EventArgs e)
        {
            CargarEstados();
            CargarPrioridades();
            CargarProductos();
            CargarCriticidades();
            CargarUsuarios();
            Consultar(new BugFiltros());
        }

        public void Consultar(BugFiltros f)
        {
            var bugs = bugsServicio.Obtener(f);
            DgvBugs.Rows.Clear();
            foreach (var b in bugs)
            {
                var fila = new string[]
                {
                    b.Id.ToString(),
                    b.Titulo,
                    b.Producto?.Nombre,
                    b.FechaAlta.ToString("dd/MM/yyyy"),
                    b.Asignado?.NombreUsuario,
                    b.Criticidad?.Nombre,
                    b.Prioridad?.Nombre,
                    b.Estado?.Nombre,
                };
                DgvBugs.Rows.Add(fila);
            }
        }

        private void CargarUsuarios()
        {
            var prioridades = usuariosServicio.GetUsuarios();
            var prioridadXDefecto = new Usuario()
            {
                NombreUsuario = "Seleccionar"
            };
            prioridades.Add(prioridadXDefecto);
            var conectorPrioridades = new BindingSource();
            conectorPrioridades.DataSource = prioridades;

            CombosUtils.CargarCombo(ref CbAsignadoA, conectorPrioridades, "NombreUsuario");
            CbAsignadoA.SelectedItem = prioridadXDefecto;
        }

        private void CargarCriticidades()
        {
            var prioridades = criticidadesServicio.Obtener();
            var prioridadXDefecto = new Criticidad()
            {
                Nombre = "Seleccionar"
            };
            prioridades.Add(prioridadXDefecto);
            var conectorPrioridades = new BindingSource();
            conectorPrioridades.DataSource = prioridades;

            CombosUtils.CargarCombo(ref CbCriticidad, conectorPrioridades);
            CbCriticidad.SelectedItem = prioridadXDefecto;
        }

        private void CargarProductos()
        {
            var prioridades = productosServicio.Obtener();
            var prioridadXDefecto = new Producto()
            {
                Nombre = "Seleccionar"
            };
            prioridades.Add(prioridadXDefecto);
            var conectorPrioridades = new BindingSource();
            conectorPrioridades.DataSource = prioridades;

            CombosUtils.CargarCombo(ref CbProducto, conectorPrioridades);
            CbProducto.SelectedItem = prioridadXDefecto;
        }

        private void CargarEstados()
        {
            var prioridades = estadosServicio.Obtener();
            var prioridadXDefecto = new Estado()
            {
                Nombre = "Seleccionar"
            };
            prioridades.Add(prioridadXDefecto);
            var conectorPrioridades = new BindingSource();
            conectorPrioridades.DataSource = prioridades;

            CombosUtils.CargarCombo(ref CbEstado, conectorPrioridades);
            CbEstado.SelectedItem = prioridadXDefecto;
        }

        private void CargarPrioridades()
        {
            var prioridades = prioridadesServicio.Obtener();
            var prioridadXDefecto = new Prioridad()
            {
                Nombre = "Seleccionar"
            };
            prioridades.Add(prioridadXDefecto);
            var conectorPrioridades = new BindingSource();
            conectorPrioridades.DataSource = prioridades;

            CombosUtils.CargarCombo(ref CbPrioridad, conectorPrioridades);
            CbPrioridad.SelectedItem = prioridadXDefecto;
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            var filtros = new BugFiltros();
            filtros.FechaDesde = DtpFechaDesde.Value;
            filtros.FechaHasta = DtpFechaHasta.Value;
            filtros.IdPrioridad = (long)CbPrioridad.SelectedValue;
            filtros.IdCriticidad = (long)CbCriticidad.SelectedValue;
            filtros.IdProducto = (long)CbProducto.SelectedValue;
            filtros.IdEstado = (long)CbEstado.SelectedValue;
            filtros.IdUsuarioAsignado = (long)CbAsignadoA.SelectedValue;

            Consultar(filtros);
        }
    }
}
