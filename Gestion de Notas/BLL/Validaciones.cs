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
            string idformato;
            idformato = @"^106\d{7}$";
            if (Regex.IsMatch(ComprobarIdentificacion, idformato))
            {
                if (Regex.Replace(ComprobarIdentificacion, idformato, string.Empty).Length == 0)
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
    }
}
