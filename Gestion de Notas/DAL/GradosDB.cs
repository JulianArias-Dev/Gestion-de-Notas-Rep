using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class GradosDB
    {
        static string cadenaConexion;

        public GradosDB()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["stringConnection"].ConnectionString;
        }

        public List<Grado> ListadoGrados()
        {
            string solicitud = "SELECT IDGRADO, NOMBRE FROM [JulianHernandoDavid_NotasDB].[dbo].[GRADOS]";
            var list = new List<Grado>();

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                using (SqlCommand command = new SqlCommand(solicitud, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Grado()
                            {
                                IdGrado=Convert.ToInt32(reader["IDGRADO"].ToString()),
                                Nombre=reader["NOMBRE"].ToString()
                            });
                        }
                    }
                }
            }
            return list;
        }
    }
}
