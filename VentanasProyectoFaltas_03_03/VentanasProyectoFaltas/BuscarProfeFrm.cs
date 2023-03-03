using AppFaltasEscritorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentanasProyectoFaltas.Modelo;

namespace VentanasProyectoFaltas
{
    public partial class BuscarProfeFrm : Form
    {
        private profesores profe;
        private string filtro;
        private Negocio negocio;
        public BuscarProfeFrm(profesores _profe)
        {
            InitializeComponent();
            this.profe = _profe;
            negocio = new Negocio();
        }

        public profesores DevolverProfesor() { return profe; }

        private async Task ActualizarListaAsync()
        {
            List<profesores> listaP = negocio.GetAsync<List<profesores>>("profesores").Result;
            foreach (profesores p in listaP)
            {
                if (p != null)
                {

                    string[] datos = new string[] {p.Nombre+" "+p.Ape1, p.DNI};
                    ListViewItem item = new ListViewItem();
                    item.Tag = p.Id;
                    if (filtro == null)
                    {
                        lvwProfesores.Items.Add(item);
                    }
                    else
                        if (datos.Contains<String>(filtro))
                        lvwProfesores.Items.Add(item);
                }
            }
            lvwProfesores.Sort();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            filtro=txtFilter.Text;
            ActualizarListaAsync();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (lvwProfesores.SelectedItems.Count == 0)
            {
                string id= lvwProfesores.SelectedItems[0].Tag.ToString();
                profe = negocio.GetAsync<profesores>($"profesores/{id}").Result;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("Selecciona un profesor de la lista");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
            this.Close();
        }
    }
}
