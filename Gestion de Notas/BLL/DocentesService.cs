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
    public class DocentesService
    {

        private static DocentesDB database = new DocentesDB();

        public static DataTable ListaDocentes()
        {
            return database.SelectForDgv();
        }

        public Docente BuscarDocente(Docente docente)
        {
            return (Docente)database.SP_DocentesCRUD(docente, 1);
        }

        public string InsertarDocente(Docente docente)
        {
            int result = Convert.ToInt32(database.SP_DocentesCRUD(docente, 2));

            string message = Resultado(result, docente);

            return message;
        }

        public string ModificarDocente(Docente docente)
        {
            int result = Convert.ToInt32(database.SP_DocentesCRUD(docente, 3));

            string message = Resultado(result, docente);

            return message;
        }

        public string EliminarDocente(Docente docente)
        {
            int result = Convert.ToInt32(database.SP_DocentesCRUD(docente, 4));

            string message = Resultado(result, docente);

            return message;
        }

        private string Resultado(int code, Docente docente)
        {
            string[] parametros = new string[] { docente.email, $"{docente.PrimerNombre} {docente.PrimerApellido}" };

            switch (code)
            {
                case 235:
                    return $"Error {code}: El docente no está registrado, no se pudo realizar la operación.";
                case 236:
                    return $"Error {code}: Los datos del docente no se pueden eliminar porque hay estudiantes asociados al mismo.";
                case 301:
                    return $"Error {code}: Identificación duplicada, ya hay un docente con una identificación similar.";
                case 302:
                    return $"Error {code}: Correo electrónico duplicado, ya hay un docente con una dirección de correo electrónico similar.";
                case 303:
                    return $"Error {code}: Teléfono duplicado, ya hay un docente con un número de teléfono similar.";
                case 201:
                    SendMails.EnviarNotificacion(parametros, 2);
                    return $"Se han registrado exitosamente los datos del docente";
                case 202:
                    SendMails.EnviarNotificacion(parametros, 3);
                    return $"Se han modificado exitosamente los datos del docente";
                case 203:
                    SendMails.EnviarNotificacion(parametros, 4);
                    return $"Se han eliminado correctamente los datos del docente";
                default:
                    return $"Error desconocido: Código {code}";
            }
        }
    }
}
