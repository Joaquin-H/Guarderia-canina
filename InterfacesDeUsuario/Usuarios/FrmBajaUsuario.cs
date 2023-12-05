using BTS_3k2_PAV.Entidades;
using BTS_3k2_PAV.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTS_3k2_PAV.InterfacesDeUsuario.Usuarios
{
    public partial class FrmBajaUsuario : Form
    {
        private readonly UsuariosServicio usuariosServicio;
        private readonly PerfilesServicio perfilesServicio;
        private readonly Usuario usuario;

        public FrmBajaUsuario(long id)
        {
            usuariosServicio = new UsuariosServicio();
            perfilesServicio = new PerfilesServicio();
            usuario = usuariosServicio.GetUsuario(id);
            InitializeComponent();
        }

        private void FrmBajaUsuario_Load(object sender, EventArgs e)
        {
            CargarDatos();
            CargarPerfiles();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (UsuarioConfirma())
                {
                    DarBajaUsuario();
                    Dispose();
                }
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error. Intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool UsuarioConfirma()
        {
            var opcion = MessageBox.Show("¿Confirma la baja del usuario?",
                "Confirmación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            return opcion == DialogResult.Yes;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            CerrarFormulario();
        }

        private void CerrarFormulario()
        {
            this.Dispose();
        }

        

        private void DarBajaUsuario()
        {
            var inactivo = RbInactivo.Checked;
            if (inactivo)
                usuario.Estado = false;
            else
                usuario.Estado = true;
            usuariosServicio.DarBajaUsuario(usuario);
            MessageBox.Show("La operación se realizó con éxito", "Información");
        }

        private void CargarDatos()
        {
            TxtNombre.Text = usuario.NombreUsuario;
            TxtEmail.Text = usuario.Email;
            if (usuario.Estado)
            {
                RbActivo.Checked = true;
                RbInactivo.Checked = false;
            }
            else
            {
                RbActivo.Checked = false;
                RbInactivo.Checked = true;
            }
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
    }
}
