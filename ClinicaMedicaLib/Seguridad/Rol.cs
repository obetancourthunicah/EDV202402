using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedicaLib.Seguridad
{
    public class Rol
    {
        private string estado;
        public string Codigo { get; set; }
        public string Descripcion { get; set; }

        public string Estado { get=>estado; set { 
                if (value == ECommonStatus.ACT || value == ECommonStatus.INA)
                {
                    this.estado = value;
                } else
                {
                    throw new Exception("Estado no valido");
                }
            }
        }

        public Rol()
        {
            Codigo = "";
            Descripcion = "";
            Estado = ECommonStatus.ACT;
        }

        public Rol(string codigo, string descripcion, string estado)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            Estado = estado;
        }
    }
}
