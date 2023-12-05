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
    public partial class FrmUsuarios : Form
    {
        private readonly UsuariosServicio usuariosServicio;
        private readonly FrmPrincipal frmPrincipal;
        private readonly PerfilesServicio perfilesServicio;

        public FrmUsuarios(FrmPrincipal _principal)
        {
            frmPrincipal = _principal;
            usuariosServicio = new UsuariosServicio();
            perfilesServicio = new PerfilesServicio();
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {

        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            CargarPerfiles();
            ConsultarUsuarios(new Usuario(), true);
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

        private void ConsultarUsuarios(Usuario filtros, bool soloActivos)
        {
            var usuarios = usuariosServicio.GetUsuarios(filtros, soloActivos);
            DGVUsuarios.Rows.Clear();
            foreach (var usuario in usuarios)
            {
                var estado = usuario.Estado ? "Activo" : "Inactivo";
                var fila = new string[]
                {
                    usuario.Id.ToString(),
                    usuario.NombreUsuario,
                    usuario.Email,
                    estado,
                    usuario.Perfil.Nombre
                };
                DGVUsuarios.Rows.Add(fila);
            }
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            var filtros = new Usuario();
            filtros.NombreUsuario = TxtNombre.Text.Trim();
            filtros.Perfil = (Perfil)CbPerfiles.SelectedItem;
            var soloActivos = !CkIncluirInactivos.Checked;
            ConsultarUsuarios(filtros,soloActivos);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            CerrarFormulario();
        }

        private void CerrarFormulario()
        {
            frmPrincipal.Show();
            Dispose();
        }

        private void FrmUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            CerrarFormulario();
        }

        private void BtnDarBaja_Click(object sender, EventArgs e)
        {
            if (DGVUsuarios.SelectedRows.Count == 1)
            {
                var id = Convert.ToInt64(DGVUsuarios.SelectedRows[0].Cells["Id"].Value);
                new FrmBajaUsuario(id).ShowDialog();
                ConsultarUsuarios(new Usuario(), true);
                return;
            }
            if (DGVUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un registro.", "Información", MessageBoxButtons.OK);
                return;
            }
            if (DGVUsuarios.SelectedRows.Count > 1)
            {
                MessageBox.Show("Debe seleccionar solo un registro, no muchos.", "Información", MessageBoxButtons.OK);
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            new FrmRegistrarUsuario().ShowDialog();
            ConsultarUsuarios(new Usuario(), true);
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (DGVUsuarios.SelectedRows.Count == 1)
            {
                var id = Convert.ToInt32(DGVUsuarios.SelectedRows[0].Cells["Id"].Value);
                new FrmEditarUsuario(id).ShowDialog();
                ConsultarUsuarios(new Usuario(), true);
                return;
            }
            if (DGVUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un registro.", "Información", MessageBoxButtons.OK);
                return;
            }
            if (DGVUsuarios.SelectedRows.Count > 1)
            {
                MessageBox.Show("Debe seleccionar solo un registro, no muchos.", "Información", MessageBoxButtons.OK);
            }
        }
    }
}
