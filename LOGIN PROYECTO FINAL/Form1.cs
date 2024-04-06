using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LOGIN_PROYECTO_FINAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool VerificarCredenciales(string usuario, string contraseña)
        {
            Dictionary<string, string> usuarios = new Dictionary<string, string>
            {
                {"Jordy", "123"},
                {"Jose", "1234"},
                {"Brando", "12345"},
                {"Samuel", "123456"},
            };

            if (usuarios.ContainsKey(usuario) && usuarios[usuario] == contraseña)
            {
                return true; // Credenciales válidas
            }
            else
            {
                return false; // Credenciales inválidas
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
