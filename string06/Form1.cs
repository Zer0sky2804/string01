using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace string06
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
            veta = veta.Trim();
            int i = 0;
            while( i < veta.Length -1)
            {
                 
                if (veta[i] == ' ' && veta[i + 1] == ' ')
                {
                    veta = veta.Remove(i, 1);
                }
                else { i++; }
            }
            textBox1.Text = veta;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string veta = textBox1.Text;
            veta = veta.Trim();
            while(veta.Contains("  "))
            {
               veta = veta.Replace("  ", " ");
            }
            
            textBox1.Text = veta;
        }
    }
}
