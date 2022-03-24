using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace string01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string samohlasky = "aeiouyáéěíóúůý";
            string souhlasky = "bcčdďfghjklmnpqrřsštťvwxzž";
            string veta = textBox1.Text;
            veta = veta.ToLower();
            int psouhlasky = 0;
            int psamohlasky = 0;
            foreach(char a in veta)
            {
                if (samohlasky.Contains(a))
                {
                    psamohlasky++;
                }
                else
                {
                    if (souhlasky.Contains(a))
                    {
                        psouhlasky++;
                    }
                   
                }
            }
            int ostatni = veta.Length - psamohlasky - psouhlasky;
            label1.Text = "Ve vete je " + psamohlasky + " samohlasek, " + psouhlasky + " souhlasek a " + ostatni + " ostatnich znaku.";
        }
    }
}
