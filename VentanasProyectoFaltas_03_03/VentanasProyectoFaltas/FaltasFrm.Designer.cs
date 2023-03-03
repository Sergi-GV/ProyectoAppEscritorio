namespace VentanasProyectoFaltas
{
    partial class FaltasFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaltasFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaFalta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPFalta = new System.Windows.Forms.TextBox();
            this.btnBuscarProfeAusente = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAula = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtgrupo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPSus = new System.Windows.Forms.TextBox();
            this.btnBuscarProfeSust = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbHora = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoConfirmada = new System.Windows.Forms.RadioButton();
            this.rdoPendiente = new System.Windows.Forms.RadioButton();
            this.rdoAnulada = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAutocompletar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha:";
            // 
            // dtpFechaFalta
            // 
            this.dtpFechaFalta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFalta.Location = new System.Drawing.Point(59, 12);
            this.dtpFechaFalta.Name = "dtpFechaFalta";
            this.dtpFechaFalta.Size = new System.Drawing.Size(118, 20);
            this.dtpFechaFalta.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hora de falta: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Profesor Ausente: ";
            // 
            // txtPFalta
            // 
            this.txtPFalta.Location = new System.Drawing.Point(113, 82);
            this.txtPFalta.Name = "txtPFalta";
            this.txtPFalta.Size = new System.Drawing.Size(268, 20);
            this.txtPFalta.TabIndex = 7;
            // 
            // btnBuscarProfeAusente
            // 
            this.btnBuscarProfeAusente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarProfeAusente.Image")));
            this.btnBuscarProfeAusente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarProfeAusente.Location = new System.Drawing.Point(387, 79);
            this.btnBuscarProfeAusente.Name = "btnBuscarProfeAusente";
            this.btnBuscarProfeAusente.Size = new System.Drawing.Size(80, 23);
            this.btnBuscarProfeAusente.TabIndex = 8;
            this.btnBuscarProfeAusente.Text = "Buscar";
            this.btnBuscarProfeAusente.UseVisualStyleBackColor = true;
            this.btnBuscarProfeAusente.Click += new System.EventHandler(this.btnBuscarProfeAusente_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Aula: ";
            // 
            // txtAula
            // 
            this.txtAula.Location = new System.Drawing.Point(53, 47);
            this.txtAula.Name = "txtAula";
            this.txtAula.Size = new System.Drawing.Size(139, 20);
            this.txtAula.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Grupo: ";
            // 
            // txtgrupo
            // 
            this.txtgrupo.Location = new System.Drawing.Point(307, 47);
            this.txtgrupo.Name = "txtgrupo";
            this.txtgrupo.Size = new System.Drawing.Size(160, 20);
            this.txtgrupo.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Profesor sustituto: ";
            // 
            // txtPSus
            // 
            this.txtPSus.Location = new System.Drawing.Point(114, 116);
            this.txtPSus.Name = "txtPSus";
            this.txtPSus.Size = new System.Drawing.Size(267, 20);
            this.txtPSus.TabIndex = 14;
            // 
            // btnBuscarProfeSust
            // 
            this.btnBuscarProfeSust.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarProfeSust.Image")));
            this.btnBuscarProfeSust.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarProfeSust.Location = new System.Drawing.Point(387, 114);
            this.btnBuscarProfeSust.Name = "btnBuscarProfeSust";
            this.btnBuscarProfeSust.Size = new System.Drawing.Size(80, 23);
            this.btnBuscarProfeSust.TabIndex = 15;
            this.btnBuscarProfeSust.Text = "Buscar";
            this.btnBuscarProfeSust.UseVisualStyleBackColor = true;
            this.btnBuscarProfeSust.Click += new System.EventHandler(this.btnBuscarProfeSust_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(392, 384);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 18;
            this.btnOk.Text = "Aceptar";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(307, 384);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cmbHora
            // 
            this.cmbHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHora.FormattingEnabled = true;
            this.cmbHora.Items.AddRange(new object[] {
            "1ª Mañana",
            "2ª Mañana",
            "3ª Mañana",
            "4ª Mañana",
            "5ª Mañana",
            "6ª Mañana",
            "1ª Tarde",
            "2ª Tarde",
            "3ª Tarde",
            "4ª Tarde",
            "5ª Tarde",
            "6ª Tarde",
            "Día Completo"});
            this.cmbHora.Location = new System.Drawing.Point(339, 5);
            this.cmbHora.Name = "cmbHora";
            this.cmbHora.Size = new System.Drawing.Size(128, 21);
            this.cmbHora.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoConfirmada);
            this.groupBox1.Controls.Add(this.rdoPendiente);
            this.groupBox1.Controls.Add(this.rdoAnulada);
            this.groupBox1.Location = new System.Drawing.Point(16, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 54);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // rdoConfirmada
            // 
            this.rdoConfirmada.AutoSize = true;
            this.rdoConfirmada.Location = new System.Drawing.Point(356, 19);
            this.rdoConfirmada.Name = "rdoConfirmada";
            this.rdoConfirmada.Size = new System.Drawing.Size(78, 17);
            this.rdoConfirmada.TabIndex = 2;
            this.rdoConfirmada.Text = "Confirmada";
            this.rdoConfirmada.UseVisualStyleBackColor = true;
            // 
            // rdoPendiente
            // 
            this.rdoPendiente.AutoSize = true;
            this.rdoPendiente.Location = new System.Drawing.Point(170, 19);
            this.rdoPendiente.Name = "rdoPendiente";
            this.rdoPendiente.Size = new System.Drawing.Size(73, 17);
            this.rdoPendiente.TabIndex = 1;
            this.rdoPendiente.Text = "Pendiente";
            this.rdoPendiente.UseVisualStyleBackColor = true;
            // 
            // rdoAnulada
            // 
            this.rdoAnulada.AutoSize = true;
            this.rdoAnulada.Checked = true;
            this.rdoAnulada.Location = new System.Drawing.Point(6, 19);
            this.rdoAnulada.Name = "rdoAnulada";
            this.rdoAnulada.Size = new System.Drawing.Size(64, 17);
            this.rdoAnulada.TabIndex = 0;
            this.rdoAnulada.TabStop = true;
            this.rdoAnulada.Text = "Anulada";
            this.rdoAnulada.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtObservaciones);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtMotivo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(22, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 175);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aviso de guardia";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(7, 82);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(421, 81);
            this.txtObservaciones.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Observaciones:";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(57, 26);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(371, 20);
            this.txtMotivo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Motivo: ";
            // 
            // btnAutocompletar
            // 
            this.btnAutocompletar.Location = new System.Drawing.Point(22, 384);
            this.btnAutocompletar.Name = "btnAutocompletar";
            this.btnAutocompletar.Size = new System.Drawing.Size(87, 23);
            this.btnAutocompletar.TabIndex = 24;
            this.btnAutocompletar.Text = "Autocompletar";
            this.btnAutocompletar.UseVisualStyleBackColor = true;
            this.btnAutocompletar.Click += new System.EventHandler(this.btnAutocompletar_Click);
            // 
            // FaltasFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 418);
            this.Controls.Add(this.btnAutocompletar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbHora);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnBuscarProfeSust);
            this.Controls.Add(this.txtPSus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtgrupo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBuscarProfeAusente);
            this.Controls.Add(this.txtPFalta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFechaFalta);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FaltasFrm";
            this.Text = "Falta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaFalta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPFalta;
        private System.Windows.Forms.Button btnBuscarProfeAusente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAula;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtgrupo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPSus;
        private System.Windows.Forms.Button btnBuscarProfeSust;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbHora;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoConfirmada;
        private System.Windows.Forms.RadioButton rdoPendiente;
        private System.Windows.Forms.RadioButton rdoAnulada;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAutocompletar;
    }
}