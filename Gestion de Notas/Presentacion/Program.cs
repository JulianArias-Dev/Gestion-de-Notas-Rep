using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        static Mutex mutex = new Mutex(true, "{BB77D37A-1A67-41B8-84F2-25A9F5B3A9A1}");

        [STAThread]
        static void Main()
        {
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                FormLogin login = new FormLogin();
                Application.Run(login);
                mutex.ReleaseMutex();
            }
            else
            {
                MessageBox.Show("Ya hay una instancia en ejecución de la aplicación.", "Instancia Duplicada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
