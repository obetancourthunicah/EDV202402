using ClinicaMedicaLib.Controladores.Seguridad;
using ClinicaMedicaLib.Seguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaMedica.Seguridad
{
    public partial class FrmLogin : Form
    {
        public Usuario UsuarioSesion { get; set; }

        private Usuarios usuarioController;
        public FrmLogin()
        {
            InitializeComponent();
            usuarioController = new Usuarios();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            UsuarioSesion = usuarioController.Login(txtUsuario.Text, txtPassword.Text);
            if (UsuarioSesion != null)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
