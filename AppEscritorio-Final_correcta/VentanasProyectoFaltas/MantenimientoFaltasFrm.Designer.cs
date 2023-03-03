namespace VentanasProyectoFaltas
{
    partial class MantenimientoFaltasFrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoFaltasFrm));
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lvFaltas = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsListadoFaltas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevaFaltaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verFaltaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarFaltaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsListadoFaltas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(713, 11);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "Nuevo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(341, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "  Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(50, 12);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(285, 20);
            this.txtFilter.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filtro:";
            // 
            // lvFaltas
            // 
            this.lvFaltas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvFaltas.ContextMenuStrip = this.cmsListadoFaltas;
            this.lvFaltas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvFaltas.FullRowSelect = true;
            this.lvFaltas.GridLines = true;
            this.lvFaltas.HideSelection = false;
            this.lvFaltas.Location = new System.Drawing.Point(0, 56);
            this.lvFaltas.MultiSelect = false;
            this.lvFaltas.Name = "lvFaltas";
            this.lvFaltas.Size = new System.Drawing.Size(800, 394);
            this.lvFaltas.TabIndex = 6;
            this.lvFaltas.UseCompatibleStateImageBehavior = false;
            this.lvFaltas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Fecha";
            this.columnHeader1.Width = 72;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Hora";
            this.columnHeader2.Width = 78;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Profe Falta";
            this.columnHeader4.Width = 137;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Profe Sustituye";
            this.columnHeader5.Width = 134;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Aula";
            this.columnHeader6.Width = 73;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Grupo";
            this.columnHeader7.Width = 77;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Estado";
            this.columnHeader8.Width = 69;
            // 
            // cmsListadoFaltas
            // 
            this.cmsListadoFaltas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaFaltaToolStripMenuItem,
            this.verFaltaToolStripMenuItem,
            this.borrarFaltaToolStripMenuItem});
            this.cmsListadoFaltas.Name = "cmsListadoFaltas";
            this.cmsListadoFaltas.Size = new System.Drawing.Size(181, 92);
            // 
            // nuevaFaltaToolStripMenuItem
            // 
            this.nuevaFaltaToolStripMenuItem.Name = "nuevaFaltaToolStripMenuItem";
            this.nuevaFaltaToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.nuevaFaltaToolStripMenuItem.Text = "Nueva Falta";
            this.nuevaFaltaToolStripMenuItem.Click += new System.EventHandler(this.nuevaFaltaToolStripMenuItem_Click);
            // 
            // verFaltaToolStripMenuItem
            // 
            this.verFaltaToolStripMenuItem.Name = "verFaltaToolStripMenuItem";
            this.verFaltaToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.verFaltaToolStripMenuItem.Text = "Ver Falta";
            this.verFaltaToolStripMenuItem.Click += new System.EventHandler(this.verFaltaToolStripMenuItem_Click);
            // 
            // borrarFaltaToolStripMenuItem
            // 
            this.borrarFaltaToolStripMenuItem.Name = "borrarFaltaToolStripMenuItem";
            this.borrarFaltaToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.borrarFaltaToolStripMenuItem.Text = "Borrar Falta";
            this.borrarFaltaToolStripMenuItem.Click += new System.EventHandler(this.borrarFaltaToolStripMenuItem_Click);
            // 
            // MantenimientoFaltasFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvFaltas);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MantenimientoFaltasFrm";
            this.Text = "Listado de faltas";
            this.cmsListadoFaltas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvFaltas;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ContextMenuStrip cmsListadoFaltas;
        private System.Windows.Forms.ToolStripMenuItem nuevaFaltaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verFaltaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarFaltaToolStripMenuItem;
    }
}