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
        private String filtro = "";
        private profesores admin;   
        private GuardiaShorter guardiaShorter;
        public MantenimientoFaltasFrm(profesores admin)
        {
            InitializeComponent();
            guardiaShorter = new GuardiaShorter();
            lvFaltas.ListViewItemSorter = guardiaShorter;
            ActualizarTablaAsync();
            this.admin = admin;
        }

        public async void ActualizarTablaAsync()
        {
            lvFaltas.Items.Clear();
            List<guardias> listaGuardias = await Herramientas.GetGuardiasAsync();

            if (listaGuardias.Count > 0)
                foreach (guardias g in listaGuardias)
                {
                    if (g.Id != 0)
                    {
                        string[] datos;
                        profesores pSus = null;

<<<<<<< HEAD:AppEscritorio-Final/VentanasProyectoFaltas/MantenimientoFaltasFrm.cs
                        profesores pFalta = await Herramientas.ObtenerProfesorPorId(g.Prof_Falta);
                        if (g.Prof_hace_guardia != null)
                            pSus = await Herramientas.ObtenerProfesorPorId(g.Prof_hace_guardia.Value);
                        datos = new string[] { g.Fecha.ToShortDateString(), g.Hora.ToString(), pFalta.Nombre + " " + pFalta.Ape1, "NO", g.Aula, g.Grupo, g.Estado.ToString() };
                        if (g.Prof_hace_guardia != null)
=======
                        profesores pFalta = pSus = negocio.GetAsync<profesores>($"profesores/{g.ProfFaltaId}").Result;
                        if (g.ProfGuardiaId != null)
                            pSus = negocio.GetAsync<profesores>($"profesores/{g.ProfGuardiaId}").Result;
                        datos = new string[] { g.Fecha.ToShortDateString(), g.Hora.ToString(), pFalta.Nombre + " " + pFalta.Ape1, "NO", g.Aula, g.Grupo, g.Estado.ToString() };
                        if (pSus != null)
>>>>>>> 8ba7f8c2081a614fa89b9f6a9be81edd2a9621bf:VentanasProyectoFaltas_03_03/VentanasProyectoFaltas/MantenimientoFaltasFrm.cs
                            datos = new string[] { g.Fecha.ToShortDateString(), g.Hora.ToString(), pFalta.Nombre + " " + pFalta.Ape1, pSus.Nombre + " " + pSus.Ape1, g.Aula, g.Grupo, g.Estado.ToString() };

                        
                        ListViewItem item = new ListViewItem(datos);
                        if(g.Prof_hace_guardia <1)
                            item.BackColor = Color.Yellow;
                        item.Tag = g.Id;
                        if (filtro.Equals(""))
                        {
                            lvFaltas.Items.Add(item);
                        }
                        else
                        if (datos.Contains(filtro))
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

        private async void btnNew_Click(object sender, EventArgs e)
        {
            guardias g=new guardias();
            FaltasFrm falta = new FaltasFrm(g,admin);
            if (falta.ShowDialog() == DialogResult.OK)
                await Herramientas.CrearGuardiaAsync("crear-aviso", falta.DevolverFalta(), admin.apikey);
        }

        private async void nuevaFaltaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guardias g = new guardias();
            FaltasFrm falta = new FaltasFrm(g, admin);
            if (falta.ShowDialog() == DialogResult.OK)
                await Herramientas.CrearGuardiaAsync("crear-aviso", falta.DevolverFalta(), admin.apikey);
        }

        private async void verFaltaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvFaltas.SelectedItems.Count > 0)
            {
<<<<<<< HEAD:AppEscritorio-Final/VentanasProyectoFaltas/MantenimientoFaltasFrm.cs
                int id = (int)lvFaltas.SelectedItems[0].Tag;
                guardias guardia = await Herramientas.ObtenerGuardiaPorId(id);
=======
                guardias guardia = negocio.GetAsync<guardias>($"guardias/{lvFaltas.SelectedItems[0].Tag.ToString()}").Result;
>>>>>>> 8ba7f8c2081a614fa89b9f6a9be81edd2a9621bf:VentanasProyectoFaltas_03_03/VentanasProyectoFaltas/MantenimientoFaltasFrm.cs
                FaltasFrm falta = new FaltasFrm(guardia, admin);
                //if (falta.ShowDialog() == DialogResult.OK)
                    //negocio.PostAsync("guardias", falta.DevolverFalta(), admin.apikey);
            }
            else
                MessageBox.Show("Selecciona una guardia");
        }

        private async void borrarFaltaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvFaltas.SelectedItems.Count == 0)
            {
<<<<<<< HEAD:AppEscritorio-Final/VentanasProyectoFaltas/MantenimientoFaltasFrm.cs
               guardias g = await Herramientas.ObtenerGuardiaPorId(Convert.ToInt32(lvFaltas.SelectedItems[0].Tag.ToString()));
=======
                guardias g= negocio.GetAsync<guardias>($"guardias/{lvFaltas.SelectedItems[0].Tag}").Result;
>>>>>>> 8ba7f8c2081a614fa89b9f6a9be81edd2a9621bf:VentanasProyectoFaltas_03_03/VentanasProyectoFaltas/MantenimientoFaltasFrm.cs
                if (MessageBox.Show("¿Seguro que quieres borrar esta guardia?", "Borrar guardia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    await Herramientas.AnularGuardiaAsync(g, admin.apikey);             
            }
        }
    }
}
