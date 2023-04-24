using ModeloDual_NET_Framework.Controlador;
using ModeloDual_NET_Framework.Modelos.Cursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModeloDual_NET_Framework
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Conexion con = new Conexion();
            Actividad actividad = new Actividad();
            Tema tema = new Tema();
            ConsultaActividad consulta = new ConsultaActividad();
            Form1 form1 = new Form1();
            CtrlActividad ctrlAct = new CtrlActividad(actividad,tema,consulta,form1);
            ctrlAct.iniciar();
            form1.Visible = true;

            //Console.WriteLine("El servidor es: ");
            //Console.WriteLine(con.retornarMensaje());
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(form1);
        }
    }
}
