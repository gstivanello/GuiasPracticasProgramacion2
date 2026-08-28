using Ejercicio3.Models;

namespace Ejercicio3_CentroTaxis;

public partial class FormPrincipal : Form
{
    CentralTaxis central=new CentralTaxis();

    public FormPrincipal()
    {
        InitializeComponent();
    }

    private void FormPrincipal_Load(object sender, EventArgs e)
    {
        for (int idx = 0; idx < central.CantidadDisponibles; idx++)
        {
           lbxDisponibles.Items.Add( central.VerDisponible(idx));
        }
    }

    private void btnAtender_Click(object sender, EventArgs e)
    {
        string tel = tbTelefono.Text;
        string direccion = tbDireccion.Text;

        Pedido nuevo=central.RecibirSolicitud(tel, direccion);

        lbxPedidosEntrantes.Items.Add(nuevo);

        tbTelefono.Clear();
        tbDireccion.Clear();
    }

    private void btnAsignar_Click(object sender, EventArgs e)
    {
        Movil movil=central.AsignarCoche();
        if (movil == null)
        {
            MessageBox.Show("No hay móvil disponible");
        }
        else
        {
            lbxDisponibles.Items.Remove(movil);
            lbxPedidosEntrantes.Items.Remove(movil.Pasajero);//remueve el pedido de pedidos entrantes

            lbxOcupados.Items.Add(movil);
            
            MessageBox.Show($"Móvil Número: {movil.Numero} asignado al cliente: {movil.Pasajero.Telefono}");
        }
    }

    private void btnLiberar_Click(object sender, EventArgs e)
    {
        int numeroMovil = Convert.ToInt32(nupNumeroMovil.Value);
        Movil movil=central.LiberarVehiculo(numeroMovil);

        if (movil == null)
        {
            MessageBox.Show("No se encontró ese móvil");
        }
        else
        {
            lbxOcupados.Items.Remove(movil);
            lbxDisponibles.Items.Add(movil);
        }
    }

   
}
