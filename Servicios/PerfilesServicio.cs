using BTS_3k2_PAV.Entidades;
using BTS_3k2_PAV.Respositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTS_3k2_PAV.Servicios
{
    public class PerfilesServicio
    {
        private readonly PerfilesRepositorio perfilesRepositorio;

        public PerfilesServicio()
        {
            perfilesRepositorio = new PerfilesRepositorio();
        }

        public List<Perfil> GetPerfiles()
        {
            return perfilesRepositorio.GetPerfiles();
        }
    }
}
