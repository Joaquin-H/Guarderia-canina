using BTS_3k2_PAV.Entidades;
using BTS_3k2_PAV.Servicios;
using BTS_3k2_PAV.Utils;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTS_3k2_PAV.InterfacesDeUsuario.Reportes
{
    public partial class BugsConFiltros : Form
    {
        private readonly EstadosServicio estadosServicio;

        private readonly ReportesServicio reportesServicio;

        public BugsConFiltros()
        {
            estadosServicio = new EstadosServicio();
            reportesServicio = new ReportesServicio();
            InitializeComponent();
        }

        private void BugsConFiltros_Load(object sender, EventArgs e)
        {
            CargarEstados();
            ObtenerReporte();
        }

        public void CargarReporte(BugFiltros filtros)
        {
            this.RwBugs.LocalReport.DataSources.Clear();
            var datos = reportesServicio.BugsPorFiltros(filtros);

            var datasource = new ReportDataSource("BugsPorFiltrosDS", datos);

            this.RwBugs.LocalReport.DataSources.Add(datasource);

            var hoy = DateTime.Now;
            var parametros = new List<ReportParameter>() {
                new ReportParameter("AnioActual", hoy.Year.ToString()),
                new ReportParameter("FechaGeneracionReporte", hoy.ToString("dd/MM/yyyy hh:mm")),
                new ReportParameter("FechaCreacionDesde", filtros.FechaDesde?.ToString("dd/MM/yyyy")),
                new ReportParameter("FechaCreacionHasta", filtros.FechaHasta?.ToString("dd/MM/yyyy")),
                new ReportParameter("EstadoFiltrado", filtros.Estado)
            };

            this.RwBugs.LocalReport.SetParameters(parametros);
            this.RwBugs.RefreshReport();
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

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            ObtenerReporte();
        }

        public void ObtenerReporte()
        {
            var filtros = new BugFiltros();
            filtros.FechaDesde = DtpFechaDesde.Value;
            filtros.FechaHasta = DtpFechaHasta.Value;
            filtros.IdEstado = (long)CbEstado.SelectedValue;
            var e = (Estado) CbEstado.SelectedItem;
            var estado = filtros.IdEstado != 0 ? e.Nombre : "TODOS";
            filtros.Estado = estado;
            CargarReporte(filtros);
        }
    }
}
