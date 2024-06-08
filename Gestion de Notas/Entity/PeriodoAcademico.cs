using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class PeriodoAcademico
    {
        public PeriodoAcademico() { }
        public int IdPeriodo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinalizacion { get; set; }
        public string Nombre { get; set; }
        public string Año { get; set; }
    }
}
