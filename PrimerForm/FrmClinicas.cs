using ClinicaMedicaLib;
using ClinicaMedicaLib.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaMedica
{
    public partial class FrmClinicas : Form
    {
        private List<Clinica> _clinicas;
        private WWClinicas _wwClinicas;
        private Clinica _clinicaSeleccionada;
        public FrmClinicas()
        {
            InitializeComponent();
            _wwClinicas = new WWClinicas();
            _clinicas = _wwClinicas.obtenerClinicas();
            bindingClinicas.DataSource = _clinicas;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count >= 1)
            {
                _clinicaSeleccionada = (Clinica)dataGridView1.SelectedRows[0].DataBoundItem;
            }
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            if (_clinicaSeleccionada != null)
            {
                MessageBox.Show("Detalle de " + _clinicaSeleccionada.Nombre);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (_clinicaSeleccionada != null)
            {
                MessageBox.Show("Editando " + _clinicaSeleccionada.Nombre);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_clinicaSeleccionada != null)
            {
                MessageBox.Show("Eliminado " + _clinicaSeleccionada.Nombre);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Creando nueva clinica");
        }
    }
}
