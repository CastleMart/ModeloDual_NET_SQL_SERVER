using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDual_NET_Framework.Modelos.Integrantes
{
    internal class Persona
    {
        //Atributos de la clase persona
        private String nombres;
        private String apellidoP;
        private String apellidoM;
        private char sexo;

        public Persona(string nombres, string apellidoP, string apellidoM, string apellidoP1, char sexo)
        {
            this.Nombres = nombres;
            this.ApellidoP = apellidoP;
            this.ApellidoM = apellidoM;
            this.Sexo = sexo;
        }

        public string Nombres { get => nombres; set => nombres = value; }
        public string ApellidoP { get => apellidoP; set => apellidoP = value; }
        public string ApellidoM { get => apellidoM; set => apellidoM = value; }
        public char Sexo { get => sexo; set => sexo = value; }
    }
}
