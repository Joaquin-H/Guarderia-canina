using BTS_3k2_PAV.Servicios;
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

namespace BTS_3k2_PAV.InterfacesDeUsuario.Reportes.BugsPorEstado
{
    public partial class FrmBugsPorEstado : Form
    {
        private readonly ReportesServicio servicio;

        public FrmBugsPorEstado()
        {
            servicio = new ReportesServicio();
            InitializeComponent();
        }

        private void FrmBugsPorEstado_Load(object sender, EventArgs e)
        {
            CargarBugsPorEstado();            
        }

        private void CargarBugsPorEstado()
        {
            var datos = servicio.BugsPorEstado();
            var datosUsuarios = servicio.Usuarios();
            this.RwBugsSegunEstados.LocalReport.DataSources.Clear();

            var ds = new ReportDataSource("CategoriaPorCantidadDS", datos);
            var ds1 = new ReportDataSource("UsuariosDS", datosUsuarios);

            this.RwBugsSegunEstados.LocalReport.DataSources.Add(ds);
            this.RwBugsSegunEstados.LocalReport.DataSources.Add(ds1);

            var hoy = DateTime.Now;

            var parametros = new List<ReportParameter>() { 
                new ReportParameter("AnioActual", hoy.Year.ToString()),
                new ReportParameter("FechaActual", hoy.ToString("dd/MM/yyyy hh:mm")),
            };

            this.RwBugsSegunEstados.LocalReport.SetParameters(parametros);

            this.RwBugsSegunEstados.RefreshReport();        }

        private void RwBugsSegunEstados_ReportExport(object sender, ReportExportEventArgs e)
        {

        }
    }
}
