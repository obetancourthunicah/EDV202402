using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicasMedicasDao;
using ClinicasMedicasDao.ClinicaMedicaDataSetTableAdapters;

namespace ClinicaMedicaLib.Controladores
{
    public class WWClinicas
    {
        private List<Clinica> _clinicas;
        private ClinicasTableAdapter _adapter;
        private ClinicaMedicaDataSet _clinicalDataSet;
        public WWClinicas()
        {
            _clinicas = new List<Clinica>();
            _adapter = new ClinicasTableAdapter();
            _clinicalDataSet = ClinicasMedicasDao.DataContext.getClinicaMedicaDataset();
        }

        public List<Clinica> obtenerClinicas() {
            _adapter.Fill(_clinicalDataSet.Clinicas);
            FillClinicas();
            return _clinicas;
        }



        private void FillClinicas() {
            _clinicas.Clear();
            foreach (ClinicaMedicaDataSet.ClinicasRow clinica in _clinicalDataSet.Clinicas.Rows) {
                _clinicas.Add(new Clinica(
                        clinica.Id,
                        clinica.Nombre,
                        clinica.Direccion,
                        clinica.Telefono,
                        clinica.Estado
                    )
                );
            }
        }

    }
}
