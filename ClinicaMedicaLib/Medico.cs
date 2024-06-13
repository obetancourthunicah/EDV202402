using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ClinicaMedicaLib
{
    public class Medico: Persona 
    {
        private string _especialidad;

        public string Especialidad { get => _especialidad; set => _especialidad = value; }

        public Medico():base() {
            _especialidad = "";
        }

        public Medico(
            string id,
            string nombre,
            string correo,
            string telefono,
            string especialidad
            ): base(id, nombre, correo, telefono) { 

            _especialidad = id;
        }

        public string obtenerPerfil() {
            return "Nombre: " + Nombre + " Especialidad: " + Especialidad + " Id: " + Id;
        }
    }
}
