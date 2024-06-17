using System;
namespace Entity
{
    public class Acudiente
    {
        public Acudiente() { }

        public int idAcudiente { get; set; }
        public string primerNombre { get; set; }
        public string segundoNombre { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public string identificacion { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public int Edad { get; set; }


        public string showAcudiente()
        {
            return $"Identificación: {identificacion}\n" +
                   $"Primer Nombre: {primerNombre}\n" +
                   $"Segundo Nombre: {segundoNombre}\n" +
                   $"Primer Apellido: {primerApellido}\n" +
                   $"Segundo Apellido: {segundoApellido}\n" +
                   $"Email: {email}\n" +
                   $"Teléfono: {telefono}\n" +
                   $"Dirección: {direccion}\n" +
                   $"Fecha de Nacimiento: {fechaNacimiento.ToShortDateString()}\n";
        }

    }
}
