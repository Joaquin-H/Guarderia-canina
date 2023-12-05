using BTS_3k2_PAV.Entidades;
using BTS_3k2_PAV.Servicios;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BTS_3k2_PAV.InterfacesDeUsuario.Usuarios
{
    public partial class FrmEditarUsuario : Form
    {
        private Usuario usuario;
        private readonly UsuariosServicio usuariosServicio;
        private readonly PerfilesServicio perfilesServicio;

        public FrmEditarUsuario(int id)
        {
            usuariosServicio = new UsuariosServicio();
            perfilesServicio = new PerfilesServicio();
            usuario = usuariosServicio.GetUsuario(id);
            InitializeComponent();
        }

        private void FrmEditarUsuario_Load(object sender, EventArgs e)
        {
            CargarDatos();
            CargarPerfiles();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Confirmar operación", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Cancel)
                    return;
                ValidarUsuario();
                ActualizarUsuario();
                CerrarFormulario();
            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CerrarFormulario()
        {
            Dispose();
        }

        private void ValidarUsuario()
        {
            var password = TxtPassword.Text;
            var repassword = TxtRePassword.Text;
            if (password != repassword)
            {
                throw new ApplicationException("La constraseña no coincide");
            }
            usuario.Contrasenia = password;
            usuario.Perfil = (Perfil)CbPerfiles.SelectedItem;
            usuario.Email = TxtEmail.Text;
            usuariosServicio.ValidarUsuario(usuario);
        }

        private void ActualizarUsuario()
        {
            usuariosServicio.ActualizarUsuario(usuario);
            MessageBox.Show("Se actualizó el usuario con éxito", "Información");
        }


        private void CargarPerfiles()
        {
            var perfiles = perfilesServicio.GetPerfiles();

            var conector = new BindingSource();
            conector.DataSource = perfiles;

            CbPerfiles.DataSource = conector;
            CbPerfiles.DisplayMember = "Nombre";
            CbPerfiles.ValueMember = "Id";

            // busco perfil del usuario actual
            var perfilSeleccionado = perfiles.First(p => p.Id == usuario.Perfil.Id);
            CbPerfiles.SelectedItem = perfilSeleccionado;
        }

        private void CargarDatos()
        {
            TxtNombre.Text = usuario.NombreUsuario;
            TxtPassword.Text = usuario.Contrasenia;
            TxtRePassword.Text = usuario.Contrasenia;
            TxtEmail.Text = usuario.Email;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            CerrarFormulario();
        }

        private void FrmEditarUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            CerrarFormulario();
        }
    }
}
