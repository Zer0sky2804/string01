﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace string07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string abeceda = "abcdefghijklmnopqrstuvwxyz ";
            string[] morzeovka = { ".- ", "-... ", "-.-. ", "-.. ", ". ", "..-. ", "--. ", ".... ", ".. ", ".--- ", "-.- ", ".-.. ", "-- ", "-. ", "--- ", ".--. ", 
                                    "--.- ", ".-. ", "... ", "- ", "..- ", "...- ", ".-- ", "-..- ", "-.-- ", "--.. ", "/ " };
            string veta = textBox1.Text;
            for(int i = 0; i < textBox1.Text.Length; i++)
            {
               char a = veta[i];
                for(int p = 0; p < abeceda.Length; p++)
                {
                    char a2 = abeceda[p];
                    if (a2 == a )
                    {
                         textBox1.Text+= morzeovka[p];
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string abeceda = "abcdefghijklmnopqrstuvwxyz ";
            string[] morzeovka = { ".- ", "-... ", "-.-. ", "-.. ", ". ", "..-. ", "--. ", ".... ", ".. ", ".--- ", "-.- ", ".-.. ", "-- ", "-. ", "--- ", ".--. ",
                                    "--.- ", ".-. ", "... ", "- ", "..- ", "...- ", ".-- ", "-..- ", "-.-- ", "--.. ", "/ " };
            string veta = textBox1.Text;
            for (int i = 0; i < textBox1.Text.Length; i++)
            {

                for (int p = 0; p < morzeovka.Length; p++)
                {

                }
            }

        }
    }
}
