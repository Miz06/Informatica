using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Mosca
{
    public partial class Form1 : Form
    {
        Point xy;
        Random posizione = new Random();
        int missed = 0;
        int i = 0;

        private Insetto insetto;
        string path = Environment.CurrentDirectory + "\\mosca_immagini"; 

        public Form1()
        {
            InitializeComponent();
            insetto = new Insetto(Mosca, Farfalla, Ragno, Ape, Bug, path);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Mosca.Checked = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            xy.X = posizione.Next(0, (area.ClientSize.Width - Bug.Width) + 1);
            xy.Y = posizione.Next(0, (area.ClientSize.Height - Bug.Height) + 1);
            Bug.Location = xy;
        }

        private void Bug_Click(object sender, EventArgs e)
        {
            string imageName = GetCurrentImageName();

            timer1.Enabled = false;
            Bug.Image = Image.FromFile(path + $"\\{imageName}X.gif");

            MessageBox.Show("Colpito", "Message from the game ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            if (i<3)
            {
                timer1.Interval -= 300;
                i++;
            }

            timer1.Enabled = true;
            Bug.Image = Image.FromFile(path + $"\\{imageName}.gif");
        }
 
        private void Insetti_Enter(object sender, EventArgs e)
        {

        }
        private void Mosca_CheckedChanged(object sender, EventArgs e)
        {
            insetto.Mosca_CheckedChanged(sender, e);
        }

        private string GetCurrentImageName()
        {
            return insetto.GetCurrentImageName();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void area_Click(object sender, EventArgs e)
        {
            missed++;
            if(missed == 5)
            {
                MessageBox.Show("You have already missed the bug 5 times", "GAME OVER", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                Close();
            }
        }
    }
}
