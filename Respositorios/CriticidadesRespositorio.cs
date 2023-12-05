using BTS_3k2_PAV.Entidades;
using System;
using System.Collections.Generic;
using System.Data;

namespace BTS_3k2_PAV.Respositorios
{
    public class CriticidadesRepositorio
    {
        public List<Criticidad> Get()
        {
            var sql = $"SELECT * FROM Criticidades";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sql);
            var items = new List<Criticidad>();
            foreach (DataRow fila in tabla.Rows)
            {
                var objeto = new Criticidad();
                objeto.Id = Convert.ToInt64(fila["id_criticidad"].ToString());
                objeto.Nombre = fila["nombre"].ToString();
                items.Add(objeto);
            }
            return items;
        }
    }
}
