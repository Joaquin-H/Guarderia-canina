using BTS_3k2_PAV.Entidades;
using BTS_3k2_PAV.Respositorios;
using System.Collections.Generic;

namespace BTS_3k2_PAV.Servicios
{
    public class PrioridadesServicio
    {
        private PrioridadesRepositorio repositorio;

        public PrioridadesServicio()
        {
            repositorio = new PrioridadesRepositorio();
        }

        public List<Prioridad> Obtener()
        {
            return repositorio.Get();
        }
    }
}
