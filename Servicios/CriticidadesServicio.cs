using BTS_3k2_PAV.Entidades;
using BTS_3k2_PAV.Respositorios;
using System.Collections.Generic;

namespace BTS_3k2_PAV.Servicios
{
    public class CriticidadesServicio
    {
        private CriticidadesRepositorio repositorio;

        public CriticidadesServicio()
        {
            repositorio = new CriticidadesRepositorio();
        }

        public List<Criticidad> Obtener()
        {
            return repositorio.Get();
        }
    }
}
