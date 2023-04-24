using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDual_NET_Framework.Modelos.Cursos
{
    internal class Actividad
    {
        //Atributos de la clase actividad.
        private int id;
        private String nombre, descripcion;
        private double horas, calificacion;

        public Actividad(int id, string nombre, string descripcion, double horas, double calificacion)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Horas = horas;
            this.Calificacion = calificacion;
        }
        public Actividad()
        {

        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Horas { get => horas; set => horas = value; }
        public double Calificacion { get => calificacion; set => calificacion = value; }
        public void limpiarActividades()
        {
            this.Id = -1;
            this.Nombre = "";
            this.Descripcion = "";
            this.Horas = -1;
            this.Calificacion = -1;
        }
    }
}
