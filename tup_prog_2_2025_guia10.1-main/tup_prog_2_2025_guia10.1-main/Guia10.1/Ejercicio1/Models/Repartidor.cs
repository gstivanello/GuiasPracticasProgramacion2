namespace Ejercicio1.Models;

public class Repartidor
{
    Stack<Paquete> entregas = new Stack<Paquete>();

    public int Capacidad { get; private set; }
    public int Ocupacion
    {
        get 
        {
            return entregas.Count;
        }
    }

    public Repartidor(int capacidad)
    { 
        this.Capacidad = capacidad;
    }

    public Paquete Revisar()
    {
        if (entregas.Count > 0)
            return entregas.Peek();
        return null;   
    }

    public void Cargar(Paquete en)
    {
        if(TieneCapacidadDisponible()==true)
            entregas.Push(en);
    }

    public Paquete Descargar()
    {
        if(entregas.Count>0)
            return entregas.Pop();
        return null;
    }

    public bool TieneCapacidadDisponible()
    {
        return Capacidad - Ocupacion>0;
    }

}

