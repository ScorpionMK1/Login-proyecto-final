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

        private bool VerificarCredenciales(string usuario, string contrase�a)
        {
            using (NpgsqlConnection con = new NpgsqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM usuario WHERE usuario = @usuario AND contrase�a = @contrase�a";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@contrase�a", contrase�a);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrase�a = txtContrase�a.Text;

            if (VerificarCredenciales(usuario, contrase�a))
            {
                MessageBox.Show("�Bienvenido, " + usuario + "!");
            }
            else
            {
                MessageBox.Show("Usuario o contrase�a incorrectos");
            }
        }

        private void lnkOlvidarContrase�a_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("�Has olvidado la contrase�a? Por favor, comun�cate con el administrador.");
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funci�n no implementada. Por favor, comun�cate con el administrador.");
        }
    }
}
