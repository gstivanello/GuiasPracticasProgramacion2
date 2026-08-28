namespace Ejercicio2.Models;

public class CentroDeAtencion
{
    Queue<Reclamo> reclamosPendientes= new Queue<Reclamo>();
    Queue<OrdenReparacion> trabajosPendientes = new Queue<OrdenReparacion>();

    int numeroReclamoGen=0;

    public CentroDeAtencion()
    {
    }

    public Reclamo RecibirReclamo(string nombrePersona, string motivo)
    { 

        //el cliente me "produce" los reclamos
        Reclamo nuevo=new Reclamo(++numeroReclamoGen, nombrePersona, motivo);

        //y los voy dejando en la bandeja 
        reclamosPendientes.Enqueue(nuevo);

        return nuevo;
    }

    //desde el centro resuelve el cliente planificando ese reclamo en una orden de reparación

    public OrdenReparacion ResolverReclamo()
    {
        OrdenReparacion orden = null;

        if (reclamosPendientes.Count > 0)
        {
            Reclamo reclamo = reclamosPendientes.Dequeue();

            orden = new OrdenReparacion(reclamo);

            trabajosPendientes.Enqueue(orden);
        }

        return orden;
    }

    public OrdenReparacion EjecutarOrdenDeTrabajo()
    {
        OrdenReparacion orden = null;

        if (trabajosPendientes.Count > 0)
        {
            orden = trabajosPendientes.Dequeue();
        }

        return orden;
    }
}
