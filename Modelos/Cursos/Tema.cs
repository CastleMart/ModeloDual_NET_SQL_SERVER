using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDual_NET_Framework.Modelos.Cursos
{
    internal class Tema : Actividad
    {
        
        public Tema(int id, string nombre, string descripcion, double horas, double calificacion) : base(id, nombre, descripcion, horas, calificacion)
        {
        }
        public Tema()
        {

        }

        
    }
}
