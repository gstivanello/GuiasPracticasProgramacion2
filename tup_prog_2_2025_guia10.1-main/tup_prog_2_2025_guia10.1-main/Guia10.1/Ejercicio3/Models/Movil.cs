namespace Ejercicio3.Models;

public class Movil : IComparable<Movil>
{
    public int Numero { get; private set; }
    public Pedido Pasajero { get; set; }

    public Movil(int numero)
    { 
        Numero = numero;
    }

    public int CompareTo(Movil other)
    {
        if(other !=null) return Numero.CompareTo(other.Numero);
        return 1;
    }

    public override string ToString()
    {
        return $"Móvil: {Numero}";
    }
}

