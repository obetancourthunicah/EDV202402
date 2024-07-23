using PrimerForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaMedicaLib.Controladores.Seguridad;
using ClinicaMedica.Seguridad;
using ClinicaMedicaLib.Seguridad;

namespace ClinicaMedica
{
    public partial class Main : Form
    {
        private int childFormNumber = 0;
        private Usuarios usuarios = new Usuarios();
        private bool isLogged = false;
        private Usuario usuario;
        public Main()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            usuarios.VerificarSeguridad();

            if(!isLogged)
            {
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.ShowDialog();
                if (frmLogin.UsuarioSesion != null && frmLogin.DialogResult == DialogResult.OK)
                {
                    isLogged = true;
                    usuario = frmLogin.UsuarioSesion;
                    menuOpcClinicas.Visible = usuarios.IsAuthorized(usuario.Codigo, "MnuClinicas");
                    menuOptContactos.Visible = usuarios.IsAuthorized(usuario.Codigo, "MnuContactos");

                    toolStripStatusLabel.Text = "Usuario: " + usuario.User;
                }
                else {
                    Close();
                }
                
            }
        }

        private void menuOpcClinicas_Click(object sender, EventArgs e)
        {
            FrmClinicas frmClinicas = new FrmClinicas();
            frmClinicas.MdiParent = this;
            frmClinicas.Show();
        }

        private void menuOptContactos_Click(object sender, EventArgs e)
        {
            FrmContactos frmContactos = new FrmContactos();
            frmContactos.MdiParent = this;
            frmContactos.Show();
        }

        private void menuOptsPokemonClient_Click(object sender, EventArgs e)
        {
            WebApi frmPokemon = new WebApi();
            frmPokemon.MdiParent = this;
            frmPokemon.Show();
        }
    }
}
