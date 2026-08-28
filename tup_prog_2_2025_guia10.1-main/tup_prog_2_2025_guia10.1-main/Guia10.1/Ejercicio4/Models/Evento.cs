using System;

namespace Ejercicio4.Models
{
    public class Evento : IComparable<Evento>
    {
        public string Nombre { get; set; }
        public double Probabilidad { get; set; }

        public Evento(string nombre, double probabilidad)
        {
            Nombre = nombre;
            Probabilidad = probabilidad;
        }

        public int CompareTo(Evento other)
        {
            if(other !=null)
                return Nombre.CompareTo(other.Nombre);
            return 1;
        }

        public override string ToString()
        {
            return $"Evento:{Nombre} - Probabilidad:{Probabilidad}";
        }
    }
}
