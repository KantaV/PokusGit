using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokusGit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int soucet = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
            label1.Text = soucet.ToString();
            double rozdil = double.Parse(textBox1.Text) - double.Parse(textBox2.Text);
            double soucin = double.Parse(textBox1.Text) * double.Parse(textBox2.Text);
            double podil = double.Parse(textBox1.Text) / double.Parse(textBox2.Text);
            MessageBox.Show(rozdil.ToString());
            MessageBox.Show(soucin.ToString());
            MessageBox.Show(podil.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vojta Kanta ITA2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            long faktorial = 1;
            int i = 1;
            while (i<=int.Parse(textBox3.Text))
            {
                faktorial *= i;
                ++i;
            }
            MessageBox.Show(faktorial.ToString());
        }
    }
}
