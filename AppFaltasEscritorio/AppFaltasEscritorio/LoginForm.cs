using AppFaltasEscritorio.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFaltasEscritorio
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            List<Profesor> p = await Herramientas.LoginAdmin(txtUsuario.Text, CreateMD5(txtContra.Text));
            if (p != null)
            {
                MainForm mainForm = new MainForm(p[0]);
                this.Hide();
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static string CreateMD5(string input)
        {

            // Create an instance of the MD5 algorithm
            MD5 md5 = MD5.Create();

            // Convert the input string to a byte array
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);

            // Compute the MD5 hash of the input byte array
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            // Convert the hash byte array to a hexadecimal string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("x2"));
            }
            string hashString = sb.ToString();
            return hashString;
        }
    }
}
