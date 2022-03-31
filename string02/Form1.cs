using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace string02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int bp = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int posun = int.Parse(textBox2.Text);
            string sifra = textBox1.Text;
            string vysledek = "";
            int p;
            for (int i = 0; i < sifra.Length; i++)
            {

                char a = sifra[i];
                if (a >= 'a' && a <= 'z' || a >= 'A' && a <= 'Z')
                {
                    if ((int)a + posun < 'a' && (int)a + posun > 'Z' || (int)a + posun > 'z')
                    {
                        p = ((int)a - 26) + posun;
                    }
                    else
                    {
                        p = (int)a + posun;
                    }
                    
                    vysledek += (char)p;
                    textBox1.Text = vysledek;
                }

            }
            bp++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int posun = int.Parse(textBox2.Text);
            string sifra = textBox1.Text;
            string vysledek = "";
            int p;
            posun *= bp;
            for (int i = 0; i < sifra.Length; i++)
            {

                char a = sifra[i];
                if (a >= 'a' && a <= 'z' || a >= 'A' && a <= 'Z')
                {
                    if ((int)a - posun < 'a' && (int)a - posun > 'Z' || (int)a - posun > 'z')
                    {
                        p = ((int)a + 26) - posun;
                    }
                    else
                    {
                        p = (int)a - posun;
                    }

                    vysledek += (char)p;
                    textBox1.Text = vysledek;
                }
            }
            bp = 0;
        }
    }
}
