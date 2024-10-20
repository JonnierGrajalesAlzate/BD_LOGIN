using System;
using System.Data.SQLite;
using System.Windows.Forms;

/*Jonnier Grajales Alzate
07/10/2024
BD+LOGIN*/

namespace PROCESO_CRUD
{
    public partial class frmLogin : Form
    {
        private int gnIntentos = 0;

        public frmLogin()
        {
            InitializeComponent();
            txtClave.KeyPress += new KeyPressEventHandler(txtClave_KeyPress);
        }

        private static string cadena = @"Data Source=.\mydatabse.db;Version=3;"; 
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string lcUsuario = txtUsuario.Text;
            int lnClave;

            if (!int.TryParse(txtClave.Text, out lnClave))
            {
                MessageBox.Show("La clave debe ser numérica.");
                return;
            }

            if (!lcUsuario.Contains("@"))
            {
                MessageBox.Show("El correo debe contener un '@'.");
                return;
            }

            if (lcUsuario == "alzatejonny39@gmail.com" && lnClave == 1025647244)
            {
                MessageBox.Show("BIENVENIDO SENIOR");
                frm_Admin frmAdministrador = new frm_Admin();
                this.Hide();
                frmAdministrador.FormClosed += (s, args) => this.Close();
                frmAdministrador.Show();
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
                        frmInicioApp frmApp = new frmInicioApp();
                        this.Hide();
                        frmApp.FormClosed += (s, args) => this.Close();
                        frmApp.Show();
                    }
                    else
                    {
                        gnIntentos++;
                        if (gnIntentos >= 3)
                        {
                            MessageBox.Show("MEJOR DALE AL BOTON DE REGISTRARSE");
                            gnIntentos = 0;
                        }
                        else
                        {
                            MessageBox.Show("La cuenta no existe o la clave es incorrecta.");
                        }
                    }
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show($"Error de SQLite: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al conectarse a la base de datos: {ex.Message}");
                }
            }
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void llblRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegistro frmRegistro = new frmRegistro();
            this.Hide();
            frmRegistro.FormClosed += (s, args) => this.Close();
            frmRegistro.Show();
        }
    }
}
