
namespace EsercitazioneProcrastinata
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxNuovaPersona = new System.Windows.Forms.GroupBox();
            this.btnCrea = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtNoStageLaurea = new System.Windows.Forms.RadioButton();
            this.rbtStageLaurea = new System.Windows.Forms.RadioButton();
            this.lblClasseMateria = new System.Windows.Forms.Label();
            this.txtClasseMateria = new System.Windows.Forms.TextBox();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.rbtDocente = new System.Windows.Forms.RadioButton();
            this.rbtStudente = new System.Windows.Forms.RadioButton();
            this.lbxStudenti = new System.Windows.Forms.ListBox();
            this.lbxDocenti = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEliminaPersona = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnCarica = new System.Windows.Forms.Button();
            this.gbxNuovaPersona.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxNuovaPersona
            // 
            this.gbxNuovaPersona.BackColor = System.Drawing.Color.LavenderBlush;
            this.gbxNuovaPersona.Controls.Add(this.btnCrea);
            this.gbxNuovaPersona.Controls.Add(this.panel1);
            this.gbxNuovaPersona.Controls.Add(this.lblClasseMateria);
            this.gbxNuovaPersona.Controls.Add(this.txtClasseMateria);
            this.gbxNuovaPersona.Controls.Add(this.txtCognome);
            this.gbxNuovaPersona.Controls.Add(this.label2);
            this.gbxNuovaPersona.Controls.Add(this.label1);
            this.gbxNuovaPersona.Controls.Add(this.txtNome);
            this.gbxNuovaPersona.Controls.Add(this.rbtDocente);
            this.gbxNuovaPersona.Controls.Add(this.rbtStudente);
            this.gbxNuovaPersona.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbxNuovaPersona.Location = new System.Drawing.Point(13, 13);
            this.gbxNuovaPersona.Name = "gbxNuovaPersona";
            this.gbxNuovaPersona.Size = new System.Drawing.Size(510, 273);
            this.gbxNuovaPersona.TabIndex = 0;
            this.gbxNuovaPersona.TabStop = false;
            this.gbxNuovaPersona.Text = "Nuova Persona";
            // 
            // btnCrea
            // 
            this.btnCrea.BackColor = System.Drawing.Color.Crimson;
            this.btnCrea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrea.Location = new System.Drawing.Point(167, 220);
            this.btnCrea.Name = "btnCrea";
            this.btnCrea.Size = new System.Drawing.Size(181, 47);
            this.btnCrea.TabIndex = 8;
            this.btnCrea.Text = "Crea";
            this.btnCrea.UseVisualStyleBackColor = false;
            this.btnCrea.Click += new System.EventHandler(this.btnCrea_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rbtNoStageLaurea);
            this.panel1.Controls.Add(this.rbtStageLaurea);
            this.panel1.Location = new System.Drawing.Point(6, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 44);
            this.panel1.TabIndex = 7;
            // 
            // rbtNoStageLaurea
            // 
            this.rbtNoStageLaurea.AutoSize = true;
            this.rbtNoStageLaurea.Location = new System.Drawing.Point(94, 12);
            this.rbtNoStageLaurea.Name = "rbtNoStageLaurea";
            this.rbtNoStageLaurea.Size = new System.Drawing.Size(85, 17);
            this.rbtNoStageLaurea.TabIndex = 1;
            this.rbtNoStageLaurea.Text = "Non in stage";
            this.rbtNoStageLaurea.UseVisualStyleBackColor = true;
            // 
            // rbtStageLaurea
            // 
            this.rbtStageLaurea.AutoSize = true;
            this.rbtStageLaurea.Checked = true;
            this.rbtStageLaurea.Location = new System.Drawing.Point(3, 12);
            this.rbtStageLaurea.Name = "rbtStageLaurea";
            this.rbtStageLaurea.Size = new System.Drawing.Size(63, 17);
            this.rbtStageLaurea.TabIndex = 0;
            this.rbtStageLaurea.TabStop = true;
            this.rbtStageLaurea.Text = "In stage";
            this.rbtStageLaurea.UseVisualStyleBackColor = true;
            // 
            // lblClasseMateria
            // 
            this.lblClasseMateria.AutoSize = true;
            this.lblClasseMateria.Location = new System.Drawing.Point(6, 128);
            this.lblClasseMateria.Name = "lblClasseMateria";
            this.lblClasseMateria.Size = new System.Drawing.Size(38, 13);
            this.lblClasseMateria.TabIndex = 6;
            this.lblClasseMateria.Text = "Classe";
            // 
            // txtClasseMateria
            // 
            this.txtClasseMateria.Location = new System.Drawing.Point(7, 144);
            this.txtClasseMateria.Name = "txtClasseMateria";
            this.txtClasseMateria.Size = new System.Drawing.Size(497, 20);
            this.txtClasseMateria.TabIndex = 1;
            this.txtClasseMateria.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(7, 105);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(497, 20);
            this.txtCognome.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cognome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(7, 66);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(497, 20);
            this.txtNome.TabIndex = 2;
            // 
            // rbtDocente
            // 
            this.rbtDocente.AutoSize = true;
            this.rbtDocente.Location = new System.Drawing.Point(80, 28);
            this.rbtDocente.Name = "rbtDocente";
            this.rbtDocente.Size = new System.Drawing.Size(66, 17);
            this.rbtDocente.TabIndex = 1;
            this.rbtDocente.Text = "Docente";
            this.rbtDocente.UseVisualStyleBackColor = true;
            // 
            // rbtStudente
            // 
            this.rbtStudente.AutoSize = true;
            this.rbtStudente.Checked = true;
            this.rbtStudente.Location = new System.Drawing.Point(6, 28);
            this.rbtStudente.Name = "rbtStudente";
            this.rbtStudente.Size = new System.Drawing.Size(68, 17);
            this.rbtStudente.TabIndex = 0;
            this.rbtStudente.TabStop = true;
            this.rbtStudente.Text = "Studente";
            this.rbtStudente.UseVisualStyleBackColor = true;
            this.rbtStudente.CheckedChanged += new System.EventHandler(this.rbtStudente_CheckedChanged_1);
            // 
            // lbxStudenti
            // 
            this.lbxStudenti.FormattingEnabled = true;
            this.lbxStudenti.Location = new System.Drawing.Point(13, 319);
            this.lbxStudenti.Name = "lbxStudenti";
            this.lbxStudenti.Size = new System.Drawing.Size(257, 238);
            this.lbxStudenti.TabIndex = 1;
            // 
            // lbxDocenti
            // 
            this.lbxDocenti.FormattingEnabled = true;
            this.lbxDocenti.Location = new System.Drawing.Point(276, 318);
            this.lbxDocenti.Name = "lbxDocenti";
            this.lbxDocenti.Size = new System.Drawing.Size(247, 238);
            this.lbxDocenti.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LavenderBlush;
            this.label3.Font = new System.Drawing.Font("Noto Sans Cond", 14.25F);
            this.label3.Location = new System.Drawing.Point(88, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Studenti";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LavenderBlush;
            this.label4.Font = new System.Drawing.Font("Noto Sans Cond", 14.25F);
            this.label4.Location = new System.Drawing.Point(356, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Docenti";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel2.Controls.Add(this.btnCarica);
            this.panel2.Controls.Add(this.btnSalva);
            this.panel2.Controls.Add(this.btnEliminaPersona);
            this.panel2.Location = new System.Drawing.Point(529, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(177, 544);
            this.panel2.TabIndex = 5;
            // 
            // btnEliminaPersona
            // 
            this.btnEliminaPersona.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminaPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminaPersona.Location = new System.Drawing.Point(13, 18);
            this.btnEliminaPersona.Name = "btnEliminaPersona";
            this.btnEliminaPersona.Size = new System.Drawing.Size(151, 46);
            this.btnEliminaPersona.TabIndex = 0;
            this.btnEliminaPersona.Text = "Elimina Persona";
            this.btnEliminaPersona.UseVisualStyleBackColor = false;
            this.btnEliminaPersona.Click += new System.EventHandler(this.btnEliminaPersona_Click);
            // 
            // btnSalva
            // 
            this.btnSalva.BackColor = System.Drawing.Color.Crimson;
            this.btnSalva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalva.Location = new System.Drawing.Point(13, 132);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(151, 46);
            this.btnSalva.TabIndex = 1;
            this.btnSalva.Text = "Salva CSV";
            this.btnSalva.UseVisualStyleBackColor = false;
            this.btnSalva.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCarica
            // 
            this.btnCarica.BackColor = System.Drawing.Color.Crimson;
            this.btnCarica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarica.Location = new System.Drawing.Point(13, 80);
            this.btnCarica.Name = "btnCarica";
            this.btnCarica.Size = new System.Drawing.Size(151, 46);
            this.btnCarica.TabIndex = 2;
            this.btnCarica.Text = "Carica Csv";
            this.btnCarica.UseVisualStyleBackColor = false;
            this.btnCarica.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(719, 572);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbxDocenti);
            this.Controls.Add(this.lbxStudenti);
            this.Controls.Add(this.gbxNuovaPersona);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxNuovaPersona.ResumeLayout(false);
            this.gbxNuovaPersona.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxNuovaPersona;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.RadioButton rbtDocente;
        private System.Windows.Forms.RadioButton rbtStudente;
        private System.Windows.Forms.TextBox txtClasseMateria;
        private System.Windows.Forms.Label lblClasseMateria;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtNoStageLaurea;
        private System.Windows.Forms.RadioButton rbtStageLaurea;
        private System.Windows.Forms.Button btnCrea;
        private System.Windows.Forms.ListBox lbxStudenti;
        private System.Windows.Forms.ListBox lbxDocenti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEliminaPersona;
        private System.Windows.Forms.Button btnCarica;
        private System.Windows.Forms.Button btnSalva;
    }
}

