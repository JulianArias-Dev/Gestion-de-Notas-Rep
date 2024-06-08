using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Usuario
    {
        public Usuario() { }
        public int IdUsuario { get; set; }
        public string NombreDeUsuario { get; set; }
        public string Contraseña { get; set; }
        public int Cargo { get; set; }
    }
}
