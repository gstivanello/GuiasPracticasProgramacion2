using Ejercicio4.Models;

namespace Ejercicio4;

public partial class FormPrincipal : Form
{
    Estadistica estadistica = new Estadistica();

    public FormPrincipal()
    {
        InitializeComponent();
    }

    private void FormPrincipal_Load(object sender, EventArgs e)
    {
        cbxDesde.Items.AddRange(estadistica.ListaEventos().ToArray());
        cbxHasta.Items.AddRange(estadistica.ListaEventos().ToArray());
    }

    private void btnVerTodosNodos_Click(object sender, EventArgs e)
    {
        tbVer.Clear();
        foreach (Evento evento in estadistica.ListaEventos())
        {
            tbVer.Text += evento + Environment.NewLine;
        }
    }

    private void btnCalcular_Click(object sender, EventArgs e)
    {
        Evento evento1 = cbxDesde.SelectedItem as Evento;
        Evento evento2 = cbxHasta.SelectedItem as Evento;

        tbVer.Clear();
        foreach (Evento evento in estadistica.ListaEventos(evento1, evento2))
        {
            tbVer.Text += evento + Environment.NewLine;
        }
        lbHijoDadoAncestro.Text = estadistica.ProbabilidadEvento2DadoEvento1(evento1, evento2).ToString("0.00");
    }
}
