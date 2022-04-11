using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace string09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string radek="";
            string vysledek="";
            
            for(int i = 0; i < textBox1.Lines.Length; i++)
            {
                string tecka = "";
                string line = textBox1.Lines[i];
                radek = line;

                if (checkBox1.Checked == true)
                {
                    radek = char.ToUpper(line[0]) + line.Substring(1);
                }
                if (checkBox2.Checked == true)
                {
                    if (line.Contains("."))
                    {
                        tecka = ".";
                    }
                   
                }
                vysledek = radek + tecka;

            }
        }
    }
}
