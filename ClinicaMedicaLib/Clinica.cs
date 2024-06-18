using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedicaLib
{
    public class Clinica
    {
        private string _nombre;
        private string _direccion;
        private string _telefono;
        private string _estado;
        private int _codigo;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Estado { get => _estado; set => _estado = value; }

        public int Codigo { get => _codigo; set => _codigo = value; }
        public Clinica() {
            _nombre = "";
            _direccion = "";
            _telefono = "";
            _estado = "";
            _codigo = 0;
        }

        public Clinica(
            int codigo,
            string nombre,
            string direccion,
            string telefono,
            string estado
            ) { 

            _nombre = nombre;
            _direccion = direccion;
            _telefono = telefono;
            _estado = estado;
            _codigo = codigo;
        }
    }
}
