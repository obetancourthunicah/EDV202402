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

        public Boolean agregarClinica(Clinica clinica) {
            try {
                _adapter.Insert(clinica.Codigo,clinica.Nombre, clinica.Direccion, clinica.Telefono, clinica.Estado);
                _adapter.Fill(_clinicalDataSet.Clinicas);
                this.FillClinicas();
                return true;
            } catch (Exception e) {
                return false;
            }
        }

        public Boolean editarClinica(Clinica clinica, Clinica originaClinica)
        {
            try
            {
                _adapter.Update(
                    clinica.Nombre,
                    clinica.Direccion,
                    clinica.Telefono,
                    clinica.Estado,
                    originaClinica.Codigo,
                    originaClinica.Nombre,
                    originaClinica.Direccion,
                    originaClinica.Telefono,
                    originaClinica.Estado
                );
                _adapter.Fill(_clinicalDataSet.Clinicas);
                this.FillClinicas();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public Boolean eliminarClinica(Clinica clinica) {
            try
            {
                _adapter.Delete(
                    clinica.Codigo,
                    clinica.Nombre,
                    clinica.Direccion,
                    clinica.Telefono,
                    clinica.Estado
                 );
                _adapter.Fill(_clinicalDataSet.Clinicas);
                this.FillClinicas();
                return true;
            }
            catch (Exception ex) {
                return false;
            }
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
