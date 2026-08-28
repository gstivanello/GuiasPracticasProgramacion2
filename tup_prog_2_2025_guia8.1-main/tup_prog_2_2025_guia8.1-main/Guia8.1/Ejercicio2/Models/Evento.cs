namespace Ejercicio2.Models;

public class Evento
{
    public DateTime Fecha { get; private set; }
    public string NombreEvento { get; private set; }

    List<Tecnico> tecnicos = new List<Tecnico>();
    List<Persona> personas = new List<Persona>();

    public Evento(DateTime fecha, string nombre)
    {
        this.Fecha = fecha;
        this.NombreEvento = nombre;
    }

    public void RegistrarExportable(IExportable exp)
    {
        //acá podría pedir verificar que no se repitan.
        if (exp is Tecnico)
        {
            tecnicos.Add(exp as Tecnico);
        }
        else if (exp is Persona)
        {
            //en esta lista tengo asistentes y expositores - todas sona personas
            personas.Add(exp as Persona);
        }
    }

    public List<IExportable> VerExportables()
    { 
        List<IExportable> exportables = new List<IExportable>();

        //uno las dos listas
        foreach (Tecnico tec in tecnicos)
        { 
            exportables.Add(tec);
        }

        foreach (Persona per in personas)
        {
            if (per is IExportable) //filtro solo las exportables
            {
                exportables.Add(per as IExportable); //me da error si no casteo, porque no todas las personas son exportables
            }
        }

        return exportables;
    }

    public override string ToString()
    {
        return $"{NombreEvento} {Fecha:dd/MM/yyyy}";
    }
}

