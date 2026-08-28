namespace Ejercicio2.Models;

public class OrdenReparacion
{
    public DateTime Fecha { get; set; }
    public Reclamo Reclamo { get; set; }
    public bool Solucionado { get; set; }

    public OrdenReparacion(Reclamo reclamo) 
    {
        Reclamo = reclamo;
        Fecha = DateTime.Now;
    }

    public override string ToString()
    {
        string solText = Solucionado ? "Sí":"No";
        return $"{Reclamo.Numero} - {Reclamo.Nombre} ";
    }
}

