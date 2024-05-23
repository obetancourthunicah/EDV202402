using PrimerForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerForm
{
    internal class Contacto
    {
        private Int32 _id;
        private String _name;
        private String _email;
        private String _phone;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Email { get => _email; set => _email = value; }
        public string Phone { get => _phone; set => _phone = value; }

        public Contacto() { }
        public Contacto(int id, string name, string email, string phone)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Phone = phone;
            
        }
    }
}
