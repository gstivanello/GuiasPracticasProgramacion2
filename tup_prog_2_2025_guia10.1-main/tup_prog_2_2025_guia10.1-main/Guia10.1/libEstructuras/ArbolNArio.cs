namespace libEstructuras;

public class ArbolNArio<T> where T : IComparable<T>
{
    public NodoNArio<T> Raiz { get; set; }

    public ArbolNArio() { }

    public void Agregar(T valor, NodoNArio<T> padre = null)
    {
        NodoNArio<T> nuevoNodo = new NodoNArio<T>(valor);
        if (padre == null)
        {
            Raiz = nuevoNodo; 
        }
        else
        {
            NodoNArio<T> buscado = BuscarNodo(valor);
            if(buscado==null)
                padre.Hijos.Add(nuevoNodo); 
        }
    }

    public NodoNArio<T> BuscarNodo(T valor)
    {
        if (Raiz != null)
        {
            if (Raiz.Valor.CompareTo(valor) == 0) return Raiz;
        }

        return BuscarNodo(valor, Raiz);
    }

    private NodoNArio<T> BuscarNodo(T valor, NodoNArio<T> nodo)
    {
        if (nodo == null) return null ;

        foreach (var hijo in nodo.Hijos)
        {
            if (hijo.Valor.CompareTo(valor) == 0) return hijo;

            BuscarNodo(valor, hijo);
        }

        return null;
    }

    public List<T> ListarNodos(NodoNArio<T> nodo = null, int nivel = 0)
    {
        List<T> lista = new List<T>();

        if (nodo==null) return lista;

        lista.Add(nodo.Valor);
        
        foreach (var hijo in nodo.Hijos)
        {
            lista.AddRange(ListarNodos(hijo, nivel + 1).ToArray());
        }

        return lista;
    }

    public List<T> ListarNodosRama(T desde, T hasta)
    {
        var nA=BuscarNodo(desde);
        List<T> rama = new List<T>();

        ListarNodosRama(nA, hasta, rama);

        return rama;
    }

    public void ListarNodosRama(NodoNArio<T> nodo, T hasta, List<T> lista)
    {
        if (nodo == null) return;

        lista.Add(nodo.Valor);

        if (nodo.Valor.Equals(hasta)|| nodo.Hijos.Count == 0)
        {    
            return;
        }

        foreach (var hijo in nodo.Hijos)
        {
            List<T> rama = new List<T>();
            ListarNodosRama(hijo, hasta, rama);

            int idx = rama.BinarySearch(hasta);
            if (idx >= 0) 
            { 
                lista.AddRange(rama.ToArray());
                return;
            };
        }
    }
}
