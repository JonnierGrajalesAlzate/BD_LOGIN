using System;
using System.Data.SQLite;
using System.Windows.Forms;

/*Jonnier Grajales Alzate
 07/10/2024
BD+LOGIN*/

namespace PROCESO_CRUD
{
    public partial class frmInicio : Form
    {
        private int lnIntentos = 0;

        public frmInicio()
        {
            InitializeComponent();
        }

        private static string cadena = @"Data Source=.\mydatabse.db;Version=3;";

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string lcUsuario = txtUsuario.Text;
            int lnClave;
            if (!int.TryParse(txtClave.Text, out lnClave))
            {
                MessageBox.Show("La clave debe ser un número.");
                return;
            }

            using (SQLiteConnection oConexion = new SQLiteConnection(cadena))
            {
                try
                {
                    oConexion.Open();
                    string lcQuery = "SELECT COUNT(1) FROM Persona WHERE nombre=@nombre AND clave=@clave";
                    SQLiteCommand cmd = new SQLiteCommand(lcQuery, oConexion);
                    cmd.Parameters.AddWithValue("@nombre", lcUsuario);
                    cmd.Parameters.AddWithValue("@clave", lnClave);

                    int lnCelda = Convert.ToInt32(cmd.ExecuteScalar());

                    if (lnCelda == 1)
                    {
                        frmAplicacion frmApp = new frmAplicacion();
                        frmApp.Show();
                        this.Hide();
                    }
                    else
                    {
                        lnIntentos++;
                        if (lnIntentos >= 3)
                        {
                            MessageBox.Show("MEJOR DALE AL BOTON DE REGISTRARSE");
                            lnIntentos = 0;
                        }
                        else
                        {
                            MessageBox.Show("La cuenta no existe.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al conectarse a la base de datos: {ex.Message}");
                }
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frm_BaseDatos frmBD = new frm_BaseDatos();
            frmBD.Show();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            frmRegistro frmRegistro = new frmRegistro();
            frmRegistro.Show();
        }
    }
}
