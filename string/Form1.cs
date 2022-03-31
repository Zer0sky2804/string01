using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @string
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
            int k=0;
            bool tf = false;
            for(int i = 0; i < textBox1.Text.Length&&!tf; i++)
            {
                char a = veta[i];
                if (a >= '0' && a <= '9')
                {
                    k = a-48;
                    tf = true;
                }
            }
            if (k>=veta.Length)
            {
                label1.Text = "";
            }
            else
            {
                veta = veta.Remove(veta.Length - k, k);
                label1.Text = veta;
            }
        }
    }
}
