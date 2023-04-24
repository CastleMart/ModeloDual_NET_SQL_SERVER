using ModeloDual_NET_Framework.Modelos.Cursos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModeloDual_NET_Framework
{
    public partial class Form1 : Form
    {

        private Actividad act =  new Actividad();
        private Tema tema = new Tema();
        private ConsultaActividad consulta = new ConsultaActividad ();
        private DataTable dt = new DataTable ();

        
        public Form1()
        {
            InitializeComponent();
            
        }

        
    }
}
