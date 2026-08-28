using Ejercicio1.Models;

namespace Ejercicio1
{
    public partial class FormPrincipal : Form
    {
        Servicio servicio = new Servicio();
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ActualizarLista();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormDatos formDatos = new FormDatos();

            if (formDatos.ShowDialog() == DialogResult.OK)
            {
                int dni = Convert.ToInt32(formDatos.tbDNI.Text);
                string nombre = formDatos.tbNombre.Text;

                Persona nueva = new Persona(dni, nombre);
                if(servicio.AgregarPersona(nueva)==true)
                 {
                    MessageBox.Show("Persona agregada correctamente.");
                }
                else
                {
                    MessageBox.Show("Error al agregar la persona. Verifique que no exista ya una persona con ese dni");
                }

                ActualizarLista();

                //alternativa:
                //btnListar.PerformClick();
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            FormDatos formDatos = new FormDatos();

            #region habilito solo el nombre para modificar
            formDatos.tbDNI.Enabled = false;
            formDatos.tbNombre.Enabled = false;
            formDatos.btnAceptar.Enabled = true;
            formDatos.btnCancelar.Visible = false;
            formDatos.btnAceptar.Text = "Cerrar";
            #endregion

            Persona persona = servicio.VerPersona(lbxPersonas.SelectedIndex);

            if (persona != null)
            {
                #region pinto la ventana modal
                formDatos.tbDNI.Text = persona.DNI.ToString();
                formDatos.tbNombre.Text = persona.Nombre;
                #endregion

                formDatos.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error al modificar la persona. No se ha seleccionado una persona del listado o fallo la búsqueda.");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FormDatos formDatos = new FormDatos();

            #region habilito solo el nombre para modificar
            formDatos.tbDNI.Enabled = false;
            formDatos.tbNombre.Enabled = true;
            #endregion

            Persona persona = servicio.VerPersona(lbxPersonas.SelectedIndex);

            if (persona != null)
            {
                #region pinto la ventana modal
                formDatos.tbDNI.Text= persona.DNI.ToString();
                formDatos.tbNombre.Text = persona.Nombre;
                #endregion

                if (formDatos.ShowDialog() == DialogResult.OK)
                {                 
                    string nombre= formDatos.tbNombre.Text; 

                    persona.Nombre = nombre;
                    MessageBox.Show("Se ha modificado los datos de la persona");
                }
            }
            else
            {
                MessageBox.Show("Error al modificar la persona. No se ha seleccionado una persona del listado o fallo la búsqueda.");
            }

            ActualizarLista();
            //alternativa:
            //btnListar.PerformClick();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            FormDatos formDatos = new FormDatos();

            Persona persona = servicio.VerPersona(lbxPersonas.SelectedIndex);

            if (persona != null)
            {
                servicio.EliminarPersona(persona);
                lbxPersonas.Items.RemoveAt(lbxPersonas.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Error al eliminar la persona. No se ha seleccionado una persona del listado o fallo la búsqueda.");
            }

            ActualizarLista();
            //alternativa:
            //btnListar.PerformClick();
        }

        private void ActualizarLista()
        {
            //actualizar listado
            lbxPersonas.Items.Clear();
            for (int n = 0; n < servicio.VerCantidadPersonas(); n++)
            {
                Persona p = servicio.VerPersona(n);
                lbxPersonas.Items.Add(p.Describir());
            }
        }
    }
}
