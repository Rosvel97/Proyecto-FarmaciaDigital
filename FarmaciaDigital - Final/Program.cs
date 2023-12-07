using FarmaciaDigital.CapaPresentacion;
using FarmaciaMedicamentos;
using Mostrar_Medicamento;
using ProyectoVarios;
using RecetaMedica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaciaDigital
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmCargando());
            Application.Run(new frmCargando());
        }
    }
}
