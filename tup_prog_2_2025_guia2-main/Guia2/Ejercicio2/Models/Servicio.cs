namespace Ejercicio2.Models;

public class Servicio
{
    List<Persona> personas = new List<Persona>();

    public Servicio() 
    {

    }

    public bool AgregarPersona(int dni, string nombre)
    {
        Persona existente = VerPersonaPorDNI(dni);

        if (existente == null)
        {
            personas.Add(new Persona(dni,nombre));//agregado!! notar que lo instancio dentro de la clase
            return true;
        }

        return false;
    }


    public int VerCantidadPersonas()
    {
        return personas.Count;
    }

    public Persona VerPersona(int n)
    {
        if(n>=0 && n<=personas.Count)
            return personas[n];
        return null;
    }

    public Persona VerPersonaPorDNI(int dni)
    {
        int idx = -1;
        int n = 0;
        while (idx == -1 && n < personas.Count)
        {
            if (personas[n].DNI==dni)
            {
                idx = n;
            }
            n++;
        }

        if(idx>-1)
            return personas[idx];
        else         
            return null;
    }

    public void EliminarPersona(Persona persona)
    {
        Persona existente = VerPersonaPorDNI(persona.DNI);

        if (existente != null)
        {
            personas.Remove(persona);//eliminado!!
        }
    }
}
