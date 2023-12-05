using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTS_3k2_PAV.Entidades
{
    //public class HistoricoBug: EntidadBase
    public class HistoricoBug: EntidadBase
    {
        public DateTime FechaRegistro { get; set; }

        public Bug Bug { get; set; }
    }
}
