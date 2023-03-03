
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentanasProyectoFaltas;
using VentanasProyectoFaltas.Modelo;

namespace AppFaltasEscritorio
{
    public partial class MainForm : Form
    {
        private profesores admin;
        private MainForm()
        {
            InitializeComponent();
        }
        public MainForm(profesores p): this()
        {
            this.admin = p;
        }
        private void tsmiListaGuardias_Click(object sender, EventArgs e)
        {
            MantenimientoFaltasFrm listaGuardias = new MantenimientoFaltasFrm(admin);
            listaGuardias.MdiParent = this;
            listaGuardias.Show();
        }

        private void tsmiSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void tsmiGuardias_Click(object sender, EventArgs e)
        {
            MantenimientoFaltasFrm listaGuardias = new MantenimientoFaltasFrm(admin);
            listaGuardias.MdiParent = this;
            listaGuardias.Show();
        }
    }
}
