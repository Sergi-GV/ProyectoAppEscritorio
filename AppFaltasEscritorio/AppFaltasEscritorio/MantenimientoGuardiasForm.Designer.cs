namespace AppFaltasEscritorio
{
    partial class MantenimientoGuardiasForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvwGuardias = new System.Windows.Forms.ListView();
            this.chProfFalta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProfGuardia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEstado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDiaSemana = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGrupo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAula = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chObservaciones = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvwGuardias
            // 
            this.lvwGuardias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chProfFalta,
            this.chProfGuardia,
            this.chEstado,
            this.chFecha,
            this.chDiaSemana,
            this.chHora,
            this.chGrupo,
            this.chAula,
            this.chObservaciones});
            this.lvwGuardias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwGuardias.GridLines = true;
            this.lvwGuardias.HideSelection = false;
            this.lvwGuardias.Location = new System.Drawing.Point(0, 0);
            this.lvwGuardias.MultiSelect = false;
            this.lvwGuardias.Name = "lvwGuardias";
            this.lvwGuardias.Size = new System.Drawing.Size(800, 450);
            this.lvwGuardias.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.lvwGuardias.TabIndex = 0;
            this.lvwGuardias.UseCompatibleStateImageBehavior = false;
            this.lvwGuardias.View = System.Windows.Forms.View.Details;
            // 
            // chProfFalta
            // 
            this.chProfFalta.Text = "Prof. falta";
            // 
            // chProfGuardia
            // 
            this.chProfGuardia.Text = "Prof. guardia";
            this.chProfGuardia.Width = 78;
            // 
            // chEstado
            // 
            this.chEstado.Text = "Estado";
            this.chEstado.Width = 47;
            // 
            // chFecha
            // 
            this.chFecha.Text = "Fecha";
            this.chFecha.Width = 108;
            // 
            // chDiaSemana
            // 
            this.chDiaSemana.Text = "Dia semana";
            this.chDiaSemana.Width = 75;
            // 
            // chHora
            // 
            this.chHora.Text = "Hora";
            this.chHora.Width = 41;
            // 
            // chGrupo
            // 
            this.chGrupo.Text = "Grupo";
            this.chGrupo.Width = 56;
            // 
            // chAula
            // 
            this.chAula.Text = "Aula";
            this.chAula.Width = 40;
            // 
            // chObservaciones
            // 
            this.chObservaciones.Text = "Observaciones";
            this.chObservaciones.Width = 271;
            // 
            // MantenimientoGuardiasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvwGuardias);
            this.Name = "MantenimientoGuardiasForm";
            this.Text = "Listado guardias";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwGuardias;
        private System.Windows.Forms.ColumnHeader chProfFalta;
        private System.Windows.Forms.ColumnHeader chProfGuardia;
        private System.Windows.Forms.ColumnHeader chEstado;
        private System.Windows.Forms.ColumnHeader chFecha;
        private System.Windows.Forms.ColumnHeader chDiaSemana;
        private System.Windows.Forms.ColumnHeader chHora;
        private System.Windows.Forms.ColumnHeader chGrupo;
        private System.Windows.Forms.ColumnHeader chAula;
        private System.Windows.Forms.ColumnHeader chObservaciones;
    }
}