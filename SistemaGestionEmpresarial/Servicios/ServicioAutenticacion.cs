using System;
using System.Data;
using System.Data.SqlClient;
using SistemaGestionEmpresarial.Data;
using SistemaGestionEmpresarial.Modelos;

namespace SistemaGestionEmpresarial.Servicios
{
    public class ServicioAutenticacion
    {
        private ConexionBD conexionBD;

        public ServicioAutenticacion()
        {
            conexionBD = new ConexionBD();
        }

        public UsuarioAutenticado ValidarCredenciales(string usuario, string contraseña)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@NombreUsuario", usuario),
                    new SqlParameter("@Contraseña", contraseña)
                };

                DataTable resultado = conexionBD.EjecutarProcedimiento("sp_ValidarUsuario", parametros);

                if (resultado.Rows.Count > 0)
                {
                    DataRow fila = resultado.Rows[0];

                    UsuarioAutenticado usuarioAutenticado = new UsuarioAutenticado
                    {
                        IdUsuario = Convert.ToInt32(fila["IdUsuario"]),
                        NombreUsuario = fila["NombreUsuario"].ToString(),
                        Nombre = fila["Nombre"].ToString(),
                        Email = fila["Email"].ToString(),
                        IdRol = Convert.ToInt32(fila["IdRol"]),
                        NombreRol = fila["NombreRol"].ToString()
                    };

                    RegistrarAuditoria(usuario, true);

                    return usuarioAutenticado;
                }
                else
                {
                    RegistrarAuditoria(usuario, false);
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al validar credenciales: " + ex.Message);
            }
        }

        public bool TienePermiso(int idRol, string nombrePermiso)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@IdRol", idRol)
                };

                DataTable permisos = conexionBD.EjecutarProcedimiento("sp_ObtenerPermisosPorRol", parametros);

                foreach (DataRow fila in permisos.Rows)
                {
                    if (fila["NombrePermiso"].ToString() == nombrePermiso)
                    {
                        return true;
                    }
                }

                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar permisos: " + ex.Message);
            }
        }

        public DataTable ObtenerPermisosPorRol(int idRol)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@IdRol", idRol)
                };

                return conexionBD.EjecutarProcedimiento("sp_ObtenerPermisosPorRol", parametros);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener permisos: " + ex.Message);
            }
        }

        private void RegistrarAuditoria(string usuario, bool exitoso)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@NombreUsuario", usuario),
                    new SqlParameter("@Exitoso", exitoso)
                };

                conexionBD.EjecutarProcedimientoSinRetorno("sp_RegistrarLoginAuditoria", parametros);
            }
            catch
            {
            }
        }
    }
}