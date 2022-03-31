using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace string04
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
            for(int i = 0; i < veta.Length; i++)
            {
                char a = veta[i];
                if (a <= 'Z' && a >= 'A')
                {
                    veta = veta.Remove(i,1);
                    i--;
                }
            }
            label1.Text = veta;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string veta = textBox1.Text;
            veta = veta.Remove('*',"");
            label1.Text = veta;
        }
    }
}
