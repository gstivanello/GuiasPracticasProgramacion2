
namespace Ejercicio3.Models;

public class Pedido
{
    public string Telefono { get; private set; }
    public string Direccion { get; private set; }

    public Pedido(string telefono, string direccion)
    {
        Telefono = telefono;
        Direccion = direccion;
    }

    public override string ToString()
    {
        return $"{Telefono} {Direccion}";
    }
}
