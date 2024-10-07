using PROCESO_CRUD.Logica;
using PROCESO_CRUD.Modelo;
using System;
using System.Windows.Forms;

namespace PROCESO_CRUD
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Persona oPersona = new Persona()
            {
                pcNombrePersona = txtNombre.Text,
                pnClavePersona = int.Parse(txtClave.Text)
            };

            bool respuesta = PersonaLogica.Instacia.Guardar(oPersona);

            if (respuesta)
            {
                MessageBox.Show("Datos guardados correctamente");
                limpiar();
            }
            else
            {
                MessageBox.Show("Error al guardar los datos");
            }
        }

        public void limpiar()
        {
            txtNombre.Text = "";
            txtClave.Text = "";
            txtNombre.Focus();
        }
    }
}
