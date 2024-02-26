using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancaForm2
{
    public partial class Form1 : Form
    {
        Banca banca = new Banca("la banca di beppe");

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void aggiungiContoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Conto c;

            if (textBox2.Text != "" && textBox3.Text != "" && textBox4.Text == "")
            {
                c = new Conto(textBox2.Text, textBox3.Text, banca.IncrementaNumero());
            }
            else
            {
                c = new Conto(textBox2.Text, textBox3.Text, Convert.ToInt32(textBox4.Text), banca.IncrementaNumero());
            }

            listBox1.Items.Add(c.StringaConto());
            banca.AddConto(c);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void aggiungiAlContoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            banca.Lista()[Convert.ToInt32(textBox5.Text)].AddToConto(Convert.ToInt32(textBox1.Text));
            listBox1.Items.Add(banca.Lista()[Convert.ToInt32(textBox5.Text)].StringaConto());
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void rimuoviDalContoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (!banca.Lista()[Convert.ToInt32(textBox5.Text)].RemoveToConto(Convert.ToInt32(textBox1.Text)))
            {
                MessageBox.Show("saldo insufficente", "ATTENZIONE");
            }
            listBox1.Items.Add(banca.Lista()[Convert.ToInt32(textBox5.Text)].StringaConto());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            foreach (Conto conto in banca.Lista())
            {
                listBox1.Items.Add(conto.StringaConto());
            }
        }
    }
}
