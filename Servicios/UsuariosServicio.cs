using BTS_3k2_PAV.Entidades;
using BTS_3k2_PAV.Respositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTS_3k2_PAV.Servicios
{
    public class UsuariosServicio
    {
        private readonly UsuariosRepositorio usuariosRepositorio;
        public static Usuario UsuarioLogueado;

        public UsuariosServicio()
        {
            usuariosRepositorio = new UsuariosRepositorio();    
        }

        public bool Login(Usuario usuario)
        {
            var usuarioLogueado = usuariosRepositorio.LoginBD(usuario);   
            if (usuarioLogueado == null)
                return false;
            UsuarioLogueado = usuarioLogueado;
            return true;
        }

        public List<Usuario> GetUsuarios()
        {
            return usuariosRepositorio.GetUsuarios();
        }

        public List<Usuario> GetUsuarios(Usuario filtros, bool soloActivo)
        {
            return usuariosRepositorio.GetUsuarios(filtros, soloActivo);
        }

        public void ValidarUsuario(Usuario usuario)
        {
            usuario.ValidarNombre();
            usuario.ValidarPassword();
            usuario.ValidarEmail();
        }

        public bool RegistrarUsuario(Usuario usuario)
        {
            if (usuario == null)
                throw new ApplicationException("Usuario Requerido");
            var filasAfectadas = usuariosRepositorio.RegistrarUsuario(usuario);
            if (filasAfectadas == 1)
                return true;
            return false;
        }

        public void ActualizarUsuario(Usuario u)
        {
            var filasAfectadas = usuariosRepositorio.ActualizarUsuario(u);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al actualizar");
        }

        public Usuario GetUsuario(long id)
        {
            var usuario = usuariosRepositorio.GetUsuario(id);
            return usuario;
        }

        public void DarBajaUsuario(Usuario u)
        {
            var filasAfectadas = usuariosRepositorio.DarBajaUsuario(u);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al dar de baja al usuario");
        }

    }
}
