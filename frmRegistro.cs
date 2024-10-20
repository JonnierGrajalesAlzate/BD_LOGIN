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
            txtClave.KeyPress += new KeyPressEventHandler(txtClave_KeyPress);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!txtNombre.Text.Contains("@"))
            {
                MessageBox.Show("El correo debe contener un '@'.");
                return;
            }
            if (!int.TryParse(txtClave.Text, out int pnClavePersona))
            {
                MessageBox.Show("La clave debe ser numérica.");
                return;
            }

            Persona oPersona = new Persona()
            {
                pcNombrePersona = txtNombre.Text,
                pnClavePersona = pnClavePersona
            };

            bool respuesta = PersonaLogica.Instacia.Guardar(oPersona);

            if (respuesta)
            {
                MessageBox.Show("Cuenta Creada Correctamente.");
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

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frmVolver = new frmLogin();
            this.Hide();
            frmVolver.FormClosed += (s, args) => this.Close();
            frmVolver.Show();
        }
    }
}
