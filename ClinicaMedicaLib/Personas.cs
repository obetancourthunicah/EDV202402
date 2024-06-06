namespace ClinicaMedicaLib
{
    public class Personas
    {
        private string _id;
        private string _nombre;
        private string _correo;
        private string _telefono;

        public string Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Correo { get => _correo; set => _correo = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }

        public Personas() { 
            _id ="";
            _nombre = "";
            _correo = "";
            _telefono = "";
        }

        public Personas(
            string id,
            string nombre,
            string correo,
            string telefono
            )
        {
            _id = id;
            _nombre = nombre;
            _correo = correo;
            _telefono = telefono;
        }
    }
}
