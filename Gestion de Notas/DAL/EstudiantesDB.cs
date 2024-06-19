using Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EstudiantesDB
    {
        static string cadenaConexion;

        public EstudiantesDB()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["stringConnection"].ConnectionString;
        }

        public object SP_EstudiantesCRUD(Estudiante estudiante, int proceso)
        {
            string spNombre = "SP_CRUD_ESTUDIANTES";

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                SqlCommand command = new SqlCommand(spNombre, connection);
                command.CommandType = CommandType.StoredProcedure;

                // Parámetros de entrada
                command.Parameters.AddWithValue("@intProceso", proceso);
                command.Parameters.AddWithValue("@idEstudiante", estudiante.IdEstudiante != 0 ? (object)estudiante.IdEstudiante : DBNull.Value);
                command.Parameters.AddWithValue("@primerNombre_E", !string.IsNullOrEmpty(estudiante.PrimerNombre) ? (object)estudiante.PrimerNombre : DBNull.Value);
                command.Parameters.AddWithValue("@segundoNombre_E", !string.IsNullOrEmpty(estudiante.SegundoNombre) ? (object)estudiante.SegundoNombre : DBNull.Value);
                command.Parameters.AddWithValue("@primerApellido_E", !string.IsNullOrEmpty(estudiante.PrimerApellido) ? (object)estudiante.PrimerApellido : DBNull.Value);
                command.Parameters.AddWithValue("@segundoApellido_E", !string.IsNullOrEmpty(estudiante.SegundoApellido) ? (object)estudiante.SegundoApellido : DBNull.Value);
                command.Parameters.AddWithValue("@identificacion_E", !string.IsNullOrEmpty(estudiante.Identificacion) ? (object)estudiante.Identificacion : DBNull.Value);
                command.Parameters.AddWithValue("@fechaNacimiento_E", estudiante.FechaNacimiento != DateTime.MinValue ? (object)estudiante.FechaNacimiento : DBNull.Value);
                command.Parameters.AddWithValue("@email_E", !string.IsNullOrEmpty(estudiante.Email) ? (object)estudiante.Email : DBNull.Value);
                command.Parameters.AddWithValue("@direccion", !string.IsNullOrEmpty(estudiante.Direccion) ? (object)estudiante.Direccion : DBNull.Value);
                command.Parameters.AddWithValue("@telefono_E", !string.IsNullOrEmpty(estudiante.Telefono) ? (object)estudiante.Telefono : DBNull.Value);
                command.Parameters.AddWithValue("@acudiente", estudiante.Acudiente.idAcudiente != 0 ? (object)estudiante.Acudiente.idAcudiente : DBNull.Value);
                command.Parameters.AddWithValue("@curso", estudiante.Curso.IdCurso != 0 ? (object)estudiante.Curso.IdCurso : DBNull.Value);
                command.Parameters.AddWithValue("@estado", estudiante.Estado);
                // Parámetros de salida para códigos de error y confirmación
                SqlParameter codigoErrorParam = new SqlParameter("@codigoError", SqlDbType.Int);
                codigoErrorParam.Direction = ParameterDirection.Output;
                command.Parameters.Add(codigoErrorParam);

                SqlParameter idResultadoParam = new SqlParameter("@idResultado", SqlDbType.Int);
                idResultadoParam.Direction = ParameterDirection.Output;
                command.Parameters.Add(idResultadoParam);

                try
                {
                    connection.Open();

                    if (proceso == 1)
                    {
                        // Proceso 1: Selección de estudiante por identificación
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Estudiante estudianteEncontrado = new Estudiante()
                                {
                                    IdEstudiante = Convert.ToInt32(reader["IDESTUDIANTE"]),
                                    Identificacion = reader["IDENTIFICACION"].ToString(),
                                    PrimerNombre= reader["PRIMERNOMBRE"].ToString(),
                                    SegundoNombre = reader["SEGUNDONOMBRE"].ToString(),
                                    PrimerApellido = reader["PRIMERAPELLIDO"].ToString(),
                                    SegundoApellido = reader["SEGUNDOAPELLIDO"].ToString(),
                                    Email = reader["EMAIL"].ToString(),
                                    Telefono = reader["TELEFONO"].ToString(),
                                    Direccion = reader["DIRECCION"].ToString(),
                                    FechaNacimiento = Convert.ToDateTime(reader["FECHANACIMIENTO"]),
                                    Edad = Convert.ToInt32(reader["EDAD"]),
                                    Acudiente = new Acudiente()
                                    {
                                        idAcudiente = Convert.ToInt32(reader["ACUDIENTE"]),
                                        primerNombre = reader["NOMBREACUDIENTE"].ToString(),
                                        primerApellido = reader["APELLIDOACUDIENTE"].ToString()
                                    },
                                    Curso = new Curso()
                                    {
                                        IdCurso = Convert.ToInt32(reader["CURSO"]),
                                        Nombre = reader["COURSE"].ToString()
                                    },
                                    Estado = reader["ESTADO"].ToString()
                                };
                                return estudianteEncontrado;
                            }
                            else
                            {
                                // No se encontró el estudiante
                                return null;
                            }
                        }
                    }
                    else
                    {
                        // Procesos 2, 3 y 4: Inserción, actualización o eliminación
                        command.ExecuteNonQuery();

                        // Obtener valores de los parámetros de salida
                        int codigoError = Convert.ToInt32(command.Parameters["@codigoError"].Value);
                        int idResultado = Convert.ToInt32(command.Parameters["@idResultado"].Value);

                        // Manejo de códigos de error y confirmación
                        if (codigoError != 0)
                        {
                            // Devuelve el código de error
                            return codigoError;
                        }
                        else
                        {
                            // Devuelve el id de resultado o cualquier otro valor necesario
                            return idResultado;
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejar la excepción adecuadamente
                    Console.WriteLine("Error en SP_EstudiantesCRUD: " + ex.Message);
                    throw; // Opcionalmente, puedes lanzar una excepción personalizada aquí
                }
                finally
                {
                    // Cerrar la conexión en el bloque finally para garantizar que se cierre adecuadamente
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }

        public DataTable selectforDgv()
        {
            DataTable table = new DataTable();

            string solicitud = "SELECT * FROM [dbo].[VISTA_ESTUDIANTES] ORDER BY APELLIDOS;";
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                SqlCommand command = new SqlCommand(solicitud, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                table.Load(reader);

            }
            return table;
        }

        public DataTable selectforGroupe(int curso)
        {
            DataTable table = new DataTable();

            string solicitud = $"SELECT " +
                                $"E.[IDENTIFICACION]," +
                                $"CONCAT(E.[PRIMERAPELLIDO], ' ', E.[SEGUNDOAPELLIDO]) AS APELLIDOS," +
                                $"CONCAT(E.[PRIMERNOMBRE], ' ', E.[SEGUNDONOMBRE]) AS NOMBRES," +
                                $"DATEDIFF(YEAR, E.[FECHANACIMIENTO], GETDATE()) - " +
                                $"CASE  WHEN MONTH(GETDATE()) < MONTH(E.[FECHANACIMIENTO]) OR " +
                                $"(MONTH(GETDATE()) = MONTH(E.[FECHANACIMIENTO]) AND DAY(GETDATE()) < DAY(E.[FECHANACIMIENTO])) " +
                                $" THEN 1 \r\n            " +
                                $"ELSE 0 \r\n        " +
                                $"END AS EDAD\r\n    " +
                                $"FROM [JulianHernandoDavid_NotasDB].[dbo].[ESTUDIANTES] E " +
                                $"WHERE E.CURSO = {curso}\r\n\tORDER BY APELLIDOS";

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                SqlCommand command = new SqlCommand(solicitud, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                table.Load(reader);

            }
            return table;
        }
    }
}
