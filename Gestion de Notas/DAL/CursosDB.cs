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
    public class CursosDB
    {
        static string cadenaConexion;

        public CursosDB()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["stringConnection"].ConnectionString;
        }


        public object SP_CursosCRUD(Curso curso, int proceso)
        {
            string spNombre = "SP_CRUD_CURSOS";
            var list = new List<Curso>();

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                SqlCommand command = new SqlCommand(spNombre, connection);
                command.CommandType = CommandType.StoredProcedure;

                // Parámetros de entrada
                command.Parameters.AddWithValue("@intProceso", proceso);
                command.Parameters.AddWithValue("@idCurso", curso.IdCurso != 0 ? (object)curso.IdCurso : DBNull.Value);
                command.Parameters.AddWithValue("@Codigo", !string.IsNullOrEmpty(curso.Codigo) ? (object)curso.Codigo : DBNull.Value);
                command.Parameters.AddWithValue("@grado", curso.grado.IdGrado != 0 ? (object)curso.grado.IdGrado : DBNull.Value);
               
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
                            while (reader.Read())
                            {
                                list.Add(new Curso()
                                {
                                    IdCurso = Convert.ToInt32(reader["IDCURSO"]),
                                    Codigo = reader["CODIGO"].ToString(),
                                    grado = new Grado()
                                    {
                                        IdGrado =Convert.ToInt32(reader["GRADO"]),
                                        Nombre = reader["NOMBRE"].ToString()
                                    },
                                    Nombre =$"{reader["NOMBRE"].ToString()}°-{reader["CODIGO"].ToString()}"
                                });
                            }
                            return list;
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
                    Console.WriteLine("Error en SP_CursosCRUD: " + ex.Message);
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
    }
}

