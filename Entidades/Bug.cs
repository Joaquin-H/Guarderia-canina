using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTS_3k2_PAV.Entidades
{
    // entidad base
    public class Bug: EntidadBase
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaAlta { get; set; }
        public Usuario Responsable { get; set; }
        public Usuario Asignado { get; set; }
        public Producto Producto { get; set; }
        public Prioridad Prioridad { get; set; }
        public Criticidad Criticidad { get; set; }
        public Estado Estado { get; set; }

        public void ValidarTitulo()
        {
            if (string.IsNullOrEmpty(Titulo))
                throw new ApplicationException("El título es requerido");
            if (!string.IsNullOrEmpty(Titulo) && Titulo.Length > 100)
                throw new ApplicationException("El título no debe superar los 100 caracteres");
        }

        public void ValidarDescripcion()
        {
            if (!string.IsNullOrEmpty(Descripcion) && Descripcion.Length > 1000)
                throw new ApplicationException("La descrición no debe superar los 1000 caracteres");
        }

        public void ValidarProducto()
        {
            if (Producto == null || Producto.Id == 0)
                throw new ApplicationException("El producto es requerido.");
        }

    }
}
