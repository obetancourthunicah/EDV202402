using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaMedicaLib;

namespace ClinicaMedica
{
    public partial class FrmClinica : Form
    {
        private Clinica _clinica;
        private EModoFormulario _modo;
        public FrmClinica()
        {
            InitializeComponent();
            Clinica = new Clinica();
            Modo = EModoFormulario.Nuevo;
        }

        public Clinica Clinica { get => _clinica; set => _clinica = value; }
        public EModoFormulario Modo { get => _modo; set => _modo = value; }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            this._clinica = new Clinica(
                int.Parse(txtCodigo.Text),
                txtNombre.Text,
                txtDireccion.Text,
                txtTelefono.Text,
                cmbEstado.SelectedText == "Activa" ? "ACT" : "INA"
            );
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
