using Ejercicio2.Models;

namespace Ejercicio2;

public partial class FormPrincipal : Form
{
    //no tengo ni lista - ni clase contenedora - gestora -
    //utilizo como contenedor el mismo listbox

    public FormPrincipal()
    {
        InitializeComponent();
    }

    private void btnAltaEvento_Click(object sender, EventArgs e)
    {
        DateTime fecha = dtpFechaEvento.Value;
        string nombre = tbNombreEvento.Text;

        Evento nuevo = new Evento(fecha,nombre);

        lbxVerEventos.Items.Add(nuevo);

        tbNombreEvento.Clear();
    }

    private void btnImportar_Click(object sender, EventArgs e)
    {
        #region seleccion del evento a administrar


        //selecciona el evento
        Evento selected = lbxVerEventos.SelectedItem as Evento;

        if (selected == null)
        {
            MessageBox.Show("Seleccione un evento para proseguir. Sino hay un evento, darlo de alta (1)","Advertencia");
            return;
        }

        #endregion

        #region importación de personas

        FileStream fs = null;
        StreamReader sr = null;
        try
        {
            openFileDialog1.Title = $"Importación de asistentes para el evento {selected.NombreEvento}";
            openFileDialog1.Filter = "Fichero de importación csv|*.csv";
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            { 
                string nombre=openFileDialog1.FileName;

                fs = new FileStream(nombre,FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);

                //Tipo:TECNICO; CUIT; nombre; Cargo
                string linea = sr.ReadLine();
                //Tipo: EXPOSITOR; DNI; Nombre; Papel Protagonico
                linea = sr.ReadLine();

                while (sr.EndOfStream == false)
                {
                    linea = sr.ReadLine();

                    string[] campos = linea.Split(';');

                    //según el discriminador crea uno u otro
                    IExportable registro = null;
                    if (campos[0] == "EXPOSITOR")
                    {
                        registro = new Expositor();
                        
                    }
                    else if (campos[0] == "TECNICO")
                    {
                        registro = new Tecnico();
                    }

                    //invoca al método responsable de importar
                    //cada instancia conoce como importarse --> polimorfismo.
                    if(registro!=null)
                        registro.Leer(campos);//polimorfismo!!!!!!!

                    selected.RegistrarExportable(registro);
                }
            }
        }
        catch (Exception ex)
        { 
            MessageBox.Show(ex.Message+"|"+ex.StackTrace,"Error de importación");
        }
        finally
        {
            if(sr!=null) sr.Close();
            if(fs!=null) fs.Close();
        }

        #endregion
    }

    private void btnExportar_Click(object sender, EventArgs e)
    {
        #region seleccion del evento a administrar

        Evento selected = lbxVerEventos.SelectedItem as Evento;

        if (selected == null)
        {
            MessageBox.Show("Seleccione un evento para proseguir", "Advertencia");
            return;
        }

        #endregion

        #region exportación 

        FileStream fs = null;
        StreamWriter sw = null;
        try
        {
            saveFileDialog1.Title = $"Exportación del evento {selected.NombreEvento}";
            saveFileDialog1.Filter = "Fichero de exportación csv|*.csv";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string nombre = saveFileDialog1.FileName;

                fs = new FileStream(nombre, FileMode.OpenOrCreate, FileAccess.Write);
                sw = new StreamWriter(fs);

                string linea = "Tipo:TECNICO; CUIT; nombre;Cargo";
                sw.WriteLine(linea);
                linea = "Tipo: EXPOSITOR; dni; nombre; PapelProtagonico";
                sw.WriteLine(linea);

                foreach (IExportable ev in selected.VerExportables())
                { 
                    sw.WriteLine(ev.Escribir()); //polimorfismo!!!!!!!
                } 
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message + "|" + ex.StackTrace, "Error de exportación");
        }
        finally
        {
            if (sw != null) sw.Close();
            if (fs != null) fs.Close();
        }

        #endregion
    }
}
