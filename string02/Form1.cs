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

        private void button1_Click(object sender, EventArgs e)
        {
            int posun = int.Parse(textBox2.Text);
            string sifra = textBox1.Text;
            string vysledek="";
            for(int i=0;i<sifra.Length;i++)
            {
                
                char a = sifra[i];
                if (a >= 'a' && a <= 'z' || a >= 'A' && a <= 'Z')
                {
                    if (a < 'a' && (int)a + posun > 'Z')
                    {

                    }
                    int p = (int)a + posun;
                    vysledek += (char)p;
                    textBox1.Text = vysledek;
                }
                
            }
        }
    }
}
