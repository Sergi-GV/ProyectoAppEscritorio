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
    public partial class FaltasFrm : Form
    {
        private guardias guardia;
        private avisos_guardia aviso;
        private profesores pFalta;
        private profesores pSus = null;
        private profesores admin;
        public FaltasFrm(guardias _guardia, profesores _admin)
        {
            InitializeComponent();
            cmbHora.Text = "1ª Mañana";
            this.admin = _admin;
            this.guardia = _guardia;
            aviso = new avisos_guardia();
            if (guardia.Id != 0)
                CargarFalta();
        }
        public avisos_guardia DevolverFalta()
        { return aviso; }

        private async void CargarFalta()
        {
            pFalta = await Herramientas.ObtenerProfesorPorId(guardia.Prof_Falta);
            if (guardia.Prof_hace_guardia != null)
                pSus = await Herramientas.ObtenerProfesorPorId(guardia.Prof_hace_guardia.Value);


            dtpFechaFalta.Value = guardia.Fecha;
            cmbHora.SelectedItem = cmbHora.Items[guardia.Hora - 1];
            txtAula.Text = guardia.Aula;
            txtgrupo.Text = guardia.Grupo;
            if (pFalta != null)
                txtPFalta.Text = pFalta.Nombre + " " + pFalta.Ape1;
            if (pSus != null)
                txtPSus.Text = pSus.Nombre + " " + pSus.Ape1;
            switch (guardia.Estado)
            {
                case 'A': rdoAnulada.Checked = true; break;
                case 'P': rdoPendiente.Checked = true; break;
                case 'C': rdoConfirmada.Checked = true; break;
            }


        }
        private int ConvertirHoras()
        {
            switch (cmbHora.Text)
            {
                case "1ª Mañana": return 1;
                case "2ª Mañana": return 2;
                case "3ª Mañana": return 3;
                case "4ª Mañana": return 4;
                case "5ª Mañana": return 5;
                case "6ª Mañana": return 6;
                case "1ª Tarde": return 7;
                case "2ª Tarde": return 8;
                case "3ª Tarde": return 9;
                case "4ª Tarde": return 10;
                case "5ª Tarde": return 11;
                case "6ª Tarde": return 12;
                case "Día Completo": return 0;
            }
            return 0;
        }

        private bool ComprobarFormulario()
        {
            if (cmbHora.Text == null) return false;
            if (txtAula.Text == null) return false;
            if (txtgrupo.Text == null) return false;
            if (txtPFalta.Text == null) return false;
            if (dtpFechaFalta.Value == null) return false;
            if (pFalta == null) return false;


            return true;

        }

        private async Task<bool> GuardarDatos()
        {
            if (ComprobarFormulario())
            {
                /*
                guardia.Aula = txtAula.Text;
                guardia.Grupo = txtgrupo.Text;
                guardia.Fecha = dtpFechaFalta.Value;
                guardia.DiaSemana = (int)dtpFechaFalta.Value.DayOfWeek;
                guardia.Prof_Falta = pFalta.Id;
                if (pSus != null)
                    guardia.Prof_hace_guardia = pSus.Id;
                guardia.Hora = ConvertirHoras();
                */

                if (txtMotivo.Text != "")
                    if (txtObservaciones.Text != "")
                    {
                        aviso.FechaGuardia = dtpFechaFalta.Value;
                        aviso.Horario = ConvertirHoras();
                        aviso.FechaHoraAviso = DateTime.Now;
                        if (rdoAnulada.Checked)
                            aviso.Anulado = true;
                        if (rdoConfirmada.Checked)
                            aviso.Confirmado = true;
                        aviso.ProfesorId = pFalta.Id;
                        await Herramientas.CrearGuardiaAsync("crear-aviso", aviso, admin.apikey);
                        //guardia.Aviso = negocio.GetAsync<List<guardias>>("guardias").Result.Count+1;
                    }

                return true;
            }
            return false;
        }

        private void btnBuscarProfeAusente_Click(object sender, EventArgs e)
        {
            BuscarProfeFrm buscarAusente = new BuscarProfeFrm(pFalta);
            if (buscarAusente.ShowDialog() == DialogResult.OK)
                pFalta = buscarAusente.DevolverProfesor();
        }

        private void btnBuscarProfeSust_Click(object sender, EventArgs e)
        {
            BuscarProfeFrm buscarSus = new BuscarProfeFrm(pSus);
            if (buscarSus.ShowDialog() == DialogResult.OK)
                pSus = buscarSus.DevolverProfesor();
        }

        private async void btnOk_Click(object sender, EventArgs e)
        {
            if (await GuardarDatos())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("Los datos introducidos son incompletos o erroneos. Rellene todos los datos esenciales");
        }
        private void autocompletar()
        {
            if (pFalta != null)
                if (dtpFechaFalta.Value != null)
                    if (cmbHora.Text != null)
                    {
                        //List<horario> listaHorarios= negocio.AutocompletarAsync<List<horario>>(pFalta, dtpFechaFalta.Value, ConvertirHoras()).Result;
                        //txtAula.Text = listaHorarios[0].Aula;
                        //txtgrupo.Text = listaHorarios[0].Grupo;

                    }

        }
        private void btnAutocompletar_Click(object sender, EventArgs e)
        {
            autocompletar();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
