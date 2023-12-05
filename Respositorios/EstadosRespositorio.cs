using BTS_3k2_PAV.Entidades;
using System;
using System.Collections.Generic;
using System.Data;

namespace BTS_3k2_PAV.Respositorios
{
    public class EstadosRepositorio
    {
        public List<Estado> Get()
        {
            var sql = $"SELECT * FROM Estados";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sql);
            var items = new List<Estado>();
            foreach (DataRow fila in tabla.Rows)
            {
                var objeto = new Estado();
                objeto.Id = Convert.ToInt64(fila["id_estado"].ToString());
                objeto.Nombre = fila["nombre"].ToString();
                items.Add(objeto);
            }
            return items;
        }
    }
}
