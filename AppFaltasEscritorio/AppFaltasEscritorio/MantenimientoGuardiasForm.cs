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
    public partial class MantenimientoGuardiasForm : Form
    {
        public MantenimientoGuardiasForm()
        {
            InitializeComponent();
            CargarGuardias();
        }

        private async void CargarGuardias()
        {
            lvwGuardias.Items.Clear();
            List<Guardia> guardias = await Herramientas.GetGuardiasAsync();

            foreach(Guardia g in guardias)
            {
                string[] data =
                {
                    g.prof_falta.ToString(),
                    g.prof_hace_guardia.ToString(),
                    g.estado.ToString(),
                    g.fecha,
                    g.dia_semana.ToString(),
                    g.hora.ToString(),
                    g.grupo,
                    g.aula,
                    g.observaciones
                };

                lvwGuardias.Items.Add(new ListViewItem(data));
            }
        }
    }
}
