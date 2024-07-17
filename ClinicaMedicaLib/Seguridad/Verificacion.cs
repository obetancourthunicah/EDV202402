using DocumentFormat.OpenXml.Office.CoverPageProps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedicaLib.Seguridad
{
    public class Verificacion
    {
        private string estado;
        public string Codigo { get; set; }
        public string Descripcion { get; set; }

        public string Estado
        {
            get=>estado; set
            {
                if (value == ECommonStatus.ACT || value == ECommonStatus.INA)
                {
                    this.estado = value;
                } else
                {
                    throw new Exception("Estado no valido");
                }

            }
        }

        public Verificacion()
        {
            Codigo = "";
            Descripcion = "";
            Estado = ECommonStatus.ACT;
        }

        public Verificacion(string codigo, string descripcion, string estado)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            Estado = estado;
        }

    }
}
