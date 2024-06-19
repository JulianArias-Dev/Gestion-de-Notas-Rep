using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Docente
    {
        public Docente() { }
        public int IdDocente { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Identificacion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public int Usuario { get; set; }
        public string email { get; set; }
        public int Edad { get; set; }
        public List<Especialidad> Especializaciones { get; set; }
    }
}
