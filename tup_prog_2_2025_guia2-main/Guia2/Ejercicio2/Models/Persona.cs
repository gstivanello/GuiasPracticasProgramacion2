namespace Ejercicio2.Models;

public class Persona
{
    public int DNI { get; set; }
    public string Nombre { get; set; }

    public Persona(int dni, string nombre)
    {
       this.DNI = dni;
       this.Nombre = nombre;
    }

    public string Describir()
    {
        return $"{DNI} - {Nombre}";
    }
}
