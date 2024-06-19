using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Estudiante
    {
        public Estudiante() { }
        public int IdEstudiante { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Identificacion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public Curso Curso { get; set; }
        public string Email { get; set; }
        public int Edad { get; set; }
        public Acudiente Acudiente { get; set; }
        public string Estado { get; set; }

        public string showStudent()
        {
            return $"Identificación: {Identificacion}\n" +
                   $"Primer Nombre: {PrimerNombre}\n" +
                   $"Segundo Nombre: {SegundoNombre}\n" +
                   $"Primer Apellido: {PrimerApellido}\n" +
                   $"Segundo Apellido: {SegundoApellido}\n" +
                   $"Email: {Email}\n" +
                   $"Teléfono: {Telefono}\n" +
                   $"Dirección: {Direccion}\n" +
                   $"Fecha de Nacimiento: {FechaNacimiento.ToShortDateString()}\n" +
                   $"Curso: {Curso.Nombre}\n" +
                   $"Acudiente: {Acudiente.primerNombre} {Acudiente.primerApellido}";
        }
    }
}
