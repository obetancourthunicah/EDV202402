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
using ClinicasMedicasDao;

namespace PrimerForm
{
    public partial class Medico : Form
    {
        private ClinicaMedicaLib.Medico Medico1;
        private ClinicaMedicaLib.Medico Medico2;
        public List<ClinicaMedicaLib.Medico> Medicos;

        public Medico()
        {
            InitializeComponent();
            Medicos = new List<ClinicaMedicaLib.Medico>();
            Medico1 = new ClinicaMedicaLib.Medico("1", "Adriana Betancourth", "correo@uncorreo.com", "21312312", "Intensivo e Infectologia");
            Medico2 = new ClinicaMedicaLib.Medico("2", "Josue Betancourth", "correo@uncorreo.com", "21312312", "Cirugia Pediatrica");

            Medicos.Add(Medico1);
            Medicos.Add(Medico2);
            
            lblTexto.Text = Medico1.obtenerPerfil();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarAExcel excel = new ExportarAExcel();
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string archivoAGuardar = saveDialog.FileName;
                excel.ExportarListaAExcel(Medicos, archivoAGuardar);
                MessageBox.Show("Archivo Guardado Exitosamente");
            }

        }
    }
}
