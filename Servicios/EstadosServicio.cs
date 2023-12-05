using BTS_3k2_PAV.Entidades;
using BTS_3k2_PAV.Respositorios;
using System.Collections.Generic;

namespace BTS_3k2_PAV.Servicios
{
    public class EstadosServicio
    {
        private EstadosRepositorio repositorio;

        public EstadosServicio()
        {
            repositorio = new EstadosRepositorio();
        }

        public List<Estado> Obtener()
        {
            return repositorio.Get();
        }
    }
}
