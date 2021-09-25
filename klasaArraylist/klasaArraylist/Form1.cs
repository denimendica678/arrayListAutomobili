using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace klasaArraylist
{
    
    public partial class Form1 : Form
    {
        ArrayList listaAutomobila = new ArrayList();
        public Form1()
        {
            InitializeComponent();




        }

        private void buttonNovi_Click(object sender, EventArgs e)
        {
            buttonUnesi.Enabled = true;
            textBoxNovi.Enabled = true;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNovi_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonUnesi_Click(object sender, EventArgs e)
        {
            Automobili a = new Automobili(textBoxNovi.Text);

            listaAutomobila.Add(a);

            richTextBox1.AppendText

            (listaAutomobila.IndexOf(a) + 1 + ". " + a.DajMarku() + "\n");

            textBoxNovi.Clear();

            buttonUnesi.Enabled = false;
            textBoxNovi.Enabled = false;
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            textBoxNovi.Clear();
        }
    }
}
