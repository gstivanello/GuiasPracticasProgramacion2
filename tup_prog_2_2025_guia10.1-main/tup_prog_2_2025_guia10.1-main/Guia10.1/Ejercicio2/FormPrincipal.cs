using Ejercicio2.Models;

namespace Ejercicio2;

public partial class FormPrincipal : Form
{
    CentroDeAtencion centro=new CentroDeAtencion();

    public FormPrincipal()
    {
        InitializeComponent();
    }

    private void btnRegistrarReclamo_Click(object sender, EventArgs e)
    {
        string nombre = tbNombrePersona.Text;
        string motivo = tbMotivo.Text;

        Reclamo nuevo=centro.RecibirReclamo(nombre, motivo);

        lbxVerReclamos.Items.Add(nuevo);

        MessageBox.Show($"Reclamo {nuevo.Numero} registrado");

        tbNombrePersona.Clear();
        tbMotivo.Clear();
    }

    private void btnResolverReclamo_Click(object sender, EventArgs e)
    {
        OrdenReparacion orden = centro.ResolverReclamo();

        //quito de la lista el reclamo
        lbxVerReclamos.Items.Remove(orden.Reclamo);

        lbxVerOrdensAEjecutar.Items.Add(orden);
    }

    private void btnEjecutarOrden_Click(object sender, EventArgs e)
    {
        OrdenReparacion orden= centro.EjecutarOrdenDeTrabajo();
        orden.Solucionado = true;

        lbxVerOrdensAEjecutar.Items.Remove(orden);
    }
}
