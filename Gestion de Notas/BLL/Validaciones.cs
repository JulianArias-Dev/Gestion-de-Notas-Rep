using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL
{
    public static class Validaciones
    {
        public static bool ValCorreo(string ComprobarEmail)
        {
            string emailFormato;
            emailFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(ComprobarEmail, emailFormato))
            {
                if (Regex.Replace(ComprobarEmail, emailFormato, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;

                }
            }
            else
            {
                return false;
            }
        }
        public static bool valTelefono(string ComprobarTelefono)
        {
            string telefonoformato;
            telefonoformato = @"^\d{10}$";
            if (Regex.IsMatch(ComprobarTelefono, telefonoformato))
            {
                if (Regex.Replace(ComprobarTelefono, telefonoformato, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;

                }
            }
            else
            {
                return false;
            }
        }

        public static bool ValIdentificacion(string ComprobarIdentificacion)
        {
                string[] patrones = new string[]
                {
                    @"^\d{8,10}$",                  // Cédula de Ciudadanía (8 a 10 dígitos)
                    @"^[EP]-\d{6,9}$",              // Cédula de Extranjería (ej. E-1234567, P-123456789)
                    @"^[A-Z0-9]{9}$",               // Pasaporte (9 caracteres alfanuméricos)

                };

                foreach (var pattern in patrones)
                {
                    if (Regex.IsMatch(ComprobarIdentificacion, pattern))
                    {
                        return true;
                    }
                }

                return false;
        }
    }
    
}
