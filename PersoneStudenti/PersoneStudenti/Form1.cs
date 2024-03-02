using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersoneStudenti
{
    public partial class Form1 : Form
    {
        List<Persona> peoples;

        public Form1()
        {
            InitializeComponent();
            peoples = new List<Persona>();
            personaToolStripMenuItem1.Enabled = false;
            studenteToolStripMenuItem1.Enabled = false;
        }

        private void personaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool var = false;

            for (int i = 0; i < peoples.Count && !var; i++)
            {
                var = (peoples[i].GetName == textBox1.Text && peoples[i].GetSurname == textBox2.Text && peoples[i].GetAge == Convert.ToInt32(textBox3.Text));
            }

            if (var)
            {
                MessageBox.Show("Warning", "La persona specificata è già presente all'interno della lista", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Persona persona = new Persona(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text));
                peoples.Add(persona);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void studenteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool var = false;

            for (int i = 0; i < peoples.Count && !var; i++)
            {
                var = (peoples[i].GetName == textBox1.Text && peoples[i].GetSurname == textBox2.Text && peoples[i].GetAge == Convert.ToInt32(textBox3.Text));
            }

            if (var)
            {
                MessageBox.Show("La persona specificata è già presente all'interno della lista", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Studente studente = new Studente(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text));
                peoples.Add(studente);
            }
        }

        private void studenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Persona p in peoples)
            {
                listBox1.Items.Add(p.Scrivi());
            }
        }

        private void pulisciListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void personaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == ""))
            {
                personaToolStripMenuItem1.Enabled = true;
                studenteToolStripMenuItem1.Enabled = true;
            }
        }

        private void generaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
