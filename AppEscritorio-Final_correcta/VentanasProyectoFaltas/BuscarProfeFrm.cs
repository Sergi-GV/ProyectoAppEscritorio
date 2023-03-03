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
        private string filtro = "";
        public BuscarProfeFrm(profesores _profe)
        {
            InitializeComponent();
            this.profe = _profe;
        }

        public profesores DevolverProfesor() { return profe; }

        private async Task ActualizarListaAsync()
        {
            lvwProfesores.Items.Clear();
            List<profesores> listaP = await Herramientas.GetProfesoresAsync();
            foreach (profesores p in listaP)
            {
                if (p.Id != 0)
                {
                    string[] datos = new string[] {p.Nombre+" "+p.Ape1, p.DNI};
                    ListViewItem item = new ListViewItem(datos);
                    item.Tag = p.Id;
                    if (filtro.Equals(""))
                    {
                        lvwProfesores.Items.Add(item);
                    }
                    else
                        if (datos[0].Contains(filtro) || datos[1].Contains(filtro))
                        lvwProfesores.Items.Add(item);
                }
            }
            lvwProfesores.Sort();
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            filtro = txtFilter.Text;
            await ActualizarListaAsync();
        }

        private async void btnOk_Click(object sender, EventArgs e)
        {
            if (lvwProfesores.SelectedItems.Count > 0)
            {
                string id= lvwProfesores.SelectedItems[0].Tag.ToString();
                profe = await Herramientas.ObtenerProfesorPorId(Convert.ToInt32(id));
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("Selecciona un profesor de la lista");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
