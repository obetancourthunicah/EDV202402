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
                FrmClinica mostrarForm = new FrmClinica();
                mostrarForm.Modo = EModoFormulario.Consultar;
                mostrarForm.Clinica = _clinicaSeleccionada;
                mostrarForm.ShowDialog();
                mostrarForm.Dispose();
                mostrarForm = null;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if ( _clinicaSeleccionada != null) { 
                FrmClinica editarForm = new FrmClinica();
                editarForm.Modo = EModoFormulario.Modificar;
                editarForm.Clinica = _clinicaSeleccionada;
                if (editarForm.ShowDialog() == DialogResult.OK)
                {
                    Boolean clinicaModificada = _wwClinicas.editarClinica(editarForm.Clinica, _clinicaSeleccionada);
                    if (clinicaModificada)
                    {
                        _clinicas = _wwClinicas.obtenerClinicas();
                        bindingClinicas.ResetBindings(false);
                    }
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_clinicaSeleccionada != null)
            {
                FrmClinica eliminarForm = new FrmClinica();
                eliminarForm.Modo = EModoFormulario.Eliminar;
                eliminarForm.Clinica = _clinicaSeleccionada;
                if (eliminarForm.ShowDialog() == DialogResult.OK)
                {
                    Boolean clinicaEliminada = _wwClinicas.eliminarClinica(eliminarForm.Clinica);
                    if (clinicaEliminada)
                    {
                        _clinicas = _wwClinicas.obtenerClinicas();
                        bindingClinicas.ResetBindings(false);
                    }
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmClinica nuevaClinica = new FrmClinica();
            nuevaClinica.Modo = EModoFormulario.Nuevo;
            if (nuevaClinica.ShowDialog() == DialogResult.OK)
            {
                Boolean clinicaAgregada =  _wwClinicas.agregarClinica(nuevaClinica.Clinica);
                if (clinicaAgregada) {
                    _clinicas = _wwClinicas.obtenerClinicas();
                    bindingClinicas.ResetBindings(false);
                }   
            }
            nuevaClinica.Dispose();
            nuevaClinica = null;
        }
    }
}
