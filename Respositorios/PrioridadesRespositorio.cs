using BTS_3k2_PAV.Entidades;
using System;
using System.Collections.Generic;
using System.Data;

namespace BTS_3k2_PAV.Respositorios
{
    public class PrioridadesRepositorio
    {
        public List<Prioridad> Get()
        {
            var sql = $"SELECT * FROM Prioridades";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sql);
            var items = new List<Prioridad>();
            foreach (DataRow fila in tabla.Rows)
            {
                var objeto = new Prioridad();
                objeto.Id = Convert.ToInt64(fila["id_prioridad"].ToString());
                objeto.Nombre = fila["nombre"].ToString();
                items.Add(objeto);
            }
            return items;
        }
    }
}
