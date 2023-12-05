using BTS_3k2_PAV.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTS_3k2_PAV.Respositorios
{
    public class ReportesRepositorio
    {

        public DataTable ObtenerBugsPorEstado()
        {
            var sql = "Select  Count(b.id_bug) as Cantidad, e.nombre as Categoria from Bugs b JOIN Estados e ON b.id_estado = e.id_estado Group By b.id_estado, e.nombre";
            var datatable = DBHelper.GetDBHelper().ConsultaSQL(sql);    
            return datatable;
        }

        public DataTable ReporteUsuarios()
        {
            var sql = "SELECT u.*, p.nombre as perfil FROM Usuarios u LEFT JOIN Perfiles p ON u.id_perfil = p.id_perfil";
            var dataTable = DBHelper.GetDBHelper().ConsultaSQL(sql);
            return dataTable;
        }

        public DataTable BugsPorFiltros(BugFiltros f)
        {
            var sql = $"SELECT b.*, pro.nombre as producto, pri.nombre as prioridad, c.nombre as criticidad, e.nombre as estado, u.usuario as usuario_asignado, ur.usuario as usuario_responsable  FROM Bugs b LEFT JOIN Productos pro ON b.id_producto = pro.id_producto LEFT JOIN Prioridades pri ON b.id_prioridad = pri.id_prioridad LEFT JOIN Criticidades c ON b.id_criticidad = c.id_criticidad LEFT JOIN Estados e ON b.id_estado = e.id_estado LEFT JOIN Usuarios u ON b.id_usuario_asignado = u.id_usuario LEFT JOIN Usuarios ur ON b.id_usuario_responsable = ur.id_usuario WHERE 1=1";
            if (f.FechaDesde.HasValue)
                sql += $" AND b.fecha_alta > '{f.FechaDesde.Value.ToString("yyyy-MM-dd")}'";
            if (f.FechaHasta.HasValue)
                sql += $" AND b.fecha_alta < '{f.FechaHasta.Value.ToString("yyyy-MM-dd")}'";
            if (f.IdPrioridad.HasValue && f.IdPrioridad != 0)
                sql += $" AND b.id_prioridad={f.IdPrioridad}";
            if (f.IdEstado.HasValue && f.IdEstado != 0)
                sql += $" AND b.id_estado={f.IdEstado}";
            if (f.IdCriticidad.HasValue && f.IdCriticidad != 0)
                sql += $" AND b.id_criticidad={f.IdCriticidad}";
            if (f.IdProducto.HasValue && f.IdProducto != 0)
                sql += $" AND b.id_producto={f.IdProducto}";
            if (f.IdUsuarioAsignado.HasValue && f.IdUsuarioAsignado != 0)
                sql += $" AND b.id_usuario_asignado={f.IdUsuarioAsignado}";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sql);
            return tabla;
        }

    }
}
