using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EstudiantesService
    {
        private static EstudiantesDB database = new EstudiantesDB();

        public static DataTable ListaEstudiantes()
        {
            return database.selectforDgv();
        }

        public static DataTable EstudiantesporCurso(int curso)
        {
            return database.selectforGroupe(curso);
        }

        public static Estudiante BuscarEstudiante(Estudiante estudiante)
        {
            return (Estudiante)database.SP_EstudiantesCRUD(estudiante, 1);
        }

        public static string InsertarEstudiante(Estudiante estudiante)
        {
            int result = Convert.ToInt32(database.SP_EstudiantesCRUD(estudiante, 2));

            string message = Resultado(result, estudiante);

            return message;
        }

        public static string ModificarEstudiante(Estudiante estudiante)
        {
            int result = Convert.ToInt32(database.SP_EstudiantesCRUD(estudiante, 3));

            string message = Resultado(result, estudiante);

            return message;
        }

        public static string EliminarEstudiante(Estudiante estudiante)
        {
            int result = Convert.ToInt32(database.SP_EstudiantesCRUD(estudiante, 4));

            string message = Resultado(result, estudiante);

            return message;
        }

        private static string Resultado(int code, Estudiante estudiante)
        {
            string[] parametros = new string[] { estudiante.Email, $"{estudiante.PrimerNombre} {estudiante.PrimerApellido}" };

            switch (code)
            {
                case 235:
                    return $"Error {code}: El estudiante no está registrado, no se pudo realizar la operación.";
                case 301:
                    return $"Error {code}: Identificación duplicada. Ya se encuentra en uso una identificación similar.";
                case 302:
                    return $"Error {code}: Correo electrónico duplicado. Ya se encuentra en uso una dirección de correo electrónico similar.";
                case 303:
                    return $"Error {code}: Teléfono duplicado. Ya se encuentra en uso un número de teléfono similar.";
                case 304:
                    return $"Error {code}: El acudiente del estudiante parece no estar registrado.";
                case 305:
                    return $"Error {code}: El curso al cual quiere agregar este estudiante, no existe.";
                case 306:
                    return $"Error {code}: No se puede eliminar el estudiante mientras pertenezca a un curso.";
                case 201:
                    SendMails.EnviarNotificacion(parametros, 2);
                    return $"Se han registrado exitosamente los datos del estudiante";
                case 202:
                    SendMails.EnviarNotificacion(parametros, 3);
                    return $"Se han modificado exitosamente los datos del estudiante";
                case 203:
                    SendMails.EnviarNotificacion(parametros, 4);
                    return $"Se han eliminado correctamente los datos del estudiante";
                default:
                    return $"Error desconocido: Código {code}";
            }
        }
    }
}
