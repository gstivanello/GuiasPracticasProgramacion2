
using System.Globalization;

namespace Ejercicio1.Models;

public class Servicio
{
    List<Persona> personas = new List<Persona>();

    public Servicio() 
    {

    }

    public bool AgregarPersona(Persona nueva)
    {
        Persona existente = VerPersonaPorDNI(nueva.DNI);

        if (existente == null)
        {
            personas.Add(nueva);//agregado!!
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
