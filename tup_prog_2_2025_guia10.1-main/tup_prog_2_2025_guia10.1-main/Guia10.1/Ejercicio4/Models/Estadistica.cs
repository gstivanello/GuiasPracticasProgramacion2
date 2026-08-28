using libEstructuras;

namespace Ejercicio4.Models;

public class Estadistica
{
    private ArbolNArio<Evento> probabilidades { get; set; } = new ArbolNArio<Evento>();

    public Estadistica()
    {
        //evento A
        Evento A = new Evento("A", 1.0);
        probabilidades.Agregar(A);

        //evento B y c 
        NodoNArio<Evento> nodoA = probabilidades.BuscarNodo(A);
        probabilidades.Agregar( new Evento("B", 0.7), nodoA);
        probabilidades.Agregar( new Evento("C", 0.3), nodoA);

        //eventos condicionales de B
        NodoNArio<Evento> nodoB = probabilidades.BuscarNodo(new Evento("B", 0));
        probabilidades.Agregar(new Evento("D", 0.6), nodoB);
        probabilidades.Agregar(new Evento("E", 0.4), nodoB);
    }

    public List<Evento> ListaEventos()
    {
        return probabilidades.ListarNodos(probabilidades.Raiz);
    }

    public List<Evento> ListaEventos(Evento desde, Evento hasta)
    {
      return probabilidades.ListarNodosRama(desde, hasta);
    }
    
    public double ProbabilidadEvento2DadoEvento1(Evento evento1, Evento evento2)
    {
        List<Evento> eventos = ListaEventos(evento1, evento2);
        double prob = 1;
        for (int idx=1;idx<eventos.Count;idx++)
        {
            prob *= eventos[idx].Probabilidad;
        }

        if (eventos.BinarySearch(evento2) < 0) prob = 0;

        return prob;
    }
}

