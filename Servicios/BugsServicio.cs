using BTS_3k2_PAV.Entidades;
using BTS_3k2_PAV.Entidades.Enums;
using BTS_3k2_PAV.Respositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTS_3k2_PAV.Servicios
{
    public class BugsServicio
    {
        private readonly BugsRepositorio repositorio;

        public BugsServicio()
        {
            repositorio = new BugsRepositorio();
        }

        public void RegistrarBug(Bug b)
        {
            b.FechaAlta = DateTime.Today;
            b.Responsable = UsuariosServicio.UsuarioLogueado;
            b.Estado = new Estado() { Id = (long) EstadosDisponibles.Nuevo };

            var hb = new HistoricoBug();
            hb.FechaRegistro = DateTime.Today;
            hb.Bug = b;

            repositorio.RegistrarBug(hb);
        }

        public void Validar(Bug bug)
        {
            bug.ValidarTitulo();
            bug.ValidarDescripcion();
            bug.ValidarProducto();
        }

        public void BarBaja(Bug b)
        {
            var h = new HistoricoBug();
            h.FechaRegistro = DateTime.Today;
            h.Bug = b;
            b.Estado = new Estado() { Id = (long) EstadosDisponibles.Baja};
            repositorio.BajaBug(h);
        }

        public List<Bug> Obtener(BugFiltros f)
        {
            return repositorio.Consultar(f);
        }

        public Bug GetBug(long id)
        {
            return repositorio.GetBug(id);
        }
    }
}
