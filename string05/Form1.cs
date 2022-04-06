using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace string05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string veta = textBox1.Text;
            int countwords = 1;
            for(int i = 0; i < veta.Length; i++)
            {
                char a = veta[i];
                if (a ==' ')
                {
                    countwords++;
                }
            }
            label1.Text = "Pocet slov ve vete je " + countwords;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string veta = textBox2.Text;
            int countwords = 0;
            string[] pole = veta.Split(' ');
            for (int i = 0; i < pole.Length; i++)
            {
               if(pole[i]!="")
               {
                    countwords++;
               }
            }
            label2.Text = "Pocet slov ve vete je " + countwords;
        }
    }
}
