using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace EsercitazioneProcrastinata
{
    public partial class Form1 : Form
    {
        Scuola school = new Scuola("Via val rossia N17");
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void rbtStudente_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbtStudente.Checked == true)
            {
                lblClasseMateria.Text = "Classe";
                rbtNoStageLaurea.Text = "Non in stage";
                rbtStageLaurea.Text = "In stage";
            }
            else
            {
                lblClasseMateria.Text = "Materia";
                rbtNoStageLaurea.Text = "Non laureato";
                rbtStageLaurea.Text = "Laureato";
            }
        }

        private void btnCrea_Click(object sender, EventArgs e)
        {
            Persona p;
            bool StageLaurea;
            if(rbtStageLaurea.Checked == true)
            {
                StageLaurea = true;
            }
            else
            {
                StageLaurea = false;
            }

            try
            {
                if (rbtStudente.Checked == true)
                {
                    p = new Studente(txtNome.Text, txtCognome.Text, txtClasseMateria.Text, StageLaurea);
                    school.DoceStud.Add(p);
                    lbxStudenti.Items.Add(school.DoceStud[school.DoceStud.Count - 1]);
                }
                else
                {
                    p = new Docente(txtNome.Text, txtCognome.Text, txtClasseMateria.Text, StageLaurea);
                    school.DoceStud.Add(p);
                    lbxDocenti.Items.Add(school.DoceStud[school.DoceStud.Count - 1]);
                }
                
            }
            catch
            {
                MessageBox.Show("I dati inseriti erano vuoti o incorretti, il processo e' stato annullato.");
            }
        }

        private void btnEliminaPersona_Click(object sender, EventArgs e)
        {
            lbxStudenti.Items.Remove(lbxStudenti.SelectedItem);
            lbxDocenti.Items.Remove(lbxDocenti.SelectedItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("ScuolaSerializzata.xml", FileMode.Open))
            {
                XmlSerializer sr = new XmlSerializer(typeof(Scuola));
                school = (Scuola)sr.Deserialize(fs);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FileStream fs= new FileStream("ScuolaSerializzata.xml", FileMode.Create))
            {
                XmlSerializer sr = new XmlSerializer(typeof(Scuola));
                sr.Serialize(fs, school);
            }
        }
    }
}
