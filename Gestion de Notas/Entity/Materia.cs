using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Materia
    {
        public Materia() { }
        public int IdMateria { get; set; }
        public string Nombre { get; set; }
        public Especialidad especialidad { get; set; }
        public int Grado { get; set; }
        public int Docente { get; set; }
    }
}
