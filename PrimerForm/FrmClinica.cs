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

        private void setClientToControls() {
            if (_clinica.Codigo != 0)
            {
                txtCodigo.Text = _clinica.Codigo.ToString();
                txtNombre.Text = _clinica.Nombre;
                txtDireccion.Text = _clinica.Direccion;
                txtTelefono.Text = _clinica.Telefono;
                cmbEstado.Text = _clinica.Estado == "ACT" ? "Activo" : "Inactivo";
                txtCodigo.ReadOnly = true;
                setReadOnly();
                establecerTitulo();
            }
        }

        private void establecerTitulo() {
            if (_modo == EModoFormulario.Nuevo)
            {
                tituloFormulario.Text = "Ingresando Nueva Clinica";
                Text = "Ingresando Nueva Clinica";
            }
            if (_clinica.Codigo > 0)
            {
                switch (_modo)
                {
                    case EModoFormulario.Modificar:
                        tituloFormulario.Text = "Modificando Clinica" ;
                        Text = "Modificando Clinica";
                        break;
                    case EModoFormulario.Eliminar:
                        tituloFormulario.Text = "Eliminando Clinica";
                        Text = "Eliminando Clinica";
                        break;
                    case EModoFormulario.Consultar:
                        tituloFormulario.Text = "Detalle de Clinica";
                        Text = "Detalle de Clinica";
                        break;
                }
            }

        }
        private void setReadOnly() {
            if (_modo == EModoFormulario.Consultar || _modo == EModoFormulario.Eliminar)
            {
                txtNombre.ReadOnly = true;
                txtDireccion.ReadOnly = true;
                txtTelefono.ReadOnly = true;
                cmbEstado.Enabled = false;
                if(_modo == EModoFormulario.Consultar)
                {
                    btnConfirmar.Visible = false;
                }
            }
        }

        public Clinica Clinica
        {
            get => _clinica;
            set { 
                _clinica = value;
                setClientToControls();
            }
        }
        public EModoFormulario Modo
        {
            get => _modo; 
            set {
                switch (value)
                {
                    case EModoFormulario.Modificar:
                    case EModoFormulario.Eliminar:
                    case EModoFormulario.Consultar:
                        setClientToControls();
                        break;
                    case EModoFormulario.Nuevo:
                        break;
                }
                _modo = value;
            }
        }

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
                cmbEstado.Text == "Activo" ? "ACT" : "INA"
            );
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
