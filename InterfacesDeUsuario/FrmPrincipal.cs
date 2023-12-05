using BTS_3k2_PAV.InterfacesDeUsuario.Bugs;
using BTS_3k2_PAV.InterfacesDeUsuario.Reportes;
using BTS_3k2_PAV.InterfacesDeUsuario.Reportes.BugsPorEstado;
using BTS_3k2_PAV.InterfacesDeUsuario.Usuarios;
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

namespace BTS_3k2_PAV.InterfacesDeUsuario
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            if(UsuariosServicio.UsuarioLogueado == null)
            {
                var frmLogin = new FrmLogin();
                frmLogin.ShowDialog();
                LblBienvenida.Text = $"Bienvenido {UsuariosServicio.UsuarioLogueado.NombreCompleto}.";
                LblBienvenida.Text += $"Perfil {UsuariosServicio.UsuarioLogueado.Perfil.Nombre}";
            }
            else
            {
                LblBienvenida.Text = $"Bienvenido {UsuariosServicio.UsuarioLogueado.NombreCompleto}.";
                LblBienvenida.Text += $"Perfil {UsuariosServicio.UsuarioLogueado.Perfil.Nombre}";
            }
            
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmUsuario = new FrmUsuarios(this);
            frmUsuario.Show();
            this.Hide();
        }

        private void bugsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmbugs = new FrmBugs(this);
            frmbugs.Show();
            Hide();
        }

        private void bugsSegúnEstadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmBugsPorEstado();
            frm.ShowDialog();
        }

        private void bugsFiltradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new BugsConFiltros();
            frm.ShowDialog();
        }
    }
}
