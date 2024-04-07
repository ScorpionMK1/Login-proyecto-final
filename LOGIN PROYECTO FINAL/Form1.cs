using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace LOGIN_PROYECTO_FINAL
{
    public partial class Form1 : Form
    {
        private string connectionString = "Host=localhost;Username=postgres;Password=902013;Database=Almacen"; 

        public Form1()
        {
            InitializeComponent();
        }

        private bool VerificarCredenciales(string usuario, string contraseña)
        {
            using (NpgsqlConnection con = new NpgsqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM usuario WHERE usuario = @usuario AND contraseña = @contraseña";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@contraseña", contraseña);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            if (VerificarCredenciales(usuario, contraseña))
            {
                MessageBox.Show("¡Bienvenido, " + usuario + "!");
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void lnkOlvidarContraseña_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("¿Has olvidado la contraseña? Por favor, comunícate con el administrador.");
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Función no implementada. Por favor, comunícate con el administrador.");
        }
    }
}
