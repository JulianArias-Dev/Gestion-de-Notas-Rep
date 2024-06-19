using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Curso
    {
        public Curso() {
            grado=new Grado();
        }

        public int IdCurso { get; set; }
        public string Codigo { get; set; }
        public Grado grado { get; set; }
        public string Nombre { get; set; }

        public string showCurso()
        {
            return $"id: {IdCurso}\n" +
                $"Grado: {grado.Nombre}\n" +
                    $"Codigo: {Codigo}\n" +
                    $"Nombre: {grado.Nombre}°{Codigo}";
        }
    }
}
