using ClinicasMedicasDao.ClinicaMedicaDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaMedicaLib.Seguridad;

namespace ClinicaMedicaLib.Controladores.Seguridad
{
    public class Roles
    {
        private RolesTableAdapter rolesTableAdapter;
        private VerificacionesTableAdapter verificacionesTableAdapter;
        private VerificacionesXRolTableAdapter rolesVerificacionesTableAdapter;

        public Roles()
        {
            rolesTableAdapter = new RolesTableAdapter();
            verificacionesTableAdapter = new VerificacionesTableAdapter();
            rolesVerificacionesTableAdapter = new VerificacionesXRolTableAdapter();
        }

        public void InsertarRol(Rol rol)
        {
            rolesTableAdapter.Insert(rol.Codigo, rol.Descripcion, rol.Estado);
        }
        public void UpdateRol(Rol rolToUdpate, Rol Original) {
            rolesTableAdapter.Update(rolToUdpate.Descripcion, rolToUdpate.Estado, Original.Codigo, Original.Descripcion, Original.Estado);
        }

        public void EliminarRol(Rol rol)
        {
            rolesTableAdapter.Delete(rol.Codigo, rol.Descripcion, rol.Estado);
        }

        public List<Rol> ObtenerRoles()
        {
            List<Rol> roles = new List<Rol>();
            foreach (var rol in rolesTableAdapter.GetData())
            {
                roles.Add(new Rol(rol.rol, rol.name, rol.status));
            }
            return roles;
        }

        public Rol? ObtenerRol(string codigo)
        {
            var rol = rolesTableAdapter.GetDataBy1(codigo).FirstOrDefault();
            if (rol == null)
            {
                return null;
            }
            return new Rol(rol.rol, rol.name, rol.status);
        }

        public List<Rol> ObtenerRolesPorUsuario(int idUsuario)
        {
            List<Rol> roles = new List<Rol>();
            foreach (var rol in rolesTableAdapter.GetDataByAssignToUser(idUsuario))
            {
                roles.Add(new Rol(rol.rol, rol.name, rol.status));
            }
            return roles;
        }
        public List<Rol> ObtenerRolesNoAsignadosAUsuario(int idUsuario)
        {
            List<Rol> roles = new List<Rol>();
            foreach (var rol in rolesTableAdapter.GetDataByNotAssignToUser(idUsuario))
            {
                roles.Add(new Rol(rol.rol, rol.name, rol.status));
            }
            return roles;
        }

        public void AgregarVerificacionARol(Rol rol, Verificacion verificacion)
        {
            if (rol == null)
            {
                throw new Exception("El rol no puede ser nulo");
            }
            if (verificacion == null)
            {
                throw new Exception("La verificacion no puede ser nula");
            }
            rolesVerificacionesTableAdapter.Insert(
                rol.Codigo,
                verificacion.Codigo,
                DateTime.Now.AddDays(360),
                ECommonStatus.ACT
            );
        }
    }
}
