﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace string08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            Font medium = new Font(textBox1.Font.Name, 12);
            Font large = new Font(textBox1.Font.Name, 20);
            string veta = textBox1.Text;
            int ps = 1;
            veta = veta.Trim();
            int count = 0;
            string word="";
            int bigestcount = 0;
            string longestword="";
            if (checkBox1.Checked == true)
            {
                for(int i = 0; i < veta.Length; i++)
                {
                    char a = veta[i];
                    if(a==' ')
                    {
                        ps++;
                    }
                }
                label1.Text = "Veta obsahuje " + ps + "slov.";
            }
            else
            {
                label1.Text = "";
            }
            if(checkBox2.Checked == true)
            {
                for (int i = 0; i < veta.Length; i++)
                {
                    char a = veta[i];
                    if(a == ' ')
                    {
                        count = 0;
                        word = "";
                    }
                    else
                    {
                        word += a;
                        count++;
                    }
                    if (count > bigestcount)
                    {
                        bigestcount = count;
                        longestword = word;
                    }
                }
                label2.Text = "Nejdelsi slovo ve vete je " + longestword;
            }
            else
            {
                label2.Text = "";
            }
            if (radioButton1.Checked == true)
            {
                textBox1.ForeColor = Color.Black;
            }
            else
            {
                if (radioButton2.Checked == true)
                {
                    textBox1.ForeColor = Color.Red;
                }
            }
            if (radioButton5.Checked == true)
            {
                textBox1.Font = medium;
            }
             else
             {
                if (radioButton6.Checked == true)
                {
                     textBox1.Font = large;
                }
             }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
