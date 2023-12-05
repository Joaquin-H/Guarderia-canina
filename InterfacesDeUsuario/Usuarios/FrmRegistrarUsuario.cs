using BTS_3k2_PAV.Entidades;
using BTS_3k2_PAV.Servicios;
using System;
using System.Windows.Forms;

namespace BTS_3k2_PAV.InterfacesDeUsuario.Usuarios
{
    public partial class FrmRegistrarUsuario : Form
    {
        private readonly UsuariosServicio usuariosServicio;
        private readonly PerfilesServicio perfilesServicio;
        private Usuario usuario;

        public FrmRegistrarUsuario()
        {
            usuariosServicio = new UsuariosServicio();
            perfilesServicio = new PerfilesServicio();
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsOperacionConfirmada())
                    return;
                if (!EsUsuarioValido())
                    return;
                RegistrarUsuario();
            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                var mensaje = ex.Message;
                MessageBox.Show("Ha ocurrido un problema, intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void FrmRegistrarUsuario_Load(object sender, EventArgs e)
        {
            CargarPerfiles();
        }

        private void RegistrarUsuario()
        {
            if (!usuariosServicio.RegistrarUsuario(usuario))
            {
                MessageBox.Show("Ocurrió un problema al registrar el usuario", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("El usuario se registró con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }

        private bool EsOperacionConfirmada()
        {
            var respuesta = MessageBox.Show("Desea confirmar la operación", "Confirmación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
                return true;
            return false;
        }


        private bool EsUsuarioValido()
        {
            var password = TxtPassword.Text;
            var repassword = TxtRePassword.Text;
            if (password != repassword)
            {
                MessageBox.Show("La constraseña no coincide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            var nombre = TxtNombre.Text;
            var perfil = (Perfil)CbPerfiles.SelectedItem;
            var email = TxtEmail.Text;

            var usuarioIngresado = new Usuario();
            usuarioIngresado.NombreUsuario = nombre;
            usuarioIngresado.Email = email;
            usuarioIngresado.Contrasenia = password;
            usuarioIngresado.Perfil = perfil;
            usuariosServicio.ValidarUsuario(usuarioIngresado);
            usuario = usuarioIngresado;
            return true;
        }

        private void CargarPerfiles()
        {
            var perfiles = perfilesServicio.GetPerfiles();

            var perfilDefault = new Perfil();
            perfilDefault.Nombre = "Seleccionar";
            perfiles.Add(perfilDefault);

            var conector = new BindingSource();
            conector.DataSource = perfiles;

            CbPerfiles.DataSource = conector;
            CbPerfiles.DisplayMember = "Nombre";
            CbPerfiles.ValueMember = "Id";
            CbPerfiles.SelectedItem = perfilDefault;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmRegistrarUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
