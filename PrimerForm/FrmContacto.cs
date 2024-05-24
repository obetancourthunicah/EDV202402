using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerForm
{
    public partial class FrmContacto : Form
    {
        private string _name;
        private string _email;
        private string _phone;

        private bool _isConfirmed = false;
        public FrmContacto()
        {
            InitializeComponent();
        }

        public string ContactName { get => _name; set => _name = value; }
        public string ContactEmail { get => _email; set => _email = value; }
        public string ContactPhone { get => _phone; set => _phone = value; }
        public bool IsConfirmed { get => _isConfirmed; set => _isConfirmed = value; }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsConfirmed = false;
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            this.ContactName = this.txtNombre.Text;
            this.ContactEmail = this.txtEmail.Text;
            this.ContactPhone = this.txtTelefono.Text;

            this.IsConfirmed = true;
            this.Close();
        }
    }
}
