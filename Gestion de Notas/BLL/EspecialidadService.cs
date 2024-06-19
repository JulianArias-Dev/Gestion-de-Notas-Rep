using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;
using System.Data;

namespace BLL
{
    public class EspecialidadService
    {
        private static EspecialidadDB database = new EspecialidadDB();

        public List<Especialidad> ObtenerTodasEspecialidades()
        {
            try
            {
                return database.ObtenerTodasEspecialidades();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las especialidades.", ex);
            }
        }

        public static Especialidad BuscarEspecialidad(int idEspecialidad)
        {
            List<Especialidad> especialidades = database.ObtenerEspecialidad(idEspecialidad);
            return especialidades.Count > 0 ? especialidades[0] : null;
        }

        public static string InsertarEspecialidad(string nombre)
        {
            try
            {
                int result = database.RegistrarEspecialidad(nombre);
                return $"Especialidad registrada exitosamente con ID: {result}";
            }
            catch (Exception ex)
            {
                return ManejarErrores(ex.Message);
            }
        }

        public static string ModificarEspecialidad(int idEspecialidad, string nombre)
        {
            try
            {
                database.ActualizarEspecialidad(idEspecialidad, nombre);
                return "Especialidad modificada exitosamente.";
            }
            catch (Exception ex)
            {
                return ManejarErrores(ex.Message);
            }
        }

        public static string EliminarEspecialidad(int idEspecialidad)
        {
            try
            {
                database.EliminarEspecialidad(idEspecialidad);
                return "Especialidad eliminada exitosamente.";
            }
            catch (Exception ex)
            {
                return ManejarErrores(ex.Message);
            }
        }

        private static string ManejarErrores(string mensajeError)
        {
            switch (mensajeError)
            {
                case "Error Code: 235":
                    return "Error 235: La especialidad no está registrada, no se pudo realizar la operación.";
                case "Error Code: 301":
                    return "Error 301: Nombre duplicado, ya hay una especialidad con un nombre similar.";
                default:
                    return $"Error desconocido: {mensajeError}";
            }
        }
    }
}
