namespace Ejercicio2.Models;

public class Reclamo
{
    public int Numero { get; set; }
    public string Nombre { get; set; }
    public string Motivo { get; set; }

    public Reclamo(int numero, string nombrePersona, string motivo)
    {
        Numero = numero;
        Nombre = nombrePersona;
        Motivo = motivo;
    }

    public override string ToString()
    {
        return $"{Numero} - {Nombre}: {Motivo}";
    }
}
