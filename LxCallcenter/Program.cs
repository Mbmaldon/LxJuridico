using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LxCallcenter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Modificación para solo abrir una instancia de la aplicación
            bool instanceCountOne = false;
            using (Mutex mtx = new Mutex(true, "LxCallcenter", out instanceCountOne))
            {
                if (instanceCountOne)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Login());
                    mtx.ReleaseMutex();
                }
                else
                {
                    MessageBox.Show("La aplicación ya se encuentra en ejecución", "MiPyME SAS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
		}
    }
}
