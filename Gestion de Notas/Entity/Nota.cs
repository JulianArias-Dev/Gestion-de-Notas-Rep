using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Nota
    {
        public Nota() { }
        public int Estudiante { get; set; }
        public int Materia { get; set; }
        public decimal NotaValor { get; set; }
        public string Observacion { get; set; }
        public int Periodo { get; set; }
    }
}
