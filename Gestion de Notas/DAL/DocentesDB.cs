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
    public class DocentesDB
    {

        static string cadenaConexion;

        public DocentesDB()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["stringConnection"].ConnectionString;
        }

        public object SP_DocentesCRUD(Docente docente, int proceso)
        {
            string spNombre = "SP_CRUD_DOCENTES";

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                SqlCommand command = new SqlCommand(spNombre, connection);
                command.CommandType = CommandType.StoredProcedure;

                // Parámetros de entrada
                command.Parameters.AddWithValue("@intProceso", proceso);
                command.Parameters.AddWithValue("@idDocente", docente.IdDocente != 0 ? (object)docente.IdDocente : DBNull.Value);
                command.Parameters.AddWithValue("@primerNombre_D", !string.IsNullOrEmpty(docente.PrimerNombre) ? (object)docente.PrimerNombre : DBNull.Value);
                command.Parameters.AddWithValue("@segundoNombre_D", !string.IsNullOrEmpty(docente.SegundoNombre) ? (object)docente.SegundoNombre : DBNull.Value);
                command.Parameters.AddWithValue("@primerApellido_D", !string.IsNullOrEmpty(docente.PrimerApellido) ? (object)docente.PrimerApellido : DBNull.Value);
                command.Parameters.AddWithValue("@segundoApellido_D", !string.IsNullOrEmpty(docente.SegundoApellido) ? (object)docente.SegundoApellido : DBNull.Value);
                command.Parameters.AddWithValue("@identificacion_D", !string.IsNullOrEmpty(docente.Identificacion) ? (object)docente.Identificacion : DBNull.Value);
                command.Parameters.AddWithValue("@fechaNacimiento_D", docente.FechaNacimiento != DateTime.MinValue ? (object)docente.FechaNacimiento : DBNull.Value);
                command.Parameters.AddWithValue("@direccion", !string.IsNullOrEmpty(docente.Direccion) ? (object)docente.Direccion : DBNull.Value);
                command.Parameters.AddWithValue("@telefono_D", !string.IsNullOrEmpty(docente.Telefono) ? (object)docente.Telefono : DBNull.Value);
                command.Parameters.AddWithValue("@email_D", !string.IsNullOrEmpty(docente.email) ? (object)docente.email : DBNull.Value);
                command.Parameters.AddWithValue("@usuario_D", docente.Usuario != 0 ? (object)docente.Usuario : DBNull.Value);

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
                        // Proceso 1: Selección de docente por identificación
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Docente docenteEncontrado = new Docente()
                                {
                                    IdDocente = Convert.ToInt32(reader["IDDOCENTE"]),
                                    Identificacion = reader["IDENTIFICACION"].ToString(),
                                    PrimerNombre = reader["PRIMERNOMBRE"].ToString(),
                                    SegundoNombre = reader["SEGUNDONOMBRE"].ToString(),
                                    PrimerApellido = reader["PRIMERAPELLIDO"].ToString(),
                                    SegundoApellido = reader["SEGUNDOAPELLIDO"].ToString(),
                                    email = reader["EMAIL"].ToString(),
                                    Telefono = reader["TELEFONO"].ToString(),
                                    Direccion = reader["DIRECCION"].ToString(),
                                    FechaNacimiento = Convert.ToDateTime(reader["FECHANACIMIENTO"]),
                                    Edad = Convert.ToInt32(reader["EDAD"])
                                };

                                return docenteEncontrado;
                            }
                            else
                            {
                                // No se encontró el docente
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
                    Console.WriteLine("Error en SP_DocentesCRUD: " + ex.Message);
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

        public DataTable SelectForDgv()
        {
            DataTable table = new DataTable();

            string solicitud = "SELECT * FROM [dbo].[VISTA_DOCENTES] ORDER BY APELLIDOS;";
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
