﻿using BTS_3k2_PAV.Entidades;
using System;
using System.Collections.Generic;
using System.Data;

namespace BTS_3k2_PAV.Respositorios
{
    public class ProductosRepositorio
    {
        public List<Producto> Get()
        {
            var sql = $"SELECT * FROM Productos";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sql);
            var items = new List<Producto>();
            foreach (DataRow fila in tabla.Rows)
            {
                var objeto = new Producto();
                objeto.Id = Convert.ToInt64(fila["id_producto"].ToString());
                objeto.Nombre = fila["nombre"].ToString();
                items.Add(objeto);
            }
            return items;
        }
    }
}
