using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicasMedicasDao
{
    public class DataContext
    {
        private static ClinicaMedicaDataSet _data;

        public static ClinicaMedicaDataSet getClinicaMedicaDataset()
        {
            if (_data == null)
            {
                _data = new ClinicaMedicaDataSet();
            }
            return _data;
        }

        private DataContext() { }
    }
}
