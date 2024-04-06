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

        private bool VerificarCredenciales(string usuario, string contrase�a)
        {
            Dictionary<string, string> usuarios = new Dictionary<string, string>
            {
                {"Jordy", "123"},
                {"Jose", "1234"},
                {"Brando", "12345"},
                {"Samuel", "123456"},
            };

            if (usuarios.ContainsKey(usuario) && usuarios[usuario] == contrase�a)
            {
                return true; // Credenciales v�lidas
            }
            else
            {
                return false; // Credenciales inv�lidas
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
