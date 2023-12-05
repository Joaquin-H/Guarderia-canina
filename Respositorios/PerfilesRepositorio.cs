using BTS_3k2_PAV.Entidades;
using System;
using System.Collections.Generic;
using System.Data;

namespace BTS_3k2_PAV.Respositorios
{
    public class PerfilesRepositorio
    {
        public List<Perfil> GetPerfiles()
        {
            var sql = $"SELECT * FROM Perfiles";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sql);
            var perfiles = new List<Perfil>();
            foreach (DataRow fila in tabla.Rows)
            {
                var perfil = new Perfil();
                perfil.Id = Convert.ToInt64(fila["id_perfil"].ToString());
                perfil.Nombre = fila["nombre"].ToString();
                perfiles.Add(perfil);
            }
            return perfiles;
        }
    }
}
