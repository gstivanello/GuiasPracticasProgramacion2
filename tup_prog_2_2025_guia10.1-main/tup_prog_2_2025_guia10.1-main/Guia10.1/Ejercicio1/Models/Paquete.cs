namespace Ejercicio1.Models;

public class Paquete
{
    public int DNIRemitente { get; set; }
    public string NombreRemitente { get; set; }
    public string Direccion { get; set; }
    
    public Paquete(int dni, string nombre, string direccion)
    {
        DNIRemitente = dni;
        NombreRemitente = nombre;
        Direccion = direccion;
    }

    public override string ToString()
    {
        return $"{NombreRemitente}({DNIRemitente}) - {Direccion}";
    }
}
