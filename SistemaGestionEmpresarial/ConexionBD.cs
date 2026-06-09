using System;
using System.Data;
using System.Data.SqlClient;

namespace SistemaGestionEmpresarial
{
    public class ConexionBD
    {
        // ⚠️ MODIFICA ESTO CON TU CONEXIÓN
        private static readonly string _cadenaConexion =
            "Server=.;Database=GestionEmpresarial;Integrated Security=true;";

        private SqlConnection conexion;

        public ConexionBD()
        {
            conexion = new SqlConnection(_cadenaConexion);
        }

        public bool Conectar()
        {
            try
            {
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                    return true;
                }
                return true;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al conectar a la BD: " + ex.Message);
            }
        }

        public void Desconectar()
        {
            if (conexion != null && conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }

        public SqlConnection ObtenerConexion()
        {
            Conectar();
            return conexion;
        }

        public DataTable EjecutarConsulta(string consulta)
        {
            try
            {
                Conectar();
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                Desconectar();
                return dt;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error en la consulta: " + ex.Message);
            }
        }

        public DataTable EjecutarProcedimiento(string nombreProcedimiento, SqlParameter[] parametros = null)
        {
            try
            {
                Conectar();
                SqlCommand cmd = new SqlCommand(nombreProcedimiento, conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                if (parametros != null)
                {
                    cmd.Parameters.AddRange(parametros);
                }

                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                Desconectar();
                return dt;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al ejecutar procedimiento: " + ex.Message);
            }
        }

        public bool EjecutarComando(string comando)
        {
            try
            {
                Conectar();
                SqlCommand cmd = new SqlCommand(comando, conexion);
                cmd.ExecuteNonQuery();
                Desconectar();
                return true;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al ejecutar comando: " + ex.Message);
            }
        }

        public bool EjecutarProcedimientoSinRetorno(string nombreProcedimiento, SqlParameter[] parametros = null)
        {
            try
            {
                Conectar();
                SqlCommand cmd = new SqlCommand(nombreProcedimiento, conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                if (parametros != null)
                {
                    cmd.Parameters.AddRange(parametros);
                }

                cmd.ExecuteNonQuery();
                Desconectar();
                return true;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al ejecutar procedimiento: " + ex.Message);
            }
        }
    }
}