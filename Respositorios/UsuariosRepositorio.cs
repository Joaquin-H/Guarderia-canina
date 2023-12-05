using BTS_3k2_PAV.Entidades;
using System;
using System.Collections.Generic;
using System.Data;

namespace BTS_3k2_PAV.Respositorios
{
    public class UsuariosRepositorio
    {
        private Usuario GetUsuarioHardcode()
        {
            var usuario = new Usuario();
            usuario.Id = 1;
            usuario.NombreCompleto = "Milagros Zea Cárdenas";
            usuario.NombreUsuario = "milagros";
            usuario.Contrasenia = "12345678";
            usuario.Email = "nzea@frc.utn.edu.ar";
            usuario.Estado = true;
            var perfil = new Perfil()
            {
                Id = 1,
                Nombre = "Administrador"
            };
            usuario.Perfil = perfil;
            return usuario;
        } 

        public Usuario Login(Usuario usuario)
        {
            var usuarioPermitido = GetUsuarioHardcode();
            if(usuario.NombreUsuario == usuarioPermitido.NombreUsuario
                && usuario.Contrasenia == usuarioPermitido.Contrasenia)
                return usuarioPermitido;
            return null;
        }

        public Usuario LoginBD(Usuario usuario)
        {
            var sql = $"SELECT u.*, p.nombre as perfil FROM Usuarios u LEFT JOIN Perfiles p ON u.id_perfil = p.id_perfil where activo='S' and usuario='{usuario.NombreUsuario}' and password='{usuario.Contrasenia}'";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            Usuario usuarioLoguado = null;
            if(tablaResultado.Rows.Count == 1)
            {
                var fila = tablaResultado.Rows[0];
                usuarioLoguado = new Usuario();
                usuarioLoguado.NombreUsuario = fila["usuario"].ToString();                
                usuarioLoguado.Id = Convert.ToInt64(fila["id_usuario"].ToString());
                usuario.Email = fila["email"].ToString();

                // activo
                var activo = fila["activo"].ToString();
                usuarioLoguado.Estado = activo == "S";

                // perfil
                var perfil = new Perfil();
                perfil.Nombre = fila["perfil"].ToString();
                perfil.Id = Convert.ToInt64(fila["id_perfil"].ToString());
                usuarioLoguado.Perfil = perfil;
            }

            return usuarioLoguado;
        }

        public List<Usuario> GetUsuarios()
        {
            var sql = $"SELECT u.*, p.nombre as perfil FROM Usuarios u LEFT JOIN Perfiles p ON u.id_perfil = p.id_perfil";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            var usuarios = new List<Usuario>();

            foreach (DataRow fila in tablaResultado.Rows)
            {
                var usuarioLogueado = new Usuario();
                usuarioLogueado.NombreUsuario = fila["usuario"].ToString();
                usuarioLogueado.Id = Convert.ToInt64(fila["id_usuario"].ToString());
                usuarioLogueado.Email = fila["email"].ToString();

                // activo
                var activo = fila["activo"].ToString();
                usuarioLogueado.Estado = activo == "S";

                // perfil
                var perfil = new Perfil();
                perfil.Nombre = fila["perfil"].ToString();
                perfil.Id = Convert.ToInt64(fila["id_perfil"].ToString());
                usuarioLogueado.Perfil = perfil;

                //agrego usuario a la lista usuarios
                usuarios.Add(usuarioLogueado);
            }

            return usuarios;
        }
        public List<Usuario> GetUsuarios(Usuario f, bool soloActivos)
        {
            var sql = $"SELECT u.*, p.nombre as perfil";
            sql += $" FROM Usuarios u LEFT JOIN Perfiles p";
            sql += $" ON u.id_perfil = p.id_perfil";
            sql += $" WHERE 1=1";
            if (!string.IsNullOrEmpty(f.NombreUsuario))
            {
                sql += $" AND u.usuario like '%{f.NombreUsuario}%'";
            }
            if (f.Perfil != null && f.Perfil.Id != 0)
            {
                sql += $" AND u.id_perfil={f.Perfil.Id}";
            }
            if (soloActivos)
            {
                sql += $" AND u.activo='S'";
            }

            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            var usuarios = new List<Usuario>();

            foreach (DataRow fila in tablaResultado.Rows)
            {
                var usuarioLogueado = new Usuario();
                usuarioLogueado.NombreUsuario = fila["usuario"].ToString();
                usuarioLogueado.Id = Convert.ToInt64(fila["id_usuario"].ToString());
                usuarioLogueado.Email = fila["email"].ToString();

                // activo
                var activo = fila["activo"].ToString();
                usuarioLogueado.Estado = activo == "S";

                // perfil
                var perfil = new Perfil();
                perfil.Nombre = fila["perfil"].ToString();
                perfil.Id = Convert.ToInt64(fila["id_perfil"].ToString());
                usuarioLogueado.Perfil = perfil;

                //agrego usuario a la lista usuarios
                usuarios.Add(usuarioLogueado);
            }

            return usuarios;
        }

        public Usuario GetUsuario(long id)
        {
            // completar
            // reutilizar mapeo de usuario
            var usuario = new Usuario();
            var sentenciaSql = $"SELECT u.*, p.nombre as perfil FROM Usuarios u LEFT JOIN Perfiles p ON u.id_perfil = p.id_perfil WHERE u.id_usuario={id}";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                usuario.NombreUsuario = fila["usuario"].ToString();
                usuario.Id = Convert.ToInt64(fila["id_usuario"].ToString());
                usuario.Email = fila["email"].ToString();

                // activo
                var activo = fila["activo"].ToString();
                usuario.Estado = activo == "S";

                // perfil
                var perfil = new Perfil();
                perfil.Nombre = fila["perfil"].ToString();                
                perfil.Id = Convert.ToInt64(fila["id_perfil"].ToString());
                usuario.Perfil = perfil;

                //agrego usuario a la lista usuario
            }
            return usuario;
        }

        public int RegistrarUsuario(Usuario u)
        {
            var sentenciaSQL = $"INSERT INTO Usuarios (id_perfil, usuario, password, email, activo) VALUES({u.Perfil.Id}, '{u.NombreUsuario}', '{u.Contrasenia}', '{u.Email}', 'S')";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSQL);
            return filasAfectadas;
        }

        public int ActualizarUsuario(Usuario u)
        {
            //completar
            var sentenciaSql = $"UPDATE Usuarios SET id_perfil='{u.Perfil.Id}', password='{u.Contrasenia}', email='{u.Email}' WHERE id_usuario={u.Id}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }

        public int DarBajaUsuario(Usuario u)
        {
            var activo = u.Estado ? "S" : "N" ;
            //UPDATE Usuarios SET id_perfil='{u.Perfil.Id}', password='{u.Contrasenia}', email='{u.Email}' WHERE id_usuario={u.Id}
            var sql = $"UPDATE Usuarios SET activo='{activo}' WHERE id_usuario={u.Id}";
            return DBHelper.GetDBHelper().EjecutarSQL(sql);
        }
    }
}
