using System;
using System.Configuration;
using System.Data.SqlClient;
using Entity;
using System.Data;

namespace DAL
{
    public class AcudientesDB
    {
        static string cadenaConexion;

        public AcudientesDB()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["stringConnection"].ConnectionString;
        }


        public object SP_AcudientesCRUD(Acudiente acudiente, int proceso)
        {
            string spNombre = "SP_CRUD_ACUDIENTES";

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                SqlCommand command = new SqlCommand(spNombre, connection);
                command.CommandType = CommandType.StoredProcedure;

                // Parámetros de entrada
                command.Parameters.AddWithValue("@intProceso", proceso);
                command.Parameters.AddWithValue("@idAcudiente", acudiente.idAcudiente != 0 ? (object)acudiente.idAcudiente : DBNull.Value);
                command.Parameters.AddWithValue("@primerNombre_A", !string.IsNullOrEmpty(acudiente.primerNombre) ? (object)acudiente.primerNombre : DBNull.Value);
                command.Parameters.AddWithValue("@segundoNombre_A", !string.IsNullOrEmpty(acudiente.segundoNombre) ? (object)acudiente.segundoNombre : DBNull.Value);
                command.Parameters.AddWithValue("@primerApellido_A", !string.IsNullOrEmpty(acudiente.primerApellido) ? (object)acudiente.primerApellido : DBNull.Value);
                command.Parameters.AddWithValue("@segundoApellido_A", !string.IsNullOrEmpty(acudiente.segundoApellido) ? (object)acudiente.segundoApellido : DBNull.Value);
                command.Parameters.AddWithValue("@identificacion_A", !string.IsNullOrEmpty(acudiente.identificacion) ? (object)acudiente.identificacion : DBNull.Value);
                command.Parameters.AddWithValue("@fechaNacimiento_A", acudiente.fechaNacimiento != DateTime.MinValue ? (object)acudiente.fechaNacimiento : DBNull.Value);
                command.Parameters.AddWithValue("@email_A", !string.IsNullOrEmpty(acudiente.email) ? (object)acudiente.email : DBNull.Value);
                command.Parameters.AddWithValue("@direccion", !string.IsNullOrEmpty(acudiente.direccion) ? (object)acudiente.direccion : DBNull.Value);
                command.Parameters.AddWithValue("@telefono_A", !string.IsNullOrEmpty(acudiente.telefono) ? (object)acudiente.telefono : DBNull.Value);

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
                        // Proceso 1: Selección de acudiente por identificación
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Acudiente acudienteEncontrado = new Acudiente()
                                {
                                    idAcudiente = Convert.ToInt32(reader["IDACUDIENTE"]),
                                    identificacion = reader["IDENTIFICACION"].ToString(),
                                    primerNombre = reader["PRIMERNOMBRE"].ToString(),
                                    segundoNombre = reader["SEGUNDONOMBRE"].ToString(),
                                    primerApellido = reader["PRIMERAPELLIDO"].ToString(),
                                    segundoApellido = reader["SEGUNDOAPELLIDO"].ToString(),
                                    email = reader["EMAIL"].ToString(),
                                    telefono = reader["TELEFONO"].ToString(),
                                    direccion = reader["DIRECCION"].ToString(),
                                    fechaNacimiento = Convert.ToDateTime(reader["FECHANACIMIENTO"]),
                                    Edad = Convert.ToInt32(reader["EDAD"])
                                };

                                return acudienteEncontrado;
                            }
                            else
                            {
                                // No se encontró el acudiente
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
                    Console.WriteLine("Error en SP_AcudientesCRUD: " + ex.Message);
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
        public DataTable selectforDgv() {
            
            DataTable table = new DataTable();

            string solicitud = "SELECT * FROM [dbo].[VISTA_ACUDIENTES] ORDER BY APELLIDOS;";
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
