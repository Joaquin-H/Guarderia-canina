using BTS_3k2_PAV.Entidades;
using BTS_3k2_PAV.Respositorios;
using System.Collections.Generic;

namespace BTS_3k2_PAV.Servicios
{
    public class ProductosServicio
    {
        private ProductosRepositorio repositorio;

        public ProductosServicio()
        {
            repositorio = new ProductosRepositorio();
        }

        public List<Producto> Obtener()
        {
            return repositorio.Get();
        }
    }
}
