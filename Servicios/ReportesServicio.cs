using BTS_3k2_PAV.Entidades;
using BTS_3k2_PAV.Respositorios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTS_3k2_PAV.Servicios
{
    public class ReportesServicio
    {
        private readonly ReportesRepositorio respositorio;

        public ReportesServicio()
        {
            this.respositorio = new ReportesRepositorio();
        }

        public DataTable BugsPorEstado()
        {
            return respositorio.ObtenerBugsPorEstado();
        }


        public DataTable Usuarios()
        {
            return respositorio.ReporteUsuarios();
        }

        public DataTable BugsPorFiltros(BugFiltros f)
        {
            return respositorio.BugsPorFiltros(f);
        }
    }
}
