﻿using System;
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
            int i = 0;
            while( i < veta.Length )
            {
                
                char a = veta[i];
                if (a <= 'Z' && a >= 'A')
                {
                    veta = veta.Remove(i, 1);
                }
                else { i++; }
            }
            label1.Text = veta;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string veta = textBox1.Text;
            veta = veta.Replace("*","");
            label1.Text = veta;
        }
    }
}
