namespace CapaPresentacion
{
    partial class FrmNuevaDefensaExterna
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
            this.dtHora = new System.Windows.Forms.DateTimePicker();
            this.dtFechaDefensa = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardarNuevoP = new System.Windows.Forms.Button();
            this.btnCancelarNuevaD = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnElegirTutor = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTutor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtHora
            // 
            this.dtHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHora.Location = new System.Drawing.Point(325, 217);
            this.dtHora.Margin = new System.Windows.Forms.Padding(2);
            this.dtHora.Name = "dtHora";
            this.dtHora.Size = new System.Drawing.Size(136, 24);
            this.dtHora.TabIndex = 18;
            // 
            // dtFechaDefensa
            // 
            this.dtFechaDefensa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaDefensa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaDefensa.Location = new System.Drawing.Point(31, 218);
            this.dtFechaDefensa.Margin = new System.Windows.Forms.Padding(2);
            this.dtFechaDefensa.Name = "dtFechaDefensa";
            this.dtFechaDefensa.Size = new System.Drawing.Size(136, 24);
            this.dtFechaDefensa.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(322, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "Hora";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 191);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 18);
            this.label1.TabIndex = 29;
            this.label1.Text = "Fecha Defensa";
            // 
            // txtAula
            // 
            this.txtAula.Location = new System.Drawing.Point(213, 221);
            this.txtAula.Margin = new System.Windows.Forms.Padding(2);
            this.txtAula.Name = "txtAula";
            this.txtAula.Size = new System.Drawing.Size(76, 20);
            this.txtAula.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 191);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = "Aula";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "",
            "tesis",
            "examen de grado",
            "proyecto de grado"});
            this.cmbTipo.Location = new System.Drawing.Point(28, 145);
            this.cmbTipo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(199, 21);
            this.cmbTipo.TabIndex = 32;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 18);
            this.label4.TabIndex = 33;
            this.label4.Text = "Tipo Defensa";
            // 
            // btnGuardarNuevoP
            // 
            this.btnGuardarNuevoP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnGuardarNuevoP.FlatAppearance.BorderSize = 0;
            this.btnGuardarNuevoP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarNuevoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarNuevoP.ForeColor = System.Drawing.Color.White;
            this.btnGuardarNuevoP.Location = new System.Drawing.Point(771, 440);
            this.btnGuardarNuevoP.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarNuevoP.Name = "btnGuardarNuevoP";
            this.btnGuardarNuevoP.Size = new System.Drawing.Size(82, 38);
            this.btnGuardarNuevoP.TabIndex = 34;
            this.btnGuardarNuevoP.Text = "Guardar";
            this.btnGuardarNuevoP.UseVisualStyleBackColor = false;
            // 
            // btnCancelarNuevaD
            // 
            this.btnCancelarNuevaD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnCancelarNuevaD.FlatAppearance.BorderSize = 0;
            this.btnCancelarNuevaD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarNuevaD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarNuevaD.ForeColor = System.Drawing.Color.White;
            this.btnCancelarNuevaD.Location = new System.Drawing.Point(683, 440);
            this.btnCancelarNuevaD.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelarNuevaD.Name = "btnCancelarNuevaD";
            this.btnCancelarNuevaD.Size = new System.Drawing.Size(82, 38);
            this.btnCancelarNuevaD.TabIndex = 35;
            this.btnCancelarNuevaD.Text = "Cancelar";
            this.btnCancelarNuevaD.UseVisualStyleBackColor = false;
            this.btnCancelarNuevaD.Click += new System.EventHandler(this.btnCancelarNuevaD_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 18);
            this.label5.TabIndex = 36;
            this.label5.Text = "Tema de la tesis";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "",
            "tesis",
            "examen de grado",
            "proyecto de grado"});
            this.comboBox1.Location = new System.Drawing.Point(24, 68);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(495, 21);
            this.comboBox1.TabIndex = 37;
            // 
            // btnElegirTutor
            // 
            this.btnElegirTutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnElegirTutor.FlatAppearance.BorderSize = 0;
            this.btnElegirTutor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnElegirTutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElegirTutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElegirTutor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnElegirTutor.Location = new System.Drawing.Point(545, 68);
            this.btnElegirTutor.Name = "btnElegirTutor";
            this.btnElegirTutor.Size = new System.Drawing.Size(86, 26);
            this.btnElegirTutor.TabIndex = 38;
            this.btnElegirTutor.Text = "Cargar";
            this.btnElegirTutor.UseVisualStyleBackColor = false;
            this.btnElegirTutor.Click += new System.EventHandler(this.btnElegirTutor_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 382);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 20);
            this.textBox1.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 352);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 18);
            this.label6.TabIndex = 40;
            this.label6.Text = "Nombre del estudiante";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(346, 382);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(274, 20);
            this.textBox2.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(343, 352);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 18);
            this.label7.TabIndex = 42;
            this.label7.Text = "Carrera";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtTutor);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btnElegirTutor);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnCancelarNuevaD);
            this.panel1.Controls.Add(this.btnGuardarNuevoP);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmbTipo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtAula);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtFechaDefensa);
            this.panel1.Controls.Add(this.dtHora);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 490);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(545, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 26);
            this.button1.TabIndex = 44;
            this.button1.Text = "Cargar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTutor
            // 
            this.txtTutor.Enabled = false;
            this.txtTutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTutor.Location = new System.Drawing.Point(252, 142);
            this.txtTutor.Name = "txtTutor";
            this.txtTutor.Size = new System.Drawing.Size(267, 24);
            this.txtTutor.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(249, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 18);
            this.label8.TabIndex = 43;
            this.label8.Text = "Tutor:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 267);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 18);
            this.label9.TabIndex = 47;
            this.label9.Text = "Registro";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(29, 297);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(143, 20);
            this.textBox3.TabIndex = 46;
            // 
            // FrmNuevaDefensaExterna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(857, 490);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmNuevaDefensaExterna";
            this.Text = "FrmNuevaDefensaExterna";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtHora;
        private System.Windows.Forms.DateTimePicker dtFechaDefensa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuardarNuevoP;
        private System.Windows.Forms.Button btnCancelarNuevaD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnElegirTutor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTutor;
        private System.Windows.Forms.Label label8;
    }
}