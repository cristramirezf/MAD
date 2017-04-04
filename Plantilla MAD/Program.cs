using System;
using System.Windows.Forms;

namespace Plantilla_MAD
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Ventanas.VentPrincipal());
        }
    }
}

/*
al actualizar planes:
AGILIDAD MASIVO: PORTA
AGILIDAD NORMAL: HL, HLS106, HMM, HMMPA, MIGPPSS, PORTA
COMPLEJIDAD NORMAL
    OTROS: CAMBIODEPLAN, 
    RECLAMOS:
    SOLICITUDES: CESION, TRASPASO

al actualizar equipos
AGILIDAD NORMAL: CEQ, CEQMM, CEQMMPA, HL (x2), HMM. HMMPA, VE

    

    */