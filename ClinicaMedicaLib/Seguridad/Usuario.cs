using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedicaLib.Seguridad
{
    public class Usuario
    {
        private string status;
        public int Codigo {  get; set; }
        public string User { get; set; }
        public string Password { get; set; }

        public DateTime PasswordExpires { get; set; }
        public string PasswordSalt { get; set; }

        public string PasswordHash { get; set; }

        public string Name { get; set; }

        public string Estado {
            get => status;
            set { 
                if (value == ECommonStatus.ACT || value == ECommonStatus.INA)
                {
                    status = value;
                } else
                {
                    throw new Exception("Estado no es Valido");
                }
            }
        }

        public Usuario()
        {
            Codigo = 0;
            User = "";
            Password = "";
            PasswordExpires = DateTime.Now.AddDays(30);
            PasswordHash = "";
            PasswordSalt = "";
            Name = "";
            Estado = ECommonStatus.ACT;
        }

        public Usuario(int codigo, string user, string password, DateTime passwordExpires, string passwordSalt, string passwordHash, string name, string estado)
        {
            Codigo = codigo;
            User = user;
            Password = password;
            PasswordExpires = passwordExpires;
            PasswordSalt = passwordSalt;
            PasswordHash = passwordHash;
            Name = name;
            Estado = estado;
        }
    }
}
