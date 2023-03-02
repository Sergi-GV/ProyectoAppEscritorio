namespace AppFaltasEscritorio
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.tsmiArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGuardias = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiListaGuardias = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiGuardiasProfesor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCrearGuardias = new System.Windows.Forms.ToolStripMenuItem();
            this.msPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // msPrincipal
            // 
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiArchivo,
            this.tsmiGuardias});
            this.msPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Size = new System.Drawing.Size(800, 24);
            this.msPrincipal.TabIndex = 0;
            this.msPrincipal.Text = "menuStrip1";
            // 
            // tsmiArchivo
            // 
            this.tsmiArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSalir});
            this.tsmiArchivo.Name = "tsmiArchivo";
            this.tsmiArchivo.Size = new System.Drawing.Size(60, 20);
            this.tsmiArchivo.Text = "Archivo";
            // 
            // tsmiGuardias
            // 
            this.tsmiGuardias.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiListaGuardias,
            this.toolStripMenuItem1,
            this.tsmiGuardiasProfesor,
            this.tsmiCrearGuardias});
            this.tsmiGuardias.Name = "tsmiGuardias";
            this.tsmiGuardias.Size = new System.Drawing.Size(65, 20);
            this.tsmiGuardias.Text = "Guardias";
            // 
            // tsmiSalir
            // 
            this.tsmiSalir.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSalir.Image")));
            this.tsmiSalir.Name = "tsmiSalir";
            this.tsmiSalir.Size = new System.Drawing.Size(180, 22);
            this.tsmiSalir.Text = "Salir";
            // 
            // tsmiListaGuardias
            // 
            this.tsmiListaGuardias.Image = ((System.Drawing.Image)(resources.GetObject("tsmiListaGuardias.Image")));
            this.tsmiListaGuardias.Name = "tsmiListaGuardias";
            this.tsmiListaGuardias.Size = new System.Drawing.Size(183, 22);
            this.tsmiListaGuardias.Text = "Lista guardias";
            this.tsmiListaGuardias.Click += new System.EventHandler(this.tsmiListaGuardias_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 6);
            // 
            // tsmiGuardiasProfesor
            // 
            this.tsmiGuardiasProfesor.Image = ((System.Drawing.Image)(resources.GetObject("tsmiGuardiasProfesor.Image")));
            this.tsmiGuardiasProfesor.Name = "tsmiGuardiasProfesor";
            this.tsmiGuardiasProfesor.Size = new System.Drawing.Size(183, 22);
            this.tsmiGuardiasProfesor.Text = "Guardias de profesor";
            // 
            // tsmiCrearGuardias
            // 
            this.tsmiCrearGuardias.Image = ((System.Drawing.Image)(resources.GetObject("tsmiCrearGuardias.Image")));
            this.tsmiCrearGuardias.Name = "tsmiCrearGuardias";
            this.tsmiCrearGuardias.Size = new System.Drawing.Size(183, 22);
            this.tsmiCrearGuardias.Text = "Crear guardia";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msPrincipal;
            this.Name = "MainForm";
            this.Text = "Gestión de faltas";
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmiArchivo;
        private System.Windows.Forms.ToolStripMenuItem tsmiSalir;
        private System.Windows.Forms.ToolStripMenuItem tsmiGuardias;
        private System.Windows.Forms.ToolStripMenuItem tsmiListaGuardias;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiGuardiasProfesor;
        private System.Windows.Forms.ToolStripMenuItem tsmiCrearGuardias;
    }
}