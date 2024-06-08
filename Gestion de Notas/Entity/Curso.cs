using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Curso
    {
        public Curso() { }
        public int IdCurso { get; set; }
        public string Codigo { get; set; }
        public int Grado { get; set; }
        public string Nombre { get; set; }
    }
}
