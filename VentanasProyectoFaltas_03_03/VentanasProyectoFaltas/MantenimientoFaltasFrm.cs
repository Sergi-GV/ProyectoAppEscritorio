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
    public partial class MantenimientoFaltasFrm : Form
    {
        private String filtro;
        private Negocio negocio;
        private profesores admin;   
        private GuardiaShorter guardiaShorter;
        public MantenimientoFaltasFrm(profesores admin)
        {
            InitializeComponent();
            negocio = new Negocio();
            guardiaShorter = new GuardiaShorter();
            lvFaltas.ListViewItemSorter = guardiaShorter;
            ActualizarTablaAsync();
            this.admin = admin;
        }

        public async Task ActualizarTablaAsync()
        {
            if (lvFaltas.Items.Count > 0)
                lvFaltas.Items.Clear();
            List<guardias> listaGuardias = await Herramientas.GetGuardiasAsync();

            if (listaGuardias.Count > 0)
                foreach (guardias g in listaGuardias)
                {
                    if (g != null)
                    {
                        string[] datos;
                        profesores pSus = null;

                        profesores pFalta = negocio.GetAsync<profesores>(g.ProfFaltaId.ToString()).Result;
                        if (g.ProfGuardiaId != null)
                            pSus = negocio.GetAsync<profesores>(g.ProfGuardiaId.Value.ToString()).Result;
                        datos = new string[] { g.Fecha.ToShortDateString(), g.Hora.ToString(), pFalta.Nombre + " " + pFalta.Ape1, "NO", g.Aula, g.Grupo, g.Estado.ToString() };
                        if (g.ProfGuardiaId != null)
                            datos = new string[] { g.Fecha.ToShortDateString(), g.Hora.ToString(), pFalta.Nombre + " " + pFalta.Ape1, pSus.Nombre + " " + pSus.Ape1, g.Aula, g.Grupo, g.Estado.ToString() };

                        
                        ListViewItem item = new ListViewItem(datos);
                        if(g.ProfGuardiaId<1)
                            item.BackColor = Color.Yellow;
                        item.Tag = g.Id;
                        if (filtro == null)
                        {
                            lvFaltas.Items.Add(item);
                        }
                        else
                        if (datos.Contains<String>(filtro))
                                lvFaltas.Items.Add(item);
                        
                    }
                }

            guardiaShorter.Order = SortOrder.Descending;
            lvFaltas.Sort();
 
            
        }

      

        private void btnSearch_Click(object sender, EventArgs e)
        {
            filtro=txtFilter.Text;
            ActualizarTablaAsync();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            guardias g=new guardias();
            FaltasFrm falta = new FaltasFrm(g,admin);
            if (falta.ShowDialog() == DialogResult.OK)
                negocio.PostAsync("guardias", falta.DevolverFalta(), admin.apikey);
        }

        private void nuevaFaltaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guardias g = new guardias();
            FaltasFrm falta = new FaltasFrm(g, admin);
            if (falta.ShowDialog() == DialogResult.OK)
                negocio.PostAsync("guardias", falta.DevolverFalta(), admin.apikey);
        }

        private void verFaltaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvFaltas.SelectedItems.Count == 0)
            {
                guardias guardia = negocio.GetAsync<guardias>(lvFaltas.SelectedItems[0].Tag.ToString()).Result;
                FaltasFrm falta = new FaltasFrm(guardia, admin);
                if (falta.ShowDialog() == DialogResult.OK)
                    negocio.PostAsync("guardias", falta.DevolverFalta(), admin.apikey);
            }
            else
                MessageBox.Show("Selecciona una guardia");
        }

        private void borrarFaltaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvFaltas.SelectedItems.Count == 0)
            {
                guardias g= negocio.GetAsync<guardias>(lvFaltas.SelectedItems[0].Tag.ToString()).Result;
                if (MessageBox.Show("¿Seguro que quieres borrar esta guardia?", "Borrar guardia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    Herramientas.AnularGuardiaAsync(g, admin.apikey);

                
            }
        }
    }
}
