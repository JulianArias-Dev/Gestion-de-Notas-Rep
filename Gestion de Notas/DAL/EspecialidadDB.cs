using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using Entity;
using System.Data;

namespace DAL
{
    public class EspecialidadDB
    {
        static string connectionString;

        public EspecialidadDB()
        {
            connectionString = ConfigurationManager.ConnectionStrings["stringConnection"].ConnectionString;
        }

        public List<Especialidad> ObtenerEspecialidad(int idEspecialidad)
        {
            List<Especialidad> especialidades = new List<Especialidad>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_CRUD_ESPECIALIDAD", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@intProceso", 1);
                cmd.Parameters.AddWithValue("@IdEspecialidad", idEspecialidad);

                SqlParameter codigoError = new SqlParameter("@codigoError", SqlDbType.Int);
                codigoError.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(codigoError);

                SqlParameter idResultado = new SqlParameter("@idResultado", SqlDbType.Int);
                idResultado.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(idResultado);

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Especialidad especialidad = new Especialidad
                    {
                        IdEspecialidad = Convert.ToInt32(reader["IDESPECIALIDAD"]),
                        Nombre = reader["NOMBRE"].ToString()
                    };

                    especialidades.Add(especialidad);
                }

                int codigoErrorValor = Convert.ToInt32(codigoError.Value);
                int idResultadoValor = Convert.ToInt32(idResultado.Value);

                reader.Close();
            }

            return especialidades;
        }


        public int RegistrarEspecialidad(string nombre)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_CRUD_ESPECIALIDAD", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@intProceso", 2);
                cmd.Parameters.AddWithValue("@Nombre", nombre);

                SqlParameter codigoError = new SqlParameter("@codigoError", SqlDbType.Int);
                codigoError.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(codigoError);

                SqlParameter idResultado = new SqlParameter("@idResultado", SqlDbType.Int);
                idResultado.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(idResultado);

                conn.Open();
                cmd.ExecuteNonQuery();

                int error = (int)codigoError.Value;
                if (error != 0)
                {
                    throw new Exception($"Error Code: {error}");
                }

                return (int)idResultado.Value;
            }
        }

        public void ActualizarEspecialidad(int idEspecialidad, string nombre)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_CRUD_ESPECIALIDAD", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@intProceso", 3);
                cmd.Parameters.AddWithValue("@IdEspecialidad", idEspecialidad);
                cmd.Parameters.AddWithValue("@Nombre", nombre);

                SqlParameter codigoError = new SqlParameter("@codigoError", SqlDbType.Int);
                codigoError.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(codigoError);

                SqlParameter idResultado = new SqlParameter("@idResultado", SqlDbType.Int);
                idResultado.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(idResultado);

                conn.Open();
                cmd.ExecuteNonQuery();

                int error = (int)codigoError.Value;
                if (error != 0)
                {
                    throw new Exception($"Error Code: {error}");
                }
            }
        }

        public void EliminarEspecialidad(int idEspecialidad)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_CRUD_ESPECIALIDAD", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@intProceso", 4);
                cmd.Parameters.AddWithValue("@IdEspecialidad", idEspecialidad);

                SqlParameter codigoError = new SqlParameter("@codigoError", SqlDbType.Int);
                codigoError.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(codigoError);

                SqlParameter idResultado = new SqlParameter("@idResultado", SqlDbType.Int);
                idResultado.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(idResultado);

                conn.Open();
                cmd.ExecuteNonQuery();

                int error = (int)codigoError.Value;
                if (error != 0)
                {
                    throw new Exception($"Error Code: {error}");
                }
            }
        }

        public List<Especialidad> ObtenerTodasEspecialidades()
        {
            List<Especialidad> especialidades = new List<Especialidad>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT IDESPECIALIDAD, NOMBRE FROM ESPECIALIDADES";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Especialidad especialidad = new Especialidad
                    {
                        IdEspecialidad = Convert.ToInt32(reader["IDESPECIALIDAD"]),
                        Nombre = reader["NOMBRE"].ToString()
                    };

                    especialidades.Add(especialidad);
                }

                reader.Close();
            }

            return especialidades;
        }
    }
}