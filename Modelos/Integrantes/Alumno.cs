using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDual_NET_Framework.Modelos.Integrantes
{
    internal class Alumno : Persona
    {
        private int noControl;
        private double promedioEscuela, promedioDual;
        private String escuela;

        public Alumno(string nombres, string apellidoP, string apellidoM, string apellidoP1, char sexo, 
                        int noControl, double promedioEscuela, double promedioDual, string escuela)
                         : base(nombres, apellidoP, apellidoM, apellidoP1, sexo)
        {
            this.NoControl = noControl;
            this.PromedioEscuela = promedioEscuela;
            this.PromedioDual = promedioDual;
            this.Escuela = escuela;
        }


        public int NoControl { get => noControl; set => noControl = value; }
        public double PromedioEscuela { get => promedioEscuela; set => promedioEscuela = value; }
        public double PromedioDual { get => promedioDual; set => promedioDual = value; }
        public string Escuela { get => escuela; set => escuela = value; }
    }
}
