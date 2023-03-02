using AppFaltasEscritorio.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFaltasEscritorio
{
    public partial class MainForm : Form
    {
        private Profesor profesor;
        private MainForm()
        {
            InitializeComponent();
        }
        public MainForm(Profesor p): this()
        {
            this.profesor = p;
        }
        private void tsmiListaGuardias_Click(object sender, EventArgs e)
        {
            MantenimientoGuardiasForm listaGuardias = new MantenimientoGuardiasForm();
            listaGuardias.MdiParent = this;
            listaGuardias.Show();
        }
    }
}
