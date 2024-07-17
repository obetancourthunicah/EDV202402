using ClinicaMedicaLib.Seguridad;
using ClinicasMedicasDao.ClinicaMedicaDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedicaLib.Controladores.Seguridad
{
    public class Usuarios
    {
        private UsuariosTableAdapter usuariosTableAdapter;

        public Usuarios()
        {
            usuariosTableAdapter = new UsuariosTableAdapter();
        }

        public int agregarUsuario(Usuario user)
        {
            // Generating Password hash
            byte[] passwordSaltBytes;
            string passwordHash = PasswordUtility.hashPassword(user.Password,out passwordSaltBytes);
            string passwordSalt = Convert.ToHexString(passwordSaltBytes);
            string password = passwordSalt + passwordHash;
            usuariosTableAdapter.Insert(
                    user.User,
                    password,
                    DateTime.Now.AddDays(90),
                    user.Name,
                    user.Estado
                );
            int lastId = (int) usuariosTableAdapter.LastUserId();
            return lastId;
        }

        public void actualizarUsuario(Usuario user, Usuario original)
        {
            byte[] passwordSaltBytes;
            string passwordHash = PasswordUtility.hashPassword(user.Password, out passwordSaltBytes);
            string passwordSalt = Convert.ToHexString(passwordSaltBytes);
            string password = passwordSalt + passwordHash;
            usuariosTableAdapter.Update(user.User, password, user.PasswordExpires, user.Name, user.Estado, original.Codigo, original.User, original.Password, original.PasswordExpires, original.Name, original.Estado);
        }

        public List<Usuario> GetUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            foreach (var usuario in usuariosTableAdapter.GetData())
            {
                Usuario nusuario = new Usuario(
                    usuario.Id,
                    usuario.user,
                    usuario.password,
                    usuario.passwordFchExp,
                    usuario.password.Substring(0,64),
                    usuario.password.Substring(64,64),
                    usuario.name,
                    usuario.status
                );
                usuarios.Add(nusuario);
            }
            return usuarios;
        }

        public Usuario? GetUsuario(string user)
        {
            var usuarioRow = usuariosTableAdapter.GetDataByUser(user).FirstOrDefault();
            if (usuarioRow != null)
            {
                return new Usuario(
                        usuarioRow.Id,
                        usuarioRow.user,
                        usuarioRow.password,
                        usuarioRow.passwordFchExp,
                        usuarioRow.password.Substring(0, 64),
                        usuarioRow.password.Substring(64, 64),
                        usuarioRow.name,
                        usuarioRow.status
                    );
            }
            return null;
        }

        public void updatePassword(string user, string newPassword)
        {
            byte[] passwordSaltBytes;
            string passwordHash = PasswordUtility.hashPassword(newPassword, out passwordSaltBytes);
            string passwordSalt = Convert.ToHexString(passwordSaltBytes);
            string password = passwordSalt + passwordHash;
            //usuariosTableAdapter.UpdatePassword(password, DateTime.Now.AddDays(90), Id);
        }
    }
}
