using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTS_3k2_PAV.Entidades
{
    public class BugFiltros
    {
        public DateTime? FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        public long? IdProducto { get; set; }
        public long? IdPrioridad { get; set; }
        public long? IdCriticidad { get; set; }
        public long? IdEstado { get; set; }
        public long? IdUsuarioAsignado { get; set; }
        public string Estado { get; set; }
    }
}
