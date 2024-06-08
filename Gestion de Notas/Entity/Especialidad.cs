using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Especialidad
    {
        public Especialidad() { }

        public Especialidad(int idEspecialidad, string nombre) {
            IdEspecialidad = idEspecialidad;
            Nombre = nombre;

        }

        public int IdEspecialidad { get; set; }
        public string Nombre { get; set; }
    }
}
