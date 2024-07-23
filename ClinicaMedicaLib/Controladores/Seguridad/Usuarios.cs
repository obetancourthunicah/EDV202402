using ClinicaMedicaLib.Seguridad;
using ClinicasMedicasDao.ClinicaMedicaDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedicaLib.Controladores.Seguridad
{
    public class Usuarios
    {
        private UsuariosTableAdapter usuariosTableAdapter;
        private Roles rolesController;
        private Verificaciones verificacionesController;

        private RolesXUsuarioTableAdapter rolesXUsuarioTA;

        public Usuarios()
        {
            usuariosTableAdapter = new UsuariosTableAdapter();
            rolesXUsuarioTA = new RolesXUsuarioTableAdapter();
            
            rolesController = new Roles();
            verificacionesController = new Verificaciones();
        }

        public int agregarUsuario(Usuario user)
        {
            // Generating Password hash
            byte[] passwordSaltBytes;
            string passwordHash = PasswordUtility.hashPassword(user.Password,out passwordSaltBytes);
            string passwordSalt = Convert.ToHexString(passwordSaltBytes);
            string password = passwordSalt + passwordHash;
            return usuariosTableAdapter.Insert(
                    user.User,
                    password,
                    DateTime.Now.AddDays(90),
                    user.Name,
                    user.Estado
                );
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
                    usuario.password.Substring(0,128),
                    usuario.password.Substring(128,128),
                    usuario.name,
                    usuario.status
                );
                usuarios.Add(nusuario);
            }
            return usuarios;
        }

        public Usuario? GetUsuario(string user)
        {
            Debug.WriteLine(user);
            var usuarioRow = usuariosTableAdapter.GetDataByUser(user).FirstOrDefault();
            Debug.WriteLine(usuarioRow);
            if (usuarioRow != null)
            {
                return new Usuario(
                        usuarioRow.Id,
                        usuarioRow.user,
                        usuarioRow.password,
                        usuarioRow.passwordFchExp,
                        usuarioRow.password.Substring(0, 128),
                        usuarioRow.password.Substring(128, 128),
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

        public void VerificarSeguridad() {
            Debug.WriteLine("Entrando a Verificar Seguridad");
            int? cantidadUsuarios = usuariosTableAdapter.ContarUsuarios();
            if (cantidadUsuarios == null || cantidadUsuarios == 0) {
                Debug.WriteLine("Creando Usuario Administrador");
                Usuario newAdministrador = new Usuario();
                newAdministrador.User = "admin";
                newAdministrador.Password = "Admin%1029";
                newAdministrador.PasswordExpires = DateTime.Now.AddDays(360);
                newAdministrador.Name = "Administrador";
                newAdministrador.Estado = ECommonStatus.ACT;
                int result = this.agregarUsuario(newAdministrador);
                if (result < 1)
                {
                    throw new Exception("No se pudo insertar Usuario");
                }
                Usuario? contextUser = this.GetUsuario(newAdministrador.User);
                if (contextUser == null)
                {
                    throw new Exception("No se pudo obtener usuario");
                }

                Debug.WriteLine("Creando Roles Predeterminados");

                Rol rolAdministrador = new Rol("admin", "Administradores", ECommonStatus.ACT);
                Rol rolUsuario = new Rol("basico", "Usuario Basico", ECommonStatus.ACT);
                Rol rolAuditor = new Rol("auditor", "Usuario Auditor", ECommonStatus.ACT);

                rolesController.InsertarRol(rolAdministrador);
                rolesController.InsertarRol(rolUsuario);
                rolesController.InsertarRol(rolAuditor);

                Debug.WriteLine("Creando Verificaciones Predeterminadas");
                Verificacion verificacionMnuClinica = new Verificacion("MnuClinicas", "Menu de Mantenimiento Clinicas", ECommonStatus.ACT);
                Verificacion verificacionMnuContactos = new Verificacion("MnuContactos", "Menu de Mantenimiento de Contactos", ECommonStatus.ACT);

                verificacionesController.InsertarVerificacion(verificacionMnuClinica);
                verificacionesController.InsertarVerificacion(verificacionMnuContactos);

                Debug.WriteLine("Asignando Roles a Usuario Administrador");
                rolesXUsuarioTA.Insert(contextUser.Codigo, rolAdministrador.Codigo, DateTime.Now.AddDays(360), ECommonStatus.ACT);

                Debug.WriteLine("Asignando Verificaciones a Rol");
                rolesController.AgregarVerificacionARol(rolAdministrador, verificacionMnuClinica);
                rolesController.AgregarVerificacionARol(rolAdministrador, verificacionMnuContactos);



                
            }
        }

        public Usuario? Login(string user, string password)
        {
            Usuario? usuario = GetUsuario(user);
            if (usuario != null)
            {
                if (PasswordUtility.comparePassword(password, usuario.PasswordHash, Convert.FromHexString(usuario.PasswordSalt)))
                {
                    return usuario;
                }
            }
            return null;
        }

        public bool IsAuthorized(int userId, string verificacion)
        {
            Verificacion? veriExiste = verificacionesController.ObtenerVerificacion(verificacion);
            if (veriExiste == null)
            {
                Verificacion verNuevo = new Verificacion(verificacion, verificacion, ECommonStatus.ACT);
                verificacionesController.InsertarVerificacion(verNuevo);
                Rol? rolAdmin = rolesController.ObtenerRol("admin");
                //Agregando a Rol de Administracion todo nuevo
                rolesController.AgregarVerificacionARol(rolAdmin, verNuevo);
            }
            int? estaAutorizado = (int) usuariosTableAdapter.IsAuthorized(userId, verificacion);

            return estaAutorizado.HasValue && estaAutorizado == 1;
        }
    }
}
 