namespace Ejercicio3.Models;

public class CentralTaxis
{
    Queue<Movil> movilesDisponibles=new Queue<Movil>();
    LinkedList<Movil> movilesOcupados = new LinkedList<Movil>();

    Queue<Pedido> pedidos = new Queue<Pedido>();
    
    public CentralTaxis()
    {
        //inicio los móviles de la empresa
        for (int n = 0; n < 4; n++)
        {
            movilesDisponibles.Enqueue(new Movil(n));
        }
    }

    public int CantidadDisponibles { get { return movilesDisponibles.Count; } }
    public Movil VerDisponible(int idx)
    {
        if (idx >= 0 && idx < CantidadDisponibles)
        {
            //no es lo mejor esta opcion,pero sino tengo que cambiar mucho el modelo
            return movilesDisponibles.ToArray()[idx];
        }
        return null;
    }

    public Pedido RecibirSolicitud(string tel, string direccion)
    {
        Pedido nuevo = new Pedido(tel, direccion);
        pedidos.Enqueue(nuevo);
        return nuevo;
    }

    public Movil AsignarCoche()
    {
        if (movilesDisponibles.Count > 0 && pedidos.Count > 0)
        {
            Movil disponible = movilesDisponibles.Dequeue();
            Pedido pedido = pedidos.Dequeue();

            disponible.Pasajero = pedido;

            movilesOcupados.AddLast(disponible);
            return disponible;
        }
        return null; //no hubo asignación
    }

    public Movil LiberarVehiculo(int numero)
    {
        Movil libre = null;//me va a indicar si fue exitosa la asignación

        LinkedListNode<Movil> nodo = movilesOcupados.First;
        while (nodo!=null && libre==null)
        {
            if (nodo.Value.Numero == numero)//busco por numero de vehiculo
            {
                libre = nodo.Value;
            }
            nodo=nodo.Next;
        }

        if (libre != null)
        {
            libre.Pasajero = null;//desvinculo con el pedido/cliente/pedido
            movilesDisponibles.Enqueue(libre);
            movilesOcupados.Remove(libre);  
        }
                   
        return libre;
    }
}
