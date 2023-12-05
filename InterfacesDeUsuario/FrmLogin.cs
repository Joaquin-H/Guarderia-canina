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

namespace BTS_3k2_PAV
{
    public partial class FrmLogin : Form
    {
        private readonly UsuariosServicio usuariosServicio;
        public FrmLogin()
        {
            InitializeComponent();
            usuariosServicio = new UsuariosServicio();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario();
            usuario.NombreUsuario = TxtUsuario.Text.Trim();
            usuario.Contrasenia = TxtContrasenia.Text.Trim();

            if (usuariosServicio.Login(usuario))
            {
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña inválidas", "Información", MessageBoxButtons.OK);
            }
        }
    }
}
