using PROCESO_CRUD.Logica;
using PROCESO_CRUD.Modelo;
using System;
using System.Windows.Forms;


namespace PROCESO_CRUD
{
    public partial class frm_Admin : Form
    {
        public frm_Admin()
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

            bool llRespuesta = PersonaLogica.Instacia.Guardar(oPersona);

            if (llRespuesta)
            {
                limpiar();
                mostrar_personas();
            }

        }

        public void mostrar_personas() {
            dgvPersonas.DataSource = null;
            dgvPersonas.DataSource = PersonaLogica.Instacia.Listar();
        }

        public void limpiar()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtClave.Text = "";
            txtNombre.Focus();
        }

        private void fmr_Panel_Load(object sender, EventArgs e)
        {
            dgvPersonas.AutoGenerateColumns = false; 
            dgvPersonas.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "pnCedulaPersona",          
                HeaderText = "id",       
                DataPropertyName = "pnIdPersona" 
            });

            dgvPersonas.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "pcNombrePersona",
                HeaderText = "Correo Electronico",
                DataPropertyName = "pcNombrePersona"
            });

            dgvPersonas.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "pnClavePersona",
                HeaderText = "Clave Numérica",
                DataPropertyName = "pnClavePersona"
            });

            mostrar_personas();
        }

         

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Persona oPersona = new Persona()
            {
                pnIdPersona = int.Parse(txtId.Text) 
            };

            bool llRespuesta = PersonaLogica.Instacia.Eliminar(oPersona);

            if (llRespuesta)
            {
                limpiar();
                mostrar_personas();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Persona oPersona = new Persona()
            {
                pnIdPersona = int.Parse(txtId.Text),
                pcNombrePersona = txtNombre.Text,
                pnClavePersona = int.Parse(txtClave.Text)
            };

            bool llRespuesta = PersonaLogica.Instacia.Actualizar(oPersona);

            if (llRespuesta)
            {
                limpiar();
                mostrar_personas();
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
