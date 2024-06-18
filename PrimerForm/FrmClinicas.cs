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
        public FrmClinicas()
        {
            InitializeComponent();
            _wwClinicas = new WWClinicas();
            _clinicas = _wwClinicas.obtenerClinicas();
            bindingClinicas.DataSource = _clinicas;
        }
    }
}
