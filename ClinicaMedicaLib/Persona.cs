namespace ClinicaMedicaLib
{
    public class Persona
    {
        private string _id;
        private string _nombre;
        private string _correo;
        private string _telefono;
        private string _avatar;

        public string Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Correo { get => _correo; set => _correo = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Avatar { get => _avatar; set => _avatar = value; }

        public Persona() { 
            _id ="";
            _nombre = "";
            _correo = "";
            _telefono = "";
            _avatar = "";
        }

        public Persona(
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
            _avatar = "";
        }
    }
}
