namespace libEstructuras;

public class NodoNArio<T>
{
    public T Valor { get; set; }
    public List<NodoNArio<T>> Hijos { get; set; }

    public NodoNArio(T valor)
    {
        Valor = valor;
        Hijos = new List<NodoNArio<T>>();
    }
}
