using Entity;
using System;

using DAL;
using System.Data;

namespace BLL
{
    public class AcudientesService
    {
        private static AcudientesDB database = new AcudientesDB(); 

        public static DataTable ListaAcudientes()
        {
            return database.selectforDgv();
        }
        
        public static Acudiente BuscarAcudiente(Acudiente acudiente)
        {
            return (Acudiente)database.SP_AcudientesCRUD(acudiente, 1);
        }

        public static string InsertarAcudiente(Acudiente acudiente)
        {
            int result = Convert.ToInt32(database.SP_AcudientesCRUD(acudiente, 2));
            
            string message = Resultado(result, acudiente);
            
            return message;
        }

        public static string ModificarAcudiente(Acudiente acudiente)
        {
            int result = Convert.ToInt32(database.SP_AcudientesCRUD(acudiente, 3));
            
            string message = Resultado(result, acudiente);

            return message;
        }

        public static string EliminarAcudiente(Acudiente acudiente)
        {
            int result = Convert.ToInt32(database.SP_AcudientesCRUD(acudiente, 4));

            string message = Resultado(result, acudiente);

            return message;
        }


        private static string Resultado(int code, Acudiente acudiente)
        {
            string[] parametros = new string[] { acudiente.email, $"{acudiente.primerNombre} {acudiente.primerApellido}" };

            switch (code)
            {
                case 235:
                    return $"Error {code}: El acudiente no está registrado, no se pudo realizar la operación.";
                case 236:
                    return $"Error {code}: Los datos del acudiente no se pueden Eliminar porque hay estudiantes asociados al mismo.";
                case 301:
                    return $"Error {code}: Identificación duplicada, ya hay un acudiente con una identificación similar.";
                case 302:
                    return $"Error {code}: Correo electrónico duplicado, ya hay un acudiente con una direccion de correo electronico similar.";
                case 303:
                    return $"Error {code}: Teléfono duplicado, ya hay un acudiente con un numero de telefono similar.";
                case 201:
                    SendMails.EnviarNotificacion(parametros, 2);
                    return $"Se han registrado exitosamente los datos del acudiente";
                case 202:
                    SendMails.EnviarNotificacion(parametros, 3);
                    return $"Se han modificado exitosamente los datos del acudiente";
                case 203:
                    SendMails.EnviarNotificacion(parametros, 4);
                    return $"Se han eliminado correctamente los datos del acudiente";
                default:
                    return $"Error desconocido: Código {code}";
            } 
        }
    }
}
