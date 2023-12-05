using BTS_3k2_PAV.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTS_3k2_PAV.Respositorios
{
    public class BugsRepositorio
    {
        public Bug GetBug(long id)
        {
            var sql = $"SELECT b.*, pro.nombre as producto, pri.nombre as prioridad, c.nombre as criticidad, e.nombre as estado, u.usuario as usuario_asignado, ur.usuario as usuario_responsable  FROM Bugs b LEFT JOIN Productos pro ON b.id_producto = pro.id_producto LEFT JOIN Prioridades pri ON b.id_prioridad = pri.id_prioridad LEFT JOIN Criticidades c ON b.id_criticidad = c.id_criticidad LEFT JOIN Estados e ON b.id_estado = e.id_estado LEFT JOIN Usuarios u ON b.id_usuario_asignado = u.id_usuario LEFT JOIN Usuarios ur ON b.id_usuario_responsable = ur.id_usuario WHERE b.id_bug={id}";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sql);
            if (tabla.Rows.Count == 1)
                return Mapear(tabla.Rows[0]);
            return null;
        }

        public List<Bug> Consultar(BugFiltros f)
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
            var bugs = new List<Bug>();
            foreach (DataRow fila in tabla.Rows)
            {
                var b = Mapear(fila);
                bugs.Add(b);
            }
            return bugs;
        }

        private Bug Mapear(DataRow fila)
        {
            var b = new Bug();
            b.Id = Convert.ToInt64(fila["id_bug"].ToString());
            b.Titulo = fila["titulo"].ToString();
            b.FechaAlta = Convert.ToDateTime(fila["fecha_alta"].ToString());
            if (!fila.IsNull("descripcion"))
                b.Descripcion = fila["descripcion"].ToString();
            if (fila.Table.Columns.Contains("usuario_responsable")
                && !fila.IsNull("usuario_responsable"))
            {
                b.Responsable = new Usuario
                {
                    NombreUsuario = fila["usuario_responsable"].ToString(),
                    Id = Convert.ToInt64(fila["id_usuario_responsable"])
                };
            }
            if (!fila.IsNull("id_usuario_asignado"))
            {
                b.Asignado = new Usuario()
                {
                    Id = Convert.ToInt64(fila["id_usuario_asignado"]),
                    NombreUsuario = fila["usuario_asignado"].ToString()
                };
            }
            if (!fila.IsNull("id_producto"))
            {
                b.Producto = new Producto()
                {
                    Id = Convert.ToInt64(fila["id_producto"]),
                    Nombre = fila["producto"].ToString()
                };
            }
            if (!fila.IsNull("id_prioridad"))
            {
                b.Prioridad = new Prioridad()
                {
                    Id = Convert.ToInt64(fila["id_prioridad"]),
                    Nombre = fila["prioridad"].ToString()
                };
            }
            if (!fila.IsNull("id_criticidad"))
            {
                b.Criticidad = new Criticidad()
                {
                    Id = Convert.ToInt64(fila["id_criticidad"]),
                    Nombre = fila["criticidad"].ToString()
                };
            }
            if (!fila.IsNull("id_estado"))
            {
                b.Estado = new Estado()
                {
                    Id = Convert.ToInt64(fila["id_estado"]),
                    Nombre = fila["estado"].ToString()
                };
            }
            return b;
        }

        public void RegistrarBug(HistoricoBug hb)
        {
            var sql = "INSERT INTO Bugs (titulo, descripcion, fecha_alta, id_usuario_responsable, id_producto, id_estado";
            if (hb.Bug.Criticidad.Id != 0)
                sql += ", id_criticidad";
            if (hb.Bug.Prioridad.Id != 0)
                sql += ", id_prioridad";
            sql += ")";
            sql += $" VALUES('{hb.Bug.Titulo}', '{hb.Bug.Descripcion}'";
            sql += $", '{hb.Bug.FechaAlta.ToString("yyyy-MM-dd")}', {hb.Bug.Responsable.Id}, {hb.Bug.Producto.Id}, {hb.Bug.Estado.Id}";
            if (hb.Bug.Criticidad.Id != 0)
                sql += $", {hb.Bug.Criticidad.Id}";
            if (hb.Bug.Prioridad.Id != 0)
                sql += $", {hb.Bug.Prioridad.Id}";
            sql += ")";

            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    hb.Bug.Id = DBHelper.GetDBHelper().EjecutarTransaccionSQL(sql);

                    var sqlHistorial = "INSERT INTO BugsHistorico (fecha_historico, titulo, descripcion, id_bug, id_usuario_responsable, id_producto, id_estado";
                    if (hb.Bug.Criticidad.Id != 0)
                        sqlHistorial += ", id_criticidad";
                    if (hb.Bug.Prioridad.Id != 0)
                        sqlHistorial += ", id_prioridad";
                    sqlHistorial += ")";
                    sqlHistorial += $" VALUES('{hb.FechaRegistro.ToString("yyyy-MM-dd")}', '{hb.Bug.Titulo}', '{hb.Bug.Descripcion}'";
                    sqlHistorial += $", {hb.Bug.Id}, {hb.Bug.Responsable.Id}, {hb.Bug.Producto.Id}, {hb.Bug.Estado.Id}";
                    if (hb.Bug.Criticidad.Id != 0)
                        sqlHistorial += $", {hb.Bug.Criticidad.Id}";
                    if (hb.Bug.Prioridad.Id != 0)
                        sqlHistorial += $", {hb.Bug.Prioridad.Id}";
                    sqlHistorial += ")";

                    DBHelper.GetDBHelper().EjecutarTransaccionSQL(sqlHistorial);
                    tx.Commit();
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    throw new ApplicationException("Hubo un problema al registrar. Intente nuevamente");

                }
                finally
                {
                    DBHelper.GetDBHelper().CloseConnection();
                }
            }
                


        }

        public void BajaBug(HistoricoBug hb)
        {
            var sql = $"UPDATE Bugs SET id_estado={hb.Bug.Estado.Id} where id_bug={hb.Bug.Id}";

            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    DBHelper.GetDBHelper().EjecutarUpdateTransaccionSQL(sql);

                    var sqlHistorial = "INSERT INTO BugsHistorico (fecha_historico, titulo, descripcion, id_bug, id_usuario_responsable, id_producto, id_estado";
                    if (hb.Bug.Criticidad.Id != 0)
                        sqlHistorial += ", id_criticidad";
                    if (hb.Bug.Prioridad.Id != 0)
                        sqlHistorial += ", id_prioridad";
                    sqlHistorial += ")";
                    sqlHistorial += $" VALUES('{hb.FechaRegistro.ToString("yyyy-MM-dd")}', '{hb.Bug.Titulo}', '{hb.Bug.Descripcion}'";
                    sqlHistorial += $", {hb.Bug.Id}, {hb.Bug.Responsable.Id}, {hb.Bug.Producto.Id}, {hb.Bug.Estado.Id}";
                    if (hb.Bug.Criticidad.Id != 0)
                        sqlHistorial += $", {hb.Bug.Criticidad.Id}";
                    if (hb.Bug.Prioridad.Id != 0)
                        sqlHistorial += $", {hb.Bug.Prioridad.Id}";
                    sqlHistorial += ")";

                    DBHelper.GetDBHelper().EjecutarTransaccionSQL(sqlHistorial);
                    tx.Commit();
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    throw new ApplicationException("Hubo un problema al registrar. Intente nuevamente");

                }
                finally
                {
                    DBHelper.GetDBHelper().CloseConnection();
                }
            }



        }
    }
}
