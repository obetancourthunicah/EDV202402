using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ClinicaMedicaLib
{
    public class Medico: Personas 
    {
        private string _especialidad;

        public string Especialidad { get => _especialidad; set => _especialidad = value; }

        public Medico() {
            _especialidad = "";
        }

        public Medico(
            string id,
            string nombre,
            string correo,
            string telefono,
            string especialidad
            ) {
            Id = id;
            Nombre = nombre;
            Correo = correo;
            Telefono = telefono;
            Especialidad = especialidad;
        }
    }
}
