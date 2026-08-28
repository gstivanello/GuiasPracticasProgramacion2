using System.Runtime.Intrinsics.X86;

namespace Ejercicio1.Models;

public class Asalariado:Empleado, IExportable
{
    public double Basico { get; set; }
    public double AportesPrevisionales { get; set; }

    public Asalariado(int dni, string nombre, double basico, double aportes):base(dni,nombre)
    {
        this.Basico = basico;
        this.AportesPrevisionales = aportes;
    }

    public override double CalcularImporteAPagar()
    {
        return Basico - AportesPrevisionales;
    }

    public override string[] GenerarRecibo()
    {
        List<string> recibo = new List<string>();

        recibo.Add($" Empleado: {Nombre}({DNI}");
        recibo.Add($" Basico ${Basico:f2}");
        recibo.Add($" Aportes ${AportesPrevisionales:f2}");
        recibo.Add($" Total: ${CalcularImporteAPagar()}");

        return recibo.ToArray();
    }

    public string Exportar()
    {
        return $"Asalariado;{DNI};{Nombre};{Basico:f2};{AportesPrevisionales}";
    }
}

