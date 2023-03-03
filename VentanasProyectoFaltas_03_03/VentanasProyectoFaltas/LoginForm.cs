
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
using VentanasProyectoFaltas.Modelo;
using static System.Net.Mime.MediaTypeNames;

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
            string pass = txtContra.Text;
            List<profesores> p = await Herramientas.LoginAdmin(txtUsuario.Text, pass);
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

        private string encriptar()
        {
            MD5 md5 = new MD5CryptoServiceProvider();
           
            if (txtContra.Text != "")
            {
                md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(txtContra.Text));
                byte[] result = md5.Hash;

                StringBuilder strBuilder = new StringBuilder();
                for (int i = 0; i < result.Length; i++)
                {
                     
                    strBuilder.Append(result[i].ToString("x2"));
                }

                return strBuilder.ToString();
            }
            return null;
        }
    }
}
