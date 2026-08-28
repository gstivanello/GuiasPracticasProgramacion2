namespace Ejercicio1.Models;

public class CentroDespachos
{
    Queue<Paquete> depositos= new Queue<Paquete>();
    Repartidor camion;

    public CentroDespachos()
    {
        camion = new Repartidor(10);
    }

    public Paquete RecibirCorrespondencia(int dni, string nombre, string direccion)
    { 
        Paquete nuevo=new Paquete(dni, nombre, direccion);
        depositos.Enqueue(nuevo);
        return nuevo;
    }

    public Repartidor PrepararCamion(int capacidad)
    {
        camion = new Repartidor(capacidad);
        return camion;
    }
    public Paquete CargarPaqueteAlCamion()
    {
        Paquete paquete = null;
       if (camion.TieneCapacidadDisponible()==true && depositos.Count > 0)
        {
            paquete = depositos.Dequeue();//saco el paquete
            camion.Cargar( paquete );//lo cargo
        }
        return paquete;//de esta forma si devuelvo null es porque terminé
    }
}
